using DailyCashDeposite.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Screens
{
    public partial class CompanySetting : Form
    {
        public CompanySetting()
        {
            InitializeComponent();
        }

        private void CompanySetting_Load(object sender, EventArgs e)
        {
            ConnectionClass.SetConnectionProperty();
            ConnectionClass.TestConnection();
            if (ConnectionClass.IsConnected)
            {
                ConnectionClass.OpenConection();
                companySettingGrid.DataSource = ConnectionClass.ShowDataInGridView(TableName.CompanySetting);
                ConfigureGrid();
            }
            else
            {
                MessageBox.Show("First Setup Successfull Connection from the Setup Screen");
                Setup setup = new Setup();
                setup.ShowDialog();
                this.Close();
            }

        }

        private void updateGridButton_Click(object sender, EventArgs e)
        {
            ConnectionClass.UpdateGrid(TableName.CompanySetting, companySettingGrid.DataSource as DataTable);
            this.CompanySetting_Load(sender, e);
        }

        private void deleteGrid_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.companySettingGrid.SelectedRows)
            {
                companySettingGrid.Rows.RemoveAt(item.Index);
            }
            this.updateGridButton_Click(sender, e);
        }

        public void ConfigureGrid()
        {
            //Set Column Width
            companySettingGrid.Columns[CompanySettingColumn.CompanyNumber].Width = 150;
            companySettingGrid.Columns[CompanySettingColumn.OffsetGlAccount].Width = 500;

            //Set Column Header Name
            companySettingGrid.Columns[CompanySettingColumn.CompanyNumber].HeaderText = "Company Number";
            companySettingGrid.Columns[CompanySettingColumn.OffsetGlAccount].HeaderText = "Offset GL Account";
            companySettingGrid.Columns[CompanySettingColumn.ContactName].HeaderText = "Contact Name";
            companySettingGrid.Columns[CompanySettingColumn.ContactEmail].HeaderText = "Contact Email";


            //Limit The Character Length
            ((DataGridViewTextBoxColumn)companySettingGrid.Columns[CompanySettingColumn.OffsetGlAccount]).MaxInputLength = 20;
        }

        private void companySettingGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(companyNumberKeyPress);
            if (companySettingGrid.CurrentCell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.CompanyNumber].Index) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(companyNumberKeyPress);
                }
            }
        }

        private void companyNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void companySettingGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                
            }
        }

        private void companySettingGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var cell = companySettingGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (companySettingGrid.IsCurrentCellInEditMode)
            {
                var validated = ValidateCell(cell);
            }
                
        }

        private bool ValidateCell(DataGridViewCell cell)
        {
            var cellValue = cell.EditedFormattedValue.ToString();

            if(cell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.CompanyNumber].Index)
            {
                if (cellValue == "" || cellValue.Length==0)
                {
                    MessageBox.Show("Company Number Is Required");
                    return false;
                }
            }
            else if (cell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.OffsetGlAccount].Index)
            {

            }
            else if (cell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.ContactName].Index)
            {

            }
            else if (cell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.ContactEmail].Index)
            {

            }
            return true;
        }

        private void companySettingGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == companySettingGrid.ColumnCount-1)
            {  
                var row = companySettingGrid.Rows[e.RowIndex];
                if (row != null)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if (!ValidateCell(cell))
                        {
                            MessageBox.Show("Not a Valid Row");
                        }
                    }
                }
            }
        }
    }

    
}
