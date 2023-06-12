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
    public partial class Import : Form
    {

        public Import()
        {
            InitializeComponent();
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
            if (FilePath.SourcePath != "" && FilePath.ArchivePath!="")
            {
                ImportExcelFiles(FilePath.SourcePath, FilePath.ArchivePath);
            }
            else
            {
                MessageBox.Show("Select Source & Archive Path First");
                Setup setup = new Setup();
                setup.ShowDialog();
            }
        }

        private void ImportExcelFiles(string srcDir,string destDir)
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
                                file.MoveTo(destFile);
                            }
                        }

                    }
                    MessageBox.Show("File Moved Successfully");
                }
            }
            catch(Exception message)
            {
                MessageBox.Show("Something Went Wrong");
            }
            
        }
    }
}
