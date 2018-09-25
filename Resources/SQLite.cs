using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace SQLWrapper
{
    public class SQLite
    {
        #region variables
        //
        private enum QueryType { NonQuery, Scalar, Reader, Adapter };
        //
        #endregion variables

        #region constructor
        //
        public SQLite() { }
        //
        #endregion constructor

        #region method

        public static int ExecuteNonQuery(string QueryString, string ConnString)
        {
            return Query(QueryString, ConnString, QueryType.NonQuery);
        }

        public static object ExecuteScalar(string QueryString, string ConnString)
        {
            return Query(QueryString, ConnString, QueryType.Scalar);
        }

        public static object Reader(string QueryString, string ConnString)
        {
            return Query(QueryString, ConnString, QueryType.Reader);
        }

        public static DataSet Adapter(string QueryString, string ConnString)
        {
            return Query(QueryString, ConnString, QueryType.Adapter);
        }

        private static dynamic Query(string QueryString, string ConnString, QueryType Type)
        {
            dynamic hsl = null;
            using (var conn = new SQLiteConnection(ConnString))
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = QueryString;
                    conn.Open();
                    switch (Type)
                    {
                        case QueryType.NonQuery:
                            hsl = cmd.ExecuteNonQuery(); break;
                        case QueryType.Scalar:
                            hsl = cmd.ExecuteScalar(); break;
                        case QueryType.Reader:
                            hsl = hsl = cmd.ExecuteReader(); break;
                        case QueryType.Adapter:
                            using (var adapter = new SQLiteDataAdapter(cmd))
                            {
                                hsl = new DataSet();
                                adapter.Fill(hsl);
                            } break;
                    }
                    conn.Close();
                }
            }
            return hsl;
        }

        public static string[] TableList(string ConnString)
        {
            string[] hsl = new string[0];
            string QueryString = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1;";
            DataSet ds = Adapter(QueryString, ConnString);
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                for (int j = 0; j < ds.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < ds.Tables[i].Columns.Count; k++)
                    {
                        Array.Resize(ref hsl, hsl.Length + 1);
                        hsl[hsl.GetUpperBound(0)] = ds.Tables[i].Rows[j].ItemArray[k].ToString();
                    }
                }
            }
            return hsl;
        }
        
        #endregion method
    }
}
