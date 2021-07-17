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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent
{
    public partial class AddRecord : Form
    {
        public int n;
        public AddRecord()
        {
            InitializeComponent();

        }

        private void User_Profile_lab_Click(object sender, EventArgs e)
        {
            upd_hide();
            clear();

            User_Name_bar_lab.Hide();
            Update_bar_lab.Hide();
            profile_bar_lab.Show();

            Update_panel.Hide();
            Main_panel.Hide();
            Profile_panel.Show();
        }

        private void User_update_lab_Click(object sender, EventArgs e)
        {
            clear();
            profile_bar_lab.Hide();
            User_Name_bar_lab.Hide();
            Update_bar_lab.Show();

            Main_panel.Hide();
            Profile_panel.Hide();
            Update_panel.Show();
        }

        private void User_name_lab_Click(object sender, EventArgs e)
        {
            upd_hide();
            clear();

            Update_bar_lab.Hide();
            profile_bar_lab.Hide();
            User_Name_bar_lab.Show();

            Profile_panel.Hide();
            Update_panel.Hide();
            Main_panel.Show();
        }


        public string user_lab;
        public string labelText { get { return user_lab; } set { user_lab = value; } }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            user_name_lab.Text = labelText; 
            Update_bar_lab.Hide();
            profile_bar_lab.Hide();
            insert_S_No.Enabled = false;
            recordLoad();
            upd_hide();
            profile_load();
        }

        private void ID_ins_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dont Worry!!\nSerial No will generate atomatically. ");
        }
        //
        //main panel
        //
        private void Insert_house_Click(object sender, EventArgs e)
        {
            insert_house.Text = "";
        }

        private void Insert_electric_Click(object sender, EventArgs e)
        {
            insert_electric.Text = "";
        }

        private void Insert_gas_Click(object sender, EventArgs e)
        {
            insert_gas.Text = "";
        }

        private void Insert_water_Click(object sender, EventArgs e)
        {
            insert_water.Text = "";
        }

        private void Delete_id_Click(object sender, EventArgs e)
        {
            Delete_id.Text = "";
        }

        private void Cllear_btn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Serial No to delete records!");
        }
        //
        //update panel
        //
        private void Update_sno_Click(object sender, EventArgs e)
        {
            update_sno.Text = "";
        }

        private void Update_houseRent_Click(object sender, EventArgs e)
        {
            update_houseRent.Text = "";
        }

        private void Update_electric_Click(object sender, EventArgs e)
        {
            update_electric.Text = "";
        }

        private void Update_gas_Click(object sender, EventArgs e)
        {
            Update_gas.Text = "";
        }

        private void Update_water_Click(object sender, EventArgs e)
        {
            update_water.Text = "";
        }

        private void Update_totalRent_Click(object sender, EventArgs e)
        {
            update_totalRent.Text = "";
        }

        private void Update_recAmnt_Click(object sender, EventArgs e)
        {
            update_recAmnt.Text = "";
        }

        private void Update_dueAmnt_Click(object sender, EventArgs e)
        {
            update_dueAmnt.Text = "";
        }
        //
        //set all form to initial state
        //
        public void clear()
        {
            //main panel
            insert_cmbMonth.Text = "Month";
            insert_cmbYear.Text = "Year";
            insert_house.Text = "House Rent";
            insert_electric.Text = "Electric Bill";
            insert_gas.Text = "Gas Bill";
            insert_water.Text = "Water Bill";
            Delete_id.Text = "S.No.";
            insert_due.Text = "";
            insert_RecAmnt.Text = "";
            insert_ttlRent.Text = "";

            //update panel
            update_sno.Text = "S. No.";
            update_houseRent.Text = "House Rent";
            update_electric.Text = "Electric Bill";
            Update_gas.Text = "Gas Bill";
            update_water.Text = "Water Bill";
            update_totalRent.Text = "Total Rent";
            update_recAmnt.Text = "Received Ammount";
            update_dueAmnt.Text = "Due Ammount";
            update_questio.Text = "What do you what to update?";
            getValues.Text = "";
            getYears.Text = "Year";
            getMonth.Text = "Month";

        }

        Recordscs r = new Recordscs();
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            r.rec_name = labelText.Trim();
            r.rec_month = insert_cmbMonth.Text;
            r.rec_year = insert_cmbYear.Text;
            r.houseRent = Convert.ToInt32(insert_house.Text);
            r.electric = Convert.ToInt32(insert_electric.Text);
            r.gas = Convert.ToInt32(insert_gas.Text);
            r.water = Convert.ToInt32(insert_water.Text);
            r.total = Convert.ToInt32(insert_ttlRent.Text);
            r.received = Convert.ToInt32(insert_RecAmnt.Text);
            r.due = Convert.ToInt32(insert_due.Text);

            bool success = r.insert(r);

            if (success == true)
            {
                recordLoad();
                MessageBox.Show("New Records Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add Records! \nTry Again.");
            }

        }


        //need to be fixed
        private void Insert_ttlRent_TextChanged(object sender, EventArgs e)
        {
            insert_ttlRent.Text = (Convert.ToInt32(insert_house.Text) + Convert.ToInt32(insert_electric.Text) + Convert.ToInt32(insert_gas.Text) + Convert.ToInt32(insert_water.Text)).ToString();
        }

        private void Insert_due_TextChanged(object sender, EventArgs e)
        {
            insert_due.Text = (Convert.ToInt32(insert_ttlRent.Text) - Convert.ToInt32(insert_RecAmnt.Text)).ToString();
        }
        // fixed area closed


        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public void recordLoad()
        {
            string keyword = Clint_searchBox.Text;

            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S_No, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText+ "' and U_Name='" + labelText.Trim()+ "'", conn) ;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Clint_GardView.DataSource = dt;
        }
        private void Clint_searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = Clint_searchBox.Text;

            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S_No, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "' and (Month LIKE '%" + keyword + "%' or Year LIKE '%" + keyword + "%' )", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Clint_GardView.DataSource = dt;
        }

        public void upd_hide()
        {
            update_month.Hide();
            update_year.Hide();
            update_houseRent.Hide();
            update_electric.Hide();
            Update_gas.Hide();
            update_water.Hide();
            update_totalRent.Hide();
            update_recAmnt.Hide();
            update_dueAmnt.Hide();
            getValues.Hide();
            getMonth.Hide();
            getYears.Hide();
            update_questio.Hide();
            con_update.Hide();
        }
        public void upd_show()
        {
            update_month.Show();
            update_year.Show();
            update_houseRent.Show();
            update_electric.Show();
            Update_gas.Show();
            update_water.Show();
            update_totalRent.Show();
            update_recAmnt.Show();
            update_dueAmnt.Show();
        }

        public string dd;
        public string chouse()
        {
            string choice = update_questio.Text;
            string choice_upd;

            if (choice == "All")
            {
                getValues.Hide();
                getMonth.Hide();
                getYears.Hide();

                upd_show();
                return "All";
            }
            if (choice == "Month")
            {
                upd_hide();
                getValues.Hide();
                getMonth.Show();
                
                return "Month";
            }
            if (choice == "Year")
            {
                upd_hide();
                getValues.Hide();
                getYears.Show();
                return "Year";
            }
            else
            {
                upd_hide();
                getValues.Show();
                choice_upd = update_questio.Text;
                getValues.Text = "Enter "+ update_questio.Text;
                return choice_upd;
            }
            
        }

        private void Con_update_Click(object sender, EventArgs e)
        {
            if(update_questio.Text == "What do you what to update?")
            {
                MessageBox.Show("Please select an option.");
            }
            else
            {
                dd = chouse();
            }
   
        }
        // need to be added. auto calculation
        private void Update_Confirm_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstring);

            int s_no = Convert.ToInt32(update_sno.Text);
            if (dd== "All")
            {
                string sql = "UPDATE RecordTab SET Month=@Month,Year=@Year,HouseRent=@HouseRent,ElectricBill=@ElectricBill,GasBill=@GasBill,WaterBill=@WaterBill,TotalRent=@TotalRent,ReceivedAmmount=@ReceivedAmmount,DueAmmount=@DueAmmount where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Month", update_month.Text);
                cmd.Parameters.AddWithValue("@Year", update_year.Text);
                cmd.Parameters.AddWithValue("@HouseRent", update_houseRent.Text);
                cmd.Parameters.AddWithValue("@ElectricBill", update_electric.Text);
                cmd.Parameters.AddWithValue("@GasBill", Update_gas.Text);
                cmd.Parameters.AddWithValue("@WaterBill", update_water.Text);
                cmd.Parameters.AddWithValue("@TotalRent", update_totalRent.Text);
                cmd.Parameters.AddWithValue("@ReceivedAmmount", update_recAmnt.Text);
                cmd.Parameters.AddWithValue("@DueAmmount", update_dueAmnt.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if(dd == "Month")
            {
                string sql = "UPDATE RecordTab SET Month=@Month where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Month", getMonth.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd+" Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "Year")
            {
                string sql = "UPDATE RecordTab SET Year=@Year where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", getYears.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "HouseRent")
            {
                string sql = "UPDATE RecordTab SET HouseRent=@HouseRent where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HouseRent", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "ElectricBill")
            {
                string sql = "UPDATE RecordTab SET ElectricBill=@ElectricBill where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ElectricBill", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "GasBill")
            {
                string sql = "UPDATE RecordTab SET GasBill=@GasBill where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@GasBill", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "WaterBill")
            {
                string sql = "UPDATE RecordTab SET WaterBill=@WaterBill where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@WaterBill", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "TotalRent")
            {
                string sql = "UPDATE RecordTab SET TotalRent=@TotalRent where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TotalRent", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "ReceivedAmmount")
            {
                string sql = "UPDATE RecordTab SET ReceivedAmmount=@ReceivedAmmount where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReceivedAmmount", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "DueAmmount")
            {
                string sql = "UPDATE RecordTab SET DueAmmount=@DueAmmount where S_No=s_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DueAmmount", getValues.Text);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    MessageBox.Show(dd + " Updated successfully!");
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Something Error Occurs!");
            }

        }

        private void GetValues_Click(object sender, EventArgs e)
        {
            getValues.Text = "";
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "DELETE from RecordTab WHERE S_No=@S_No";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@S_No", Delete_id.Text);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                recordLoad();
                MessageBox.Show("Record deleted!");
            }
            else
            {
                MessageBox.Show("Record not deleted!\nPlease check Serial No.");
            }
        }

        // fixing zone start.................................................................
        public int id_load()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ID from UserTables Where FirstName='" + labelText + "' and Name='"+LogIncs.setText+"'");
            cmd.Connection = conn;
            conn.Open();
            int TranLab = (int)cmd.ExecuteScalar();
            conn.Close();
            return TranLab;
        }

        public string fname_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select FirstName from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string Fname = (string)cmd.ExecuteScalar();
            conn.Close();

            return Fname;
        }

        public string lname_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select LastName from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string lname = (string)cmd.ExecuteScalar();
            conn.Close();

            return lname;
        }

        public string emil_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select UserEmail from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string eml = (string)cmd.ExecuteScalar();
            conn.Close();

            return eml;
        }

        public string contno_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ContactNo from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string cn = (string)cmd.ExecuteScalar();
            conn.Close();

            return cn;
        }

        public string gen_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Gender from UserTables Where ID=" + x + " and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string gen = (string)cmd.ExecuteScalar();
            conn.Close();

            return gen;
        }

        public string joinmon_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select JoiningMonth from UserTables Where ID=" + x + " and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string joinm = (string)cmd.ExecuteScalar();
            conn.Close();

            return joinm;
        }

        public string dob_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select DOB from UserTables Where ID=" + x + " and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string dob = (string)cmd.ExecuteScalar();
            conn.Close();

            return dob;
        }

        public string fltno_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Flat from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            string fn = (string)cmd.ExecuteScalar();
            conn.Close();

            return fn;
        }

        public int ttlPaid_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select sum(ReceivedAmmount) as ttlsum From RecordTab where name = '"+labelText+ "'and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            int fn = (int)cmd.ExecuteScalar();
            conn.Close();
            return fn;
        }

        public int ttlRnt_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select sum(TotalRent) as ttlsum From RecordTab where name = '" + labelText + "'and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            int fn = (int)cmd.ExecuteScalar();
            conn.Close();
            return fn;
        }

        public void img_Load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select UserImage from UserTables Where ID=" + x + "and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count>0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["UserImage"]);
                prop_picBox.Image = new Bitmap(ms);
            }
            conn.Close();
        }

        public void profile_load()
        {
            prop_id_leb.Text = Convert.ToString(id_load());
            prop_name_leb.Text = fname_load() +" "+ lname_load();
            prop_email_leb.Text = emil_load();
            prop_contact_leb.Text = contno_load();
            prop_gender_leb.Text = gen_load();
            prop_joinMnth_leb.Text = joinmon_load();
            prop_dob_leb.Text = dob_load();
            prop_flat_leb.Text = fltno_load();
            img_Load();
            //prop_Tpaid_leb.Text = Convert.ToString(ttlPaid_load());
            //prop_Tdue_leb.Text = Convert.ToString(ttlRnt_load() - ttlPaid_load());
        }

        //fixing zone end....................................................................Done....
        private void Srl_ok_btn_Click(object sender, EventArgs e)
        {
            int val;
            if(!int.TryParse(update_sno.Text, out val))
            {
                MessageBox.Show("Please Enter Serial Number.");
            }
            else
            {
                update_questio.Show();
                con_update.Show();
            }
            
        }

        private void ADD_srch_ins_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter year to search.");
        }

        private void InsSno_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Serial No.");
        }
    }
}
