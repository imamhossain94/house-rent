using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent.Classes
{
    class ClintClasscs
    {
        public int id;
        public byte[] image;
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string contactno { get; set; }
        public string gender { get; set; }
        public string joinmonth { get; set; }
        public string dob { get; set; }
        public string flat { get; set; }
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool insert(ClintClasscs user)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "INSERT into UserTables (ID,Flat,FirstName,LastName,UserEmail,ContactNo,Gender,JoiningMonth,DOB,UserImage,Name) values(@ID,@Flat,@FirstName,@LastName,@UserEmail,@ContactNo,@Gender,@JoiningMonth,@DOB,@UserImage,@Name)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", user.id);
            cmd.Parameters.AddWithValue("@Flat", user.flat);
            cmd.Parameters.AddWithValue("@FirstName", user.firstname);
            cmd.Parameters.AddWithValue("@LastName", user.lastname);
            cmd.Parameters.AddWithValue("@UserEmail", user.email);
            cmd.Parameters.AddWithValue("@ContactNo", user.contactno);
            cmd.Parameters.AddWithValue("@Gender", user.gender);
            cmd.Parameters.AddWithValue("@JoiningMonth", user.joinmonth);
            cmd.Parameters.AddWithValue("@DOB", user.dob);            
            cmd.Parameters.AddWithValue("@UserImage", user.image);
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


        public int Max_Value()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select MAX(ID) from UserTables");
            cmd.Connection = conn;
            conn.Open();
            int tranlab = (int)cmd.ExecuteScalar();

            //resultsDT.Rows[currentRow["TranLab"] == null

            int tranint = tranlab;
            conn.Close();

            return tranint;
        }

    }
}
