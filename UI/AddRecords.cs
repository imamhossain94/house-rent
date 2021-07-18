using DGVPrinterHelper;
using House_Rent.Classes;
using House_Rent.Profil;
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
    public partial class AddRecords : Form
    {
        public AddRecords()
        {
            InitializeComponent();
        }
        public string dd;
        public string user_lab;
        public static string username;
        public string labelText { get { return user_lab; } set { user_lab = value; } }
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        Recordscs r = new Recordscs();
        //-----------------------------Button Clicked event------------------------
        private void AddRec_Click(object sender, EventArgs e)
        {
            Profile_panel.Hide();
            deletePanel.Hide();
            Update_panel.Hide();
            if (Main_panel.Visible == false)
            {
                Main_panel.Show();
            }
            else
            {
                Main_panel.Hide();
            }
        }
        private void UpdRec_Click(object sender, EventArgs e)
        {
            Profile_panel.Hide();
            deletePanel.Hide();
            Main_panel.Hide();
            if (Update_panel.Visible == false)
            {
                clear();
                Update_panel.Show();
            }
            else
            {
                Update_panel.Hide();
            }
        }
        private void HomeRec_Click(object sender, EventArgs e)
        {
            clear();
            Update_panel.Hide();
            Profile_panel.Hide();
            deletePanel.Hide();
            Update_panel.Hide();
            Main_panel.Hide();
        }
        private void DelRec_Click(object sender, EventArgs e)
        {
            Delete_id.Text = "S.No.";

            Profile_panel.Hide();
            Update_panel.Hide();
            Main_panel.Hide();
            if (deletePanel.Visible == false)
            {
                deletePanel.Show();
            }
            else
            {
                deletePanel.Hide();
            }
        }
        private void ProfRec_Click(object sender, EventArgs e)
        {
            deletePanel.Hide();
            Update_panel.Hide();
            Main_panel.Hide();
            if (Profile_panel.Visible == false)
            {
                Profile_panel.Show();
            }
            else
            {
                Profile_panel.Hide();
            }
        }

        private void ID_ins_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serial no. will exicute automatically!");
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            insert();
        }
        private void Update_Conf_btn_Click(object sender, EventArgs e)
        {
            update();
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (deletCombBox.Text == "All")
            {
                deleteAllRec();
            }
            else if (deletCombBox.Text == "One by one")
            {
                delete();
            }
            
        }

        //-----------------------------Application load-----------------------------
        private void AddRecords_Load(object sender, EventArgs e)
        {
            ThemeLoad();
            user_name_lab.Text = labelText;
            username = labelText;
            recordLoad();
            profile_load();
            Profile_panel.Hide();
            deletePanel.Hide();
            Delete_id.Enabled = false;
            inst_btn.Enabled = false;
            Update_panel.Hide();
            Main_panel.Hide();
            upd_hide();
            insert_S_No.Enabled = false;
        }


        //----------------------------Insert---Text Box clicked/changed event-----------------------
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
        private void Insert_ttlRent_TextChanged_1(object sender, EventArgs e)
        {
            insert_ttlRent.Text = (Convert.ToInt32(insert_house.Text) + Convert.ToInt32(insert_electric.Text) + Convert.ToInt32(insert_gas.Text) + Convert.ToInt32(insert_water.Text)).ToString();
        }

        private void Insert_due_TextChanged(object sender, EventArgs e)
        {
            insert_due.Text = (Convert.ToInt32(insert_ttlRent.Text) - Convert.ToInt32(insert_RecAmnt.Text)).ToString();
        }

        //----------------------------Update---Text Box clicked/changed event-----------------------
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

        private void Update_totalRent_TextChanged(object sender, EventArgs e)
        {
            update_totalRent.Text = (Convert.ToInt32(update_houseRent.Text) + Convert.ToInt32(update_electric.Text) + Convert.ToInt32(Update_gas.Text) + Convert.ToInt32(update_water.Text)).ToString();
        }

        private void Update_recAmnt_Click(object sender, EventArgs e)
        {
            update_recAmnt.Text = "";
        }

        private void Update_dueAmnt_TextChanged(object sender, EventArgs e)
        {
            update_dueAmnt.Text = (Convert.ToInt32(update_totalRent.Text) - Convert.ToInt32(update_recAmnt.Text)).ToString();

        }

        private void Delete_id_Click(object sender, EventArgs e)
        {
            Delete_id.Text = "";
        }

        private void Insert_RecAmnt_Click(object sender, EventArgs e)
        {
            insert_RecAmnt.Text = "";
        }


        //-------------------------load all the record of a clint-----------------------
        public void recordLoad()
        {
            string keyword = Clint_searchBox.Text;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S_No, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Clint_GardView.DataSource = dt;
        }

        //-------------------------Getting data for clint profile-------------------------
        public bool check_data()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select * from RecordTab where U_Name = '" + user_name_lab.Text.Trim() + "'and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
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
        public int id_load()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ID from UserTables Where FirstName='" + labelText + "' and Name='" + LogIncs.setText + "'");
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
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["UserImage"]);
                prop_picBox.Image = new Bitmap(ms);
            }
            conn.Close();
        }
        public int ttlPaid_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select sum(ReceivedAmmount) as ttlsum From RecordTab where U_Name = '" + user_name_lab.Text.Trim() + "'and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }
        public int ttlRnt_load()
        {
            int x = id_load();
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("select sum(TotalRent) as ttlsum From RecordTab where U_Name = '" + user_name_lab.Text.Trim() + "'and Name='" + LogIncs.setText + "'");
            cmd.Connection = conn;
            conn.Open();
            object fn1 = cmd.ExecuteScalar();
            conn.Close();
            int fn = Convert.ToInt32(fn1);
            return fn;
        }
        public void profile_load()
        {
            prop_id_leb.Text = Convert.ToString(id_load());
            prop_name_leb.Text = fname_load() + " " + lname_load();
            prop_email_leb.Text = emil_load();
            prop_contact_leb.Text = contno_load();
            prop_gender_leb.Text = gen_load();
            prop_joinMnth_leb.Text = joinmon_load();
            prop_dob_leb.Text = dob_load();
            prop_flat_leb.Text = fltno_load();
            img_Load();
            if(check_data() == true)
            {
                prop_Tpaid_leb.Text = Convert.ToString(ttlPaid_load());
                prop_Tdue_leb.Text = Convert.ToString(ttlRnt_load() - ttlPaid_load());
            }
        }



        //----------------------Search Box text change---------------------------
        private void Clint_searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = Clint_searchBox.Text;

            SqlConnection conn = new SqlConnection(myconstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT S_No, Month, Year, HouseRent, ElectricBill, GasBill, WaterBill, TotalRent, ReceivedAmmount, DueAmmount FROM RecordTab WHERE Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "' and (Month LIKE '%" + keyword + "%' or Year LIKE '%" + keyword + "%' )", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Clint_GardView.DataSource = dt;
        }

        //---------------------------Update-------------------
        public bool sno_check()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select S_No from RecordTab where S_No=" + Convert.ToInt32(update_sno.Text) + " and Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "'");
            cmd.Connection = conn;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
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

        private void Srl_ok_btn_Click(object sender, EventArgs e)
        {
            int val;
            if (!int.TryParse(update_sno.Text, out val))
            {
                MessageBox.Show("Please Enter Serial No.");
            }
            else
            {
                bool suc = sno_check();
                if(suc == true)
                {
                    update_questio.Show();
                    con_update.Show();
                }
                else
                {
                    MessageBox.Show("Enter Valid serial No. from the data table list");
                }

            }
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
                getValues.Text = "Enter " + update_questio.Text;
                return choice_upd;
            }

        }
        private void Con_update_Click(object sender, EventArgs e)
        {
            if (update_questio.Text == "What do you what to update?")
            {
                MessageBox.Show("Please select an option.");
            }
            else
            {
                dd = chouse();
            }

        }
        public void clear()
        {
            //main panel
            insert_ttlRent.Text = "0000";
            insert_due.Text = "0000";
            insert_cmbMonth.Text = "Month";
            insert_cmbYear.Text = "Year";
            insert_house.Text = "House Rent";
            insert_electric.Text = "Electric Bill";
            insert_gas.Text = "Gas Bill";
            insert_water.Text = "Water Bill";
            Delete_id.Text = "S.No.";
            insert_RecAmnt.Text = "";

            //update panel
            update_totalRent.Text = "Total Rent";
            update_dueAmnt.Text = "Due Ammount";
            update_sno.Text = "S.No.";
            update_houseRent.Text = "House Rent";
            update_electric.Text = "Electric Bill";
            Update_gas.Text = "Gas Bill";
            update_water.Text = "Water Bill";            
            update_recAmnt.Text = "Received Ammount";
            update_questio.Text = "What do you what to update?";
            getValues.Text = "";
            getYears.Text = "Year";
            getMonth.Text = "Month";

        }
        private void GetValues_Click(object sender, EventArgs e)
        {
            getValues.Text = "";
        }

        //-----------------Insert-------Update------Delete---------------------
        public void insert()
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
                Main_panel.Hide();
                DGVPrinter p = new DGVPrinter();

                p.Title = "Agun";
                p.SubTitle = "Agun State";
                p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                p.PageNumbers = true;
                p.PageNumberInHeader = false;
                p.PorportionalColumns = true;
                p.HeaderCellAlignment = StringAlignment.Near;
                p.Footer = "Discount: " + labelText.Trim() + "% \r\n" + "VAT: " + "";
                p.FooterSpacing = 15;
                p.PrintDataGridView(Clint_GardView);


                recordLoad();

                MessageBox.Show("New Records Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add Records! \nTry Again.");
            }
        }
        public void update()
        {
            MessageBox.Show(dd);
            SqlConnection conn = new SqlConnection(myconstring);

            if (dd == "All")
            {
                string sql = "UPDATE RecordTab SET Month=@Month,Year=@Year,HouseRent=@HouseRent,ElectricBill=@ElectricBill,GasBill=@GasBill,WaterBill=@WaterBill,TotalRent=@TotalRent,ReceivedAmmount=@ReceivedAmmount,DueAmmount=@DueAmmount where S_No=@sn_no";
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
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "Month")
            {
                string sql = "UPDATE RecordTab SET Month=@Month where S_No=@sn_no and U_Name ='"+labelText+"' and '"+LogIncs.setText+"' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Month", getMonth.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "Year")
            {
                string sql = "UPDATE RecordTab SET Year=@Year where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Year", getYears.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }

            /*
            else if (dd == "HouseRent")
            {
                string sql = "UPDATE RecordTab SET HouseRent=@HouseRent where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HouseRent", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "ElectricBill")
            {
                string sql = "UPDATE RecordTab SET ElectricBill=@ElectricBill where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ElectricBill", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "GasBill")
            {
                string sql = "UPDATE RecordTab SET GasBill=@GasBill where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@GasBill", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "WaterBill")
            {
                string sql = "UPDATE RecordTab SET WaterBill=@WaterBill where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@WaterBill", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "TotalRent")
            {
                string sql = "UPDATE RecordTab SET TotalRent=@TotalRent where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TotalRent", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "ReceivedAmmount")
            {
                string sql = "UPDATE RecordTab SET ReceivedAmmount=@ReceivedAmmount where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReceivedAmmount", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }
            else if (dd == "DueAmmount")
            {
                string sql = "UPDATE RecordTab SET DueAmmount=@DueAmmount where S_No=@sn_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DueAmmount", getValues.Text);
                cmd.Parameters.AddWithValue("@sn_no", Convert.ToInt32(update_sno.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    recordLoad();
                    Update_panel.Hide();
                    MessageBox.Show(dd + " Updated successfully!");
                    upd_hide();
                }
                else
                {
                    MessageBox.Show("There is an Error!!");
                }
                conn.Close();
            }

            */
            else
            {
                MessageBox.Show("Something Error Occurs!");
            }
        }
        //---------------------Delete single record-----------------
        public void delete()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "DELETE from RecordTab WHERE S_No=@S_No and Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@S_No", Delete_id.Text);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                recordLoad();
                deletePanel.Hide();
                MessageBox.Show("Record deleted!");
            }
            else
            {
                MessageBox.Show("Record not deleted!\nPlease check Serial No.");
            }
        }
        //---------------------Delete all record-----------------
        public void deleteAllRec()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "DELETE from RecordTab WHERE Name='" + LogIncs.setText + "' and U_Name='" + labelText.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        //-----------------------------delete function update---------------------------28-10-2019

        private void Delokctn_Click(object sender, EventArgs e)
        {
            string choice = deletCombBox.Text;

            if (choice == "How do you wants to delete?")
            {
                MessageBox.Show("Please select an option.");
            }
            else if(choice == "All")
            {
                Delete_id.Text = "S.No.";
                Delete_id.Enabled = false;
                inst_btn.Enabled = false;
            }
            else if(choice == "One by one")
            {
                Delete_id.Enabled = true;
                inst_btn.Enabled = true;
            }
            else
            {
                Delete_id.Text = "S.No.";
                Delete_id.Enabled = false;
                inst_btn.Enabled = false;
            }
        }

        private void Inst_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter serial no then press delete to remove record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------------Theme load--------------------------------------
        public void moodules(int x, int y, int z)
        {
            Clint_searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            user_name_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Update_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            Profile_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
        }

        public void light()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            moodules(30, 144, 255);
        }

        public void Dark()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            moodules(100, 100, 100);
        }
        public void DarkSlateGray()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            moodules(47, 79, 79);
        }
        public void Teal()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            moodules(0, 128, 128);
        }
        public void Crimson()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            moodules(220, 20, 60);
        }
        public void RedMaroon()
        {
            this.Clint_GardView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
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

        private void Prop_picBox_Click(object sender, EventArgs e)
        {
            HouseRentMain.ClickedEvent = "Client";
            new UserProfile().ShowDialog();
        }

        

        //---------------------------------------------next steps-----------------------------------------










    }
}
