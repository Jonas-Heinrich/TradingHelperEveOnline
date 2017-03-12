using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TradingHelperEveOnline.OreCalculatorNS.Forms.Controls
{
    class TableLayoutPanelWrapper
    {
        //
        //  Properties
        //

        #region Properties
        TableLayoutPanel table;
        private int selectedRow = -1;
        Func<object, MouseEventArgs, int, int, int> RespondToMouseClick;
        Label[,] reference; 
        
        public int GetSelectedRow
        {
            get
            {
                return selectedRow;
            }
        }
        #endregion

        public TableLayoutPanelWrapper(TableLayoutPanel table, Func<object, MouseEventArgs, int, int, int> handlerMethod, int[] widths)
        {
            this.table = table;
            rowColors = new Color[table.ColumnCount];
            reference = new Label[table.ColumnCount, table.RowCount];
            RespondToMouseClick = handlerMethod;

            for (int x = 0; x < table.ColumnCount; x++)
            {
                table.ColumnStyles[x].SizeType = SizeType.Absolute;
                table.ColumnStyles[x].Width = widths[x];
                for (int y = 0; y < table.RowCount; y++)
                {
                    Label l = GenerateLabel("", x, y);
                    reference[x,y] = l;
                    table.Controls.Add(l, x, y);
                }
            }
            for (int y = 0; y < table.RowCount; y++)
            {
                table.RowStyles[y].SizeType = SizeType.Absolute;
                table.RowStyles[y].Height = 15;
            }
        }

        //
        //  Utility Functions
        //

        #region Utility Functions
        private int FindMaxLength(float[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i].ToString("0.00").Length > max)
                    max = arr[i].ToString("0.00").Length;

            return max;
        }

        public int[] GetTableCords(object sender)
        {
            int index = table.Controls.IndexOf((Control)sender);
            int[] cords = new int[2];
            cords[0] = index / table.RowCount;
            cords[1] = index % table.RowCount;
            return cords;
        }

        private int HandlerMethodWrapper(object sender, MouseEventArgs e, int x, int y)
        {
            if (RespondToMouseClick == null)
                return 0;
            RespondToMouseClick.Invoke(sender, e, x, y);
            return 1;
        }

        private Label GenerateLabel(string t, int x, int y)
        {
            Label l = new Label();
            l.Margin = new Padding(0);
            l.Dock = DockStyle.Fill;
            l.MouseClick += new MouseEventHandler((s, arg) => HandlerMethodWrapper(s, arg, x, y));
            l.Text = t;
            return l;
        }

        #endregion

        //
        //  Data Entry
        //

        #region Data Entry
        public void EnterData(int column, int row, string data)
        {
            reference[column, row].Text = data;
        }

        public void FillTable(int column, float[] data)
        {
            int maxLength = FindMaxLength(data);
            for (int i = 1; i < table.RowCount; i++)
            {
                string s = data[i - 1].ToString("0.00");
                for (int y = s.Length; y < maxLength; y++)
                    s = " " + s;
                EnterData(column, i, s);
                reference[column, i].Font = new Font(FontFamily.GenericMonospace, 8);
            }
        }

        public void FillTable(int column, string[] data)
        {
            for (int i = 1; i < table.RowCount; i++)
                EnterData(column, i, data[i - 1]);
        }

        public void FillTable(int column, string data)
        {
            for (int i = 1; i < table.RowCount; i++)
                EnterData(column, i, data);
        }
        #endregion

        //
        //  Background Color Control
        //

        #region BackgroundColor Control
        public void SetCellColor(int column, int row, Color c)
        {
            table.GetControlFromPosition(column, row).BackColor = c;
        }

        int currentHighlightRow = -1;
        Color[] rowColors;
        public void HighlightRow(int row)
        {
            if(currentHighlightRow != -1)
                for (int x = 0; x < table.ColumnCount; x++)
                    reference[x, currentHighlightRow].BackColor = rowColors[x];

            for (int x = 0; x < table.ColumnCount; x++)
            {
                rowColors[x] = reference[x, row].BackColor;
                reference[x, row].BackColor = Color.FromArgb(51, 143, 255);
            }
            

            currentHighlightRow = row;
        }
        #endregion

    }
}
