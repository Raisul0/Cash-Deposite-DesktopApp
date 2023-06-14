using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyCashDeposite.Helper
{
    public static class ControlUtilities
    {
        public static Control AddToolTip(this Control control, string title, string text)
        {
            var toolTip = new ToolTip
            {
                ToolTipIcon = ToolTipIcon.None,
                IsBalloon = true,
                ShowAlways = true,
                ToolTipTitle = title,
            };
            toolTip.SetToolTip(control, text);
            return control;
        }

    }
}
