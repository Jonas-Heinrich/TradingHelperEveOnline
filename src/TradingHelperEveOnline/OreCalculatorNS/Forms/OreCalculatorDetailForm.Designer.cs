namespace TradingHelperEveOnline.OreCalculatorNS.Forms
{
    partial class OreCalculatorDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.numMinimalSecurity = new System.Windows.Forms.NumericUpDown();
            this.lblMinSecurity = new System.Windows.Forms.Label();
            this.cmdApplyFilter = new System.Windows.Forms.Button();
            this.numMinTotal = new System.Windows.Forms.NumericUpDown();
            this.numMinPerc = new System.Windows.Forms.NumericUpDown();
            this.lblMinTotalMargin = new System.Windows.Forms.Label();
            this.lblMinimalPercentMargin = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.numOreYield = new System.Windows.Forms.NumericUpDown();
            this.lblOreYield = new System.Windows.Forms.Label();
            this.grpRefreshData = new System.Windows.Forms.GroupBox();
            this.prgStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusInfoTitle = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.timRefreshStatusUpdater = new System.Windows.Forms.Timer(this.components);
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblInvestment = new System.Windows.Forms.Label();
            this.lstInvestmentLog = new System.Windows.Forms.ListBox();
            this.lstIncomeLog = new System.Windows.Forms.ListBox();
            this.lblIncomeLog = new System.Windows.Forms.Label();
            this.lblProfitLog = new System.Windows.Forms.Label();
            this.lstProfitLog = new System.Windows.Forms.ListBox();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.lstRepeats = new System.Windows.Forms.ListBox();
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.lstSellLocationLog = new System.Windows.Forms.ListBox();
            this.lblSellLocationLog = new System.Windows.Forms.Label();
            this.lstBuyLocationLog = new System.Windows.Forms.ListBox();
            this.lblBuyLocationLog = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOreYield)).BeginInit();
            this.grpRefreshData.SuspendLayout();
            this.grpEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.numMinimalSecurity);
            this.grpSettings.Controls.Add(this.lblMinSecurity);
            this.grpSettings.Controls.Add(this.cmdApplyFilter);
            this.grpSettings.Controls.Add(this.numMinTotal);
            this.grpSettings.Controls.Add(this.numMinPerc);
            this.grpSettings.Controls.Add(this.lblMinTotalMargin);
            this.grpSettings.Controls.Add(this.lblMinimalPercentMargin);
            this.grpSettings.Controls.Add(this.txtStation);
            this.grpSettings.Controls.Add(this.txtSystem);
            this.grpSettings.Controls.Add(this.txtRegion);
            this.grpSettings.Controls.Add(this.lblStation);
            this.grpSettings.Controls.Add(this.lblSystem);
            this.grpSettings.Controls.Add(this.lblRegion);
            this.grpSettings.Controls.Add(this.numOreYield);
            this.grpSettings.Controls.Add(this.lblOreYield);
            this.grpSettings.Location = new System.Drawing.Point(627, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(259, 428);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // numMinimalSecurity
            // 
            this.numMinimalSecurity.DecimalPlaces = 1;
            this.numMinimalSecurity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMinimalSecurity.Location = new System.Drawing.Point(9, 312);
            this.numMinimalSecurity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinimalSecurity.Name = "numMinimalSecurity";
            this.numMinimalSecurity.Size = new System.Drawing.Size(244, 20);
            this.numMinimalSecurity.TabIndex = 14;
            // 
            // lblMinSecurity
            // 
            this.lblMinSecurity.AutoSize = true;
            this.lblMinSecurity.Location = new System.Drawing.Point(6, 296);
            this.lblMinSecurity.Name = "lblMinSecurity";
            this.lblMinSecurity.Size = new System.Drawing.Size(83, 13);
            this.lblMinSecurity.TabIndex = 13;
            this.lblMinSecurity.Text = "Minimal Security";
            // 
            // cmdApplyFilter
            // 
            this.cmdApplyFilter.Location = new System.Drawing.Point(178, 399);
            this.cmdApplyFilter.Name = "cmdApplyFilter";
            this.cmdApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.cmdApplyFilter.TabIndex = 12;
            this.cmdApplyFilter.Text = "Apply";
            this.cmdApplyFilter.UseVisualStyleBackColor = true;
            this.cmdApplyFilter.Click += new System.EventHandler(this.cmdApplyFilter_Click);
            // 
            // numMinTotal
            // 
            this.numMinTotal.DecimalPlaces = 2;
            this.numMinTotal.Location = new System.Drawing.Point(152, 103);
            this.numMinTotal.Name = "numMinTotal";
            this.numMinTotal.Size = new System.Drawing.Size(101, 20);
            this.numMinTotal.TabIndex = 11;
            this.numMinTotal.ValueChanged += new System.EventHandler(this.numMinTotal_ValueChanged);
            // 
            // numMinPerc
            // 
            this.numMinPerc.DecimalPlaces = 2;
            this.numMinPerc.Location = new System.Drawing.Point(9, 103);
            this.numMinPerc.Name = "numMinPerc";
            this.numMinPerc.Size = new System.Drawing.Size(132, 20);
            this.numMinPerc.TabIndex = 10;
            this.numMinPerc.ValueChanged += new System.EventHandler(this.numMinPerc_ValueChanged);
            // 
            // lblMinTotalMargin
            // 
            this.lblMinTotalMargin.AutoSize = true;
            this.lblMinTotalMargin.Location = new System.Drawing.Point(149, 87);
            this.lblMinTotalMargin.Name = "lblMinTotalMargin";
            this.lblMinTotalMargin.Size = new System.Drawing.Size(103, 13);
            this.lblMinTotalMargin.TabIndex = 9;
            this.lblMinTotalMargin.Text = "Minimum ISK Margin";
            // 
            // lblMinimalPercentMargin
            // 
            this.lblMinimalPercentMargin.AutoSize = true;
            this.lblMinimalPercentMargin.Location = new System.Drawing.Point(6, 87);
            this.lblMinimalPercentMargin.Name = "lblMinimalPercentMargin";
            this.lblMinimalPercentMargin.Size = new System.Drawing.Size(135, 13);
            this.lblMinimalPercentMargin.TabIndex = 8;
            this.lblMinimalPercentMargin.Text = "Minimal Percentage Margin";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(9, 238);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(244, 20);
            this.txtStation.TabIndex = 7;
            // 
            // txtSystem
            // 
            this.txtSystem.Location = new System.Drawing.Point(9, 199);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(244, 20);
            this.txtSystem.TabIndex = 6;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(9, 160);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(244, 20);
            this.txtRegion.TabIndex = 5;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(6, 222);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(40, 13);
            this.lblStation.TabIndex = 4;
            this.lblStation.Text = "Station";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(6, 183);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(41, 13);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "System";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(6, 144);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            // 
            // numOreYield
            // 
            this.numOreYield.DecimalPlaces = 2;
            this.numOreYield.Location = new System.Drawing.Point(9, 54);
            this.numOreYield.Name = "numOreYield";
            this.numOreYield.Size = new System.Drawing.Size(244, 20);
            this.numOreYield.TabIndex = 1;
            this.numOreYield.Value = new decimal(new int[] {
            500,
            0,
            0,
            65536});
            this.numOreYield.ValueChanged += new System.EventHandler(this.numOreYield_ValueChanged);
            // 
            // lblOreYield
            // 
            this.lblOreYield.AutoSize = true;
            this.lblOreYield.Location = new System.Drawing.Point(6, 29);
            this.lblOreYield.Name = "lblOreYield";
            this.lblOreYield.Size = new System.Drawing.Size(50, 13);
            this.lblOreYield.TabIndex = 0;
            this.lblOreYield.Text = "Ore Yield";
            // 
            // grpRefreshData
            // 
            this.grpRefreshData.Controls.Add(this.prgStatus);
            this.grpRefreshData.Controls.Add(this.lblStatus);
            this.grpRefreshData.Controls.Add(this.lblStatusInfoTitle);
            this.grpRefreshData.Controls.Add(this.cmdRefresh);
            this.grpRefreshData.Location = new System.Drawing.Point(627, 446);
            this.grpRefreshData.Name = "grpRefreshData";
            this.grpRefreshData.Size = new System.Drawing.Size(259, 157);
            this.grpRefreshData.TabIndex = 7;
            this.grpRefreshData.TabStop = false;
            this.grpRefreshData.Text = "Refresh Data";
            // 
            // prgStatus
            // 
            this.prgStatus.Location = new System.Drawing.Point(9, 64);
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Size = new System.Drawing.Size(244, 23);
            this.prgStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "---";
            // 
            // lblStatusInfoTitle
            // 
            this.lblStatusInfoTitle.AutoSize = true;
            this.lblStatusInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusInfoTitle.Location = new System.Drawing.Point(6, 25);
            this.lblStatusInfoTitle.Name = "lblStatusInfoTitle";
            this.lblStatusInfoTitle.Size = new System.Drawing.Size(78, 18);
            this.lblStatusInfoTitle.TabIndex = 4;
            this.lblStatusInfoTitle.Text = "Status Info";
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(178, 127);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // timRefreshStatusUpdater
            // 
            this.timRefreshStatusUpdater.Tick += new System.EventHandler(this.timRefreshStatusUpdater_Tick);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(512, 562);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(91, 23);
            this.cmdCalculate.TabIndex = 12;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblInvestment
            // 
            this.lblInvestment.AutoSize = true;
            this.lblInvestment.Location = new System.Drawing.Point(115, 16);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(80, 13);
            this.lblInvestment.TabIndex = 14;
            this.lblInvestment.Text = "Investment Log";
            // 
            // lstInvestmentLog
            // 
            this.lstInvestmentLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInvestmentLog.FormattingEnabled = true;
            this.lstInvestmentLog.ItemHeight = 14;
            this.lstInvestmentLog.Items.AddRange(new object[] {
            "--Updating Data--"});
            this.lstInvestmentLog.Location = new System.Drawing.Point(118, 32);
            this.lstInvestmentLog.Name = "lstInvestmentLog";
            this.lstInvestmentLog.Size = new System.Drawing.Size(158, 312);
            this.lstInvestmentLog.TabIndex = 13;
            this.lstInvestmentLog.SelectedIndexChanged += new System.EventHandler(this.lstInvestmentLog_SelectedIndexChanged);
            // 
            // lstIncomeLog
            // 
            this.lstIncomeLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIncomeLog.FormattingEnabled = true;
            this.lstIncomeLog.ItemHeight = 14;
            this.lstIncomeLog.Items.AddRange(new object[] {
            "--Updating Data--"});
            this.lstIncomeLog.Location = new System.Drawing.Point(282, 32);
            this.lstIncomeLog.Name = "lstIncomeLog";
            this.lstIncomeLog.Size = new System.Drawing.Size(155, 312);
            this.lstIncomeLog.TabIndex = 15;
            this.lstIncomeLog.SelectedIndexChanged += new System.EventHandler(this.lstIncomeLog_SelectedIndexChanged);
            // 
            // lblIncomeLog
            // 
            this.lblIncomeLog.AutoSize = true;
            this.lblIncomeLog.Location = new System.Drawing.Point(279, 16);
            this.lblIncomeLog.Name = "lblIncomeLog";
            this.lblIncomeLog.Size = new System.Drawing.Size(63, 13);
            this.lblIncomeLog.TabIndex = 16;
            this.lblIncomeLog.Text = "Income Log";
            // 
            // lblProfitLog
            // 
            this.lblProfitLog.AutoSize = true;
            this.lblProfitLog.Location = new System.Drawing.Point(440, 16);
            this.lblProfitLog.Name = "lblProfitLog";
            this.lblProfitLog.Size = new System.Drawing.Size(52, 13);
            this.lblProfitLog.TabIndex = 18;
            this.lblProfitLog.Text = "Profit Log";
            // 
            // lstProfitLog
            // 
            this.lstProfitLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfitLog.FormattingEnabled = true;
            this.lstProfitLog.ItemHeight = 14;
            this.lstProfitLog.Items.AddRange(new object[] {
            "--Updating Data--"});
            this.lstProfitLog.Location = new System.Drawing.Point(443, 32);
            this.lstProfitLog.Name = "lstProfitLog";
            this.lstProfitLog.Size = new System.Drawing.Size(155, 312);
            this.lstProfitLog.TabIndex = 17;
            this.lstProfitLog.SelectedIndexChanged += new System.EventHandler(this.lstProfitLog_SelectedIndexChanged);
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(6, 16);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(47, 13);
            this.lblRepeats.TabIndex = 20;
            this.lblRepeats.Text = "Repeats";
            // 
            // lstRepeats
            // 
            this.lstRepeats.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRepeats.FormattingEnabled = true;
            this.lstRepeats.ItemHeight = 14;
            this.lstRepeats.Items.AddRange(new object[] {
            "--Updating--"});
            this.lstRepeats.Location = new System.Drawing.Point(9, 32);
            this.lstRepeats.Name = "lstRepeats";
            this.lstRepeats.Size = new System.Drawing.Size(103, 312);
            this.lstRepeats.TabIndex = 19;
            this.lstRepeats.SelectedIndexChanged += new System.EventHandler(this.lstReapeats_SelectedIndexChanged);
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.Controls.Add(this.lstSellLocationLog);
            this.grpEvaluation.Controls.Add(this.lblSellLocationLog);
            this.grpEvaluation.Controls.Add(this.lstBuyLocationLog);
            this.grpEvaluation.Controls.Add(this.lblBuyLocationLog);
            this.grpEvaluation.Controls.Add(this.lblTotalProfit);
            this.grpEvaluation.Controls.Add(this.lblTotal);
            this.grpEvaluation.Controls.Add(this.lblRepeats);
            this.grpEvaluation.Controls.Add(this.cmdCalculate);
            this.grpEvaluation.Controls.Add(this.lstInvestmentLog);
            this.grpEvaluation.Controls.Add(this.lstRepeats);
            this.grpEvaluation.Controls.Add(this.lblInvestment);
            this.grpEvaluation.Controls.Add(this.lblProfitLog);
            this.grpEvaluation.Controls.Add(this.lstIncomeLog);
            this.grpEvaluation.Controls.Add(this.lstProfitLog);
            this.grpEvaluation.Controls.Add(this.lblIncomeLog);
            this.grpEvaluation.Location = new System.Drawing.Point(12, 12);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Size = new System.Drawing.Size(609, 591);
            this.grpEvaluation.TabIndex = 21;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "Evaluation";
            // 
            // lstSellLocationLog
            // 
            this.lstSellLocationLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstSellLocationLog.FormattingEnabled = true;
            this.lstSellLocationLog.Items.AddRange(new object[] {
            "--Updating Data--"});
            this.lstSellLocationLog.Location = new System.Drawing.Point(9, 452);
            this.lstSellLocationLog.Name = "lstSellLocationLog";
            this.lstSellLocationLog.Size = new System.Drawing.Size(594, 69);
            this.lstSellLocationLog.TabIndex = 25;
            // 
            // lblSellLocationLog
            // 
            this.lblSellLocationLog.AutoSize = true;
            this.lblSellLocationLog.Location = new System.Drawing.Point(6, 435);
            this.lblSellLocationLog.Name = "lblSellLocationLog";
            this.lblSellLocationLog.Size = new System.Drawing.Size(89, 13);
            this.lblSellLocationLog.TabIndex = 26;
            this.lblSellLocationLog.Text = "Sell Location Log";
            // 
            // lstBuyLocationLog
            // 
            this.lstBuyLocationLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lstBuyLocationLog.FormattingEnabled = true;
            this.lstBuyLocationLog.Items.AddRange(new object[] {
            "--Updating Data--"});
            this.lstBuyLocationLog.Location = new System.Drawing.Point(9, 363);
            this.lstBuyLocationLog.Name = "lstBuyLocationLog";
            this.lstBuyLocationLog.Size = new System.Drawing.Size(594, 69);
            this.lstBuyLocationLog.TabIndex = 23;
            // 
            // lblBuyLocationLog
            // 
            this.lblBuyLocationLog.AutoSize = true;
            this.lblBuyLocationLog.Location = new System.Drawing.Point(6, 347);
            this.lblBuyLocationLog.Name = "lblBuyLocationLog";
            this.lblBuyLocationLog.Size = new System.Drawing.Size(90, 13);
            this.lblBuyLocationLog.TabIndex = 24;
            this.lblBuyLocationLog.Text = "Buy Location Log";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(148, 558);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(0, 24);
            this.lblTotalProfit.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 558);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 24);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Profit";
            // 
            // OreCalculatorDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 611);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.grpRefreshData);
            this.Controls.Add(this.grpSettings);
            this.Name = "OreCalculatorDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OreCalculatorDetailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OreCalculatorDetailForm_FormClosed);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOreYield)).EndInit();
            this.grpRefreshData.ResumeLayout(false);
            this.grpRefreshData.PerformLayout();
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label lblOreYield;
        private System.Windows.Forms.NumericUpDown numOreYield;
        private System.Windows.Forms.GroupBox grpRefreshData;
        private System.Windows.Forms.ProgressBar prgStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusInfoTitle;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Timer timRefreshStatusUpdater;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label lblInvestment;
        private System.Windows.Forms.ListBox lstInvestmentLog;
        private System.Windows.Forms.ListBox lstIncomeLog;
        private System.Windows.Forms.Label lblIncomeLog;
        private System.Windows.Forms.Label lblProfitLog;
        private System.Windows.Forms.ListBox lstProfitLog;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.ListBox lstRepeats;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblMinTotalMargin;
        private System.Windows.Forms.Label lblMinimalPercentMargin;
        private System.Windows.Forms.NumericUpDown numMinPerc;
        private System.Windows.Forms.NumericUpDown numMinTotal;
        private System.Windows.Forms.Button cmdApplyFilter;
        private System.Windows.Forms.ListBox lstSellLocationLog;
        private System.Windows.Forms.Label lblSellLocationLog;
        private System.Windows.Forms.ListBox lstBuyLocationLog;
        private System.Windows.Forms.Label lblBuyLocationLog;
        private System.Windows.Forms.NumericUpDown numMinimalSecurity;
        private System.Windows.Forms.Label lblMinSecurity;
    }
}