using ComponentFactory.Krypton.Toolkit;
using DailyCashDeposite.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            depositGrid.Columns[DepositColumn.OffSetGLAccount].Width = 150;
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
        }

        private void importedDatePicker_CloseUp(object sender, EventArgs e)
        {
            var search = importedDatePicker.Value.Date.ToString();
            if (!string.IsNullOrEmpty(search))
            {
                GridRowFilter(string.Format(DepositColumn.DateImported + " = '{0}'", search));
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
            var debitValue = debittxtbox.Text == "" ? 0 : Convert.ToDecimal(debittxtbox.Text);
            var creditValue = credittxtbox.Text == "" ? 0 : Convert.ToDecimal(credittxtbox.Text);

            transtotaltxtbox.Text = (debitValue - creditValue).ToString();
        }

        private void credittxtbox_Leave(object sender, EventArgs e)
        {
            var debitValue = debittxtbox.Text == "" ? 0 : Convert.ToDecimal(debittxtbox.Text);
            var creditValue = credittxtbox.Text == "" ? 0 : Convert.ToDecimal(credittxtbox.Text);

            transtotaltxtbox.Text = (debitValue - creditValue).ToString();
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

        private void transtotaltxtbox_TextChanged(object sender, EventArgs e)
        {
            var totalValue = transtotaltxtbox.Text == "" ? 0 : Convert.ToDecimal(transtotaltxtbox.Text);
            if(totalValue != 0)
            {
                
            }
        }

        public void AddNewRow()
        {
            DataTable dataTable = (DataTable)depositGrid.DataSource;
            DataRow row = dataTable.NewRow();
            row[DepositColumn.Journal] = journalTxtbox.Text;
            row[DepositColumn.DepositDate] = depositdatepicker.Text;
            row[DepositColumn.PeriodPostingDate] = periodpostingtxtbox.Text;
            row[DepositColumn.OffSetGLAccount] = offsetCombobox.SelectedValue;
            row[DepositColumn.Description] = descriptiontxtbox.Text;
            row[DepositColumn.Debit] = debittxtbox.Text == "" ? 0 : Convert.ToDecimal(debittxtbox.Text);
            row[DepositColumn.Credit] = credittxtbox.Text == "" ? 0 : Convert.ToDecimal(credittxtbox.Text);
            row[DepositColumn.Bun] = buntxtbox.Text == "" ? 0 : Convert.ToInt32(buntxtbox.Text);
            row[DepositColumn.TransactionTotal] = transtotaltxtbox.Text == "" ? 0 : Convert.ToDecimal(transtotaltxtbox.Text);
            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();
            depositGrid.Rows[depositGrid.Rows.Count - 1].Selected = true;
        }
    }
}
