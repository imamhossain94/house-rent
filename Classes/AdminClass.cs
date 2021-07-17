using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent.Classes
{
    class AdminClass
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }

        public byte[] image;

        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool insert(AdminClass log)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);

            string sql = "INSERT INTO Admin(Name,Email,Password,DOB,Gender,Image) values(@Name,@Email,@Password,@DOB,@Gender,@Image)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", log.name);
            cmd.Parameters.AddWithValue("@Email", log.email);
            cmd.Parameters.AddWithValue("@Password", log.password);
            cmd.Parameters.AddWithValue("@DOB", log.dob);
            cmd.Parameters.AddWithValue("@Gender", log.gender);
            cmd.Parameters.AddWithValue("@Image", log.image);
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
