using System;
using System.Collections;
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

namespace House_Rent.StatisticUI
{
    public partial class StatisticPanel : Form
    {
        public StatisticPanel()
        {
            InitializeComponent();

            DashBoardPanel.AutoScroll = false;
            DashBoardPanel.VerticalScroll.Enabled = false;
            DashBoardPanel.VerticalScroll.Visible = false;
            DashBoardPanel.VerticalScroll.Maximum = 0;
            DashBoardPanel.HorizontalScroll.Maximum = 0;
            DashBoardPanel.AutoScroll = true;
        }

        public Dictionary<string, int> list = new Dictionary<string, int>();
        public Dictionary<string, int> list1 = new Dictionary<string, int>();
        public int jan = 0, feb = 0, mar = 0, apr = 0, may = 0, jun = 0, jly = 0, agu = 0, sep = 0, oct = 0, nov = 0, dec = 0;
        public int jan1 = 0, feb1 = 0, mar1 = 0, apr1 = 0, may1 = 0, jun1 = 0, jly1 = 0, agu1 = 0, sep1 = 0, oct1 = 0, nov1 = 0, dec1 = 0;

        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        private void MenuButton_Click(object sender, EventArgs e)
        {
            /*
            if(MenuPanel.Width == 250)
            {
                MenuPanel.Width = 60;
            }
            else
            {
                MenuPanel.Width = 250;
            }
            */
        }

        private void StatisticPanel_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
            }
            catch
            {

            }
            
        }

        void RefreshData()
        {
            TotalTenants.Text = TotalTenantFn().ToString();
            CurrentTenants.Text = CurrentTenantFn().ToString();
            VipTenants.Text = VipTenantFn().ToString();
            TenantsOnDue.Text = TenantOnDueFn().ToString();

            if (TotalAmmountFn() > 0)
            {
                TotalAmmount.Text = TotalAmmountFn().ToString();
            }
            else
            {
                TotalAmmount.Text = "0";
            }

            if (ReceivedAmmountFn() > 0)
            {
                ReceivedAmmount.Text = ReceivedAmmountFn().ToString();
            }
            else
            {
                ReceivedAmmount.Text = "0";
            }
            
            if (TotalProfitFn() > 0)
            {
                TotalProfit.Text = TotalProfitFn().ToString();
            }
            else
            {
                TotalProfit.Text = "0";
            }

            if (DueAmmountFn() > 0)
            {
                DueAmmount.Text = DueAmmountFn().ToString();
            }
            else
            {
                DueAmmount.Text = "0";
            }
            UpdateReceived();
            UpdateProfit();
            ReceivedAmountChart();
            ProfitAmountChart();
        }

        public int TotalTenantFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTables where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }
        public int CurrentTenantFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTables where Name='"+ LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        public int VipTenantFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTables where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        public int TenantOnDueFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalRent)-SUM(ReceivedAmmount) FROM RecordTab where Name='" + LogIncs.setText + "' GROUP BY U_Name");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int[] Array = new int[10000];
            int i = 0;
            while (reader.Read())
            {
                Array[i] = Convert.ToInt32(reader.GetValue(0));
                i++;
            }
            reader.Close();
            int count = 0;
            for(i=0; i<Array.Length; i++)
            {
                if (Array[i] < 0)
                    count++;
            }

            return count;
        }

        public int TotalAmmountFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalRent)FROM RecordTab where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        public int ReceivedAmmountFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT SUM(ReceivedAmmount)FROM RecordTab where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        public int TotalProfitFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT (SUM(ReceivedAmmount)-(SUM(ElectricBill)+SUM(GasBill)+SUM(WaterBill)))FROM RecordTab where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }

        public int DueAmmountFn()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT (SUM(TotalRent)-SUM(ReceivedAmmount))FROM RecordTab where Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }


        private void UpdateReceived()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT Month,SUM(ReceivedAmmount) FROM RecordTab where Name='" + LogIncs.setText + "' group by Month");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString(), Convert.ToInt32(reader.GetValue(1)));
            }
            reader.Close();
            for (int i = 0; i < list.Count; i++)
            {
                if(list.Keys.ElementAt(i) == "January")
                {
                    jan = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "February")
                {
                    feb = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "March")
                {
                    mar = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "April")
                {
                    apr = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "May")
                {
                    may = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "June")
                {
                    jun = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "July")
                {
                    jly = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "August")
                {     
                    agu = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "September")
                {
                    sep = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "October")
                {
                    oct = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "November")
                {
                    nov = list[list.Keys.ElementAt(i)];
                }
                else if (list.Keys.ElementAt(i) == "December")
                {
                    dec = list[list.Keys.ElementAt(i)];
                }

            }
            list.Clear();
        }

        private void ReceivedAmountChart()
        {
            AmountChart.Series["Received"].Points.AddXY("JAN", jan);
            AmountChart.Series["Received"].Points.AddXY("FEB", feb);
            AmountChart.Series["Received"].Points.AddXY("MAR", mar);
            AmountChart.Series["Received"].Points.AddXY("APR", apr);
            AmountChart.Series["Received"].Points.AddXY("MAY", may);
            AmountChart.Series["Received"].Points.AddXY("JUN", jun);
            AmountChart.Series["Received"].Points.AddXY("JUL", jly);
            AmountChart.Series["Received"].Points.AddXY("AUG", agu);
            AmountChart.Series["Received"].Points.AddXY("SEP", sep);
            AmountChart.Series["Received"].Points.AddXY("OCT", oct);
            AmountChart.Series["Received"].Points.AddXY("NOV", nov);
            AmountChart.Series["Received"].Points.AddXY("DEC", dec);
        }

        private void UpdateProfit()
        {

            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("SELECT Month,(SUM(ReceivedAmmount)-(SUM(ElectricBill)+SUM(GasBill)+SUM(WaterBill))) FROM RecordTab where Name='" + LogIncs.setText + "' group by Month");
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list1.Add(reader.GetValue(0).ToString(), Convert.ToInt32(reader.GetValue(1)));
            }
            reader.Close();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1.Keys.ElementAt(i) == "January")
                {
                    jan1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "February")
                {
                    feb1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "March")
                {
                    mar1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "April")
                {
                    apr1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "May")
                {
                    may1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "June")
                {
                    jun1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "July")
                {
                    jly1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "August")
                {
                    agu1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "September")
                {
                    sep1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "October")
                {
                    oct1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "November")
                {
                    nov1 = list1[list1.Keys.ElementAt(i)];
                }
                else if (list1.Keys.ElementAt(i) == "December")
                {
                    dec1 = list1[list1.Keys.ElementAt(i)];
                }

            }
            list1.Clear();
        }

        private void ProfitAmountChart()
        {
            ProfitChart.Series["Profit"].Points.AddXY("JAN", jan1);
            ProfitChart.Series["Profit"].Points.AddXY("FEB", feb1);
            ProfitChart.Series["Profit"].Points.AddXY("MAR", mar1);
            ProfitChart.Series["Profit"].Points.AddXY("APR", apr1);
            ProfitChart.Series["Profit"].Points.AddXY("MAY", may1);
            ProfitChart.Series["Profit"].Points.AddXY("JUN", jun1);
            ProfitChart.Series["Profit"].Points.AddXY("JUL", jly1);
            ProfitChart.Series["Profit"].Points.AddXY("AUG", agu1);
            ProfitChart.Series["Profit"].Points.AddXY("SEP", sep1);
            ProfitChart.Series["Profit"].Points.AddXY("OCT", oct1);
            ProfitChart.Series["Profit"].Points.AddXY("NOV", nov1);
            ProfitChart.Series["Profit"].Points.AddXY("DEC", dec1);
        }

        private void RefreshProfit_Click(object sender, EventArgs e)
        {
            //ProfitChart.Series.Clear();
            UpdateProfit();
            //ProfitAmountChart();
        }

        private void RefreshAmmount_Click(object sender, EventArgs e)
        {
            //AmountChart.Series.Clear();
            UpdateReceived();
            //ReceivedAmountChart();
        }
    }
}
