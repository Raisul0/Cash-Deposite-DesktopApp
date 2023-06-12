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
            //ConnectionClass.SetConnectionProperty();
            //ConnectionClass.TestConnection();
        }

        private void CompanySetting_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void updateGridButton_Click(object sender, EventArgs e)
        {
            UpdateRowGrid();
        }
        private void deleteGridButton_Click(object sender, EventArgs e)
        {
            DeleteRowGrid();
        }

        private void LoadGrid()
        {
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

        private void UpdateRowGrid()
        {
            var updated = ConnectionClass.UpdateGrid(TableName.CompanySetting, companySettingGrid.DataSource as DataTable);
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

        private void DeleteRowGrid()
        {
            foreach (DataGridViewRow item in this.companySettingGrid.SelectedRows)
            {
                companySettingGrid.Rows.RemoveAt(item.Index);
            }
            var deleted = ConnectionClass.UpdateGrid(TableName.CompanySetting, companySettingGrid.DataSource as DataTable);
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

        private void InsertRowGrid(DataGridViewRow row)
        {
            var columNames = "";
            for(var i = 0; i < companySettingGrid.ColumnCount; i++)
            {
                columNames += companySettingGrid.Columns[i].Name + ",";
            }
            columNames = columNames.TrimEnd(',');

            var cellValues = "";
            for (var i = 0; i < row.Cells.Count; i++)
            {
                cellValues += "'" + row.Cells[i].EditedFormattedValue.ToString() + "',";
            }
            cellValues = cellValues.TrimEnd(',');

            ConnectionClass.InsertData(columNames,cellValues,TableName.CompanySetting);
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
            if (companySettingGrid.CurrentCell.ColumnIndex == companySettingGrid.Columns[CompanySettingColumn.CompanyNumber].Index) //Allow Number Inputs only On Company Number
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
            //if(e.KeyChar == (char)Keys.Enter)
            //{
                
            //}
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

        private void companySettingGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //var row = companySettingGrid.CurrentRow;
            //if (row != null)
            //{
            //    var isValid = true;
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (!ValidateCell(cell))
            //        {
            //            isValid = false;
            //        }
            //    }

            //    if (isValid)
            //    {
            //        InsertRowGrid(row);
            //    }
            //}
        }
    }

    
}
