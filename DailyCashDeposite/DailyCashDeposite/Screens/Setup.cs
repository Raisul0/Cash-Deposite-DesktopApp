using DailyCashDeposite.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Screens
{
    public partial class Setup : Form
    {
        public string noPathText = "No Path Selected";
        public Setup()
        {
            InitializeComponent();
        }

        private void srcFolderButton_Click(object sender, EventArgs e)
        {
            if(srcFolderDialog.ShowDialog() == DialogResult.OK)
            {
                if(srcFolderDialog.SelectedPath != FilePath.ArchivePath)
                {
                    srcPath.Text = srcFolderDialog.SelectedPath;
                    srcFolderButton.BackColor = Color.PaleGreen;
                    FilePath.SourcePath = srcFolderDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Source Path can't Be Same as Archive Path");
                    srcPath.Text = noPathText;
                    srcFolderButton.BackColor = Color.SkyBlue;
                    FilePath.SourcePath = "";
                }

            }
            else
            {
                srcPath.Text = noPathText;
                srcFolderButton.BackColor = Color.SkyBlue;
                FilePath.SourcePath = "";
            }
        }

        private void arcFolderButton_Click(object sender, EventArgs e)
        {
            if (arcFolderDialog.ShowDialog() == DialogResult.OK)
            {
                if (arcFolderDialog.SelectedPath != FilePath.SourcePath)
                {
                    arcPath.Text = arcFolderDialog.SelectedPath;
                    arcFolderButton.BackColor = Color.PaleGreen;
                    FilePath.ArchivePath = arcFolderDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Archive Path can't Be Same as Source Path");
                    arcPath.Text = noPathText;
                    arcFolderButton.BackColor = Color.SkyBlue;
                    FilePath.ArchivePath = "";
                }
            }
            else
            {
                arcPath.Text = noPathText;
                arcFolderButton.BackColor = Color.SkyBlue;
                FilePath.ArchivePath = "";
            }
        }

        private void sqlTestButton_Click(object sender, EventArgs e)
        {
            var userName = userNameTextBox.Text?.Trim() ?? "";
            var password = passwordTextbox.Text?.Trim() ?? "";
            ConnectionClass.SetConnectionProperty(userName, password);
            if (ConnectionClass.TestConnection())
            {
                successLable.Show();
                failedLable.Hide();
            }
            else
            {
                failedLable.Show();
                successLable.Hide();
            }
            
        }
    }
}
