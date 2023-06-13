using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCashDeposite.Helper
{
    public static class ConnectionClass
    {
        public static string ServerName = "LAPTOP-QBG3R6L8\\RAILAPTOP";
        public static string DatabaseName = "MAAImportDB";
        public static string UserName = "sa";
        public static string Password = "12345678";
        public static string ConnectionString = "";
        private static SqlConnection con;
        public static bool IsConnected = false;

        public static void SetConnectionProperty(string userName="",string password = "",string serverName = "", string databaseName = "")
        {
            ServerName = serverName == "" ? ServerName:serverName;
            DatabaseName = databaseName == "" ? DatabaseName : databaseName;
            UserName = userName == "" ? UserName : userName;
            Password = password == "" ? Password : password;

            ConnectionString = "Data Source='" + ServerName + "';Initial Catalog='" + DatabaseName + "';User ID='" + UserName + "';Password='" + Password + "'";
        }

        public static bool TestConnection()
        {
            using (con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    //Check If The SQL database Returns 1 
                    var reader = DataReader("Select 1 as Number");
                    while (reader.Read())
                    {
                        int value = Convert.ToInt32(reader["Number"].ToString());
                        if (value == 1)
                        {
                            con.Close();
                            IsConnected = true;
                            return true;
                        }
                        else
                        {
                            con.Close();
                            IsConnected = false;
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    return false;
                }
            }
            return false;
        }

        public static void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public static void CloseConnection()
        {
            con.Close();
        }

        public static void ExecuteQueries(string Query_)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception message)
            {

            }
        }

        public static string ReadSingleValueWithCondition(string tableName,string condition,string columnName)
        {
            try
            {
                var selectQuery = "Select " + columnName + " from " + tableName + " where " + condition + "";
                var res = "";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                res = reader[columnName].ToString();
                            }
                        }
                    } // reader closed and disposed up here

                } // command disposed here
                return res;
            }
            catch (Exception message)
            {
                return "";
            }
        }

        public static List<string> ReadAllValueWithCondition(string tableName, string condition, string columnName)
        {
            try
            {
                var selectQuery = "Select " + columnName + " from " + tableName + " where " + condition + "";
                var list = new List<string>();
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                list.Add(reader[columnName].ToString());
                            }
                            return list;
                        }
                    } // reader closed and disposed up here

                } // command disposed here
                return new List<string>();
            }
            catch (Exception message)
            {
                return new List<string>();
            }
        }

        public static SqlDataReader DataReader(string Query_)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception message)
            {
                return null;
            }
        }

        public static object ShowDataInGridView(string tableName)
        {
            try
            {
                var selectString = "Select * from " + tableName;
                SqlDataAdapter dr = new SqlDataAdapter(selectString, ConnectionString);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                object dataum = ds.Tables[0];
                return dataum;
            }
            catch (Exception message)
            {
                return null;
            }

        }

        public static int UpdateGrid(string tableName,DataTable table)
        {
            try
            {
                var selectStatement = "Select * from " + tableName;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(selectStatement, con);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);
                adapter.Fill(table);


                adapter.UpdateCommand = cb.GetUpdateCommand();
                adapter.DeleteCommand = cb.GetDeleteCommand();
                adapter.InsertCommand = cb.GetInsertCommand();

                return adapter.Update(table);
            }
            catch (Exception message)
            {
                return 0;
            }

        }

        public static void InsertData(string columnNames,string cellValues,string tableName)
        {
            try
            {
                var insertStatement = "Insert into " + tableName + " (" + columnNames + ")" + " values (" + cellValues + ")";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(insertStatement, con);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception message)
            {

            }
        }

    }
}
