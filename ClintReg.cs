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
    public partial class ClintReg : Form
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public ClintReg()
        {
            InitializeComponent();
        }

        private void Clint_firstName_Click(object sender, EventArgs e)
        {
            clint_firstName.Text = "";
        }

        private void Clint_lastName_Click(object sender, EventArgs e)
        {
            clint_lastName.Text = "";
        }

        private void Clint_Email_Click(object sender, EventArgs e)
        {
            clint_Email.Text = "";
        }

        private void Clint_contactNo_Click(object sender, EventArgs e)
        {
            clint_contactNo.Text = "";
        }

        private void Clint_birthday_Click(object sender, EventArgs e)
        {
            clint_birthday.Text = "";
        }

        private void Birth_ins_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formate: dd/mm/yyyy.\nExample: 07/12/1997");
        }

        //
        //getting image data
        //
        string imageloc = "";
        private void Browse_ClintProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageloc = dialog.FileName.ToString();
                Clint_profile.ImageLocation = imageloc;
            }
        }

        ClintClasscs c = new ClintClasscs();
        private void Clint_reg_Click(object sender, EventArgs e)
        { 
            FileStream streem = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            c.id = Convert.ToInt32(Clint_ID.Text);
            c.flat = clint_cmbFlat.Text;
            c.firstname = clint_firstName.Text;
            c.lastname = clint_lastName.Text;
            c.email = clint_Email.Text;
            c.contactno = clint_contactNo.Text;
            c.gender = clint_cmdGender.Text;
            c.joinmonth = clint_cmbMonth.Text;
            c.dob = clint_birthday.Text;
            c.image = brs.ReadBytes((int)streem.Length);
            bool success = c.insert(c);

            if (success == true)
            {
                int x = c.Max_Value();
                if (x >= 12)
                {
                    clint_reg.BackColor = Color.Coral;
                    clint_reg.Text = "Quary Full!";
                    clint_reg.ForeColor = Color.White;
                    clint_reg.Enabled = false;
                }
                Clint_ID.Enabled = false;
                MessageBox.Show("Contact Successfully Inserted.\nPlease Refresh the tab.. ID is "+ c.id);
            }
            else
            {
                MessageBox.Show("Failed to add New Contact. Try Again.");
            } 
        }

        private void ClintReg_Load(object sender, EventArgs e)
        {
            //Clint_ID.Enabled = false;
        }

    }
}
