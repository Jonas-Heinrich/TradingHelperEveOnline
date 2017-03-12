using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using TradingHelperEveOnline.Database.SaveClasses;

namespace TradingHelperEveOnline.Database
{
    static class DataBaseManager
    {
        readonly private static string DataBaseName = "MarketData.db";
        private static SQLiteConnection dbConnection;

        readonly private static string TABLENAME_MARKET = "Market";
        readonly private static string TABLENAME_ITEMIDS = "ItemIDs";
        readonly private static string FILENAME_TRADABLEITEMS = "TradableItems.txt";


        //
        //  Initialize
        //

        public static void InitializeDataBase()
        {
            SQLiteConnection.CreateFile(DataBaseName);
            Start();

            ResetMarketTable();
        }

        public static void Start()
        {
            dbConnection = new SQLiteConnection("Data Source=" + DataBaseName + ";Version=3;");
            dbConnection.Open();
        }

        public static void End()
        {
            dbConnection.Close();
            GC.Collect();
        }

        //
        //  Low level interactions with db
        //

        private static void ExecuteCommand(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        private static string CreateTable(string tableName, string[] columnNames, string[] columnTypes, string[] columnAttributes)
        {
            string sql = "DROP TABLE IF EXISTS " + tableName;
            ExecuteCommand(sql);

            sql = "CREATE TABLE " + tableName + " (";

            for(int i = 0; i < columnNames.Length; i++)
            {
                sql += columnNames[i] + " " + columnTypes[i] + " " + columnAttributes[i];

                if (i < columnNames.Length - 1)
                    sql += ", ";
            }
            sql += ");";

            return sql;
        }
        
        private static SQLiteCommand Insert(string tableName, string[] columns, string[] values)
        {
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tableName + " (";
            
            
            for (int i = 0; i < columns.Length; i++)
            {
                cmd.CommandText += columns[i];

                if (i < columns.Length - 1)
                    cmd.CommandText += ", ";
            }
            cmd.CommandText += ") values (";
            
            for (int i = 0; i < values.Length; i++)
            {
                cmd.CommandText += "@p" + i.ToString();

                if (i < values.Length - 1)
                    cmd.CommandText += ", ";

                cmd.Parameters.Add(new SQLiteParameter("@p" + i.ToString(), values[i]));
            }

            cmd.CommandText += ");";
            return cmd;
        }

        //
        //  Saving MarketItem
        //

        public static void ResetMarketTable()
        {
            string sql = CreateTable
               (
                   TABLENAME_MARKET,
                   new string[] { "ID", "ItemID", "Region", "System", "Station", "Security", "Price", "Quantity", "EntryType" },
                   new string[] { "INTEGER", "INTEGER", "VARCHAR(25)", "VARCHAR(25)", "VARCHAR(100)", "REAL", "REAL", "INTEGER", "BOOLEAN" },
                   new string[] { "PRIMARY KEY AUTOINCREMENT", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL", "NOT NULL" }
               );
            ExecuteCommand(sql);
        }

        public static void SaveIDs(int[] indices)
        {
            string sql = CreateTable
            (
                TABLENAME_ITEMIDS,
                new string[] { "ID", "ItemID", "Saved"},
                new string[] { "INTEGER", "INTEGER", "BOOLEAN" },
                new string[] { "PRIMARY KEY AUTOINCREMENT", "NOT NULL", "NOT NULL"}
            );
            ExecuteCommand(sql);

            using (var transaction = dbConnection.BeginTransaction())
            {
                for (int i = 0; i < indices.Length; i++)
                {
                    SQLiteCommand cmd = Insert
                    (
                        TABLENAME_ITEMIDS,
                        new string[] { "ItemID", "Saved"},
                        new string[]
                        {
                            Convert.ToString(indices[i]),
                            "0"
                        });

                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
        }

        public static void MarkDone(int id)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                ExecuteCommand("UPDATE " + TABLENAME_ITEMIDS + " SET SAVED=1 WHERE ItemID=" + Convert.ToString(id));
                transaction.Commit();
            }
        }

        public static void UpdateTradableIDs()
        {
            string ids = "";
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;
            cmd.CommandText = "SELECT * FROM " + TABLENAME_MARKET + " ORDER BY ITEMID";
            SQLiteDataReader rd = cmd.ExecuteReader();

            string prev = "";

            int count = 0;
            while (rd.Read())
            {
                if(prev != rd["ItemID"].ToString())
                {
                    ids += rd["ItemID"].ToString() + " ";
                    prev = rd["ItemID"].ToString();
                }
                count++;
            }

            rd.Close();
            
            StreamWriter sw = new StreamWriter(FILENAME_TRADABLEITEMS);
            sw.WriteLine(ids);
            sw.Close();
        }

        public static void SaveMarketItem(MarketItem item)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                for (int i = 0; i < item.Entries.Length; i++)
                {
                    SQLiteCommand cmd = Insert
                    (
                        TABLENAME_MARKET,
                        new string[] { "ItemID", "Region", "System", "Station", "Security", "Price", "Quantity", "EntryType" },
                        new string[]
                        {
                            Convert.ToString(item.ID),
                            item.Entries[i].Region,
                            item.Entries[i].System,
                            item.Entries[i].Station,
                            Convert.ToString(item.Entries[i].Security),
                            Convert.ToString(item.Entries[i].Price),
                            Convert.ToString(item.Entries[i].Quantity),
                            Convert.ToString((int)item.Entries[i].EntryType)
                        });

                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }
                
                transaction.Commit();
            }
        }

        //
        //  Getter
        //

        public static int[] GetTradableIDs()
        {
            StreamReader sr = new StreamReader(FILENAME_TRADABLEITEMS);
            string s = sr.ReadToEnd().Trim();
            string[] ids = s.Split(' ');

            int[] res = new int[ids.Length];
            for (int i = 0; i < ids.Length; i++)
                res[i] = Convert.ToInt32(ids[i]);

            return res;
        }

        public static MarketItemEntry[] GetMarketItemEntries(int id)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = dbConnection;
            cmd.CommandText = "SELECT * FROM " + TABLENAME_MARKET + " WHERE ITEMID=" + id.ToString();
            SQLiteDataReader rd = cmd.ExecuteReader();

            List<MarketItemEntry> result = new List<MarketItemEntry>();

            while (rd.Read())
            {
                result.Add
                (
                    new MarketItemEntry
                    (
                        (string)rd["Region"],
                        (string)rd["System"],
                        (string)rd["Station"],
                        (float)rd["Security"],
                        (float)rd["Price"],
                        (int)rd["Quantity"],
                        (MarketItemEntryType)(int)rd["EntryType"]
                    )
                );
            }

            rd.Close();
            return result.ToArray();
        }
    }
}
