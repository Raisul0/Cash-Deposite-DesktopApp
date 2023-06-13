using DailyCashDeposite.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Helper
{
    public static class MessageBoxHelper
    {
        public static void SetupConnenctionMessage()
        {
            MessageBox.Show("First Setup Successfull Connection from the Setup Screen");
            Setup setup = new Setup();
            setup.ShowDialog();
        }
    }
}
