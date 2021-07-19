using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }
        //----------------------------Button clicked event-------------------------
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Imam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100037108248990");
        }

        private void Rafsan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/itsRafsanJani?fref=hovercard&hc_location=chat");
        }

        private void Shuvo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/immahmudshuvo");
        }

        private void Nid_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Nid1996");
        }

        private void Ok_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MailContactlab_Click(object sender, EventArgs e)
        {

        }

        private void WebSiteLab_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
