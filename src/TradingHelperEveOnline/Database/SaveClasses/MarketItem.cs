using System;
using System.Collections.Generic;
using System.Linq;

namespace TradingHelperEveOnline.Database.SaveClasses
{
    public class MarketItem
    {
        //
        //  Properties
        //

        #region Properties

        public int ID;
        public string Name;
        MarketItemEntry[] orig_entries;

        MarketItemEntry[] entries;

        MarketItemEntry[] buyEntries;
        MarketItemEntry[] sellEntries;

        #endregion


        public MarketItem(int id, string name, MarketItemEntry[] entries)
        {
            ID = id;
            Name = name;
            orig_entries = entries;
            this.entries = entries;
            UpdateBuySellEntries();
        }

        //
        //  Get
        //

        #region Get

        public MarketItemEntry[] Entries
        {
            get
            {
                return entries;
            }
            set
            {
                entries = value;
                UpdateBuySellEntries();
            }
        }

        public MarketItemEntry[] BuyEntries
        {
            get
            {
                return buyEntries;
            }
        }

        public MarketItemEntry[] SellEntries
        {
            get
            {
                return sellEntries;
            }
        }

        public float GetBuyPrice()
        {
            float highestBuyPrice = -1;
            int index = 0;
            for (int i = 0; i < this.Entries.Length; i++)
                if (this.Entries[i].EntryType == MarketItemEntryType.BuyOrder && highestBuyPrice < this.Entries[i].Price)
                {
                    highestBuyPrice = this.Entries[i].Price;
                    index = i;
                }

            return highestBuyPrice;
        }

        public float GetSellPrice()
        {
            float lowestSellPrice = 10000000000000;

            for (int i = 0; i < entries.Length; i++)
                if (entries[i].EntryType == MarketItemEntryType.SellOrder && lowestSellPrice > entries[i].Price)
                    lowestSellPrice = entries[i].Price;

            return lowestSellPrice;
        }

        public float[][] GetAbstractSellData()
        {
            List<float[]> buyData = new List<float[]>();
            
            foreach(MarketItemEntry entry in Entries)
                if (entry.EntryType == MarketItemEntryType.SellOrder)
                    buyData.Add(new float[] { entry.Quantity, entry.Price });

            return buyData.OrderBy(inner => inner[1]).ToArray();
        }

        public float[][] GetAbstractBuyData()
        {
            List<float[]> sellData = new List<float[]>();

            foreach (MarketItemEntry entry in Entries)
                if (entry.EntryType == MarketItemEntryType.BuyOrder)
                    sellData.Add(new float[] { entry.Quantity, entry.Price });

            return sellData.OrderBy(inner => inner[1]).Reverse().ToArray();
        }

        #endregion

        //
        //  Utility Functions
        //

        #region Utility Functions
        private void UpdateBuySellEntries()
        {
            List<MarketItemEntry> buyEntries = new List<MarketItemEntry>();
            List<MarketItemEntry> sellEntries = new List<MarketItemEntry>();

            for (int i = 0; i < entries.Length; i++)
                if (entries[i].EntryType == MarketItemEntryType.BuyOrder)
                    buyEntries.Add(entries[i]);
                else if (entries[i].EntryType == MarketItemEntryType.SellOrder)
                    sellEntries.Add(entries[i]);

            this.buyEntries = buyEntries.ToArray();
            this.sellEntries = sellEntries.ToArray();
        }

        public void ApplyFilter(string region, string system, string station, float sec)
        {
            List<MarketItemEntry> entries = new List<MarketItemEntry>();
            for(int i = 0; i < orig_entries.Length; i++)
            {
                if (orig_entries[i].Region.Contains(region) &&
                    orig_entries[i].System.Contains(system) &&
                    orig_entries[i].Station.Contains(station) &&
                    orig_entries[i].Security >= sec)
                    entries.Add(orig_entries[i]);
            }
            this.entries = entries.ToArray();
            UpdateBuySellEntries();
        }
        #endregion
    }
}
