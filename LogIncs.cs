using House_Rent.Classes;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static string setText;
        
        public LogIncs()
        {
            InitializeComponent();
        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Name_Click(object sender, EventArgs e)
        {
            User_Name.Text = " ";
        }

        private void SignUp_tab_Click(object sender, EventArgs e)
        {
            LogIn_leb.Hide();
            SignUp_leb.Show();
            LogInPanel.Hide();
            SignUp_panel.Show();
        }

        private void Login_tab_Click(object sender, EventArgs e)
        {
            LogIn_leb.Show();
            SignUp_leb.Hide();
            SignUp_panel.Hide();
            LogInPanel.Show();
        }

        private void LogIncs_Load(object sender, EventArgs e)
        {
            LogIn_leb.Show();
            SignUp_leb.Hide();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Passwordbtn_Click(object sender, EventArgs e)
        {
            User_pw.Text = "";
        }

        private void Sign_name_Click(object sender, EventArgs e)
        {
            Sign_name.Text = "";
        }

        private void Sign_email_Click(object sender, EventArgs e)
        {
            Sign_email.Text = "";
        }

        private void Sign_Pw_Click(object sender, EventArgs e)
        {
            Sign_Pw.Text = "";
        }

        private void Sign_DOB_Click(object sender, EventArgs e)
        {
            Sign_DOB.Text = "";
        }


        string imageloc = "";
        private void BrowsePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageloc = dialog.FileName.ToString();
                pictureBox_profile.ImageLocation = imageloc;
            }
        }



        private void Instruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your name containing letters, digites (A - Z), (a - z), (0 - 9).\nExample: Imam84, RafsanJani96 etc.");
        }

        //
        //login operations
        //
        AdminClass c = new AdminClass();
        ClintClasscs d = new ClintClasscs();
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void Login_btn_Click(object sender, EventArgs e)
        {
            setText = User_Name.Text.Trim();
            //c.name = User_Name.Text.Trim();
            //c.password = User_pw.Text.Trim();
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Admin Where Name = '" + User_Name.Text.Trim() + "' and Password = '" + User_pw.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                HouseRent frm = new HouseRent();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Wrong! username and password");
            }

        }
        //
        //Add admin info
        //
        private void CreateAcc_btn_Click(object sender, EventArgs e)
        {
            FileStream streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);

            c.name = Sign_name.Text;
            c.email = Sign_email.Text;
            c.password = Sign_Pw.Text;
            c.dob = Sign_DOB.Text;
            c.gender = sign_gender.Text;
            c.image = brs.ReadBytes((int)streem.Length);
            bool success = c.insert(c);

            if (success == true)
            {
                LogIn_leb.Show();
                SignUp_leb.Hide();
                SignUp_panel.Hide();
                LogInPanel.Show();
                MessageBox.Show("Please Login with your Name & password.", "Sign Up Compleate", MessageBoxButtons.OK); 
            }
            else
            {
                MessageBox.Show("Try Again!","Sign Up Failed.",MessageBoxButtons.OK);
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Date of birth:");
        }
    }
}
