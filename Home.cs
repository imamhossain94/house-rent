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
   
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void Home_Search_btn_TextChanged(object sender, EventArgs e)
        {
            string keyword = Home_Search_box.Text;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT U_Name, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' and (U_Name LIKE '%" + keyword + "%' OR Month LIKE '%" + keyword + "%'OR Year LIKE '%" + keyword + "%')", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MainDataGardView.DataSource = dt;
        }

        private void Home_srch_ins_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search keyword: \nU_Name, Month, Year.");
        }

        public void rlod()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT U_Name, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MainDataGardView.DataSource = dt;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            rlod();
        }
    }
}
