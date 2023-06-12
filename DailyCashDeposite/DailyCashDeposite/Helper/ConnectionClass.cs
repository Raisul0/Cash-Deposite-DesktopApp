﻿using System;
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
        static string ServerName = "";
        static string DatabaseName = "";
        static string UserName = "";
        static string Password = "";
        static string ConnectionString = "";
        static SqlConnection con;
        public static bool IsConnected = false;

        public static void SetConnectionProperty(string userName="sa",string password = "12345678",string serverName = "LAPTOP-QBG3R6L8\\RAILAPTOP",string databaseName = "MAAImportDB")
        {
            ConnectionString = "Data Source='" + serverName + "';Initial Catalog='" + databaseName + "';User ID='" + userName + "';Password='" + password + "'";
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
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public static SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static object ShowDataInGridView(string tableName)
        {
            var selectString = "Select * from " + tableName;
            SqlDataAdapter dr = new SqlDataAdapter(selectString, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public static int UpdateGrid(string tableName,DataTable table)
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

        
    }
}