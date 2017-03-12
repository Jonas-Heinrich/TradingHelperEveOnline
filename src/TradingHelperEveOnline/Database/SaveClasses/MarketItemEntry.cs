namespace TradingHelperEveOnline.Database.SaveClasses
{
    public class MarketItemEntry
    {
        public string Region;
        public string System;
        public string Station;

        public float Security;
        public float Price;
        public int Quantity;

        public MarketItemEntryType EntryType;

        public MarketItemEntry(string region, string system, string station, float sec, float price, int qty, MarketItemEntryType type)
        {
            Region = "\"" + region + "\"";
            System = "\"" + system + "\"";
            Station = "\"" + station + "\"";
            Security = sec;
            Price = price;
            Quantity = qty;
            EntryType = type;
        }

        public string[] LocationInformation
        {
            get
            {
                return new string[] { Region, System, Station };
            }
        }
    }
}