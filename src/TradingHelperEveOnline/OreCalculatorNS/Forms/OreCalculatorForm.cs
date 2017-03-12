using System;
using TradingHelperEveOnline.OreCalculatorNS.Forms.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingHelperEveOnline.Database.SaveClasses;
using TradingHelperEveOnline.DataStripper;

namespace TradingHelperEveOnline.OreCalculatorNS.Forms
{
    public partial class OreCalculatorForm : Form
    {
        #region Properties
        OreCalculator calculator = new OreCalculator(CalculationType.InstantBuySell, 0.5f);
        MarketDataStripper stripper = new MarketDataStripper();
        MarketItem[] outputItems = new MarketItem[6];

        TableLayoutPanelWrapper tabOrePriceWrapper;
        TableLayoutPanelWrapper tabOutputPriceWrapper;
        TableLayoutPanelWrapper tabProfitOverviewWrapper;
        #endregion

        public OreCalculatorForm()
        {
            InitializeComponent();
        }

        //
        //  UI Events
        //

        #region UIEvents

        private void OreCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            calculator.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OreCalculator_Load(object sender, EventArgs e)
        {
            tabOrePriceWrapper = new TableLayoutPanelWrapper
            (
                tabOrePrice,
                HandleCellClick_OreTable,
                new int[] {175, 25}
            );
            tabOutputPriceWrapper = new TableLayoutPanelWrapper
            (
                tabOutputPrice,
                HandleCellClick_OutputTable,
                new int[] {175, 50}
            );
            tabProfitOverviewWrapper = new TableLayoutPanelWrapper
            (
                tabProfitOverview,
                HandleCellClick_ProfitTable,
                new int[] {200, 200, 150, 100, 200, 50}
            );

            InitContentTableOre();
            InitContentTableOutput();
            InitContentTableProfit();
        }

        private async void cmdApplyFilter_Click(object sender, EventArgs e)
        {
            calculator.OreConversionRate = (float)numOreYield.Value / 100;
            calculator.ApplyFilter(txtRegion.Text, txtSystem.Text, txtStation.Text, (float)numMinimalSecurity.Value);
            await Task.Factory.StartNew(() => calculator.UpdatePrices());
            DisplayPrice();
        }

        #endregion

        //
        //  Refresh
        //

        #region Refresh UI Methods

        private async void cmdRefresh_Click(object sender, EventArgs e)
        {
            timRefreshStatusUpdater.Enabled = true;
            cmdRefresh.Enabled = false;

            await Task.Factory.StartNew(() => calculator.UpdateData());

            prgStatus.Value = 0;
            timRefreshStatusUpdater.Enabled = false;

            lblStatus.Text = "Updating displayed values..";
            DisplayPrice();
            lblStatus.Text = "Done.";

            cmdRefresh.Enabled = true;
        }

        private void timRefreshStatusUpdater_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = calculator.Status;

            prgStatus.Maximum = calculator.TotalItemCount;
            prgStatus.Value = calculator.ItemsFinishedCount;
        }
        #endregion

        //
        //  Initialisation
        //

        #region TableInit

        private void InitContentTableOre()                          // Set content of 1. row and column
        {
            tabOrePriceWrapper.FillTable(0, OreDataProvider.OreNames);

            tabOrePrice.GetControlFromPosition(0, 0).Text = "Ore Type";
            tabOrePrice.GetControlFromPosition(1, 0).Text = "ISK";
        }

        private void InitContentTableOutput()
        {
            tabOutputPriceWrapper.FillTable(0, OreDataProvider.OutputNames);

            tabOutputPrice.GetControlFromPosition(0, 0).Text = "Output Type";
            tabOutputPrice.GetControlFromPosition(1, 0).Text = "ISK";
        }

        private void InitContentTableProfit()                       // Set content of 1. row and column
        {
            tabProfitOverviewWrapper.FillTable(0, OreDataProvider.OreNames);
            tabProfitOverviewWrapper.FillTable(5, "<click>");

            tabProfitOverview.GetControlFromPosition(0, 0).Text = "Ore Type";
            tabProfitOverview.GetControlFromPosition(1, 0).Text = "Investment";
            tabProfitOverview.GetControlFromPosition(2, 0).Text = "Income";
            tabProfitOverview.GetControlFromPosition(3, 0).Text = "Margin";
            tabProfitOverview.GetControlFromPosition(4, 0).Text = "Profit";
            tabProfitOverview.GetControlFromPosition(5, 0).Text = "Detail";
        }

        #endregion

        //
        //  Display Data Tables
        //        

        #region Display Data Tables

        private void DisplayPrice()
        {
            DisplayOutputPrices();
            DisplayOrePrices();
            DisplayProfitData();
        }

        #region Display Subfunctions
        private void DisplayOrePrices()
        {
            tabOrePrice.Visible = false;
            tabOrePriceWrapper.FillTable(1, calculator.GetOrePrices());
            tabOrePrice.Visible = true;
        }

        private void DisplayOutputPrices()
        {
            tabOutputPrice.Visible = false;
            tabOutputPriceWrapper.FillTable(1, calculator.GetOutputPrices());
            tabOutputPrice.Visible = true;
        }

        private void DisplayProfitData()
        {
            tabProfitOverview.Visible = false;
            float[] investmentData = calculator.GetInvestmentData();
            float[] incomeData = calculator.GetIncomeData();
            float[] margin = new float[incomeData.Length];
            float[] profit = new float[incomeData.Length];

            for (int i = 0; i < margin.Length; i++)
            {
                margin[i] = (incomeData[i] / investmentData[i] * 100) - 100;
                profit[i] = incomeData[i] - investmentData[i];
            }

            tabProfitOverviewWrapper.FillTable(1, investmentData);
            tabProfitOverviewWrapper.FillTable(2, incomeData);
            tabProfitOverviewWrapper.FillTable(3, margin);
            tabProfitOverviewWrapper.FillTable(4, profit);
            tabProfitOverview.Visible = true;
        }
        #endregion
        #endregion

        //
        //  Utility Functions
        //
        
        //
        //  Handle Cell Click
        //

        #region Handle Cell Click
            
        private int HandleCellClick_OreTable(object sender, MouseEventArgs e, int x, int y)
        {
            int[] cellCords = tabOrePriceWrapper.GetTableCords(sender);
            if (cellCords[1] != 0)
            {
                tabOrePriceWrapper.HighlightRow(cellCords[1]);
            }
            return 0;
        }
        private int HandleCellClick_OutputTable(object sender, MouseEventArgs e, int x, int y)
        {
            int[] cellCords = tabOutputPriceWrapper.GetTableCords(sender);
            if (cellCords[1] != 0)
                tabOutputPriceWrapper.HighlightRow(cellCords[1]);
            return 0;
        }
        private int HandleCellClick_ProfitTable(object sender, MouseEventArgs e, int x, int y)
        {
            int[] cellCords = tabProfitOverviewWrapper.GetTableCords(sender);
            if (cellCords[0] != 5 && cellCords[1] != 0)
            {
                tabProfitOverviewWrapper.HighlightRow(cellCords[1]);
            }
            else if(cellCords[0] == 5 && cellCords[1] != 0)
            {
                OreCalculatorDetailForm n;
                if (!calculator.Initialised)
                    n = new OreCalculatorDetailForm
                        (
                            CalculationType.InstantBuySell, 
                            (float)numOreYield.Value, 
                            cellCords[1] - 1,
                            txtRegion.Text,
                            txtSystem.Text,
                            txtStation.Text,
                            (float)numMinimalSecurity.Value
                        );
                else
                    n = new OreCalculatorDetailForm
                        (
                            CalculationType.InstantBuySell, 
                            (float)numOreYield.Value, 
                            calculator.GetOreMarketData(cellCords[1] - 1), 
                            calculator.GetOutputMarketData(),
                            txtRegion.Text,
                            txtSystem.Text,
                            txtStation.Text,
                            (float)numMinimalSecurity.Value
                        );
                n.Show();
            }
            return 0;
        }
        #endregion
    }
}