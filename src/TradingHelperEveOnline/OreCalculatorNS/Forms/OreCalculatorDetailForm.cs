using System.Threading.Tasks;
using System.Windows.Forms;
using TradingHelperEveOnline.Database.SaveClasses;

namespace TradingHelperEveOnline.OreCalculatorNS.Forms
{
    public partial class OreCalculatorDetailForm : Form
    {
        int oreIndex;
        OreDetailCalculator calculator;
        CalculationType calcType;

        //
        //  Constructor/Destructor
        //

        #region Constructor/Destructor

        public OreCalculatorDetailForm(CalculationType calcType, float conversionRate, int oreIndex, string region, string system, string station, float val)
        {
            InitializeComponent();

            txtRegion.Text = region;
            txtStation.Text = station;
            txtSystem.Text = system;
            numMinimalSecurity.Value = (decimal)val;
            this.calcType = calcType;
            this.oreIndex = oreIndex;

            Text = "Detail Screen: " + OreDataProvider.OreNames[oreIndex];
            calculator = new OreDetailCalculator(calcType, conversionRate, oreIndex);
            numOreYield.Value = (decimal)conversionRate;

            UpdateMarketData();
        }

        public OreCalculatorDetailForm(CalculationType calcType, float conversionRate, MarketItem oreData, MarketItem[] outputData, string region, string system, string station, float val)
        {
            InitializeComponent();

            txtRegion.Text = region;
            txtStation.Text = station;
            txtSystem.Text = system;
            numMinimalSecurity.Value = (decimal)val;
            this.calcType = calcType;
            oreIndex = OreDataProvider.GetOreIndex(oreData.ID);

            Text = "Detail Screen: " + OreDataProvider.OreNames[oreIndex];
            calculator = new OreDetailCalculator(calcType, conversionRate, oreData, outputData);
            numOreYield.Value = (decimal)conversionRate;
        }

        private void OreCalculatorDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            calculator.Close();
        }

        #endregion

        //
        //  UI Events
        //

        #region UI Events

        private void cmdRefresh_Click(object sender, System.EventArgs e)
        {
            UpdateMarketData();
        }

        private void timRefreshStatusUpdater_Tick(object sender, System.EventArgs e)
        {
            lblStatus.Text = calculator.Status;

            prgStatus.Maximum = calculator.TotalItemCount;
            prgStatus.Value = calculator.ItemsFinishedCount;
        }

        private async void cmdCalculate_Click(object sender, System.EventArgs e)
        {
            grpSettings.Enabled = false;
            cmdCalculate.Enabled = false;
            await Task.Factory.StartNew(() => calculator.UpdateCalculations());
            DisplayLogs();
            lblTotalProfit.Text = calculator.TotalProfit.ToString("000,000,000,000.00") + " ISK";
            cmdCalculate.Enabled = true;
            grpSettings.Enabled = true;
        }

        #endregion
        
        //
        //  Logging
        //

        #region Log to Listboxes

        private void DisplayLogs()
        {
            DisplayRepeats();
            DisplayInvestmentLog();
            DisplayIncomeLog();
            DisplayProfitLog();
        }

        private void DisplayRepeats()
        {
            lstRepeats.Items.Clear();
            int maxLength = FindMaxLength(calculator.TransactionLog, 0);
            for (int i = 0; i < calculator.TransactionLog.Length; i++)
                lstRepeats.Items.Add((int)calculator.TransactionLog[i][0]);
        }

        private void DisplayInvestmentLog()
        {
            lstInvestmentLog.Items.Clear();
            int maxLength = FindMaxLength(calculator.TransactionLog, 1);
            for (int i = 0; i < calculator.TransactionLog.Length; i++)
            {
                lstInvestmentLog.Items.Add(calculator.TransactionLog[i][1].ToString("0.00") + " ISK");
            }
        }

        private void DisplayIncomeLog()
        {
            lstIncomeLog.Items.Clear();
            int maxLength = FindMaxLength(calculator.TransactionLog, 2);
            for (int i = 0; i < calculator.TransactionLog.Length; i++)
            {
                lstIncomeLog.Items.Add(calculator.TransactionLog[i][2].ToString("0.00") + " ISK");
            }
        }

        private void DisplayProfitLog()
        {
            lstProfitLog.Items.Clear();
            for (int i = 0; i < calculator.TransactionLog.Length; i++)
            {
                lstProfitLog.Items.Add((calculator.TransactionLog[i][2] - calculator.TransactionLog[i][1]).ToString("0.00") + " ISK");
            }
        }

        #endregion

        //
        //  Utility Functions
        //

        #region Utility Functions

        private int FindMaxLength(float[][] data, int column)
        {
            int max = 0;

            for (int i = 0; i < data.Length; i++)
                if (max < data[i][column].ToString("0.00").Length)
                    max = data[i][column].ToString("0.00").Length;

            return max;
        }

        private async void UpdateMarketData()
        {
            timRefreshStatusUpdater.Enabled = true;
            cmdCalculate.Enabled = false;
            cmdRefresh.Enabled = false;

            await Task.Factory.StartNew(() => calculator.UpdateMarketData());

            prgStatus.Value = 0;
            timRefreshStatusUpdater.Enabled = false;

            lblStatus.Text = "Updating displayed values..";
            lblStatus.Text = "Done.";

            calculator.ApplyFilter(txtRegion.Text, txtSystem.Text, txtStation.Text, (float)numMinimalSecurity.Value);

            cmdCalculate.Enabled = true;
            cmdRefresh.Enabled = true;
        }

        #endregion

        //
        //  Settings
        //

        #region Settings

        private void numOreYield_ValueChanged(object sender, System.EventArgs e)
        {
            calculator.ConversionRate = (float)numOreYield.Value;
        }

        private void numMinPerc_ValueChanged(object sender, System.EventArgs e)
        {
            calculator.MinimumMarginPercentage = (float)((double)numMinPerc.Value / 100.0);
        }

        private void numMinTotal_ValueChanged(object sender, System.EventArgs e)
        {
            calculator.MinimumMarginTotal = (float)numMinTotal.Value;
        }

        private void cmdApplyFilter_Click(object sender, System.EventArgs e)
        {
            calculator.ApplyFilter(txtRegion.Text, txtSystem.Text, txtStation.Text, (float)numMinimalSecurity.Value);
        }

        #endregion

        //
        //  ListBoxes
        //

        #region ListBoxes

        bool updating = false;
        private void UpdatePosition(ListBox box)
        {
            updating = true;

            lstProfitLog.TopIndex = box.TopIndex;
            lstInvestmentLog.TopIndex = box.TopIndex;
            lstIncomeLog.TopIndex = box.TopIndex;
            lstRepeats.TopIndex = box.TopIndex;

            lstProfitLog.SelectedIndex = box.SelectedIndex;
            lstInvestmentLog.SelectedIndex = box.SelectedIndex;
            lstIncomeLog.SelectedIndex = box.SelectedIndex;
            lstRepeats.SelectedIndex = box.SelectedIndex;

            if(box.SelectedIndex < calculator.LocationLog.Length && box.SelectedIndex >= 0)
            {
                lstBuyLocationLog.Items.Clear();
                for (int i = 0; i < calculator.LocationLog[box.SelectedIndex][0].Count; i++)
                {
                    string s = "";
                    for (int y = 0; y < calculator.LocationLog[box.SelectedIndex][0][i].Length; y++)
                        s += calculator.LocationLog[box.SelectedIndex][0][i][y].Replace('\"', ' ').Trim() + ", ";
                    lstBuyLocationLog.Items.Add(s);
                }

                lstSellLocationLog.Items.Clear();
                for (int i = 0; i < calculator.LocationLog[box.SelectedIndex][1].Count; i++)
                {
                    string s = "";
                    for (int y = 0; y < calculator.LocationLog[box.SelectedIndex][1][i].Length; y++)
                        s += calculator.LocationLog[box.SelectedIndex][1][i][y].Replace('\"', ' ').Trim() + ", ";
                    lstSellLocationLog.Items.Add(s);
                }
            }

            updating = false;
        }

        private void lstProfitLog_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(!updating)
                UpdatePosition(lstProfitLog);
        }

        private void lstInvestmentLog_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!updating)
                UpdatePosition(lstInvestmentLog);
        }

        private void lstIncomeLog_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!updating)
                UpdatePosition(lstIncomeLog);
        }

        private void lstReapeats_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!updating)
                UpdatePosition(lstRepeats);
        }

        #endregion
    }
}
