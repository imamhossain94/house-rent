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
    public partial class HouseRent : Form
    {
        //
        //Application Moveable_Start
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        //Application Moveable_Close
        //
        public HouseRent()
        {
            InitializeComponent();
        }
        //
        //Function For closed apps
        //
        private void AppClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //LogIncs ls = new LogIncs();
            //ls.Show();
        }
        //
        //Funclion for control the side menu bar
        //
        private void Clint_btn_Click(object sender, EventArgs e)
        {
            if (SidePanel.Width == 0)
            {
                SidePanel.Width = 304;
            }
            else
            {
                SidePanel.Width = 0;
            }
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            if (SidePanel.Width == 304)
            {
                SidePanel.Width = 736;
            }
            else
            {
                SidePanel.Width = 304;
            }
        }
        //
        //Function to load another form in main form
        //
        private void GetFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        //
        //calling second form
        //
        private void Add_User_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new ClintReg());
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new Home());
        }
        //
        //user hide
        //
        public void user_sidePanel_hide()
        {
            User1_btn.Hide();
            User1_leb.Hide();

            User2_btn.Hide();
            User2_leb.Hide();

            User3_btn.Hide();
            User3_leb.Hide();

            User4_btn.Hide();
            User4_leb.Hide();

            User5_btn.Hide();
            User5_leb.Hide();

            User6_btn.Hide();
            User6_leb.Hide();

            User7_btn.Hide();
            User7_leb.Hide();

            User8_btn.Hide();
            User8_leb.Hide();

            User9_btn.Hide();
            User9_leb.Hide();

            User10_btn.Hide();
            User10_leb.Hide();

            User11_btn.Hide();
            User11_leb.Hide();

            User12_btn.Hide();
            User12_leb.Hide();
        }
        //
        //user lab load
        //
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public string Fname(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select FirstName from UserTables Where ID=" + i + "and Name='"+LogIncs.setText+"'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }

        public string UName(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select Name from UserTables Where ID="+i+ "and Name='"+LogIncs.setText +"'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }

        public void sidePanel_config()
        {
            int i = 1;
            
            for (i = 1; i <= 12; i++)
            {

                SqlConnection conn = new SqlConnection(myconstring);
                string sql = "Select ID from UserTables Where ID=" + i + "and Name='"+LogIncs.setText+"'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                string nam1 = UName(i);
                
                if (dtbl.Rows.Count == 1)
                {
                    

                    if (i == 1 && UName(i) == LogIncs.setText)
                    {                      
                            User1_btn.Show();
                            User1_leb.Show();
                            User1_leb.Text = Fname(i);         
                    }

                    if (i == 2 && UName(i) == LogIncs.setText)
                    {
                        User2_btn.Show();
                        User2_leb.Show();

                        User2_leb.Text = Fname(i);
                    }

                    if (i == 3 && UName(i) == LogIncs.setText)
                    {
                        User3_btn.Show();
                        User3_leb.Show();
                        User3_leb.Text = Fname(i);
                    }

                    if (i == 4 && UName(i) == LogIncs.setText)
                    {
                        User4_btn.Show();
                        User4_leb.Show();
                        User4_leb.Text = Fname(i);
                    }

                    if (i == 5)
                    {
                        User5_btn.Show();
                        User5_leb.Show();
                        User5_leb.Text = Fname(i);
                    }

                    if (i == 6)
                    {
                        User6_btn.Show();
                        User6_leb.Show();
                        User6_leb.Text = Fname(i);
                    }

                    if (i == 7)
                    {
                        User7_btn.Show();
                        User7_leb.Show();
                        User7_leb.Text = Fname(i);
                    }

                    if (i == 8)
                    {
                        User8_btn.Show();
                        User8_leb.Show();
                        User8_leb.Text = Fname(i);
                    }

                    if (i == 9)
                    {
                        User9_btn.Show();
                        User9_leb.Show();
                        User9_leb.Text = Fname(i);
                    }

                    if (i == 10)
                    {
                        User10_btn.Show();
                        User10_leb.Show();
                        User10_leb.Text = Fname(i);
                    }

                    if (i == 11)
                    {
                        User11_btn.Show();
                        User11_leb.Show();
                        User11_leb.Text = Fname(i);
                    }

                    if (i == 12)
                    {
                        User12_btn.Show();
                        User12_leb.Show();
                        User12_leb.Text = Fname(i);
                    }
                    
                }
                else
                {

                }
            }


            /*/new style..
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Select * from Admin,UserTables Where Admin.Name=UserTables.Name";

            SqlCommand cmd0 = new SqlCommand(sql, conn);
            cmd0.Connection.Open();

            int s = cmd0.ExecuteNonQuery();
            if (s == 1)
            {
                SqlCommand cmd1 = new SqlCommand("Select UserTables.FirstName from Admin,UserTables Where Admin.Name=UserTables.Name");
                cmd1.Connection = conn;
                conn.Open();
                string val1 = (string)cmd1.ExecuteScalar();


                User1_btn.Show();
                User1_leb.Show();

                User1_leb.Text = val1;
                conn.Close();
            }
            else
            {

            }
            cmd0.Connection.Close();
            */


        }

        public void HouseRent_Load(object sender, EventArgs e)
        {
            admin_prp_load();
            user_sidePanel_hide();
            sidePanel_config();
            Admin_leb.Text ="[ "+LogIncs.setText+ " ]";
            GetFormInPanel(new Home());
        }
        //
        //user btn load
        //
        private void User1_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(1);
            AddRecord ar = new AddRecord();
            ar.labelText= x;
            SidePanel.Width = 0;
            GetFormInPanel( ar );
        }

        private void User2_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(2);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User3_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(3);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User4_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(4);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User5_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(5);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User6_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(6);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User7_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(7);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User8_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(8);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User9_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(9);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User10_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(10);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User11_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(11);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }

        private void User12_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(12);
            AddRecord ar = new AddRecord();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }
       
        private void About_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("House Rent. beta Test Version");
        }
        // reset............................
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            //ResetF rf = new ResetF();
            //rf.Show();
            if (TopBar.Height == 60)
            {
                TopBar.Height = 270;
            }
            else
            {
                TopBar.Height = 60;
            }
        }

        public string admin()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Drop Table Admin";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (r < 0)
            {
                //SqlCommand cmd1 = new SqlCommand("CREATE TABLE Admin(Name varchar(50) PRIMARY KEY,Email varchar(50),Password varchar(50),DOB varchar(50),Gender varchar(50),[Image] [image])", conn);
                SqlCommand cmd1 = new SqlCommand("CREATE TABLE Admin(Name varchar(50) primary key, Email varchar(50), Password varchar(50), DOB varchar(50), Gender varchar(50), Image image)", conn);
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "yes";
            }
            else
            {
                return "no";
            }
        }

        public string user()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Drop Table UserTables";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (r < 0)
            {
                //SqlCommand cmd1 = new SqlCommand("CREATE TABLE Admin(Name varchar(50) PRIMARY KEY,Email varchar(50),Password varchar(50),DOB varchar(50),Gender varchar(50),[Image] [image])", conn);
                SqlCommand cmd1 = new SqlCommand("CREATE TABLE UserTables(ID int, Flat varchar(50), FirstName varchar(50), LastName varchar(50), UserEmail varchar(50), ContactNo varchar(50), Gender varchar(50), JoiningMonth varchar(50), DOB varchar(50), UserImage image, Name varchar(50))", conn);
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "yes";
            }
            else
            {
                return "no";
            }
        }

        public string record()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Drop Table RecordTab";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (r < 0)
            {
                //SqlCommand cmd1 = new SqlCommand("CREATE TABLE Admin(Name varchar(50) PRIMARY KEY,Email varchar(50),Password varchar(50),DOB varchar(50),Gender varchar(50),[Image] [image])", conn);
                SqlCommand cmd1 = new SqlCommand("CREATE TABLE RecordTab(S_No int Primary Key identity(1,1), U_Name varchar(50), Month varchar(50), Year varchar(50), HouseRent int, ElectricBill int, GasBill int, WaterBill int,TotalRent int, ReceivedAmmount int, DueAmmount int,Name varchar(50),[Image] [image])", conn);
                cmd1.Connection.Open();
                cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
                return "yes";
            }
            else
            {
                return "no";
            }
        }

        public void del_clnt()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Delete from UserTables where Name='" + LogIncs.setText + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void del_rec()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Delete from RecordTab where Name='" + LogIncs.setText + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        private void Cmf_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstring);

            if (CmbGet.Text == "Admin + Clints + Records")
            {
                DialogResult DR = MessageBox.Show("All data Will be lost..! pore kanna-kati kore lav nai", "Are you sure?", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    string x = admin();
                    string y = user();
                    string z = record();
                    if (x == y && x == z && x == "yes")
                    {
                        MessageBox.Show("Operation Successfull!");
                        this.Hide();
                        LogIncs cs = new LogIncs();
                        cs.Show();
                    }
                    else
                    {
                        MessageBox.Show("Operation Not Successfull!");
                    }
                }
                else if (DR == DialogResult.No)
                {
                    this.Close();
                }

            }

            else if (CmbGet.Text == "Clints + Records")
            {
                DialogResult DR = MessageBox.Show("reset", "Are you sure?", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    del_rec();
                    del_clnt();
                    TopBar.Height = 60;
                    GetFormInPanel(new Home());
                    SidePanel.Width = 304;
                    MessageBox.Show("Please Refresh the Clint tab");
                }
                else if (DR == DialogResult.No)
                {
                    this.Close(); 
                }
            }

            else if (CmbGet.Text == "Records")
            {
                DialogResult DR = MessageBox.Show("reset", "Are you sure?", MessageBoxButtons.YesNo);
                if (DR == DialogResult.Yes)
                {
                    del_rec();
                    TopBar.Height = 60;
                    GetFormInPanel(new Home());
                }
                else if (DR == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        //Admin profile load..........................
        public void img_Load()
        {
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
                prop_picBox.Image = new Bitmap(ms);
            }
            conn.Close();
        }

        public string admin_email()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Email from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string Aemail = (string)cmd.ExecuteScalar();
            conn.Close();
            return Aemail;
        }

        public string admin_dob()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select DOB from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string Adob = (string)cmd.ExecuteScalar();
            conn.Close();
            return Adob;
        }

        public string admin_gender()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Gender from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string Agen = (string)cmd.ExecuteScalar();
            conn.Close();
            return Agen;
        }

        public void admin_prp_load()
        {
            img_Load();
            prop_name_leb.Text = LogIncs.setText;
            prop_email_leb.Text = admin_email();
            prop_dob_leb.Text = admin_dob();
            prop_gender_leb.Text = admin_gender();
        }
    }
}
