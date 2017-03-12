namespace TradingHelperEveOnline.OreCalculatorNS.Forms
{
    partial class OreCalculatorForm
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
            this.tabOrePrice = new System.Windows.Forms.TableLayoutPanel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.tabOutputPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrePriceTableTitle = new System.Windows.Forms.Label();
            this.lblOutputPriceTableTitle = new System.Windows.Forms.Label();
            this.grpRefreshData = new System.Windows.Forms.GroupBox();
            this.prgStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusInfoTitle = new System.Windows.Forms.Label();
            this.timRefreshStatusUpdater = new System.Windows.Forms.Timer(this.components);
            this.tabProfitOverview = new System.Windows.Forms.TableLayoutPanel();
            this.lbltabProfitTitle = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.numMinimalSecurity = new System.Windows.Forms.NumericUpDown();
            this.lblMinSecurity = new System.Windows.Forms.Label();
            this.cmdApplyFilter = new System.Windows.Forms.Button();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.numOreYield = new System.Windows.Forms.NumericUpDown();
            this.lblOreYield = new System.Windows.Forms.Label();
            this.grpRefreshData.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOreYield)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOrePrice
            // 
            this.tabOrePrice.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabOrePrice.ColumnCount = 2;
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tabOrePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOrePrice.Location = new System.Drawing.Point(12, 30);
            this.tabOrePrice.Name = "tabOrePrice";
            this.tabOrePrice.RowCount = 49;
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOrePrice.Size = new System.Drawing.Size(301, 785);
            this.tabOrePrice.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1404, 821);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Location = new System.Drawing.Point(178, 153);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.cmdRefresh.TabIndex = 3;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // tabOutputPrice
            // 
            this.tabOutputPrice.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabOutputPrice.ColumnCount = 2;
            this.tabOutputPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOutputPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOutputPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tabOutputPrice.Location = new System.Drawing.Point(1220, 670);
            this.tabOutputPrice.Name = "tabOutputPrice";
            this.tabOutputPrice.RowCount = 9;
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabOutputPrice.Size = new System.Drawing.Size(259, 145);
            this.tabOutputPrice.TabIndex = 2;
            // 
            // lblOrePriceTableTitle
            // 
            this.lblOrePriceTableTitle.AutoSize = true;
            this.lblOrePriceTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrePriceTableTitle.Location = new System.Drawing.Point(12, 9);
            this.lblOrePriceTableTitle.Name = "lblOrePriceTableTitle";
            this.lblOrePriceTableTitle.Size = new System.Drawing.Size(111, 18);
            this.lblOrePriceTableTitle.TabIndex = 4;
            this.lblOrePriceTableTitle.Text = "Ore Price Table";
            // 
            // lblOutputPriceTableTitle
            // 
            this.lblOutputPriceTableTitle.AutoSize = true;
            this.lblOutputPriceTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPriceTableTitle.Location = new System.Drawing.Point(1217, 649);
            this.lblOutputPriceTableTitle.Name = "lblOutputPriceTableTitle";
            this.lblOutputPriceTableTitle.Size = new System.Drawing.Size(130, 18);
            this.lblOutputPriceTableTitle.TabIndex = 5;
            this.lblOutputPriceTableTitle.Text = "Output Price Table";
            // 
            // grpRefreshData
            // 
            this.grpRefreshData.Controls.Add(this.prgStatus);
            this.grpRefreshData.Controls.Add(this.lblStatus);
            this.grpRefreshData.Controls.Add(this.lblStatusInfoTitle);
            this.grpRefreshData.Controls.Add(this.cmdRefresh);
            this.grpRefreshData.Location = new System.Drawing.Point(1220, 464);
            this.grpRefreshData.Name = "grpRefreshData";
            this.grpRefreshData.Size = new System.Drawing.Size(259, 182);
            this.grpRefreshData.TabIndex = 6;
            this.grpRefreshData.TabStop = false;
            this.grpRefreshData.Text = "Refresh Data";
            // 
            // prgStatus
            // 
            this.prgStatus.Location = new System.Drawing.Point(9, 85);
            this.prgStatus.Name = "prgStatus";
            this.prgStatus.Size = new System.Drawing.Size(244, 23);
            this.prgStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 111);
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
            // timRefreshStatusUpdater
            // 
            this.timRefreshStatusUpdater.Tick += new System.EventHandler(this.timRefreshStatusUpdater_Tick);
            // 
            // tabProfitOverview
            // 
            this.tabProfitOverview.BackColor = System.Drawing.SystemColors.Control;
            this.tabProfitOverview.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabProfitOverview.ColumnCount = 6;
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tabProfitOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfitOverview.Location = new System.Drawing.Point(319, 30);
            this.tabProfitOverview.Name = "tabProfitOverview";
            this.tabProfitOverview.RowCount = 49;
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabProfitOverview.Size = new System.Drawing.Size(895, 785);
            this.tabProfitOverview.TabIndex = 7;
            // 
            // lbltabProfitTitle
            // 
            this.lbltabProfitTitle.AutoSize = true;
            this.lbltabProfitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabProfitTitle.Location = new System.Drawing.Point(316, 9);
            this.lbltabProfitTitle.Name = "lbltabProfitTitle";
            this.lbltabProfitTitle.Size = new System.Drawing.Size(83, 18);
            this.lbltabProfitTitle.TabIndex = 8;
            this.lbltabProfitTitle.Text = "Profit Table";
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.numMinimalSecurity);
            this.grpSettings.Controls.Add(this.lblMinSecurity);
            this.grpSettings.Controls.Add(this.cmdApplyFilter);
            this.grpSettings.Controls.Add(this.txtStation);
            this.grpSettings.Controls.Add(this.txtSystem);
            this.grpSettings.Controls.Add(this.txtRegion);
            this.grpSettings.Controls.Add(this.lblStation);
            this.grpSettings.Controls.Add(this.lblSystem);
            this.grpSettings.Controls.Add(this.lblRegion);
            this.grpSettings.Controls.Add(this.numOreYield);
            this.grpSettings.Controls.Add(this.lblOreYield);
            this.grpSettings.Location = new System.Drawing.Point(1220, 30);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(259, 428);
            this.grpSettings.TabIndex = 9;
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
            // OreCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 855);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.tabProfitOverview);
            this.Controls.Add(this.lbltabProfitTitle);
            this.Controls.Add(this.grpRefreshData);
            this.Controls.Add(this.lblOutputPriceTableTitle);
            this.Controls.Add(this.lblOrePriceTableTitle);
            this.Controls.Add(this.tabOutputPrice);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.tabOrePrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OreCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ore Refinement Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OreCalculator_FormClosed);
            this.Load += new System.EventHandler(this.OreCalculator_Load);
            this.grpRefreshData.ResumeLayout(false);
            this.grpRefreshData.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOreYield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabOrePrice;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TableLayoutPanel tabOutputPrice;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Label lblOrePriceTableTitle;
        private System.Windows.Forms.Label lblOutputPriceTableTitle;
        private System.Windows.Forms.GroupBox grpRefreshData;
        private System.Windows.Forms.Timer timRefreshStatusUpdater;
        private System.Windows.Forms.Label lblStatusInfoTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar prgStatus;
        private System.Windows.Forms.TableLayoutPanel tabProfitOverview;
        private System.Windows.Forms.Label lbltabProfitTitle;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown numMinimalSecurity;
        private System.Windows.Forms.Label lblMinSecurity;
        private System.Windows.Forms.Button cmdApplyFilter;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.NumericUpDown numOreYield;
        private System.Windows.Forms.Label lblOreYield;
    }
}