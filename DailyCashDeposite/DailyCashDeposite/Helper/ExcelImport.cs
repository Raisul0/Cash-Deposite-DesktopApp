using DailyCashDeposite.Screens;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Helper
{
    public static class ExcelImport
    {

        public static bool ImportExcelFiles(string srcDir, string destDir)
        {

            try
            {
                if (Directory.Exists(srcDir) && Directory.Exists(destDir))
                {
                    DirectoryInfo dir = new DirectoryInfo(srcDir);
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        if (file.Extension == ".csv" || file.Extension == ".xlsx")
                        {
                            string destFile = Path.Combine(destDir, file.Name);
                            if (!File.Exists(destFile))
                            {
                                InsertDataTableToDatabase(GenerateDataTable(file.FullName));
                                file.MoveTo(destFile);
                            }
                        }

                    }
                    MessageBox.Show("File Moved Successfully");
                    return true;
                }
                return false;
            }
            catch (Exception message)
            {
                MessageBox.Show("Something Went Wrong");
                return false;
            }

            
        }

        public static DataTable GenerateDataTable(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                        {
                            result.Columns.Add( ColumnNames.GetMatchingColumnName(typeof(DepositColumn),fields[i]));
                        }
                        else
                        {
                            result.Columns.Add("Col" + i);
                        }

                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();
                    fields = fields.Take(fields.Length - 1).ToArray();
                    result.Rows.Add(fields);
                }
            }

            return result;
        }

        public static void InsertDataTableToDatabase(DataTable table)
        {
            //var columnNames = "";
            //foreach(var column in table.Columns)
            //{
            //    columnNames += ColumnNames.GetColumnName(typeof(DepositColumn),column.ToString()) + ",";
            //}
            //columnNames += DepositColumn.TransactionTotal + "," + DepositColumn.Status + "," + DepositColumn.StatusDescription + "," + DepositColumn.DateImported + "," + DepositColumn.TimeImported + "," + DepositColumn.WindowsUser + ",";
            var cellValues = "";
            var entryNo = "";
            for(var rowCount =0;rowCount< table.Rows.Count;)
            {
                entryNo = table.Rows[rowCount]["Entry"].ToString();
                var rows = table.Select("Entry = '" + entryNo +"'");
                InsertDepositRows(rows);
                rowCount += rows.Count();
            }

            //foreach(DataRow row in table.Rows)
            //{
            //    var cellValues = "";
            //    for (var i = 0; i < row.ItemArray.Length; i++)
            //    {
            //        cellValues += "'" + row.ItemArray["ewv"].ToString()+"',";
            //    }
            //    cellValues.TrimEnd(',');



            //}
        }

        public static void InsertDepositRows(DataRow[] rows)
        {
            var status = "Pass";
            var statusDescription = "";

            var isActive = true;
            decimal transactionTotal = 0;
            var glPresent = false;
            foreach (DataRow row in rows)
            {
                var bun = row[DepositColumn.Bun].ToString();
                var bunRes = ConnectionClass.ReadSingleValueWithCondition(TableName.CompanySetting, CompanySettingColumn.CompanyNumber + " ='" + bun + "'", CompanySettingColumn.CompanyNumber);
                if (bun != bunRes)
                {
                    isActive=false;
                }

                var glAccount = row[DepositColumn.OffSetGLAccount].ToString();
                var glRes = ConnectionClass.ReadSingleValueWithCondition(TableName.CompanySetting, CompanySettingColumn.OffsetGlAccount + " ='" + glAccount + "'", CompanySettingColumn.OffsetGlAccount);
                if (glAccount == glRes)
                {
                    glPresent = true;
                }

                var debit = row[DepositColumn.Debit].ToString() == "" ? 0 : Convert.ToDecimal(row[DepositColumn.Debit].ToString());
                var credit = row[DepositColumn.Credit].ToString() == "" ? 0 : Convert.ToDecimal(row[DepositColumn.Credit].ToString());

                transactionTotal += debit;
                transactionTotal -= credit;
            }

            if (!isActive)
            {
                status = "Fail";
                statusDescription += "Inactive Company,";
            }

            if (transactionTotal != 0)
            {
                status = "Fail";
                statusDescription += "Error in Transaction Total,";
            }

            if (!glPresent)
            {
                status = "Fail";
                statusDescription += "Invalid Offset Account";
            }
            statusDescription.TrimEnd(',');

            if (ConnectionClass.IsConnected)
            {
                ConnectionClass.OpenConection();
                for (var i = 0; i < rows.Length; i++)
                {
                    var cellValues = "";
                    cellValues += "'" + rows[i][DepositColumn.Journal].ToString() + "',";
                    cellValues += "'" + rows[i][DepositColumn.Entry].ToString() + "',";
                    cellValues += "'" + rows[i][DepositColumn.DepositDate].ToString() + "',";
                    cellValues += "'" + rows[i][DepositColumn.PeriodPostingDate].ToString() + "',";
                    cellValues += "'" + rows[i][DepositColumn.OffSetGLAccount].ToString() + "',";
                    cellValues += "'" + rows[i][DepositColumn.Description].ToString() + "',";

                    var debit = rows[i][DepositColumn.Debit].ToString() == "" ? 0 : Convert.ToDecimal(rows[i][DepositColumn.Debit].ToString());
                    cellValues += "'" + debit + "',";

                    var credit = rows[i][DepositColumn.Credit].ToString() == "" ? 0 : Convert.ToDecimal(rows[i][DepositColumn.Credit].ToString());
                    cellValues += "'" + credit + "',";

                    cellValues += "'" + rows[i][DepositColumn.Bun].ToString() + "',";
                    cellValues += "'" + transactionTotal.ToString() + "',";
                    cellValues += "'" + status + "',";
                    cellValues += "'" + statusDescription + "',";
                    cellValues += "'" + DateTime.Now.Date.ToString() + "',";
                    cellValues += "'" + DateTime.Now.TimeOfDay.ToString() + "',";
                    cellValues += "'" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "'";

                    ConnectionClass.InsertData(ColumnNames.GetAllColumnsTogether(typeof(DepositColumn)), cellValues, TableName.Deposit);
                }

            }
            else
            {
                MessageBoxHelper.SetupConnenctionMessage();
                if (ConnectionClass.IsConnected)
                {
                    InsertDepositRows(rows);
                }
                
            }

            
        }
    }
}
