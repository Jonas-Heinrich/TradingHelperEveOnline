namespace TradingHelperEveOnline.OreCalculatorNS
{
    static class OreDataProvider
    {
        #region OreNames
        public static readonly string[] OreNames = new string[]
        {
            "Arkonor",
            "Crimson Arkonor",
            "Prime Arkonor",
            "Bistot",
            "Triclinic Bistot",
            "Monoclinic Bistot",
            "Crokite",
            "Sharp Crokite",
            "Crystalline Crokite",
            "Dark Ochre",
            "Onyx Ochre",
            "Obsidian Ochre",
            "Gneiss",
            "Iridescent Gneiss",
            "Prismatic Gneiss",
            "Hedbergite",
            "Vitric Hedbergite",
            "Glazed Hedbergite",
            "Hemorphite",
            "Vivid Hemorphite",
            "Radiant Hemorphite",
            "Jaspet",
            "Pure Jaspet",
            "Pristine Jaspet",
            "Kernite",
            "Luminous Kernite",
            "Fiery Kernite",
            "Mercoxit",
            "Magma Mercoxit",
            "Vitreous Mercoxit ",
            "Omber",
            "Silvery Omber",
            "Golden Omber",
            "Plagioclase",
            "Azure Plagioclase",
            "Rich Plagioclase",
            "Pyroxeres",
            "Solid Pyroxeres",
            "Viscous Pyroxeres",
            "Scordite",
            "Condensed Scordite",
            "Massive Scordite ",
            "Spodumain",
            "Bright Spodumain",
            "Gleaming Spodumain",
            "Veldspar",
            "Concentrated Veldspar",
            "Dense Veldspar",
        };
        #endregion

        #region OreIDs
        public static readonly int[] OreIDs = new int[]
        {
            22,         // Arkonor
            17425,      // Crimson Arkonor
            17426,      // Prime Arkonor

            1223,       // Bistot
            17428,      // Triclinic Bistot
            17429,      // Monoclinic Bistot

            1225,       // Crokite
            17432,      // Sharp Crokite
            17433,      // Crystalline Crokite

            1232,       // Dark Ochre
            17436,      // Onyx Ochre
            17437,      // Obsidian Ochre

            1229,       // Gneiss
            17865,      // Iridescent Gneiss
            17866,      // Prismatic Gneiss

            21,         // Hedbergite
            17440,      // Vitric Hedbergite
            17441,      // Glazed Hedbergite

            1231,       // Hemorphite
            17444,      // Vivid Hemorphite
            17445,      // Radiant Hemorphite

            1226,       // Jaspet
            17448,      // Pure Jaspet
            17449,      // Pristine Jaspet

            20,         // Kernite
            17452,      // Luminous Kernite
            17453,      // Fiery Kernite

            11396,      // Mercoxit
            17869,      // Magma Mercoxit
            17870,      // Vitreous Mercoxit 

            1227,       // Omber
            17867,      // Silvery Omber
            17868,      // Golden Omber

            18,         // Plagioclase
            17455,      // Azure Plagioclase
            17456,      // Rich Plagioclase

            1224,       // Pyroxeres
            17459,      // Solid Pyroxeres
            17460,      // Viscous Pyroxeres

            1228,       // Scordite
            17463,      // Condensed Scordite
            17464,      // Massive Scordite

            19,         // Spodumain
            17466,      // Bright Spodumain
            17467,      // Gleaming Spodumain

            1230,       // Veldspar
            17470,      // Concentrated Veldspar
            17471,      // Dense Veldspar
        };
        #endregion

        #region OreConversion Rates
        public static readonly int[] OreConversion = new int[]
        {
            //  Tri     Pye     Mex     Iso     Noc     Zyd     Meg     Mor
                // Arkonor
                22000,  0,      2500,   0,      0,      0,      320,    0,
                23100,  0,      2625,   0,      0,      0,      336,    0,
                24200,  0,      2750,   0,      0,      0,      352,    0,
                // Bistot
                0,      12000,  0,      0,      0,      450,    100,    0,
                0,      12600,  0,      0,      0,      473,    105,    0,
                0,      13200,  0,      0,      0,      495,    110,    0,
                // Crokite
                21000,  0,      0,      0,      760,    135,    0,      0,
                22050,  0,      0,      0,      798,    142,    0,      0,
                23100,  0,      0,      0,      836,    149,    0,      0,
                // Ochre
                10000,  0,      0,      1600,   120,    0,      0,      0,
                10500,  0,      0,      1680,   126,    0,      0,      0,
                11000,  0,      0,      1760,   132,    0,      0,      0,
                // Gneiss
                0,      2200,   2400,   300,    0,      0,      0,      0,
                0,      2310,   2520,   315,    0,      0,      0,      0,
                0,      2420,   2640,   330,    0,      0,      0,      0,
                // Hedbergite
                0,      1000,   0,      200,    100,    19,     0,      0,
                0,      1050,   0,      210,    105,    20,     0,      0,
                0,      1100,   0,      220,    110,    21,     0,      0,
                // Hermorphite
                2200,   0,      0,      100,    120,    15,     0,      0,
                2310,   0,      0,      105,    126,    16,     0,      0,
                2420,   0,      0,      110,    132,    17,     0,      0,
                // Jaspet
                0,      0,      350,    0,      75,     8,      0,      0,
                0,      0,      368,    0,      79,     8,      0,      0,
                0,      0,      385,    0,      83,     9,      0,      0,
                // Kernite
                134,    0,      267,    134,    0,      0,      0,      0,
                141,    0,      281,    141,    0,      0,      0,      0,
                148,    0,      294,    148,    0,      0,      0,      0,
                // Mercoxit
                0,      0,      0,      0,      0,      0,      0,      300,
                0,      0,      0,      0,      0,      0,      0,      315,
                0,      0,      0,      0,      0,      0,      0,      330,
                // Omber
                800,    100,    0,      85,     0,      0,      0,      0,
                840,    105,    0,      90,     0,      0,      0,      0,
                880,    110,    0,      94,     0,      0,      0,      0, 
                // Plagioclase
                107,    213,    107,    0,      0,      0,      0,      0,
                113,    224,    113,    0,      0,      0,      0,      0,
                118,    235,    118,    0,      0,      0,      0,      0,  
                // Pyroxeres
                351,    25,     50,     0,      5,      0,      0,      0,
                369,    26,     53,     0,      5,      0,      0,      0,
                387,    27,     55,     0,      5,      0,      0,      0,
                // Scordite
                346,    173,    0,      0,      0,      0,      0,      0,
                364,    182,    0,      0,      0,      0,      0,      0,
                381,    190,    0,      0,      0,      0,      0,      0,
                // Spodumain
                56000,  12050,  2100,   450,    0,      0,      0,      0,
                58800,  12653,  2205,   473,    0,      0,      0,      0,
                61600,  13255,  2310,   495,    0,      0,      0,      0,
                // Veldspar
                415,    0,      0,      0,      0,      0,      0,      0,
                436,    0,      0,      0,      0,      0,      0,      0,
                457,    0,      0,      0,      0,      0,      0,      0,

        };
        #endregion


        public static readonly string[] OutputNames = new string[]
        {
            "Tritanium",
            "Pyerite",
            "Mexallon",
            "Isogen",
            "Nocxium",
            "Zydrine",
            "Megacyte",
            "Morphite"
        };

        public static readonly int[] OutputIDs = new int[]
        {
            34,
            35,
            36,
            37,
            38,
            39,
            40,
            11399
        };

        //
        //  Methods
        //
        
        public static int[] GetConversionRates(int oreIndex, float conversionRate)
        {
            int[] conversionRates = new int[8];

            for (int i = 8 * oreIndex; i < 8 * (oreIndex + 1); i++)
                conversionRates[i % 8] = (int)System.Math.Round(OreConversion[i] * conversionRate);

            return conversionRates;
        }

        public static int GetOreIndex(int itemID)
        {
            int index;

            for (index = 0; index < OreIDs.Length; index++)
                if (OreIDs[index] == itemID)
                    return index;
            throw new System.ArgumentException();
        }

        public static int GetOutputIndex(int itemID)
        {
            int index;
            for (index = 0; index < OutputIDs.Length; index++)
                if (OutputIDs[index] == itemID)
                    return index;
            throw new System.ArgumentException();
        }
    }
}
