using TradingHelperEveOnline.Database.SaveClasses;
using TradingHelperEveOnline.DataStripper;

namespace TradingHelperEveOnline.OreCalculatorNS
{
    public class OreCalculator
    {
        //
        //  Properties
        //

        #region Properties
        bool initialised = false;
        MarketDataStripper stripper;
        CalculationType type;

        float[] orePrices = new float[OreDataProvider.OreNames.Length];
        float[] outputPrices = new float[OreDataProvider.OutputNames.Length];

        float[] investment = new float[OreDataProvider.OreNames.Length];
        float[] income = new float[OreDataProvider.OreNames.Length];

        MarketItem[] oreData = new MarketItem[OreDataProvider.OreNames.Length];
        MarketItem[] outputData = new MarketItem[OreDataProvider.OutputNames.Length];

        string status = "";
        private float oreConversionRate;
        #endregion

        public OreCalculator(CalculationType type, float oreConversionRate)
        {
            this.type = type;
            this.oreConversionRate = oreConversionRate;
            stripper = new MarketDataStripper();
        }

        public void Close()
        {
            stripper.Close();
        }
        
        public void ApplyFilter(string region, string system, string station, float sec)
        {
            for (int i = 0; i < oreData.Length; i++)
                oreData[i].ApplyFilter(region, system, station, sec);
            for (int i = 0; i < outputData.Length; i++)
                outputData[i].ApplyFilter(region, system, station, sec);
        }

        //
        //  Get
        //

        #region

        public bool Initialised
        {
            get
            {
                return initialised;
            }
        }

        public float[] GetOutputPrices()
        {
            return outputPrices;
        }

        public float[] GetOrePrices()
        {
            return orePrices;
        }

        public MarketItem GetOreMarketData(int oreID)
        {
            return oreData[oreID];
        }

        public MarketItem[] GetOutputMarketData()
        {
            return outputData;
        }

        public float[] GetInvestmentData()
        {
            return investment;
        }

        public float[] GetIncomeData()
        {
            return income;
        }

        public string Status
        {
            get
            {
                return status;
            }
        }

        public int ItemsFinishedCount
        {
            get
            {
                return stripper.ItemsFinishedCount;
            }
        }

        public int TotalItemCount
        {
            get
            {
                return stripper.TotalItemCount;
            }
        }

        public float OreConversionRate
        {
            get
            {
                return oreConversionRate;
            }
            set
            {
                if(oreConversionRate >= 0 && oreConversionRate <= 1)
                    oreConversionRate = value;
            }
        }

        #endregion

        //
        //  Update Market Data
        //

        private void UpdateMarketData()
        {
            status = "Updating Ore Data..";
            oreData = stripper.GetMarketData(OreDataProvider.OreIDs);
            status = "Updating Output Data..";
            outputData = stripper.GetMarketData(OreDataProvider.OutputIDs);
        }

        //
        //  Update Prices
        //

        public void UpdateData()
        {
            UpdateMarketData();

            status = "Updating Prices..";
            UpdatePrices();
            status = "Done.";
            initialised = true;
        }

        public void UpdatePrices()
        {
            UpdateOrePrices();
            UpdateOutputPrices();

            UpdateInvestment();
            UpdateIncome();
        }
        
        private void UpdateOrePrices()
        {
            if (type == CalculationType.InstantBuySell)
            {
                for (int i = 0; i < OreDataProvider.OreNames.Length; i++)
                    orePrices[i] = oreData[i].GetSellPrice();
            }
            else if (type == CalculationType.OrderBuySell)
            {
                for (int i = 0; i < OreDataProvider.OreNames.Length; i++)
                    orePrices[i] = oreData[i].GetBuyPrice();
            }
        }

        private void UpdateOutputPrices()
        {
            if (type == CalculationType.InstantBuySell)
            {
                for (int i = 0; i < OreDataProvider.OutputIDs.Length; i++)
                    outputPrices[i] = outputData[i].GetBuyPrice();
            }
            else if (type == CalculationType.OrderBuySell)
            {
                for (int i = 0; i < OreDataProvider.OutputIDs.Length; i++)
                    outputPrices[i] = outputData[i].GetSellPrice();
            }
        }


        //
        //  Market Data Processing Utility functions
        //

        #region Utility Functions

        private MarketItem FindMarketItem(int itemID)
        {
            MarketItem m = null;
            for (int i = 0; i < oreData.Length; i++)
                if (oreData[i].ID == itemID)
                {
                    m = oreData[i];
                    break;
                }

            if (m == null)
                for (int i = 0; i < outputData.Length; i++)
                    if (outputData[i].ID == itemID)
                    {
                        m = outputData[i];
                        break;
                    }
            if (m == null)
                throw new System.ArgumentException("ID not found!");
            return m;
        }

        private float[] GetOutputData()
        {
            float[] prices = new float[outputData.Length];
            for(int i = 0; i < prices.Length; i++)
            {
                if (type == CalculationType.InstantBuySell)
                    prices[i] = outputData[i].GetBuyPrice();
                else
                    prices[i] = outputData[i].GetSellPrice();
            }
            return prices;
        }

        private float[] GetOreData()
        {
            float[] prices = new float[oreData.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                if (type == CalculationType.InstantBuySell)
                    prices[i] = oreData[i].GetSellPrice();
                else
                    prices[i] = oreData[i].GetBuyPrice();
            }
            return prices;
        }

        #endregion
 
        //
        //  Investment/Income
        //

        private void UpdateInvestment()
        {
            float[] prices = GetOreData();
            for (int i = 0; i < investment.Length; i++)
                investment[i] = 100 * prices[i];
        }

        private void UpdateIncome()
        {
            float[] prices = GetOutputData();
            for (int i = 0; i < income.Length; i++)
            {
                int[] conversionRates = OreDataProvider.GetConversionRates(i, OreConversionRate);
                income[i] = 0;

                for(int y = 0; y < conversionRates.Length; y++)
                    income[i] += conversionRates[y] * prices[y];
            }
        }
    }
}
