using House_Rent.Classes;
using House_Rent.SettingsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent.UI
{
    public partial class SettingPanel : Form
    {
        public SettingPanel()
        {
            InitializeComponent();
        }
        //---------------------------Shadow--------------------------------------
        private const int cs_d = 0x00020003;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs_d;
                cp.ExStyle = 0x00000080;
                return cp;
            }
        }



        RegistryMd5 re = new RegistryMd5();
        public string versionType;



        //----------------------------Button Clicked Event------------------------------
        private void AppClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingPanel_Load(object sender, EventArgs e)
        {
            checkVer();
            GetFormInPanel(new Theme());
        }
        //----------------------------Get Form In Panel---------------------------------
        public void GetFormInPanel(object FormInP)
        {
            if (this.PanelConnector.Controls.Count > 0)
                this.PanelConnector.Controls.RemoveAt(0);
            Form fh = FormInP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelConnector.Controls.Add(fh);
            this.PanelConnector.Tag = fh;
            fh.Show();
        }

        private void Themes_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new Theme());
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            if(versionType == "paid")
            {
                GetFormInPanel(new Import());
            }
            else
            {
                MessageBox.Show("This is only for premium user.\nPlease Buy a key to use premium features", "Premium Feature", MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetFormInPanel(new BuyNow());
            }  
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            if (versionType == "paid")
            {
                GetFormInPanel(new Export());
            }
            else
            {
                MessageBox.Show("This is only for premium user.\nPlease Buy a key to use premium features", "Premium Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFormInPanel(new BuyNow());
            }
        }

        public void Buy_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new BuyNow());
        }

        private void Feedback_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new FeedBack());
        }

        private void ChangeLog_Btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new ChangeLog());
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new Updatecs());
        }


        //------------------------------Premium Function----------------------------

        public void checkVer()
        {
            re.getRemainingTrialDay();
            if (re.checkVer() == "trial")
            {
                versionType = "trial";
            }
            else if (re.checkVer() == "paid")
            {
                versionType = "paid";
            }
        }


    }
}
