using System;
using System.Collections.Generic;
using TradingHelperEveOnline.Database.SaveClasses;
using TradingHelperEveOnline.DataStripper;

namespace TradingHelperEveOnline.OreCalculatorNS
{
    class OreDetailCalculator
    {
        //
        //  Properties
        //

        #region Properties

        MarketDataStripper stripper;
        MarketItem oreMarketData;
        MarketItem[] outputMarketData;

        int oreIndex;
        float totalProfit;
        float conversionRate;
        float minimumMarginPercentage;
        float minimumMarginTotal;
        CalculationType calcType;

        float[][] transactionLog = new float[][] { };
        List<string[]>[][] locationLog = new List<string[]>[][] { };


        string status;
        #endregion

        //
        //  Constructor
        //

        #region Constructor
        public OreDetailCalculator(CalculationType calcType, float conversionRate, MarketItem oreMarketData, MarketItem[] outputMarketData)
        {
            this.calcType = calcType;
            this.conversionRate = conversionRate;
            this.oreMarketData = oreMarketData;
            this.outputMarketData = outputMarketData;

            oreIndex = OreDataProvider.GetOreIndex(oreMarketData.ID);
            stripper = new MarketDataStripper();
        }

        public OreDetailCalculator(CalculationType calcType, float conversionRate, int oreIndex)
        {
            this.calcType = calcType;
            this.conversionRate = conversionRate;
            this.oreIndex = oreIndex;

            stripper = new MarketDataStripper();
        }
        #endregion

        //
        //  Decostructor
        //

        #region Deconstructor (kind of)
        public void Close()
        {
            stripper.Close();
        }
        #endregion

        //
        //  Public Properties
        //

        #region Public Properties
        public string Status
        {
            get
            {
                return status;
            }
        }

        public float TotalProfit
        {
            get
            {
                return totalProfit;
            }
        }

        public float MinimumMarginTotal
        {
            set
            {
                minimumMarginTotal = value;
            }
        }

        public float MinimumMarginPercentage
        {
            set
            {
                minimumMarginPercentage = value;
            }
        }

        public float ConversionRate
        {
            get
            {
                return conversionRate;
            }
            set
            {
                conversionRate = value;
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

        public float[][] TransactionLog
        {
            get
            {
                return transactionLog;
            }
        }

        public List<string[]>[][] LocationLog
        {
            get
            {
                return locationLog;
            }
        }


        #endregion

        //
        //  Utility
        //

        #region Utility

        public void ApplyFilter(string region, string system, string station, float sec)
        {
            oreMarketData.ApplyFilter(region, system, station, sec);
            for(int i = 0; i < outputMarketData.Length; i++)
                outputMarketData[i].ApplyFilter(region, system, station, sec);
        }

        private bool Equal(List<string[]>[] obj1, List<string[]>[] obj2)
        {
            if (obj1.Length != obj2.Length)
                return false;

            for (int i = 0; i < obj1.Length; i++)
            {
                if (obj1[i].Count != obj2[i].Count)
                    return false;
                for (int y = 0; y < obj1[i].Count; y++)
                {
                    if (obj1[i][y].Length != obj2[i][y].Length)
                        return false;
                    for (int a = 0; a < obj1[i][y].Length; a++)
                        if (obj1[i][y][a] != obj2[i][y][a])
                            return false;
                }
            }
            return true;
        }

        #endregion

        //
        //  Update Market Data
        //

        #region UpdateMarketdata
        public void UpdateMarketData()
        {
            status = "Updating Ore Data..";
            oreMarketData = stripper.GetMarketData(OreDataProvider.OreIDs[oreIndex]);
            status = "Updating Output Data..";
            outputMarketData = stripper.GetMarketData(OreDataProvider.OutputIDs);
            status = "Done.";
        }
        #endregion

        //
        //  Calculate with Data
        //

        public void UpdateCalculations()
        {
            List<float[]> log = new List<float[]>();
            List<List<string[]>[]> location = new List<List<string[]>[]>();


            float[][] sellData = oreMarketData.GetAbstractSellData();
            float[][][] buyData = new float[outputMarketData.Length][][];
            int[] conversionRates = OreDataProvider.GetConversionRates(oreIndex, conversionRate / 100);

            for (int i = 0; i < buyData.Length; i++)
                buyData[i] = outputMarketData[i].GetAbstractBuyData();
            
            float totalProfit = 0;
            int orePointer = 0;
            int[] outputPointer = new int[outputMarketData.Length];

            for (int i = 0; i < buyData.Length; i++)
                outputPointer[i] = 0;
            while (true)
            {
                List<string[]>[] loc = new List<string[]>[2];
                loc[0] = new List<string[]>();
                loc[1] = new List<string[]>();

                float investment = 0;
                int batchOre = 0;
                while (batchOre < 100)
                {
                    if (sellData[orePointer][0] >= 100 - batchOre)
                    {
                        sellData[orePointer][0] -= 100 - batchOre;
                        investment += sellData[orePointer][1] * (100 - batchOre);
                        batchOre += 100 - batchOre;

                        loc[0].Add(oreMarketData.SellEntries[orePointer].LocationInformation);

                        if (sellData[orePointer][0] == 0)
                            orePointer++;
                    }
                    else
                    {
                        batchOre += (int)sellData[orePointer][0];
                        investment += sellData[orePointer][0] * sellData[orePointer][1];
                        sellData[orePointer][0] = 0;
                        loc[0].Add(oreMarketData.SellEntries[orePointer].LocationInformation);

                        if (orePointer + 1 >= sellData.Length)
                        {
                            this.transactionLog = log.ToArray();
                            this.totalProfit = (float)Math.Round(totalProfit * 0.98, 2);
                            return;
                        }
                        orePointer++;
                    }
                }

                int[] output = new int[conversionRates.Length];
                conversionRates.CopyTo(output, 0);

                float income = 0;

                for(int i = 0; i < output.Length; i++)
                {
                    while (output[i] > 0)
                    {
                        if (buyData[i][outputPointer[i]][0] >= output[i])
                        {
                            income += buyData[i][outputPointer[i]][1] * output[i];
                            buyData[i][outputPointer[i]][0] -= output[i];
                            output[i] = 0;

                            loc[1].Add(outputMarketData[i].BuyEntries[outputPointer[i]].LocationInformation);
                        }
                        else
                        {
                            income += buyData[i][outputPointer[i]][0] * buyData[i][outputPointer[i]][1];
                            output[i] -= (int)buyData[i][outputPointer[i]][0];
                            buyData[i][outputPointer[i]][0] = 0;

                            loc[1].Add(outputMarketData[i].BuyEntries[outputPointer[i]].LocationInformation);

                            if (outputPointer[i] + 1 >= buyData[i].Length)
                            {
                                this.transactionLog = log.ToArray();
                                this.totalProfit = (float)Math.Round(totalProfit * 0.98, 2);
                                return;
                            }
                            outputPointer[i]++;
                        }
                    }
                }

                if (income * 0.98 > investment && 
                    income / investment - 1 > minimumMarginPercentage && 
                    income - investment > minimumMarginTotal)
                {
                    totalProfit += income - investment;
                    if (    log.Count == 0 || 
                            investment != log[log.Count - 1][1] || 
                            income != log[log.Count - 1][2] ||
                            !Equal(loc, location[location.Count - 1]))
                    {
                        log.Add
                        (
                            new float[]
                            {
                                1,
                                investment,
                                income
                            }
                        );
                        location.Add(loc);
                    }
                    else
                        log[log.Count - 1][0]++;
                }
                else
                    break;
            }
            this.transactionLog = log.ToArray();
            this.locationLog = location.ToArray();
            this.totalProfit = (float)Math.Round(totalProfit * 0.98, 2);
        }
        
        private static int Compare(float first, float second)
        {
            return first.CompareTo(second);
        }
    }
}

//
//  TODO
//

/*
 * implement limit by region/system
 */
