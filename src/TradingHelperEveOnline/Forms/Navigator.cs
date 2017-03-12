using System;
using System.Windows.Forms;
using TradingHelperEveOnline.OreCalculatorNS.Forms;

namespace TradingHelperEveOnline.Forms
{
    public partial class Navigator : Form
    {
        public Navigator()
        {
            InitializeComponent();
        }

        private void cmdStartDataBaseView_Click(object sender, EventArgs e)
        {
            using (DataBaseViewer v = new DataBaseViewer())
            {
                v.ShowDialog();
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdStartOreCalculator_Click(object sender, EventArgs e)
        {
            using (OreCalculatorForm o = new OreCalculatorForm())
            {
                o.ShowDialog();
            }
        }
    }
}
