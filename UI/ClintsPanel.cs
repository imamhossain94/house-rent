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

namespace House_Rent.UI
{
    public partial class ClintsPanel : Form
    {
        public ClintsPanel()
        {
            InitializeComponent();
            //clint_reg.Enabled = false;
        }
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        ClintClasscs c = new ClintClasscs();
        Recordscs r = new Recordscs();

        private void ClintsPanel_Load(object sender, EventArgs e)
        {
            ThemeLoad();
        }
        //----------------------------------Button clicked Event---------------------------------
        private void Browse_ClintProfile_Click(object sender, EventArgs e)
        {
            brimg();
        }
        private void Done_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please reload the page","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Clint_reg_Click(object sender, EventArgs e)
        {
            cling_reg();
        }
        private void Remove_client_Click(object sender, EventArgs e)
        {
            removeClient();
        }
        //--------------------------------------key press--------------------------------------
        private void Clint_firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_lastName.Focus();
                e.Handled = true;
            }
        }

        private void Clint_lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_contactNo.Focus();
                e.Handled = true;
            }
        }

        private void Clint_contactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_Email.Focus();
                e.Handled = true;
            }
        }

        private void Clint_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbClint_ID.Focus();
                e.Handled = true;
            }
        }

        private void CmbClint_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_cmbFlat.Focus();
                e.Handled = true;
            }
        }

        private void Clint_cmbFlat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_cmbMonth.Focus();
                e.Handled = true;
            }
        }

        private void Clint_cmbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_cmbYear.Focus();
                e.Handled = true;
            }
        }

        private void Clint_cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_cmdGender.Focus();
                e.Handled = true;
            }
        }

        private void Clint_cmdGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clint_flatPrice.Focus();
                e.Handled = true;
            }
        }

        private void Clint_flatPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clint_payInAdvanced.Focus();
                e.Handled = true;
            }
        }

        private void Clint_payInAdvanced_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clint_reg.PerformClick();
            }
        }

        //----------------------------------Pick clint image from user-------------------------
        string imageloc = "";
        public void brimg()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageloc = dialog.FileName.ToString();
                Clint_profile.ImageLocation = imageloc;
            }
        }

        //-----------------------Checking Id existence in DB---------------------------
        public bool id_check()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select ID from UserTables where ID=" + Convert.ToInt32(CmbClint_ID.Text) + " and Name='" + LogIncs.setText + "'");
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

        //-----------------------Checking Flat existence in DB---------------------------
        public bool Flat_check()
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            SqlCommand cmd = new SqlCommand("Select Flat from UserTables where Flat='" + clint_cmbFlat.Text.Trim() + "' and Name='" + LogIncs.setText + "'");
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

        //------------------------Registation-----------------------------
        public void cling_reg()
        {
            if (CmbClint_ID.Text.Trim() == "ID")
            {
                MessageBox.Show("Please Enter An ID");
            }
            else
            {
                if (clint_firstName.Text == "First Name" || clint_lastName.Text == "Last Name")
                {
                    MessageBox.Show("Please Enter clint name");
                }
                else
                {
                    bool idchack = id_check();

                    if (clint_cmbFlat.Text == "Flat")
                    {
                        MessageBox.Show("Please Select a flat.");
                    }
                    else
                    {
                        if (idchack == true)
                        {
                            MessageBox.Show("Id " + Convert.ToInt32(CmbClint_ID.Text) + " Dose not available. \ntry another. ");
                        }
                        else if (Flat_check() == true)
                        {
                            MessageBox.Show("Flat " + clint_cmbFlat.Text + " Already booked. \nChouse another. ");
                        }
                        else if (idchack == false && Flat_check() == false)
                        {
                            if (imageloc == "")
                            {
                                MessageBox.Show("Please Upload an Image.");
                                brimg();
                            }
                            else
                            {
                                FileStream streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                                BinaryReader brs = new BinaryReader(streem);
                                c.id = Convert.ToInt32(CmbClint_ID.Text);
                                c.flat = clint_cmbFlat.Text;
                                c.firstname = clint_firstName.Text;
                                c.lastname = clint_lastName.Text;
                                c.email = clint_Email.Text;
                                c.contactno = clint_contactNo.Text;
                                c.gender = clint_cmdGender.Text;
                                c.joinmonth = clint_cmbMonth.Text+", "+ clint_cmbYear.Text;
                                c.dob = clint_dob.Value.ToString();
                                c.image = brs.ReadBytes((int)streem.Length);
                                //inserting into recordTab

                                r.rec_name = clint_firstName.Text.Trim();
                                r.rec_month = clint_cmbMonth.Text;
                                r.rec_year = clint_cmbYear.Text;
                                r.electric = 0;
                                r.gas = 0;
                                r.water = 0;
                                r.houseRent = Convert.ToInt32(Clint_flatPrice.Text);
                                r.received = Convert.ToInt32(Clint_payInAdvanced.Text);
                                r.total = Convert.ToInt32(Clint_flatPrice.Text);
                                r.due = Convert.ToInt32((Convert.ToInt32(Clint_flatPrice.Text)-(Convert.ToInt32(Clint_payInAdvanced.Text))));

                                bool successc = c.insert(c);
                                bool successr = r.insert(r);
                                if (successc == true && successr == true)
                                {
                                    int x = c.Max_Value();
                                    if (x >= 24)
                                    {
                                        clint_reg.BackColor = Color.Coral;
                                        //clint_reg.Text = "Quary Full!";
                                        clint_reg.ForeColor = Color.White;
                                        clint_reg.Enabled = false;
                                    }
                                    CmbClint_ID.Enabled = false;
                                    MessageBox.Show("Client Successfully Registered.\nPlease Refresh the tab.");
                                }
                                else
                                {
                                    MessageBox.Show("Something wents wrong!");
                                }
                            }
                        }
                    }
                }
            }
        }

        //------------------------------Remove a client-----------------------------------
        public void removeClintsRec()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            string sql = "DELETE from RecordTab WHERE Name='" + LogIncs.setText + "' and U_Name='" + Rem_Name.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection.Open();
            int r = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void removeClient()
        {
            if (rem_id.Text.Trim() == "ID")
            {
                MessageBox.Show("Please Enter An ID.");
            }
            else if (Rem_Name.Text == "First Name")
            {
                MessageBox.Show("Please Enter clients FirstName.");
            }
            else
            {
                DialogResult DR = MessageBox.Show("Are you sure?", "Remove Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DR == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(myconstring);
                    string sql = "Delete from UserTables where ID='" + Convert.ToInt32(rem_id.Text) + "' and FirstName='" + Rem_Name.Text + "' and Name='" + LogIncs.setText + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Connection.Open();
                    int r = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    removeClintsRec();
                    MessageBox.Show("Please Refresh the tab.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CmbClint_ID.Text = "ID";
                    clint_firstName.Text = "First Name";
                }
            }
        }
        //------------------------------------------Theme load--------------------------------------
        public void moodules(int x, int y, int z)
        {
            profileContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            TextCariearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            CombCariearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            RemoverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(x)))), ((int)(((byte)(y)))), ((int)(((byte)(z)))));
        }

        public void light()
        {
            moodules(30, 144, 255);
        }

        public void Dark()
        {
            moodules(100, 100, 100);
        }
        public void DarkSlateGray()
        {
            moodules(47, 79, 79);
        }
        public void Teal()
        {
            moodules(0, 128, 128);
        }
        public void Crimson()
        {
            moodules(220, 20, 60);
        }
        public void RedMaroon()
        {
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

        //---------------------------------------------next steps-----------------------------------------



    }
}
