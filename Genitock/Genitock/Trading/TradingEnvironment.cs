﻿using Genitock.Entity.Poloniex;
using Genitock.Entity.Poloniex.Market;
using Genitock.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genitock.Poloniex.Live;
using Genitock.Entity.Live;
using System.Xml.Serialization;
using System.IO;

namespace Genitock.Trading
{
    /// <summary>
    /// this class represents all trading data,
    /// like wallet, current order....
    /// </summary>
    public class TradingEnvironment
    {

        private TradingContext context;


        /// <summary>
        /// return the wallet which will be used for trading
        /// </summary>
        public Wallet SourceWallet { get; private set; }
        public Wallet TargetWallet { get; private set; }
        /// <summary>
        /// return the target pair for trading
        /// </summary>
        public Pair TradedPair { get { return _TradedPair; } }

        public IBroker _broker;

        public ITicker _ticker;

        private Pair _TradedPair;

        /// <summary>
        /// store the stop limit rate from buy action
        /// </summary>
        private static Double StopLimitBids;

        public TradingEnvironment(IBroker broker, ITicker ticker)
        {

            Boolean success;
            _broker = broker;
            _ticker = ticker;

            success = Enum.TryParse<Pair>(ConfigurationManager.AppSettings["Trading_Pair"], out _TradedPair);
            if (!success)
            {
                Console.WriteLine("Parameter Trading_Pair is invalid please see poloniex API for the correct format");
                Environment.Exit(0);
            }

            RefreshWallet();
            LoadTradingContext();

            if (context.CurrentOperation != Operation.Out)
                Sell();
        }

        private void RefreshWallet()
        {
            SourceWallet = new Wallet { currency = (Currencies)Enum.Parse(typeof(Currencies), _TradedPair.ToString().Split('_')[0]) };
            SourceWallet.amount = _broker.ReturnBalance(SourceWallet.currency);

            TargetWallet = new Wallet { currency = (Currencies)Enum.Parse(typeof(Currencies), _TradedPair.ToString().Split('_')[1]) };
            TargetWallet.amount = _broker.ReturnBalance(TargetWallet.currency);
        }

        public void Buy()
        {
            Console.WriteLine("Init buy process");
            MarketOrderBook ob = _broker.returnMarketOrderBook(_TradedPair, 20);
            Double amount = SourceWallet.amount;

            TradeDone allorders = new TradeDone();
            allorders.resultingTrades = new List<ResultingTrade>();
            context.AmountTraded = 0;
            while (amount > Convert.ToDouble(ConfigurationManager.AppSettings["Minimum_trade"]))
            {
                TradeDone order = _broker.Buy(_TradedPair, ob.GetTheNextAsks().rate, amount);
                if (order.resultingTrades.Count() == 0)
                {
                    Boolean cleanSituation = false;
                    Console.WriteLine("order not executed. clean it");
                    //need to cancel order to rate to high
                    while (!cleanSituation)
                        cleanSituation = _broker.CancelOrder(order.orderNumber);
                    //restart the process
                    Console.WriteLine("clean complete continue buy process");
                    continue;
                }
                else
                {
                    amount = amount - order.totalAmountDoneSourceCurrency;
                    context.AmountTraded += order.totalAmountDoneSourceCurrency;
                    allorders.resultingTrades.AddRange(order.resultingTrades);
                }
            }

            //compute the average rate to determine the stop limit
            StopLimitBids = allorders.AverageRate * Convert.ToDouble(ConfigurationManager.AppSettings["StopLoss"]);
            Console.WriteLine($"buy done stop limit rate {StopLimitBids}");
            _ticker.onTick += WatchStopLimit;

            //update context
            context.status = TradingStatus.InMarket;
            context.CurrentOperation = Operation.buy;
            context.Position = DateTime.Now;
          

#if DEBUG
            SaveTradingContext();
#endif
            //refresh all amounts
            RefreshWallet();

        }

        public void Sell()
        {
            
            Console.WriteLine("Init sell process");
            MarketOrderBook ob = _broker.returnMarketOrderBook(_TradedPair, 20);
            Double amount = TargetWallet.amount;

			while (amount > Convert.ToDouble(ConfigurationManager.AppSettings["Minimum_trade"]))
            {
                TradeDone order= _broker.Sell(_TradedPair, ob.GetTheNextBids().rate, amount);
                if (order.resultingTrades.Count() == 0)
                {
                    Boolean cleanSituation = false;
                    Console.WriteLine("order not executed. clean it");
                    //need to cancel order to rate to high
                    while (!cleanSituation)
                        cleanSituation = _broker.CancelOrder(order.orderNumber);
                    //restart the process
                    Console.WriteLine("clean complete continue sell process");
                    continue;
                }

                amount = amount - order.totalAmountDoneTargetCurrency;
            }
            Console.WriteLine("disable ticker action");


                _ticker.onTick -= WatchStopLimit;



            //compute the original amount not traded
            double initialAmount = SourceWallet.amount;

            RefreshWallet();

            //compute the profit
            context.Profit=(SourceWallet.amount-initialAmount)/ (context.AmountTraded.Value-initialAmount);

            context.status = TradingStatus.OutMarket;
            context.CurrentOperation = Operation.Out;
            context.Position = null;

           // context.Profit = orders
            
#if DEBUG
			SaveTradingContext();
#endif
        }

			public Chart GetChartData(Pair pair, DateTime dtStart, DateTime dtEnd, Period period)
        {
            return _broker.GetChartData(pair, dtStart, dtEnd, period);
        }

        /// <summary>
        /// check if the stop limit is raised
        /// </summary>
        /// <param name="source">Source.</param>
        /// <param name="e">E.</param>
		void WatchStopLimit(object source, TickerArgument e)
        {
            Console.WriteLine($"Date {DateTime.Now} Pair {e.Pair} Rate {e.Rate} HighestBid {e.HighestBid}");
            Console.WriteLine($"Stop loss rate : {StopLimitBids}");
            if (e.HighestBid < StopLimitBids)
                Sell();
        }

        void SaveTradingContext()
        {
            XmlSerializer xs = new XmlSerializer(typeof(TradingContext));
            TextWriter WriteFileStream = new StreamWriter(@"tradeconfig.xml");
            xs.Serialize(WriteFileStream, context);
            Console.WriteLine("trading context updated");
        }

        void LoadTradingContext()
        {
            if (File.Exists(@"tradeconfig.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(TradingContext));
                TextReader tr = new StreamReader(@"tradeconfig.xml");
                context = (TradingContext)xs.Deserialize(tr);
            }
            else
            {
                context = new TradingContext();
                context.status = TradingStatus.OutMarket;
                context.HighestProfit = 1;
                context.Profit = 1;
                context.CurrentOperation = Operation.Out;
            }
            Console.WriteLine("trading context sucessfully loaded!");
        }
    }
}
