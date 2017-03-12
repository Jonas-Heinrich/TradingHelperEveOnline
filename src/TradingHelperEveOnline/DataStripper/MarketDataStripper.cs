using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradingHelperEveOnline.Database;
using TradingHelperEveOnline.Database.SaveClasses;

namespace TradingHelperEveOnline.DataStripper
{
    class MarketDataStripper
    {
        private const string ITEMSPAGEURL = "https://eve-central.com/home/typesearch.html?search=";
        private const string ITEMPAGEURL =  "https://eve-central.com/home/";

        private List<MarketItem> marketItems = new List<MarketItem>();

        public int ItemsFinishedCount = 0;
        public int TotalItemCount = 0;
        public int FailureCount = 0;
        public MarketUpdateStatus Status = MarketUpdateStatus.Idle;

        public object EntryType { get; private set; }

        //
        //  Pure Database Management
        //

        public MarketDataStripper()
        {
            DataBaseManager.Start();
        }
        
        public void Close()
        {
            DataBaseManager.End();
        }

        public void ClearDataBase()
        {
            DataBaseManager.End();
            DataBaseManager.InitializeDataBase();
            DataBaseManager.Start();
        }

        //
        //  Low level functions with EveCentral Access
        //

        public string GetHTML(string link)
        {
            string url = link;
            string html = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if(response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                html = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }
            html = html.Replace('\n', ' ');
            html = html.Replace('\t', ' ');
            return html;
        }

        private string[] GetItemURLs()
        {
            string html = GetHTML(ITEMSPAGEURL);

            List<string> itemURLList = new List<string>();

            string[] links = html.Split(new string[] { "</a>" }, StringSplitOptions.None);

            string searchParameter = "<a href=\"";
            string acc = "";
            for (int i = 0; i < links.Length; i++)
            {
                int index = links[i].IndexOf(searchParameter) + searchParameter.Length;

                if (links[i].Contains("<a"))
                {
                    acc = "";
                    while (links[i][index] != '\"')
                        acc += links[i][index++];

                    if (acc.Contains("quicklook.html?typeid="))
                        itemURLList.Add(acc);
                }
            }
            return itemURLList.ToArray();
        }

        private string[] GetItemURLsDB()
        {
            int[] ids = DataBaseManager.GetTradableIDs();

            string[] urls = new string[ids.Length];
            for (int i = 0; i < urls.Length; i++)
                urls[i] = "quicklook.html?typeid=" + ids[i].ToString();
            return urls;
        }

        //
        //  Data Processing
        //

        private MarketItem StripMarketItem(string html, int id)
        {
            List<MarketItemEntry> entries = new List<MarketItemEntry>();

            string[] tables = html.Split(new string[] { "</table>" }, StringSplitOptions.None);
            
            if(tables.Length != 4)
                return new MarketItem(id, "MarketItem" + Convert.ToString(id), entries.ToArray());
            
            for (int table = 0; table < tables.Length - 2; table++)
            {
                tables[table] = tables[table].Substring(tables[table].IndexOf("<table"));
                string[] rows = tables[table].Split(new string[] { "</tr>" }, StringSplitOptions.None);

                if (rows.Length == 2)
                    continue;

                for(int row = 1; row < rows.Length - 1; row++)
                {
                    string[] cells = new string[7];

                    rows[row].Split(new string[] { "</td>" }, StringSplitOptions.None).CopyTo(cells, 0);

                    string[] s = cells[1].Split(new string[] { "</span>" }, StringSplitOptions.None);

                    if(s.Length == 2)
                    {
                        cells[1] = s[0];
                        for (int i = 6; i > 2; i--)
                            cells[i] = cells[i - 1];
                        cells[2] = s[1];
                    }
                    else if(s.Length == 3)
                    {
                        cells[1] = s[0];
                        for (int i = 6; i > 2; i--)
                            cells[i] = cells[i - 1];
                        cells[2] = s[1].Split(new string[] { "<span" }, StringSplitOptions.None)[0];
                    }

                    string[] cellData = new string[cells.Length];
 
                    for(int cell = 0; cell < cells.Length; cell++)
                    {
                        cellData[cell] = "";
                        for(int i = cells[cell].LastIndexOf('>') + 1; i < cells[cell].Length; i++)
                        {
                            cellData[cell] += cells[cell][i];
                        }
                    }

                    s = cellData[2].Split('-');

                    if (cellData[4].Contains("(Min:"))
                        cellData[4] = cellData[4].Substring(0, cellData[4].IndexOf("(Min:"));

                    if(s.Length > 1)
                    {
                        entries.Add(new MarketItemEntry
                            (
                                cellData[0],
                                s[0],
                                s[1],
                                Convert.ToSingle(cellData[1]),
                                Convert.ToSingle(cellData[3].Replace(",", "")),
                                Convert.ToInt32(cellData[4].Replace(",", "")),
                                (MarketItemEntryType)table
                            ));
                    }
                    else
                    {
                        entries.Add(new MarketItemEntry
                            (
                                cellData[0],
                                s[0],
                                "",
                                Convert.ToSingle(cellData[1]),
                                Convert.ToSingle(cellData[3].Replace(",", "")),
                                Convert.ToInt32(cellData[4].Replace(",", "")),
                                (MarketItemEntryType)table
                            ));
                    }
                }
            }

            return new MarketItem(id, "MarketItem" + Convert.ToString(id), entries.ToArray());
        }

        private void CreateMarketItem(string URL, CancellationToken cancelToken, ref bool failure)
        {
            failure = false;
            try
            {
                string html = GetHTML(ITEMPAGEURL + URL);

                if (cancelToken.IsCancellationRequested)
                    return;

                int id = Convert.ToInt32(URL.Replace("quicklook.html?typeid=", ""));

                if (cancelToken.IsCancellationRequested)
                    return;

                MarketItem m = StripMarketItem(html, id);

                if (cancelToken.IsCancellationRequested)
                    return;

                marketItems.Add(m);
            }
            catch (IOException)
            {
                failure = true;
            }
            catch (WebException)
            {
                failure = true;
            }
        }

        private void UpdateMarketData(string[] itemURLList, CancellationToken cancelToken)
        {
            DataBaseManager.ResetMarketTable();
            int[] s = new int[itemURLList.Length];
            for (int i = 0; i < itemURLList.Length; i++)
                s[i] = Convert.ToInt32(itemURLList[i].Replace("quicklook.html?typeid=", ""));
            DataBaseManager.SaveIDs(s);

            // Reset status data
            ItemsFinishedCount = 0;
            TotalItemCount = itemURLList.Length;
            FailureCount = 0;

            // Declarate tasks, task management
            Task[] tasks = new Task[TotalItemCount];
            bool[] saved = new bool[TotalItemCount];
            bool[] failures = new bool[TotalItemCount];

            // Init tasks, task management
            Status = MarketUpdateStatus.GettingItemData;
            for (int y = 0; y < itemURLList.Length - 1; y++)
            {
                string url = itemURLList[y];
                saved[y] = false;
                failures[y] = false;
                tasks[y] = Task.Factory.StartNew(() => CreateMarketItem(url, cancelToken, ref failures[y]));
            }

            // While one task is not completed and therefore sets done to false
            bool done = false;
            while (!done)
            {
                if (cancelToken.IsCancellationRequested)
                    break;
                done = true;
                // Check if tasks are done
                for (int i = 0; i < tasks.Length - 1; i++)
                    if (!tasks[i].IsCompleted)
                        done = false;
                    else
                    {
                        // If task does not report failure via ref bool
                        if (!failures[i])
                        {
                            if (!saved[i])
                            {
                                DataBaseManager.SaveMarketItem(marketItems[marketItems.Count - 1]);
                                DataBaseManager.MarkDone(marketItems[marketItems.Count - 1].ID);

                                ItemsFinishedCount++;
                                saved[i] = true;
                            }
                        }
                        // Else increase failure count, Retry
                        else
                        {
                            FailureCount++;
                        }
                    }
            }

            Status = MarketUpdateStatus.Idle;
        }

        //
        //  Top Level Functions
        //

        public void UpdateMarketDataFull(CancellationToken cancelToken)
        {
            // Update Status, Get URLS of HTML pages
            Status = MarketUpdateStatus.GettingItemList;
            UpdateMarketData(GetItemURLs(), cancelToken);
            DataBaseManager.UpdateTradableIDs();
        }

        public void UpdateMarketData(CancellationToken cancelToken)
        {
            // Update Status, Get URLS out of DB
            Status = MarketUpdateStatus.GettingItemList;
            UpdateMarketData(GetItemURLsDB(), cancelToken);
        }

        public MarketItem[] GetMarketData(int[] itemIDs)
        {
            TotalItemCount = itemIDs.Length;
            ItemsFinishedCount = 0;

            MarketItem[] m = new MarketItem[itemIDs.Length];
            Task<MarketItem>[] tasks = new Task<MarketItem>[itemIDs.Length];

            bool[] taskDone = new bool[itemIDs.Length];

            for(int i = 0; i < tasks.Length; i++)
            {
                int saver = i;
                taskDone[saver] = false;
                tasks[saver] = Task.Factory.StartNew(() => GetMarketData(itemIDs[saver]));
            }

            bool done = false;
            while (!done)
            {
                done = true;
                for (int i = 0; i < tasks.Length; i++)
                    if (!tasks[i].IsCompleted)
                        done = false;
                    else if (tasks[i].IsCompleted && !taskDone[i])
                    {
                        taskDone[i] = true;
                        ItemsFinishedCount++;
                    }
            }
            
            for (int i = 0; i < tasks.Length; i++)
                m[i] = tasks[i].Result;
            return m;
        }

        public MarketItem GetMarketData(int itemID)
        {
            return StripMarketItem(GetHTML("https://eve-central.com/home/quicklook.html?typeid=" + Convert.ToString(itemID)), itemID);
        }
    }
}