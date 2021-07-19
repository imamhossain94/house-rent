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
    public partial class Updatecs : Form
    {
        public Updatecs()
        {
            InitializeComponent();
        }
        public int steps;

        private void ProgressTime_Tick(object sender, EventArgs e)
        {
            UpdateCheckBar.Value += 1;
            if (UpdateCheckBar.Value == steps)
            {
                progressTime.Enabled = false;
                MessageBox.Show("Ther have no new update available right now", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCheck_btn_Click(object sender, EventArgs e)
        {
            steps = 100;
            if(progressTime.Enabled == false)
            {
                UpdateCheckBar.Value = 0;
                progressTime.Enabled = true;

            }
        }
    }
}
