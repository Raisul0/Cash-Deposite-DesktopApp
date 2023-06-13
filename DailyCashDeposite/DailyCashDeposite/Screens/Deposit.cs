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

namespace DailyCashDeposite.Screens
{
    public partial class Deposit : Form
    {

        public Deposit()
        {
            InitializeComponent();
            ConnectionClass.SetConnectionProperty();
            ConnectionClass.TestConnection();
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
                if (FilePath.SourcePath == "" || FilePath.ArchivePath == "")
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
                MessageBox.Show("First Setup Successfull Connection from the Setup Screen");
                Setup setup = new Setup();
                setup.ShowDialog();
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
            depositGrid.Columns[DepositColumn.Journal].Width = 45;
            depositGrid.Columns[DepositColumn.Entry].Width = 40;
            depositGrid.Columns[DepositColumn.Bun].Width = 50;
            depositGrid.Columns[DepositColumn.Status].Width = 60;
            depositGrid.Columns[DepositColumn.StatusDescription].Width = 250;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
