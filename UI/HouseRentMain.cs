using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using BunifuAnimatorNS;
using DGVPrinterHelper;
using House_Rent.Classes;
using House_Rent.Profil;
using House_Rent.SettingsUI;
using House_Rent.UI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class HouseRentMain : Form
    {
        public HouseRentMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        RegistryMd5 re = new RegistryMd5();
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public static string ClickedEvent;


        //*************************Borderless winform resizable*****************************
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;

                }
            }
            base.WndProc(ref m);
        }

        //*************************************Button Click event*******************************

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            ClickedEvent = "Admin";
            new UserProfile().ShowDialog();
        }
        private void Admin_leb_Click(object sender, EventArgs e)
        {
            sidetab();
        }
        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new Home());
        }

        private void AddClint_btn_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new ClintsPanel());
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            new Resetpanel().ShowDialog();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            new AboutUs().ShowDialog();
        }
        private void Settings_btn_Click(object sender, EventArgs e)
        {
            new SettingPanel().ShowDialog();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void WinMaxMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //bunifuElipse.ApplyElipse(this, 0);
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

        }

        //****************************************End button click event*****************************
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Space))
            {
                return true;
            }
            if (keyData == (Keys.Tab))
            {
                //sidetab();
                return true;
            }
            if (keyData == (Keys.Home))
            {
                GetFormInPanel(new Home());
                return true;
            }
            if (keyData == (Keys.C | Keys.Control))
            {
                GetFormInPanel(new ClintsPanel());
                return true;
            }
            if (keyData == (Keys.R | Keys.Control))
            {
                new Resetpanel().ShowDialog();
                return true;
            }
            if (keyData == (Keys.A | Keys.Control))
            {
                new AboutUs().ShowDialog();
                return true;
            }
            if (keyData == (Keys.S | Keys.Control))
            {
                new SettingPanel().ShowDialog();
                return true;
            }
            //----------------------------------Clients Tab Menu----------------------------

            return base.ProcessCmdKey(ref msg, keyData);
        }

        //****************************************Loading a fron in panel****************************
        public void GetFormInPanel(object FormInP)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormInP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }




        //***************************loading some modules at start******************************
        private void HouseRentMain_Load(object sender, EventArgs e)
        {
            //Loading apps theme.
            ThemeLoad();

            //hiding all the panel at the start then,
            

            // calling this function to check clint presents in database.
            sidePanel_config();

            //loading admin image from database.
            img_Load();

            //importing admin name from login form as static string
            Admin_leb.Text = LogIncs.setText.ToUpper();

            //to add round corner at clint panel

            SidePanel.AutoScroll = false;
            SidePanel.VerticalScroll.Enabled = false;
            SidePanel.VerticalScroll.Visible = false;
            SidePanel.VerticalScroll.Maximum = 0;
            SidePanel.HorizontalScroll.Maximum = 0;
            SidePanel.AutoScroll = true;
            

            //loading home tab into main apps panel
            GetFormInPanel(new Home());
            StartCondition();

            for (int i = 1; i <= max(); i++)
            {
                BunifuPictureBox b = CreateButton(i);
                Label l = CreateLabel(i);
                Panel p = CreatePanel(i);
                p.Controls.Add(b);
                p.Controls.Add(l);
                SidePanel.Controls.Add(p);

                //b.Click += new System.EventHandler(btndblClk);
                //p.Click += new System.EventHandler(onlClk);
                l.Click += new System.EventHandler(LabelClick);

            }


        }
        //*******************************Hiding both horizontal&vertical scrollbar 
        //*********Without disabling it.
        //*** also hiding clint panel. this function is called at starting.

        void ButtonClick(Object sender, EventArgs e)
        {
            BunifuPictureBox bp = (BunifuPictureBox)sender;
            string x = Fname(1);
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);

        }

        void LabelClick(Object sender, EventArgs e)
        {
            Label bp = (Label)sender;
            string x = bp.Text;
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }





        public void sidetab()
        {
            if (SidePanel.Width == 0)
            {
                SidePanel.Width = 265;
                bunifuTransition2.ShowSync(SidePanel);
            }
            else
            {
                bunifuTransition2.HideSync(SidePanel);
                SidePanel.Width = 0;
            }
        }




        Panel CreatePanel(int i)
        {
            Panel p = new Panel();
            BunifuElipse be = new BunifuElipse();
            //p.Controls.Add(CreateButton(i));
            //p.Controls.Add(CreateLabel(i));
            //be.ApplyElipse(p, 10);
            p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            bunifuTransition2.SetDecoration(this.add_tenant_pnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            bunifuTransition1.SetDecoration(this.add_tenant_pnl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            //p.Location = new System.Drawing.Point(10, 10);
            p.Margin = new System.Windows.Forms.Padding(10,5,5,5);
            p.Name = "add_tenant_pnl"+i;
            p.Size = new System.Drawing.Size(247, 47);
            p.TabIndex = 0;
            return p;
        }

        Label CreateLabel(int i)
        {
            Label p = new Label();
            p.Size = new System.Drawing.Size(100, 30);
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuTransition1.SetDecoration(this.add_tenant_lbl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            bunifuTransition2.SetDecoration(this.add_tenant_lbl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            p.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p.ForeColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point(55, 8);
            p.Name = "add_tenant_lbl"+i;
            p.Size = new System.Drawing.Size(247, 30);
            p.TabIndex = 51;
            p.Text = Fname(i); ;
            p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            return p;
        }

        BunifuPictureBox CreateButton(int i)
        {
            BunifuPictureBox bp = new BunifuPictureBox();
            bp.AllowFocused = false;
            bp.Anchor = System.Windows.Forms.AnchorStyles.None;
            bp.BackColor = System.Drawing.Color.Transparent;
            bp.BorderRadius = 30;
            bunifuTransition2.SetDecoration(this.add_tenant_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            bunifuTransition1.SetDecoration(this.add_tenant_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            bp.Image = new Bitmap(Clintimg_Load(i));
            bp.IsCircle = true;
            bp.Location = new System.Drawing.Point(2, 2);
            bp.Name = "add_tenant_btn"+i;
            bp.Size = new System.Drawing.Size(42, 42);
            bp.Margin = new System.Windows.Forms.Padding(3);
            bp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            bp.TabStop = false;
            bp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            return bp;
        }



        //*********************************** Admin data ****************************************
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
                Admin_btn.Image = new Bitmap(ms);
            }
            conn.Close();
        }

        //******************************************Clint data************************************
        public int max()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select count(ID) from UserTables where Name='" + LogIncs.setText + "'");
            cmd1.Connection = conn;
            conn.Open();
            int val1 = (int)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }


        //Clintimg_Load(int i) used to retrive clint/ Tenat image from database
        public MemoryStream Clintimg_Load(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select UserImage from UserTables Where ID=" + i + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["UserImage"]);
            conn.Close();
            return ms;
        }
        //Fname(int i) used to get clint first name from database.
        public string Fname(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select FirstName from UserTables Where ID=" + i + "and Name='" + LogIncs.setText + "'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }
        //UName(int i) used to get admin name from database.
        public string UName(int i)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd1 = new SqlCommand("Select Name from UserTables Where ID=" + i + "and Name='" + LogIncs.setText + "'");
            cmd1.Connection = conn;
            conn.Open();
            string val1 = (string)cmd1.ExecuteScalar();
            conn.Close();
            return val1;
        }

        //*********************** loading and placeing also controling side panel ************
        //using database
        public void sidePanel_config()
        {
            int i = 1;
            SqlConnection conn = new SqlConnection(myconstring);
            conn.Open();
            for (i = 1; i <= 50; i++)
            {

                string sql = "Select ID from UserTables Where ID=" + i + "and Name='" + LogIncs.setText + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                string nam1 = UName(i);

                if (dtbl.Rows.Count == 1)
                {
                    if (i == 50 && UName(i) == LogIncs.setText)
                    {
                        //panel50.Show();
                        //User50_btn.Show();
                        //User50_leb.Show();
                        //User50_leb.Text = Fname(i);
                        //User50_btn.Image = new Bitmap(Clintimg_Load(i));
                    }
                }

            }
            conn.Close();
        }

        //*****************All the clint button clicking event *****************************
        private void User1_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(1);
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            SidePanel.Width = 0;
            GetFormInPanel(ar);
        }
        

        //initial built for first time.
        //will optimized later.
        //------------------------------------------Theme load--------------------------------------
        public void userpan(int x, int y, int z)
        {
            //panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            
        }

        public void moodules(int x, int y, int z)
        {
            userpan(x, y, z);
            AdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Home_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            AddClint_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            StatisticBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Reset_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            About_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Refreshbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
        }

        public void light()
        {
            moodules(30, 144, 255);
            //moodules(197, 202,233 );
        }

        public void Dark()
        {
            moodules(100, 100, 100);
        }
        public void DarkSlateGray()
        {
            moodules(47, 79, 79);
        }
        public void Teal()
        {
            moodules(0, 128, 128);
        }
        public void Crimson()
        {
            moodules(220, 20, 60);
        }
        public void RedMaroon()
        {
            moodules(255, 69, 0);
        }
        //---------------------------------------------End------------------------------------------
        public string SetThemes()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Themes from Admin Where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string fn = (string)cmd.ExecuteScalar();
            conn.Close();
            return fn;
        }
        public void ThemeLoad()
        {
            if (SetThemes() == "Light")
            {
                light();
            }
            else if (SetThemes() == "Dark")
            {
                Dark();
            }
            else if (SetThemes() == "DarkSlateGray")
            {
                DarkSlateGray();
            }
            else if (SetThemes() == "Teal")
            {
                Teal();
            }
            else if (SetThemes() == "Crimson")
            {
                Crimson();
            }
            else if (SetThemes() == "RedMaroon")
            {
                RedMaroon();
            }
            else
            {
                light();
            }
        }

        //------------------------------------------------Checking Trial--------------------------------------------
        public void StartCondition()
        {
            re.getRemainingTrialDay();
            if (re.checkVer() == "trial")
            {
                DialogResult dr = MessageBox.Show("You have " + (30 - re.trialDay).ToString() + " Days Trial remaining\n" +
                    "Would you like to buy now.!", "Trial", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    new BuyNow().ShowDialog();
                }
            }
            else
            {

            }
        }
    }
}
