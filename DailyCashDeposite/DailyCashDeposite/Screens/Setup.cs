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
                srcPath.Text = srcFolderDialog.SelectedPath;
                srcFolderButton.BackColor = Color.PaleGreen;
            }
            else
            {
                srcPath.Text = noPathText;
                srcFolderButton.BackColor = Color.SkyBlue;
            }
        }

        private void arcFolderButton_Click(object sender, EventArgs e)
        {
            if (arcFolderDialog.ShowDialog() == DialogResult.OK)
            {
                arcPath.Text = arcFolderDialog.SelectedPath;
                arcFolderButton.BackColor = Color.PaleGreen;
            }
            else
            {
                arcPath.Text = noPathText;
                arcFolderButton.BackColor = Color.SkyBlue;
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
