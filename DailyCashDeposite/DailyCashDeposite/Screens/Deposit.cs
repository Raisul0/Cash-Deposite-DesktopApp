using ComponentFactory.Krypton.Toolkit;
using DailyCashDeposite.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DailyCashDeposite.Screens
{
    public partial class Deposit : Form
    {

        public Deposit()
        {
            InitializeComponent();
            importedDatePicker.Value = DateTime.Now;
            bodyContainer.Panel1Collapsed =true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CompanySetting companySetting = new CompanySetting();
            companySetting.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (FilePath.SourcePath != FilePath.NoPath && FilePath.ArchivePath != FilePath.NoPath)
            {
                var IsSuccess = ExcelImport.ImportExcelFiles(FilePath.SourcePath, FilePath.ArchivePath);
                if (IsSuccess)
                {
                    LoadGrid();
                }
            }
            else
            {
                MessageBox.Show("Select Source & Archive Path First");
                Setup setup = new Setup();
                setup.ShowDialog();
                if (FilePath.SourcePath == FilePath.NoPath || FilePath.ArchivePath == FilePath.NoPath)
                {
                    MessageBox.Show("Can't Import Files, Source/Archive Path Not Provided");
                }
                else
                {
                    importButton_Click(sender, e);
                }
            }
        }

        private void LoadGrid()
        {
            if (ConnectionClass.IsConnected)
            {
                ConnectionClass.OpenConection();
                depositGrid.DataSource = ConnectionClass.ShowDataInGridView(TableName.Deposit);
                ConfigureGrid();
            }
            else
            {
                MessageBoxHelper.SetupConnenctionMessage();
                if (ConnectionClass.IsConnected)
                {
                    LoadGrid();
                }
                depositGrid.DataSource = null;
            }
        }

        public void ConfigureGrid()
        {
            //Hide Columns
            depositGrid.Columns["Id"].Visible = false;

            //Set Column Width
            depositGrid.Columns[DepositColumn.Journal].Width = 60;
            depositGrid.Columns[DepositColumn.Entry].Width = 40;
            depositGrid.Columns[DepositColumn.Bun].Width = 50;
            depositGrid.Columns[DepositColumn.Status].Width = 60;
            depositGrid.Columns[DepositColumn.Debit].Width = 100;
            depositGrid.Columns[DepositColumn.Credit].Width = 100;
            depositGrid.Columns[DepositColumn.OffSetGLAccount].Width = 150;
            depositGrid.Columns[DepositColumn.PeriodPostingDate].Width = 150;
            depositGrid.Columns[DepositColumn.StatusDescription].Width = 250;

            //Set Column Header Name
            depositGrid.Columns[DepositColumn.DepositDate].HeaderText = "Deposit Date";
            depositGrid.Columns[DepositColumn.PeriodPostingDate].HeaderText = "Period Posting Date";
            depositGrid.Columns[DepositColumn.OffSetGLAccount].HeaderText = "OffSet GL Account";
            depositGrid.Columns[DepositColumn.TransactionTotal].HeaderText = "Transaction Total";
            depositGrid.Columns[DepositColumn.StatusDescription].HeaderText = "Status Description";
            depositGrid.Columns[DepositColumn.DateImported].HeaderText = "Date Imported";
            depositGrid.Columns[DepositColumn.TimeImported].HeaderText = "Time Imported";
            depositGrid.Columns[DepositColumn.WindowsUser].HeaderText = "Windows User";

            //Set Sorting For Columns
            depositGrid.Columns[DepositColumn.Journal].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.Entry].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.DepositDate].SortMode = DataGridViewColumnSortMode.Automatic; // Allow
            depositGrid.Columns[DepositColumn.PeriodPostingDate].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.OffSetGLAccount].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.Description].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.Bun].SortMode = DataGridViewColumnSortMode.Automatic; // Allow
            depositGrid.Columns[DepositColumn.TransactionTotal].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.Status].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.StatusDescription].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.DateImported].SortMode = DataGridViewColumnSortMode.Automatic; // Allow
            depositGrid.Columns[DepositColumn.TimeImported].SortMode = DataGridViewColumnSortMode.NotSortable;
            depositGrid.Columns[DepositColumn.WindowsUser].SortMode = DataGridViewColumnSortMode.NotSortable;

            //Set Columns to Readonly
            depositGrid.Columns[DepositColumn.Journal].ReadOnly = true;
            depositGrid.Columns[DepositColumn.Entry].ReadOnly = true;
            depositGrid.Columns[DepositColumn.DepositDate].ReadOnly = true;
            depositGrid.Columns[DepositColumn.PeriodPostingDate].ReadOnly = true;
            depositGrid.Columns[DepositColumn.OffSetGLAccount].ReadOnly = true;
            depositGrid.Columns[DepositColumn.Description].ReadOnly = true;
            depositGrid.Columns[DepositColumn.Bun].ReadOnly = true;
            depositGrid.Columns[DepositColumn.TransactionTotal].ReadOnly = true;
            depositGrid.Columns[DepositColumn.Status].ReadOnly = true;
            depositGrid.Columns[DepositColumn.StatusDescription].ReadOnly = true;
            depositGrid.Columns[DepositColumn.DateImported].ReadOnly = true;
            depositGrid.Columns[DepositColumn.TimeImported].ReadOnly = true;
            depositGrid.Columns[DepositColumn.WindowsUser].ReadOnly = true;

            foreach(DataGridViewColumn column in depositGrid.Columns)
            {
                if (column.ReadOnly)
                {
                    column.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void companyCodeTextbox_TextChanged(object sender, EventArgs e)
        {
            var search = companyCodeTextbox.Text;
            if (!string.IsNullOrEmpty(search))
            {
                GridRowFilter(string.Format(DepositColumn.Bun + " = '{0}'", search));
            }
            else
            {
                GridRowFilter("");
            }
            
        }

        private void GridRowFilter(string rowFilter)
        {
            (depositGrid.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void refreshGridButton_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void transactionDatePicker_CloseUp(object sender, EventArgs e)
        {
            var search = transactionDatePicker.Value.Date.ToString();
            if (!string.IsNullOrEmpty(search))
            {
                GridRowFilter(string.Format(DepositColumn.DepositDate + " = '{0}'", search));
            }
            else
            {
                GridRowFilter("");
            }
        }

        private void importedDatePicker_CloseUp(object sender, EventArgs e)
        {
            var search = importedDatePicker.Value.Date.ToString();
            if (!string.IsNullOrEmpty(search))
            {
                GridRowFilter(string.Format(DepositColumn.DateImported + " = '{0}'", search));
            }
            else
            {
                GridRowFilter("");
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(bodyContainer.Panel1Collapsed)
            {
                bodyContainer.Panel1Collapsed = false;
            }
        }

        private void closePanal1Button_Click(object sender, EventArgs e)
        {
            if (!bodyContainer.Panel1Collapsed)
            {
                bodyContainer.Panel1Collapsed = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        private void buntxtbox_Leave(object sender, EventArgs e)
        {
            var bunValue = buntxtbox.Text?.Trim() ?? "";
            if(ConnectionClass.IsConnected)
            {
                ConnectionClass.OpenConection();
                var list = ConnectionClass.ReadAllValueWithCondition(TableName.CompanySetting, CompanySettingColumn.CompanyNumber + " ='" + bunValue + "'", CompanySettingColumn.OffsetGlAccount);


                if(list.Count > 0)
                {
                    list.ForEach(x => {
                        offsetCombobox.Items.Add(x);
                    });
                    if (offsetCombobox.Items.Count > 0)
                    {
                        offsetCombobox.SelectedItem = list[0];
                    }
                }
                
            }
            else
            {
                MessageBoxHelper.SetupConnenctionMessage();
            }
        }

        private void debittxtbox_Leave(object sender, EventArgs e)
        {
            transtotaltxtbox.Text = calculateTransactionTotal().ToString();
        }

        private void credittxtbox_Leave(object sender, EventArgs e)
        {
            transtotaltxtbox.Text = calculateTransactionTotal().ToString();
        }

        private decimal calculateTransactionTotal()
        {
            var debitValue = debittxtbox.Text == "" ? 0 : Convert.ToDecimal(debittxtbox.Text);
            var creditValue = credittxtbox.Text == "" ? 0 : Convert.ToDecimal(credittxtbox.Text);

            return (debitValue - creditValue);
        }

        private void buntxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void debittxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimal(debittxtbox.Text, e);
        }

        private void credittxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimal(credittxtbox.Text, e);
        }

        private void AllowDecimal(string txt, KeyPressEventArgs e) 
        {
            if (!char.IsControl(e.KeyChar))
            {
                txt += e.KeyChar.ToString();
                if (!decimal.TryParse(txt, out decimal myresult) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
            
        }

        public void AddNewRow()
        {
            
            DataTable dataTable = (DataTable)depositGrid.DataSource;
            DataRow row1 = dataTable.NewRow();
            var EntryNo = 1;
            if(entryTxtbox.Text.Length > 0)
            {
                EntryNo = Convert.ToInt32(entryTxtbox.Text);
            }
            else
            {
                if (dataTable.Rows.Count > 0)
                {
                    EntryNo = Convert.ToInt32(dataTable.Rows[dataTable.Rows.Count - 1][DepositColumn.Entry]) + 1;
                }
            }
            
             

            row1[DepositColumn.Journal] = journalTxtbox.Text;
            row1[DepositColumn.Entry] = EntryNo;
            row1[DepositColumn.DepositDate] = depositdatepicker.Text;
            row1[DepositColumn.PeriodPostingDate] = periodpostingtxtbox.Text;
            row1[DepositColumn.OffSetGLAccount] = offsetCombobox.Text;
            row1[DepositColumn.Description] = descriptiontxtbox.Text;
            row1[DepositColumn.Debit] = debittxtbox.Text == "" ? 0 : Convert.ToDecimal(debittxtbox.Text);
            row1[DepositColumn.Credit] = 0;
            row1[DepositColumn.Bun] = buntxtbox.Text == "" ? 0 : Convert.ToInt32(buntxtbox.Text);

            DataRow row2 = dataTable.NewRow();

            row2[DepositColumn.Journal] = journalTxtbox.Text;
            row2[DepositColumn.Entry] = EntryNo;
            row2[DepositColumn.DepositDate] = depositdatepicker.Text;
            row2[DepositColumn.PeriodPostingDate] = periodpostingtxtbox.Text;
            row2[DepositColumn.OffSetGLAccount] = offsetCombobox.Text;
            row2[DepositColumn.Description] = descriptiontxtbox.Text;
            row2[DepositColumn.Debit] = 0;
            row2[DepositColumn.Credit] = credittxtbox.Text == "" ? 0 : Convert.ToDecimal(credittxtbox.Text);
            row2[DepositColumn.Bun] = buntxtbox.Text == "" ? 0 : Convert.ToInt32(buntxtbox.Text);


            if(ExcelImport.InsertDepositRows(new DataRow[]{ row1,row2 }) > 0)
            {
                MessageBox.Show("Records Inserted");
                LoadGrid();
                depositGrid.CurrentCell = depositGrid.Rows[depositGrid.Rows.Count - 1].Cells[DepositColumn.Journal];
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                LoadGrid();
            }

            
        }

        private void deleteGrid_Click(object sender, EventArgs e)
        {
            DeleteRowGrid();
        }

        private void DeleteRowGrid()
        {
            foreach (DataGridViewRow item in this.depositGrid.SelectedRows)
            {
                depositGrid.Rows.RemoveAt(item.Index);
            }
            var deleted = ConnectionClass.UpdateGrid(TableName.Deposit, depositGrid.DataSource as DataTable);
            if (deleted > 0)
            {
                MessageBox.Show("Deleted Successfully");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                LoadGrid();
            }
        }

        private void updateGridButton_Click(object sender, EventArgs e)
        {
            UpdateRowGrid();
        }

        private void UpdateRowGrid()
        {
            var updated = ConnectionClass.UpdateGrid(TableName.Deposit, depositGrid.DataSource as DataTable);
            if (updated > 0)
            {
                MessageBox.Show("Grid Updated Successfully");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
                LoadGrid();
            }

        }

        private void depositGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var errorText = "Error in Transaction Total,";
            if (e.ColumnIndex == depositGrid.Columns[DepositColumn.Debit].Index)
            {
                var debit = Convert.ToDecimal( depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Debit].Value);
                var credit = Convert.ToDecimal(depositGrid.Rows[e.RowIndex+1].Cells[DepositColumn.Credit].Value);

                depositGrid.Rows[e.RowIndex].Cells[DepositColumn.TransactionTotal].Value = debit - credit;
                depositGrid.Rows[e.RowIndex+1].Cells[DepositColumn.TransactionTotal].Value = debit - credit;


                if(debit-credit == 0)
                {
                    var oldDescription = depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString();
                    var newDescription = oldDescription.Replace(errorText, "");
                    newDescription = oldDescription.Replace(errorText.TrimEnd(','), "");

                    newDescription = newDescription.TrimEnd(',');

                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value = newDescription;
                    depositGrid.Rows[e.RowIndex + 1].Cells[DepositColumn.StatusDescription].Value = newDescription;

                    if (string.IsNullOrEmpty(newDescription))
                    {
                        depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Status].Value = "Pass";
                        depositGrid.Rows[e.RowIndex + 1].Cells[DepositColumn.Status].Value = "Pass";
                    }
                }
                else if(!depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString().Contains(errorText.TrimEnd(',')))
                {
                    var oldDescription = depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString();
                    if (oldDescription.Contains("Inactive Company,"))
                    {
                        oldDescription = oldDescription.Replace("Inactive Company,", "Inactive Company," + errorText);
                    }
                    else
                    {
                        oldDescription = errorText + oldDescription;
                    }
                    var newDescription = oldDescription.TrimEnd(',');

                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value = newDescription;
                    depositGrid.Rows[e.RowIndex + 1].Cells[DepositColumn.StatusDescription].Value = newDescription;

                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Status].Value = "Fail";
                    depositGrid.Rows[e.RowIndex + 1].Cells[DepositColumn.Status].Value = "Fail";
                }
            }
            else if ( e.ColumnIndex == depositGrid.Columns[DepositColumn.Credit].Index)
            {
                var debit = Convert.ToDecimal(depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.Debit].Value);
                var credit = Convert.ToDecimal(depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Credit].Value);

                depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.TransactionTotal].Value = debit - credit;
                depositGrid.Rows[e.RowIndex].Cells[DepositColumn.TransactionTotal].Value = debit - credit;

                if (debit - credit == 0)
                {
                    var oldDescription = depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString();
                    var newDescription = oldDescription.Replace(errorText, "");
                    newDescription = oldDescription.Replace(errorText.TrimEnd(','), "");

                    newDescription = newDescription.TrimEnd(',');

                    depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.StatusDescription].Value = newDescription;
                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value = newDescription;

                    if (string.IsNullOrEmpty(newDescription))
                    {
                        depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.Status].Value = "Pass";
                        depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Status].Value = "Pass";
                    }

                }
                else if (!depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString().Contains(errorText.TrimEnd(',')))
                {
                    var oldDescription = depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value.ToString();
                    if (oldDescription.Contains("Inactive Company,"))
                    {
                        oldDescription = oldDescription.Replace("Inactive Company,", "Inactive Company," + errorText);
                    }
                    else
                    {
                        oldDescription = errorText + oldDescription;
                    }
                    var newDescription = oldDescription.TrimEnd(',');

                    depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.StatusDescription].Value = newDescription;
                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.StatusDescription].Value = newDescription;

                    depositGrid.Rows[e.RowIndex-1].Cells[DepositColumn.Status].Value = "Fail";
                    depositGrid.Rows[e.RowIndex].Cells[DepositColumn.Status].Value = "Fail";
                }
            }
        }

        private void entryTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            journalTxtbox.Text = "99";
            depositdatepicker.Value = DateTime.Now;
            entryTxtbox.Clear();
            periodpostingtxtbox.Clear();
            descriptiontxtbox.Text = "Bank Deposit";
            buntxtbox.Clear();
            offsetCombobox.Text = string.Empty;
            debittxtbox.Text = "0.00"; ;
            credittxtbox.Text = "0.00";
            transtotaltxtbox.Text = "0.00";

        }
    }
}
