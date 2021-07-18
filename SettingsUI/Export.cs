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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working heard to bring this functionality", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
