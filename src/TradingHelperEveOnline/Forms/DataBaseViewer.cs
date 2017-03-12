using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingHelperEveOnline.Database;
using TradingHelperEveOnline.DataStripper;

namespace TradingHelperEveOnline
{
    public partial class DataBaseViewer : Form
    {
        MarketDataStripper stripper = new MarketDataStripper();
        CancellationTokenSource updateCancelToken;
        int tenths = 0;


        public DataBaseViewer()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            stripper.Close();
        }
        
        //
        //
        //  Update Market Data
        //
        //

        private void ToogleUpdateButtons()
        {
            cmdCancel.Enabled = !cmdCancel.Enabled;
            cmdUpdate.Enabled = !cmdUpdate.Enabled;
            cmdUpdateMarketFull.Enabled = !cmdUpdateMarketFull.Enabled;
        }

        //
        //  Buttons
        //

        private async void cmdUpdateMarketFull_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This may take several minutes, up to hours.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateCancelToken = new CancellationTokenSource();
                ToogleUpdateButtons();

                stripper.ClearDataBase();
                Task t = Task.Factory.StartNew(() => stripper.UpdateMarketDataFull(updateCancelToken.Token));

                TimerUpdateStatus.Enabled = true;
                tenths = 0;

                await t;
                ToogleUpdateButtons();
            }
        }

        private async void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This may take several minutes.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateCancelToken = new CancellationTokenSource();
                ToogleUpdateButtons();
                
                Task t = Task.Factory.StartNew(() => stripper.UpdateMarketData(updateCancelToken.Token));

                TimerUpdateStatus.Enabled = true;
                tenths = 0;

                await t;

                ToogleUpdateButtons();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            updateCancelToken.Cancel();
        }

        private void TimerUpdateStatus_Tick(object sender, EventArgs e)
        {
            if(stripper.Status == MarketUpdateStatus.Idle)
            {
                lblUpdateStatus.Text =
                    Convert.ToString(stripper.TotalItemCount) + " / " +
                    Convert.ToString(stripper.TotalItemCount);
                lblUpdateStatus.Text += " Done";

                lblSecondsLeft.Text = "--Done--";

                TimerUpdateStatus.Enabled = false;
            }
            else if (stripper.Status == MarketUpdateStatus.GettingItemList)
            {
                lblUpdateStatus.Text = "Getting Item List..";
                lblSecondsLeft.Text = "? s left";
            }
            else if (stripper.Status == MarketUpdateStatus.GettingItemData)
            {
                pgUpdateStatus.Maximum = stripper.TotalItemCount;
                pgUpdateStatus.Value = stripper.ItemsFinishedCount;

                lblUpdateStatus.Text =
                    Convert.ToString(stripper.ItemsFinishedCount) + " / " +
                    Convert.ToString(stripper.TotalItemCount) + " Items (" +
                    Convert.ToString(Math.Round((double)stripper.ItemsFinishedCount / stripper.TotalItemCount * 100, 2)) +
                    "%) | " +
                    Convert.ToString(stripper.FailureCount) + " Failures";

                tenths++;

                if(tenths % 5 == 0)
                {
                    lblSecondsLeft.Text = Convert.ToString(Math.Round(
                        ((tenths / 10.0) /                                                          // Seconds
                        (stripper.ItemsFinishedCount)) *                                            // Seconds per item
                        (stripper.TotalItemCount - stripper.ItemsFinishedCount), 2)) + " s left";  // Items to do
                }
            }
        }
    }
}
