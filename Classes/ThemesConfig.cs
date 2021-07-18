using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent.Classes
{
    class ThemesConfig
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public string ThemesID { get; set; }

        public bool SetThemesID(ThemesConfig TC)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "UPDATE Admin SET Themes=@Theme where Name=@Name";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Theme", TC.ThemesID);
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
