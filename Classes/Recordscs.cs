using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent.Classes
{
    class Recordscs
    {
        public string rec_name { get; set; }
        public string rec_month { get; set; }
        public string rec_year { get; set; }

        public int houseRent;
        public int electric;
        public int gas;
        public int water;
        public int total;
        public int received;
        public int due;


        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool insert(Recordscs rc)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "INSERT into RecordTab (U_Name,Month,Year,HouseRent,ElectricBill,GasBill,WaterBill,TotalRent,ReceivedAmmount,DueAmmount,Name) Values(@U_Name,@Month,@Year,@HouseRent,@ElectricBill,@GasBill,@WaterBill,@TotalRent,@ReceivedAmmount,@DueAmmount,@Name)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@U_Name", rc.rec_name);
            cmd.Parameters.AddWithValue("@Month", rc.rec_month);
            cmd.Parameters.AddWithValue("@Year", rc.rec_year);
            cmd.Parameters.AddWithValue("@HouseRent", rc.houseRent);
            cmd.Parameters.AddWithValue("@ElectricBill", rc.electric);
            cmd.Parameters.AddWithValue("@GasBill", rc.gas);
            cmd.Parameters.AddWithValue("@WaterBill", rc.water);
            cmd.Parameters.AddWithValue("@TotalRent", rc.total);
            cmd.Parameters.AddWithValue("@ReceivedAmmount", rc.received);
            cmd.Parameters.AddWithValue("@DueAmmount", rc.due);
            cmd.Parameters.AddWithValue("@Name", LogIncs.setText);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
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






    }
}
