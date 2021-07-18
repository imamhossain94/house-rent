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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent.Profil
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }
        //---------------------------Shadow-----------------------
        private const int cs_d = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs_d;
                return cp;
            }
        }




        AdminClass ac = new AdminClass();
        public string user_lab;
        public string labelText { get { return user_lab; } set { user_lab = value; } }
        //--------------------------------Load Admin pic--------------------------------
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public void img_Load()
        {
            //img_load() used to load admin picture from database
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Image from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                AdmiUserPicBox.Image = new Bitmap(ms);
            }
            conn.Close();
        }

        public string dob_load()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select DOB from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string dob = (string)cmd.ExecuteScalar();
            conn.Close();

            return dob;
        }

        public string Email_load()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Email from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string dob = (string)cmd.ExecuteScalar();
            conn.Close();

            return dob;
        }

        public string Grnderload()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Gender from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string dob = (string)cmd.ExecuteScalar();
            conn.Close();

            return dob;
        }
        //------------------------------------Load Clients Pic-------------------------------

        public int id_load()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ID from UserTables Where FirstName='" + AddRecords.username + "' and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            int TranLab = (int)cmd.ExecuteScalar();
            conn.Close();
            return TranLab;
        }

        public void Clientsimg_Load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select UserImage from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["UserImage"]);
                AdmiUserPicBox.Image = new Bitmap(ms);
            }
            conn.Close();
        }

        public string emil_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select UserEmail from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string eml = (string)cmd.ExecuteScalar();
            conn.Close();

            return eml;
        }
        public string gen_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Gender from UserTables Where ID=" + x + " and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string gen = (string)cmd.ExecuteScalar();
            conn.Close();

            return gen;
        }

        public string contno_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ContactNo from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string cn = (string)cmd.ExecuteScalar();
            conn.Close();

            return cn;
        }

        public string Clientsdob_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select DOB from UserTables Where ID=" + x + " and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string dob = (string)cmd.ExecuteScalar();
            conn.Close();

            return dob;
        }

        public void adminInfo()
        {
            img_Load();
            NameLab.Text = ": " +LogIncs.setText;
            EmailLab.Text = ": "+ Email_load();
            GenderLab.Text = ": "+ Grnderload();
            PasswordLab.Text = ": *****";
            DateOFBirthLab.Text = ": "+ dob_load();
        }


        public void clientsInfo()
        {
            Clientsimg_Load();
            NameLab.Text = ": " + AddRecords.username;
            EmailLab.Text = ": " + emil_load();
            GenderLab.Text = ": " + gen_load();
            PassLab.Text = "Contac No";
            PasswordLab.Text = ": " + contno_load();
            DateOFBirthLab.Text = ": " + Clientsdob_load();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            
            if (HouseRentMain.ClickedEvent == "Admin")
            {
                adminInfo();
            }
            else if(HouseRentMain.ClickedEvent == "Client")
            {
                clientsInfo();
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
