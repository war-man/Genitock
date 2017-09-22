
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;

	private global::Gtk.Table TableMain;

	private global::Gtk.Button btnAnalyze;

	private global::Gtk.HBox hbox1;

	private global::Gtk.RadioButton rbNo;

	private global::Gtk.RadioButton rdSMA;

	private global::Gtk.RadioButton rdReg;

	private global::Gtk.RadioButton rdEMA;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label6;

	private global::Gtk.Entry txtNbPeriod;

	private global::Gtk.Label lblAlpha;

	private global::Gtk.Entry txtAlpha;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label label2;

	private global::Gtk.Entry txtSL;

	private global::Gtk.Label label3;

	private global::Gtk.Entry txtFees;

	private global::Gtk.HBox hbox5;

	private global::Gtk.CheckButton chkReinvest;

	private global::Gtk.CheckButton chkMargin;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label lblMarginRate;

	private global::Gtk.Entry txtMarginRate;

	private global::Gtk.HBox hbPrediction;

	private global::Gtk.Entry txtpathPrediction;

	private global::Gtk.Button btnBrowseProfit;

	private global::Gtk.HBox hbTick;

	private global::Gtk.Entry txtpathTick;

	private global::Gtk.Button btnTick;

	private global::Gtk.HBox hbTrend;

	private global::Gtk.HBox hbox9;

	private global::Gtk.HBox hbox10;

	private global::Gtk.CheckButton chkTrend;

	private global::Gtk.Label lblTrendScale;

	private global::Gtk.Entry txtScale;

	private global::Gtk.Entry txtTrend;

	private global::Gtk.Button btnTickTrend;

	private global::Gtk.Label label1;

	private global::Gtk.Label Label1;

	private global::Gtk.Label label4;

	private global::Gtk.Label label5;

	private global::Gtk.Entry txtOutput;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("GenotickResultAnalyzer");
		this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-color-picker", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.TableMain = new global::Gtk.Table(((uint)(8)), ((uint)(2)), false);
		this.TableMain.Name = "TableMain";
		this.TableMain.RowSpacing = ((uint)(6));
		this.TableMain.ColumnSpacing = ((uint)(6));
		// Container child TableMain.Gtk.Table+TableChild
		this.btnAnalyze = new global::Gtk.Button();
		this.btnAnalyze.CanFocus = true;
		this.btnAnalyze.Name = "btnAnalyze";
		this.btnAnalyze.UseUnderline = true;
		this.btnAnalyze.Label = global::Mono.Unix.Catalog.GetString("Analyze");
		this.TableMain.Add(this.btnAnalyze);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.TableMain[this.btnAnalyze]));
		w1.TopAttach = ((uint)(7));
		w1.BottomAttach = ((uint)(8));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rbNo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("NoClipping"));
		this.rbNo.CanFocus = true;
		this.rbNo.Name = "rbNo";
		this.rbNo.DrawIndicator = true;
		this.rbNo.UseUnderline = true;
		this.rbNo.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.hbox1.Add(this.rbNo);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.rbNo]));
		w2.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rdSMA = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("SimpleMoving Average"));
		this.rdSMA.CanFocus = true;
		this.rdSMA.Name = "rdSMA";
		this.rdSMA.DrawIndicator = true;
		this.rdSMA.UseUnderline = true;
		this.rdSMA.Group = this.rbNo.Group;
		this.hbox1.Add(this.rdSMA);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.rdSMA]));
		w3.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rdReg = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Linear regression"));
		this.rdReg.CanFocus = true;
		this.rdReg.Name = "rdReg";
		this.rdReg.DrawIndicator = true;
		this.rdReg.UseUnderline = true;
		this.rdReg.Group = this.rbNo.Group;
		this.hbox1.Add(this.rdReg);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.rdReg]));
		w4.Position = 2;
		// Container child hbox1.Gtk.Box+BoxChild
		this.rdEMA = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Exponential Average"));
		this.rdEMA.CanFocus = true;
		this.rdEMA.Name = "rdEMA";
		this.rdEMA.DrawIndicator = true;
		this.rdEMA.UseUnderline = true;
		this.rdEMA.Group = this.rbNo.Group;
		this.hbox1.Add(this.rdEMA);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.rdEMA]));
		w5.Position = 3;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Nb Period");
		this.hbox2.Add(this.label6);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label6]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtNbPeriod = new global::Gtk.Entry();
		this.txtNbPeriod.Sensitive = false;
		this.txtNbPeriod.CanFocus = true;
		this.txtNbPeriod.Name = "txtNbPeriod";
		this.txtNbPeriod.Text = global::Mono.Unix.Catalog.GetString("20");
		this.txtNbPeriod.IsEditable = true;
		this.txtNbPeriod.InvisibleChar = '●';
		this.hbox2.Add(this.txtNbPeriod);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtNbPeriod]));
		w7.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.lblAlpha = new global::Gtk.Label();
		this.lblAlpha.Name = "lblAlpha";
		this.lblAlpha.LabelProp = global::Mono.Unix.Catalog.GetString("Alpha");
		this.hbox2.Add(this.lblAlpha);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.lblAlpha]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtAlpha = new global::Gtk.Entry();
		this.txtAlpha.CanFocus = true;
		this.txtAlpha.Name = "txtAlpha";
		this.txtAlpha.IsEditable = true;
		this.txtAlpha.InvisibleChar = '●';
		this.hbox2.Add(this.txtAlpha);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtAlpha]));
		w9.Position = 3;
		this.hbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
		w10.Position = 4;
		this.TableMain.Add(this.hbox1);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbox1]));
		w11.TopAttach = ((uint)(5));
		w11.BottomAttach = ((uint)(6));
		w11.LeftAttach = ((uint)(1));
		w11.RightAttach = ((uint)(2));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Stop Loss");
		this.hbox4.Add(this.label2);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtSL = new global::Gtk.Entry();
		this.txtSL.CanFocus = true;
		this.txtSL.Name = "txtSL";
		this.txtSL.Text = global::Mono.Unix.Catalog.GetString("0.9");
		this.txtSL.IsEditable = true;
		this.txtSL.InvisibleChar = '●';
		this.hbox4.Add(this.txtSL);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.txtSL]));
		w13.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Fees");
		this.hbox4.Add(this.label3);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.txtFees = new global::Gtk.Entry();
		this.txtFees.CanFocus = true;
		this.txtFees.Name = "txtFees";
		this.txtFees.Text = global::Mono.Unix.Catalog.GetString("0.25");
		this.txtFees.IsEditable = true;
		this.txtFees.InvisibleChar = '●';
		this.hbox4.Add(this.txtFees);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.txtFees]));
		w15.Position = 3;
		this.TableMain.Add(this.hbox4);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbox4]));
		w16.TopAttach = ((uint)(3));
		w16.BottomAttach = ((uint)(4));
		w16.LeftAttach = ((uint)(1));
		w16.RightAttach = ((uint)(2));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.chkReinvest = new global::Gtk.CheckButton();
		this.chkReinvest.CanFocus = true;
		this.chkReinvest.Name = "chkReinvest";
		this.chkReinvest.Label = global::Mono.Unix.Catalog.GetString("Reinvest amount");
		this.chkReinvest.DrawIndicator = true;
		this.chkReinvest.UseUnderline = true;
		this.hbox5.Add(this.chkReinvest);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.chkReinvest]));
		w17.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.chkMargin = new global::Gtk.CheckButton();
		this.chkMargin.CanFocus = true;
		this.chkMargin.Name = "chkMargin";
		this.chkMargin.Label = global::Mono.Unix.Catalog.GetString("Margin trading");
		this.chkMargin.DrawIndicator = true;
		this.chkMargin.UseUnderline = true;
		this.hbox5.Add(this.chkMargin);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.chkMargin]));
		w18.Position = 1;
		// Container child hbox5.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lblMarginRate = new global::Gtk.Label();
		this.lblMarginRate.Name = "lblMarginRate";
		this.lblMarginRate.LabelProp = global::Mono.Unix.Catalog.GetString("Margin Rate");
		this.hbox3.Add(this.lblMarginRate);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.lblMarginRate]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txtMarginRate = new global::Gtk.Entry();
		this.txtMarginRate.CanFocus = true;
		this.txtMarginRate.Name = "txtMarginRate";
		this.txtMarginRate.IsEditable = true;
		this.txtMarginRate.InvisibleChar = '●';
		this.hbox3.Add(this.txtMarginRate);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.txtMarginRate]));
		w20.Position = 1;
		this.hbox5.Add(this.hbox3);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox3]));
		w21.Position = 2;
		this.TableMain.Add(this.hbox5);
		global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbox5]));
		w22.TopAttach = ((uint)(4));
		w22.BottomAttach = ((uint)(5));
		w22.LeftAttach = ((uint)(1));
		w22.RightAttach = ((uint)(2));
		w22.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbPrediction = new global::Gtk.HBox();
		this.hbPrediction.Name = "hbPrediction";
		this.hbPrediction.Spacing = 6;
		// Container child hbPrediction.Gtk.Box+BoxChild
		this.txtpathPrediction = new global::Gtk.Entry();
		this.txtpathPrediction.CanFocus = true;
		this.txtpathPrediction.Name = "txtpathPrediction";
		this.txtpathPrediction.Text = global::Mono.Unix.Catalog.GetString("/home/jeremy/Documents/Trading/genotick/data/m30/result/predictions_m30.csv");
		this.txtpathPrediction.IsEditable = true;
		this.txtpathPrediction.InvisibleChar = '●';
		this.hbPrediction.Add(this.txtpathPrediction);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbPrediction[this.txtpathPrediction]));
		w23.Position = 0;
		// Container child hbPrediction.Gtk.Box+BoxChild
		this.btnBrowseProfit = new global::Gtk.Button();
		this.btnBrowseProfit.CanFocus = true;
		this.btnBrowseProfit.Name = "btnBrowseProfit";
		this.btnBrowseProfit.UseUnderline = true;
		this.btnBrowseProfit.Label = global::Mono.Unix.Catalog.GetString("Choose a file");
		this.hbPrediction.Add(this.btnBrowseProfit);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbPrediction[this.btnBrowseProfit]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		this.TableMain.Add(this.hbPrediction);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbPrediction]));
		w25.TopAttach = ((uint)(1));
		w25.BottomAttach = ((uint)(2));
		w25.LeftAttach = ((uint)(1));
		w25.RightAttach = ((uint)(2));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbTick = new global::Gtk.HBox();
		this.hbTick.Name = "hbTick";
		this.hbTick.Spacing = 6;
		// Container child hbTick.Gtk.Box+BoxChild
		this.txtpathTick = new global::Gtk.Entry();
		this.txtpathTick.CanFocus = true;
		this.txtpathTick.Name = "txtpathTick";
		this.txtpathTick.Text = global::Mono.Unix.Catalog.GetString("/home/jeremy/Documents/Trading/genotick/data/m30/BTC_ETH.csv");
		this.txtpathTick.IsEditable = true;
		this.txtpathTick.InvisibleChar = '●';
		this.hbTick.Add(this.txtpathTick);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbTick[this.txtpathTick]));
		w26.Position = 0;
		// Container child hbTick.Gtk.Box+BoxChild
		this.btnTick = new global::Gtk.Button();
		this.btnTick.CanFocus = true;
		this.btnTick.Name = "btnTick";
		this.btnTick.UseUnderline = true;
		this.btnTick.Label = global::Mono.Unix.Catalog.GetString("Choose a File");
		this.hbTick.Add(this.btnTick);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbTick[this.btnTick]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.TableMain.Add(this.hbTick);
		global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbTick]));
		w28.LeftAttach = ((uint)(1));
		w28.RightAttach = ((uint)(2));
		w28.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.hbTrend = new global::Gtk.HBox();
		this.hbTrend.Name = "hbTrend";
		this.hbTrend.Spacing = 6;
		// Container child hbTrend.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.chkTrend = new global::Gtk.CheckButton();
		this.chkTrend.CanFocus = true;
		this.chkTrend.Name = "chkTrend";
		this.chkTrend.Label = global::Mono.Unix.Catalog.GetString("enable trend analysis");
		this.chkTrend.DrawIndicator = true;
		this.chkTrend.UseUnderline = true;
		this.hbox10.Add(this.chkTrend);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.chkTrend]));
		w29.Position = 0;
		// Container child hbox10.Gtk.Box+BoxChild
		this.lblTrendScale = new global::Gtk.Label();
		this.lblTrendScale.Sensitive = false;
		this.lblTrendScale.Name = "lblTrendScale";
		this.lblTrendScale.LabelProp = global::Mono.Unix.Catalog.GetString("Trend factor");
		this.hbox10.Add(this.lblTrendScale);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.lblTrendScale]));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.txtScale = new global::Gtk.Entry();
		this.txtScale.Sensitive = false;
		this.txtScale.CanFocus = true;
		this.txtScale.Name = "txtScale";
		this.txtScale.Text = global::Mono.Unix.Catalog.GetString("4");
		this.txtScale.IsEditable = true;
		this.txtScale.InvisibleChar = '●';
		this.hbox10.Add(this.txtScale);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.txtScale]));
		w31.Position = 2;
		this.hbox9.Add(this.hbox10);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.hbox10]));
		w32.Position = 0;
		// Container child hbox9.Gtk.Box+BoxChild
		this.txtTrend = new global::Gtk.Entry();
		this.txtTrend.Sensitive = false;
		this.txtTrend.CanFocus = true;
		this.txtTrend.Name = "txtTrend";
		this.txtTrend.Text = global::Mono.Unix.Catalog.GetString("/home/jeremy/Documents/Trading/genotick/data/h2/result/predictions_h2.csv");
		this.txtTrend.IsEditable = true;
		this.txtTrend.InvisibleChar = '●';
		this.hbox9.Add(this.txtTrend);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.txtTrend]));
		w33.Position = 1;
		this.hbTrend.Add(this.hbox9);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbTrend[this.hbox9]));
		w34.Position = 0;
		// Container child hbTrend.Gtk.Box+BoxChild
		this.btnTickTrend = new global::Gtk.Button();
		this.btnTickTrend.Sensitive = false;
		this.btnTickTrend.CanFocus = true;
		this.btnTickTrend.Name = "btnTickTrend";
		this.btnTickTrend.UseUnderline = true;
		this.btnTickTrend.Label = global::Mono.Unix.Catalog.GetString("Choose a File");
		this.hbTrend.Add(this.btnTickTrend);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbTrend[this.btnTickTrend]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		this.TableMain.Add(this.hbTrend);
		global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.TableMain[this.hbTrend]));
		w36.TopAttach = ((uint)(2));
		w36.BottomAttach = ((uint)(3));
		w36.LeftAttach = ((uint)(1));
		w36.RightAttach = ((uint)(2));
		w36.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Genotick Prediction");
		this.TableMain.Add(this.label1);
		global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.TableMain[this.label1]));
		w37.TopAttach = ((uint)(1));
		w37.BottomAttach = ((uint)(2));
		w37.XOptions = ((global::Gtk.AttachOptions)(4));
		w37.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.Label1 = new global::Gtk.Label();
		this.Label1.Name = "Label1";
		this.Label1.LabelProp = global::Mono.Unix.Catalog.GetString("Tick Files");
		this.TableMain.Add(this.Label1);
		global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.TableMain[this.Label1]));
		w38.XOptions = ((global::Gtk.AttachOptions)(4));
		w38.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Clipping");
		this.TableMain.Add(this.label4);
		global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.TableMain[this.label4]));
		w39.TopAttach = ((uint)(5));
		w39.BottomAttach = ((uint)(6));
		w39.XOptions = ((global::Gtk.AttachOptions)(4));
		w39.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("output filename");
		this.TableMain.Add(this.label5);
		global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.TableMain[this.label5]));
		w40.TopAttach = ((uint)(6));
		w40.BottomAttach = ((uint)(7));
		w40.XOptions = ((global::Gtk.AttachOptions)(4));
		w40.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child TableMain.Gtk.Table+TableChild
		this.txtOutput = new global::Gtk.Entry();
		this.txtOutput.CanFocus = true;
		this.txtOutput.Name = "txtOutput";
		this.txtOutput.IsEditable = true;
		this.txtOutput.InvisibleChar = '●';
		this.TableMain.Add(this.txtOutput);
		global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.TableMain[this.txtOutput]));
		w41.TopAttach = ((uint)(6));
		w41.BottomAttach = ((uint)(7));
		w41.LeftAttach = ((uint)(1));
		w41.RightAttach = ((uint)(2));
		w41.YOptions = ((global::Gtk.AttachOptions)(4));
		this.alignment1.Add(this.TableMain);
		this.Add(this.alignment1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1221;
		this.DefaultHeight = 322;
		this.lblAlpha.Hide();
		this.txtAlpha.Hide();
		this.lblMarginRate.Hide();
		this.txtMarginRate.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.chkTrend.Toggled += new global::System.EventHandler(this.OnChkTrendToggled);
		this.btnTickTrend.Clicked += new global::System.EventHandler(this.OnBtnTickTrendClicked);
		this.btnTick.Clicked += new global::System.EventHandler(this.OnBtnTickClicked);
		this.btnBrowseProfit.Clicked += new global::System.EventHandler(this.OnBtnBrowseProfitClicked);
		this.chkMargin.Toggled += new global::System.EventHandler(this.OnChkMarginToggled);
		this.rbNo.Pressed += new global::System.EventHandler(this.OnRdPressed);
		this.rdSMA.Pressed += new global::System.EventHandler(this.OnRdPressed);
		this.rdReg.Pressed += new global::System.EventHandler(this.OnRdPressed);
		this.rdEMA.Pressed += new global::System.EventHandler(this.OnRdPressed);
		this.btnAnalyze.Clicked += new global::System.EventHandler(this.OnBtnAnalyzeClicked);
	}
}
