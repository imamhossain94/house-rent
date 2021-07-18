using DGVPrinterHelper;
using House_Rent.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        //search box instruction button------------------------
        private void Home_srch_ins_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search keyword: \nU_Name, Month, Year.");
        }

        //Search box text changed------------------------------
        private void Home_Search_btn_TextChanged(object sender, EventArgs e)
        {
            string keyword = Home_Search_box.Text;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT U_Name, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' and (U_Name LIKE '%" + keyword + "%' OR Month LIKE '%" + keyword + "%'OR Year LIKE '%" + keyword + "%')", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MainDataGardView.DataSource = dt;
        }

        //Reloading all data from batabase---------------------
        public void reload()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT U_Name, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MainDataGardView.DataSource = dt;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ThemeLoad();
            reload();
        }

        //------------------------------------------Theme load--------------------------------------
        public void moodules(int x, int y, int z)
        {
            this.Home_Search_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
        }
        public void light()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            moodules(30, 144, 255);
        }

        public void Dark()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            moodules(100, 100, 100);
        }
        public void DarkSlateGray()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            moodules(47, 79, 79);
        }
        public void Teal()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            moodules(0, 128, 128);
        }
        public void Crimson()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            moodules(220, 20, 60);
        }
        public void RedMaroon()
        {
            this.MainDataGardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
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

        private void HomePrintButton_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();

            p.Title = "Agun";
            p.SubTitle = "Agun State";
            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            p.PageNumbers = true;
            p.PageNumberInHeader = false;
            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "Type: " + "All Document" + "% \r\n" + "VAT: " + "";
            p.FooterSpacing = 15;
            p.PrintDataGridView(MainDataGardView);
        }
        //---------------------------------------------next steps-----------------------------------------

    }
}
