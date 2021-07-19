using House_Rent.Classes;
using House_Rent.SettingsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class LogIncs : Form
    {
        public LogIncs()
        {
            //m_aeroEnabled = false;
            //this.FormBorderStyle = FormBorderStyle.None;

            InitializeComponent();

            //LogInPanel.BackColor = Color.FromArgb(130, Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49))))));
            //SignUpPanel.BackColor = Color.FromArgb(130, Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49))))));
            
        }
        //---------------------------Shadow--------------------------------------
        // /*
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

       // */
       




        Microsoft.Win32.RegistryKey key;
        public string Regname = "Software\\NewAgeBD\\House Rent";

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        AdminClass c = new AdminClass();
        RegistryMd5 re = new RegistryMd5();

        
        public static string setText;
        //*******************************Button clocking event***************************
        private void HelpButton_Click(object sender, EventArgs e)
        {

        }
        private void AppClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            login();
        }
        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            LogInPanel.Hide();
            SignUpPanel.Show();
        }
        private void LogInLabel_Click(object sender, EventArgs e)
        {
            SignUpPanel.Hide();
            LogInPanel.Show();
        }
        private void ForgetPassword_Click(object sender, EventArgs e)
        {

        }

        private void RememberMeCheckBox_OnChange(object sender, EventArgs e)
        {

        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            UploadProfile();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            signup();
        }

        //-----------------------Log In--------------------------------
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                LogInUserNameBox.Focus();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void LogInUserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInPasswordBox.Focus();
                e.Handled = true;
            }
        }
        private void LogInPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LogInButton.PerformClick();
            }
        }

        //---------------------------------Sign Up------------------------------------

        private void SignUpUserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool suc = Admin_check();

            if (e.KeyCode == Keys.Enter)
            {
                if (suc == true)
                {
                    MessageBox.Show("This Name is not availavle.\nTry--\n" + SignUpUserNameBox.Text + "" + RandomNumber(0, 500) + ",        " + SignUpUserNameBox.Text + "" + RandomNumber(500, 1000) + " or        " + SignUpUserNameBox.Text + "" + RandomNumber(1000, 3500) + "\n\nElse Enter another name.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SignUpPasswordBox.Focus();
                    e.Handled = true;
                }
            }
        }

        private void SignUpPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUpPasswordBox2.Focus();
                e.Handled = true;
            }
        }

        private void SignUpPasswordBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(SignUpPasswordBox.Text!= SignUpPasswordBox2.Text)
                {
                    SignUpPasswordBox.Focus();
                    SignUpPasswordBox.BorderColorIdle = Color.Red;
                    SignUpPasswordBox2.BorderColorIdle = Color.Red;
                    SignUpPasswordBox.Text = "";
                    SignUpPasswordBox2.Text = "";
                }
                else if (SignUpPasswordBox.Text == SignUpPasswordBox2.Text)
                {
                    SignUpEmailBox.Focus();
                    SignUpPasswordBox.BorderColorIdle = Color.RoyalBlue;
                    
                }
                e.Handled = true;
            }
        }

        private void SignUpEmailBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUpButton.PerformClick();
            }
        }

        //open file dialog to pick admin photo

        string imageloc = "";
        public void UploadProfile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageloc = dialog.FileName.ToString();
                UploadProfilePicture.ImageLocation = imageloc;
            }
        }

        //  Function to check whatever admin nameexistence in DB
        public bool Admin_check()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select * from Admin Where Name = '" + SignUpUserNameBox.Text.Trim() + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            conn.Close();
            return success;
        }

        //  picking random number for new admin name
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //  Signup info function..
        public void signup()
        {
            bool suc = Admin_check();

            if (suc == true)
            {
                MessageBox.Show("This Name is not availavle.\nTry--\n" + SignUpUserNameBox.Text + "" + RandomNumber(0, 500) + ",        " + SignUpUserNameBox.Text + "" + RandomNumber(500, 1000) + " or        " + SignUpUserNameBox.Text + "" + RandomNumber(1000, 3500) + "\n\nElse Enter another name.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (suc == false)
            {
                if (imageloc == "")
                {
                    MessageBox.Show("Please Upload an Image.");
                    UploadProfile();
                }
                else
                {
                    FileStream streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    c.image = brs.ReadBytes((int)streem.Length);
                    c.name = SignUpUserNameBox.Text;
                    c.email = SignUpEmailBox.Text;
                    c.password = re.MD5Hash(SignUpPasswordBox2.Text);
                    bool success = c.insert(c);

                    if (success == true)
                    {
                        SignUpPanel.Visible = false;
                        LogInPanel.Visible = true;
                        MessageBox.Show("Please Login with your Name & password.", "Sign Up Compleate", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Try Again!", "Sign Up Failed.", MessageBoxButtons.OK);
                    }
                }

            }
        }

        //  Login info function..
        public void login()
        {
            setText = LogInUserNameBox.Text.Trim();
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Admin Where Name = '" + LogInUserNameBox.Text.Trim() + "' and Password = '" + re.MD5Hash(LogInPasswordBox.Text.Trim()).Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                HouseRentMain frm = new HouseRentMain();
                this.Visible = false;
                frm.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong! username and password");
            }
        }


        //------------------------------------Registry Check--------------------------------
        public void insertInstallDate()
        {
            var time = DateTime.Now;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Regname, true);
            if (key.GetValue("ins").ToString() == re.ToHexString("NewAgeBD"))
            {
                re.writeRegistryKey("InsD", re.ToHexString(time.ToString("dd")));
                re.writeRegistryKey("InsM", re.ToHexString(time.ToString("MM")));
                re.writeRegistryKey("InsY", re.ToHexString(time.ToString("yyyy")));
                re.writeRegistryKey("ins", re.ToHexString("HouseRent"));
            }
        }

        private void LogIncs_Load(object sender, EventArgs e)
        {
            re.writeRegistryKey("InsKy", re.ToHexString("XXX-XXX-XXX"));
            
            re.writeRegistryKey("InsD", re.ToHexString("25"));
            re.writeRegistryKey("InsM", re.ToHexString("10"));
            re.writeRegistryKey("InsY", re.ToHexString("2019"));
            
            re.writeRegistryKey("ins", re.ToHexString("NewAgeBD"));
            //re.writeRegistryKey("ins", re.ToHexString("NewAgeBD"));//4E006500770041006700650042004400
            //writeRegistryKey("ins", re.ToHexString("HouseRent"));//48006F00750073006500520065006E007400
            //Trial 
            //re.writeRegistryKey("ProdT", re.MD5Hashx5("NeoRentAgeTril"));//000a30000a0001c00074000bd0007e0004d000ea0002c000c1000620009f0000f00044000360009d
            //Paid 
            re.writeRegistryKey("ProdT", re.MD5Hashx3("NeoNewPaidHouseRent"));//0270e305401d0c00650dd09a02d00c08d0c40b105a0670b6

            insertInstallDate();
            StartCondition();
            //re.writeRegistryKey("InsKy", re.ToHexString("XXX-XXX-XXX"));
            /*
            re.writeRegistryKey("InsD", re.ToHexString("25"));
            re.writeRegistryKey("InsM", re.ToHexString("10"));
            re.writeRegistryKey("InsY", re.ToHexString("2019"));
            */
            //re.writeRegistryKey("ins", re.ToHexString("NewAgeBD"));
            //re.writeRegistryKey("ins", re.ToHexString("NewAgeBD"));//4E006500770041006700650042004400
            //writeRegistryKey("ins", re.ToHexString("HouseRent"));//48006F00750073006500520065006E007400
            //Trial 
            //re.writeRegistryKey("ProdT", re.MD5Hashx5("NeoRentAgeTril"));//000a30000a0001c00074000bd0007e0004d000ea0002c000c1000620009f0000f00044000360009d
            //Paid 
            //re.writeRegistryKey("ProdT", re.MD5Hashx3("NeoNewPaidHouseRent"));//0270e305401d0c00650dd09a02d00c08d0c40b105a0670b6
        }

        public void StartCondition()
        {
            re.getRemainingTrialDay();
            if (re.checkVer() == "expired")
            {
                this.Hide();
                new BuyNow().ShowDialog();
            }
            else
            {

            }
        }

        
    }
}
