using DailyCashDeposite.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Screens
{
    public partial class Setup : Form
    {
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
                    srcPath.Text = FilePath.NoPath;
                    srcFolderButton.BackColor = Color.SkyBlue;
                    FilePath.SourcePath = FilePath.NoPath;
                }

            }
            else
            {
                srcPath.Text = FilePath.NoPath;
                srcFolderButton.BackColor = Color.SkyBlue;
                FilePath.SourcePath = FilePath.NoPath;
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
                    arcPath.Text = FilePath.NoPath;
                    arcFolderButton.BackColor = Color.SkyBlue;
                    FilePath.ArchivePath = FilePath.NoPath;
                }
            }
            else
            {
                arcPath.Text = FilePath.NoPath;
                arcFolderButton.BackColor = Color.SkyBlue;
                FilePath.ArchivePath = FilePath.NoPath;
            }
        }

        private void sqlTestButton_Click(object sender, EventArgs e)
        {
            var serverName = serverTextBox.Text?.Trim() ?? "";
            var database = dataBaseTextBox.Text?.Trim() ?? "";
            var userName = userNameTextBox.Text?.Trim() ?? "";
            var password = passwordTextbox.Text?.Trim() ?? "";
            ConnectionClass.SetConnectionProperty(userName, password, serverName, database);
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


        private void Setup_Load(object sender, EventArgs e)
        {
            srcPath.Text = FilePath.SourcePath;
            arcPath.Text = FilePath.ArchivePath;

            serverTextBox.Text = ConnectionClass.ServerName;
            dataBaseTextBox.Text = ConnectionClass.DatabaseName;
            userNameTextBox.Text = ConnectionClass.UserName;
            passwordTextbox.Text = ConnectionClass.Password;

            if (ConnectionClass.IsConnected)
            {
                successLable.Show();
                failedLable.Hide();
            }
            else
            {
                successLable.Hide();
            }

            if (FilePath.SourcePath != FilePath.NoPath)
            {
                srcFolderButton.BackColor = Color.PaleGreen;
            }

            if (FilePath.ArchivePath != FilePath.NoPath)
            {
                arcFolderButton.BackColor = Color.PaleGreen;
            }
            this.ActiveControl = passwordTextbox;
        }

        private void passwordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                sqlTestButton.PerformClick();
            }
        }
    }
}
