using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent.SettingsUI
{
    public partial class ChangeLog : Form
    {
        public ChangeLog()
        {
            InitializeComponent();
        }

        private void TimerForLog_Tick(object sender, EventArgs e)
        {
            if(ChangelogBox.Top>-1700)
            {
                ChangelogBox.Top = ChangelogBox.Top - 1;
            }
            else
            {
                ChangelogBox.Top = 0;
            }
            
        }
    }
}
