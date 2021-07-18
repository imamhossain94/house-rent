using House_Rent.Classes;
using Microsoft.Win32;
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
    public partial class BuyNow : Form
    {
        public BuyNow()
        {
            InitializeComponent();
        }
        Microsoft.Win32.RegistryKey key;
        static string Regname = "Software\\NewAgeBD\\House Rent";

        RegistryMd5 re = new RegistryMd5();
        public string versionType;
        public int trialBerValues;

        private void BuyNow_Load(object sender, EventArgs e)
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);
            serialkeylab.Text = "Key: " + re.FromHexString(key.GetValue("InsKy").ToString());
            installed_Time();
            ExpireClose_btn.Hide();
            TrialOrPaidClose_btn.Hide();
            featurelab.Hide();
            activationCode_Box.Visible = false;
            active_btn.Visible = false;
            ActiveBox_btn.Visible = false;
            StartCondition();
        }

        private void Buynow_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://buytrial.com/");
        }

        private void ActivationLabel_Click(object sender, EventArgs e)
        {
            activationCode_Box.Visible = true;
            ActiveBox_btn.Visible = true;
            buynow_btn.Visible = false;
            active_btn.Visible = true;
            ActivationLabel.Visible = false;
            TrialLabel.Visible = false;
            TrialBar.Visible = false;
        }

        private void Active_btn_Click(object sender, EventArgs e)
        {
            activeProduct();
        }

        private void ActiveBox_btn_Click(object sender, EventArgs e)
        {
            activationCode_Box.Visible = false;
            ActiveBox_btn.Visible = false;
            buynow_btn.Visible = true;
            active_btn.Visible = false;
            ActivationLabel.Visible = true;
            TrialLabel.Visible = true;
            TrialBar.Visible = true;
        }

        private void TrialBarTimer_Tick(object sender, EventArgs e)
        {
            TrialBar.Value += 1;
            if (TrialBar.Value == trialBerValues)
            {
                trialBarTimer.Enabled = false;
            }
        }

        //---------------------------------Start with trial/ paid-----------------------------------
        public void installed_Time()
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);
            installedTime.Text = "Installed Date: "+ re.FromHexString(key.GetValue("InsD").ToString()) +"/"+ re.FromHexString(key.GetValue("InsM").ToString()) + "/" + re.FromHexString(key.GetValue("InsY").ToString());
        }
        public void trialVer()
        {
            trialBerValues = 10 * re.trialDay;
            if (re.trialDay>0 && re.trialDay <= 30)
            {
                trialBarTimer.Enabled = true;
                TrialLabel.Text = "You have " + (30 - re.trialDay).ToString() + " days trial left";
            }
            if(re.trialDay == 0)
            {
                trialBarTimer.Enabled = false;
            }
            TrialOrPaidClose_btn.Show();
        }

        public void paidVer()
        {
            topLabel.Text = "PRODUCT ACTIVATED";
            discountlabel.Hide();
            priceOffLabel.Hide();
            priceAfterOfflab.Hide();
            featurelab.Show();
            this.AllFeatureLab.Location = new System.Drawing.Point(135, 70);
            buynow_btn.Hide();
            ActivationLabel.Hide();
            active_btn.Hide();
            ActiveBox_btn.Hide();
            activationCode_Box.Hide();
            TrialBar.Hide();
            TrialLabel.Show();
            TrialOrPaidClose_btn.Show();
            TrialLabel.Text = "Product Activated by NewAgeBD";
        }

        public void expiredVer()
        {
            if (10 * re.trialDay >= 300)
            {
                trialBerValues = 300;
            }
            TrialLabel.Text = "Your 30 days trial has expired";
            ExpireClose_btn.Show();
        }

        //-----------------------------------------Load at start---------------------------------------
        public void StartCondition()
        {
            re.getRemainingTrialDay();
            if (re.checkVer() == "expired")
            {
                expiredVer();
            }
            else if (re.checkVer() == "trial")
            {
                trialVer();
            }
            else if(re.checkVer() == "paid")
            {
                trialBarTimer.Enabled = false;
                paidVer();
            }
        }


        private void TrialOrPaidClose_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpireClose_btn_Click(object sender, EventArgs e)
        {
            HouseRentMain obj = (HouseRentMain)Application.OpenForms["HouseRentMain"];
            obj.Close();
            this.Close();
        }

        //-------------------------------------Activetion setting-----------------------------------------
        public void activeProduct()
        {
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);
            string[] after;
            after = (string[])key.GetValue("hrcd");
            foreach (string str in after)
            {
                if (str == re.MD5Hashx3(activationCode_Box.Text))
                {
                    versionType = "NeoNewPaidHouseRent";
                    paidVer();
                } 
            }
            if(versionType != "NeoNewPaidHouseRent")
            {
                DialogResult dr = MessageBox.Show("You entered wrong product key.", "Invalid", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Cancel)
                {
                    ActiveBox_btn.PerformClick();
                }
                else
                {
                    activationCode_Box.Text = "";
                }
            }
            else
            {
                re.writeRegistryKey("InsKy", re.ToHexString(activationCode_Box.Text));
                re.writeRegistryKey("ProdT", re.MD5Hashx3(versionType));
                serialkeylab.Text = "Key: " + re.FromHexString(key.GetValue("InsKy").ToString());
            }
            key.Close();
        }
    }
}
