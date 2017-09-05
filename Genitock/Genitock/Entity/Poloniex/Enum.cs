﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Genitock.Entity.Poloniex
{
    public enum Pair
    {
        BTC_BCN,
        BTC_BELA,
        BTC_BLK,
        BTC_BTCD,
        BTC_BTM,
        BTC_BTS,
        BTC_BURST,
        BTC_CLAM,
        BTC_DASH,
        BTC_DGB,
        BTC_DOGE,
        BTC_EMC2,
        BTC_FLDC,
        BTC_FLO,
        BTC_GAME,
        BTC_GRC,
        BTC_HUC,
        BTC_LTC,
        BTC_MAID,
        BTC_OMNI,
        BTC_NAUT,
        BTC_NAV,
        BTC_NEOS,
        BTC_NMC,
        BTC_NOTE,
        BTC_NXT,
        BTC_PINK,
        BTC_POT,
        BTC_PPC,
        BTC_RIC,
        BTC_SJCX,
        BTC_STR,
        BTC_SYS,
        BTC_VIA,
        BTC_XVC,
        BTC_VRC,
        BTC_VTC,
        BTC_XBC,
        BTC_XCP,
        BTC_XEM,
        BTC_XMR,
        BTC_XPM,
        BTC_XRP,
        BTC_ETH,
        BTC_SC,
        BTC_BCY,
        BTC_EXP,
        BTC_FCT,
        BTC_RADS,
        BTC_AMP,
        BTC_DCR,
        BTC_LSK,
        BTC_LBC,
        BTC_STEEM,
        BTC_SBD,
        BTC_ETC,
        BTC_REP,
        BTC_ARDR,
        BTC_ZEC,
        BTC_STRAT,
        BTC_NXC,
        BTC_PASC,
        BTC_GNT,
        BTC_GNO,
        BTC_BCH,
        BTC_ZRX,
        ETH_LSK,
        ETH_STEEM,
        ETH_ETC,
        ETH_REP,
        ETH_ZEC,
        ETH_GNT,
        ETH_GNO,
        ETH_BCH,
        ETH_ZRX,
        USDT_BTC,
        USDT_DASH,
        USDT_LTC,
        USDT_NXT,
        USDT_STR,
        USDT_XMR,
        USDT_XRP,
        USDT_ETH,
        USDT_ETC,
        USDT_REP,
        USDT_ZEC,
        USDT_BCH,
        XMR_BCN,
        XMR_BLK,
        XMR_BTCD,
        XMR_DASH,
        XMR_LTC,
        XMR_MAID,
        XMR_NXT,
        XMR_ZEC,
    }

    public enum Period
    {
       m5 = 300,
        m15 = 900,
        m30 = 1800,
       h2 = 7200,
       h4 = 14400,
       d1 = 86400

    }
    /// <summary>
    /// market operation
    /// </summary>
    public enum Operation
    {
        buy,
        sell,
        Out
    }

}
