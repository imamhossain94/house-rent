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

namespace House_Rent.UI
{
    public partial class Resetpanel : Form
    {
        public Resetpanel()
        {
            InitializeComponent();
        }
        //---------------------------Shadow--------------------------------------
        private const int cs_d = 0x00020003;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs_d;
                cp.ExStyle = 0x00000080;
                return cp;
            }
        }



        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        //----------------------------Button Clicked Event------------------------------
        private void Confirm_del_btn_Click(object sender, EventArgs e)
        {
            delect_fun();
        }

        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------Functions----------------------
        public void del_Admi()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Delete from Admin where Name='" + LogIncs.setText + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public void del_clnt()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Delete from UserTables where Name='" + LogIncs.setText + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void del_rec()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "Delete from RecordTab where Name='" + LogIncs.setText + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void delect_fun()
        {
            
            SqlConnection conn = new SqlConnection(myconstring);
            if(Admin_checkBox.Checked == true)
            {
                DialogResult DR = MessageBox.Show("Are you sure?\nAll data Will be lost..! pore kanna-kati kore lav nai", "Admin", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    del_Admi();
                    del_rec();
                    del_clnt();
                    new LogIncs().Show();
                    HouseRentMain obj = (HouseRentMain)Application.OpenForms["HouseRentMain"];
                    obj.Close();
                    this.Close();
                }
            }
            else if (Clients_checkBox.Checked == true)
            {
                DialogResult DR = MessageBox.Show("Are you sure?\nAll Clients & there records Will be delete..! then you have to refresh the page", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    del_rec();
                    del_clnt();
                    this.Close();
                }
            }
            else if (Records_checkBox.Checked == true)
            {
                DialogResult DR = MessageBox.Show("Are you sure?\nAll records Will be delete..! then you have to refresh the page", "Records", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    del_rec();
                    this.Close();
                } 
            }
            
        }

        
        //--------------------------------Reset panel onChanged-----------------------------
        private void Admin_checkBox_OnChange(object sender, EventArgs e)
        {
            if (Admin_checkBox.Checked == true)
            {
                Clients_checkBox.Checked = false;
                Records_checkBox.Checked = false;
            }
            else
            {
                Admin_checkBox.Checked = true;
            }
        }
        private void Clients_checkBox_OnChange(object sender, EventArgs e)
        {
            if (Clients_checkBox.Checked == true)
            {
                Admin_checkBox.Checked = false;
                Records_checkBox.Checked = false;
            }
            else
            {
                Clients_checkBox.Checked = true;
            }
        }
        private void Records_checkBox_OnChange(object sender, EventArgs e)
        {
            if (Records_checkBox.Checked == true)
            {
                Admin_checkBox.Checked = false;
                Clients_checkBox.Checked = false;
            }
            else
            {
                Records_checkBox.Checked = true;
            }
        }
        //----------------------------------Key Event-------------------------------
        private void Confirm_del_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                delect_fun();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Back))
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
