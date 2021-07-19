using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using House_Rent.Classes;
using House_Rent.Profil;
using House_Rent.SettingsUI;
using House_Rent.StatisticUI;
using House_Rent.UI;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class HouseRentMain : Form
    {


        public HouseRentMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            TenantsDotMenu.Hide();
            MessageDotMenu.Hide();
            
        }
        public static int size;
        public int[] Array;


        //*************************Borderless winform resizable*****************************
        private const int cGrip = 17;
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


        RegistryMd5 re = new RegistryMd5();
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public static string ClickedEvent;


       

        //*************************************Button Click event*******************************


        //-------------------------Top Panel Button--------------------------------//
        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (SidePanelTenant.Width == 65)
            {
                SidePanelTenant.Width = 250;
                SidePanelTenants.Location = new System.Drawing.Point(0, 225);
                SidePanelTenants.Size = new System.Drawing.Size(250, 550);
            }
            else
            {
                SidePanelTenant.Width = 65;
                SidePanelTenants.Location = new System.Drawing.Point(0, 0);
                SidePanelTenants.Size = new System.Drawing.Size(250, 770);
            }
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            if (SidePanelMessage.Width == 65)
            {
                SidePanelMessage.Width = 250;
                SidePanelMessae.Location = new System.Drawing.Point(0, 225);
                SidePanelMessae.Size = new System.Drawing.Size(250, 550);
            }
            else
            {
                SidePanelMessage.Width = 65;
                SidePanelMessae.Location = new System.Drawing.Point(0, 0);
                SidePanelMessae.Size = new System.Drawing.Size(250, 770);
            }
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new Home());
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            new Resetpanel().ShowDialog();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new StatisticPanel());

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingPanel().ShowDialog();
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            new AboutUs().ShowDialog();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIncs().ShowDialog();
            this.Dispose();
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeMinimizeButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void AppCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        //------------------------------Left Panel-------------------------------------//
        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            ClickedEvent = "Admin";
            new UserProfile().ShowDialog();
        }
        private void LeftDot_Click(object sender, EventArgs e)
        {
            if(TenantsDotMenu.Visible == true)
            {
                TenantsDotMenu.Hide();
            }
            else
            {
                TenantsDotMenu.Show();
            }
        }

        private void TenantDelete_Click(object sender, EventArgs e)
        {

        }

        private void TenantEdit_Click(object sender, EventArgs e)
        {

        }

        private void TenantSettings_Click(object sender, EventArgs e)
        {

        }

        private void AddTenantButton_Click(object sender, EventArgs e)
        {
            GetFormInPanel(new ClintsPanel());
        }

        //------------------------------Right Panel-------------------------------------//
        private void RightDot_Click(object sender, EventArgs e)
        {
            if (MessageDotMenu.Visible == true)
            {
                MessageDotMenu.Hide();
            }
            else
            {
                MessageDotMenu.Show();
            }
        }

        private void MessageDelete_Click(object sender, EventArgs e)
        {

        }

        private void MessageEdit_Click(object sender, EventArgs e)
        {

        }

        private void MessageSettings_Click(object sender, EventArgs e)
        {

        }

        private void CreateMessageButton_Click(object sender, EventArgs e)
        {

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
            if (this.LoadAnotherForm.Controls.Count > 0)
                this.LoadAnotherForm.Controls.RemoveAt(0);
            Form fh = FormInP as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.LoadAnotherForm.Controls.Add(fh);
            this.LoadAnotherForm.Tag = fh;
            fh.Show();
        }




        //***************************loading some modules at start******************************
        private void HouseRentMain_Load(object sender, EventArgs e)
        {
            size = max();
            Array = new int[size];
            AllTenants();
            //MessageBox.Show(size.ToString());
            //Loading apps theme.
            ThemeLoad();
            ProfileName.Text = LogIncs.setText;
            //hiding all the panel at the start then,


            // calling this function to check clint presents in database.
            //sidePanel_config();

            //loading admin image from database.
            img_Load();

            //importing admin name from login form as static string
            //Admin_leb.Text = LogIncs.setText.ToUpper();

            //to add round corner at clint panel

            SidePanelTenants.AutoScroll = false;
            SidePanelTenants.VerticalScroll.Enabled = false;
            SidePanelTenants.VerticalScroll.Visible = false;
            SidePanelTenants.VerticalScroll.Maximum = 0;
            SidePanelTenants.HorizontalScroll.Maximum = 0;
            SidePanelTenants.AutoScroll = true;


            //loading home tab into main apps panel
            GetFormInPanel(new StatisticPanel());
            
            StartCondition();

            for (int i = 0; i < Array.Length; i++)
            {
                BunifuPictureBox b = CreateButton(Array[i]);
                Label l = CreateLabel(Array[i]);
                Panel p = CreatePanel(Array[i]);
                p.Controls.Add(b);
                p.Controls.Add(l);
                SidePanelTenants.Controls.Add(p);

                b.Click += new System.EventHandler(ButtonClick);
                //p.Click += new System.EventHandler(onlClk);
                l.Click += new System.EventHandler(LabelClick);

            }


        }


        
        public int AllTenants()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select ID from UserTables where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //int[] Array = new int[1000000];
            int i = 0;
            while (reader.Read())
            {
                Array[i] = Convert.ToInt32(reader.GetValue(0));
                i++;
            }
            reader.Close();
            int count = 0;
            for (i = 0; i < Array.Length; i++)
            {
                if (Array[i] < 0)
                    count++;
            }
            return count;
        }

        //*******************************Hiding both horizontal&vertical scrollbar 
        //*********Without disabling it.
        //*** also hiding clint panel. this function is called at starting.

        void ButtonClick(Object sender, EventArgs e)
        {
            BunifuPictureBox bp = (BunifuPictureBox)sender;
            string x = bp.Text;
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            //SidePanel2.Width = 0;
            GetFormInPanel(ar);

        }

        void LabelClick(Object sender, EventArgs e)
        {
            Label l = (Label)sender;
            string x = l.Text;
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            //SidePanel2.Width = 0;
            GetFormInPanel(ar);
        }

       

        Panel CreatePanel(int i)
        {
            Panel p = new Panel();
            BunifuElipse be = new BunifuElipse();
            //p.Controls.Add(CreateButton(i));
            //p.Controls.Add(CreateLabel(i));
            //be.ApplyElipse(p, 10);
            p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            //p.Location = new System.Drawing.Point(10, 10);
            //p.BackColor = Color.Brown;
            p.Margin = new System.Windows.Forms.Padding(0,1,1,0);
            p.Name = "add_tenant_pnl"+i;
            p.Text = Fname(i); ;
            p.Size = new System.Drawing.Size(250, 47);
            p.TabIndex = 0;
            return p;
        }

        Label CreateLabel(int i)
        {
            Label p = new Label();
            p.Size = new System.Drawing.Size(100, 30);
            p.Cursor = System.Windows.Forms.Cursors.Hand;
            p.Font = new System.Drawing.Font("Dosis", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            p.ForeColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point(60, 8);
            p.Name = "add_tenant_lbl"+i;
            p.Size = new System.Drawing.Size(177, 30);
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
            bp.Image = new Bitmap(Clintimg_Load(i));
            bp.IsCircle = true;
            bp.Location = new System.Drawing.Point(7, 2);
            bp.Name = "add_tenant_btn"+i;
            bp.Text = Fname(i); ;
            bp.Size = new System.Drawing.Size(45, 45);
            bp.Margin = new System.Windows.Forms.Padding(2);
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
                ProfilePicture.Image = new Bitmap(ms);
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
       

        //*****************All the clint button clicking event *****************************
        private void User1_btn_Click(object sender, EventArgs e)
        {
            string x = Fname(1);
            AddRecords ar = new AddRecords();
            ar.labelText = x;
            //SidePanel2.Width = 0;
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
            //AdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //Home_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //AddClint_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //StatisticBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //Reset_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //About_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            //Refreshbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
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
