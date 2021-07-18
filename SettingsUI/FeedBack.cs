using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent.SettingsUI
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }
        public string sub;
        public string senderid = "senderappmail@gmail.com";
        public string senderpw = "passwordisincorrect";

        private void Send_btn_Click(object sender, EventArgs e)
        {
            getinfo();
            try 
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(senderid);
                message.To.Add("newagebubt@gmail.com");

                message.Body = "Apps: House Rent;\nSender Name: "+ User_Name.Text+ "\nSender Email: "+EmailBox.Text+"\n" + DescribeBox.Text;
                message.Subject = sub;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true; 
                client.Credentials = new System.Net.NetworkCredential(senderid, senderpw);
                Cursor.Current = Cursors.WaitCursor;
                client.Send(message);
                MessageBox.Show("Thank you!\nAs soon as we check your mail. We will take necessary action.", "Sent",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Cursor.Current = Cursors.Default;
                message = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void getinfo()
        {
            if(cmntCheck.Checked == true)
            {
                sub = "Comment";
            }
            if (BugCheck.Checked == true)
            {
                sub = "Bug Report";
            }
            if (OtherCheck.Checked == true)
            {
                sub = "Other";
            }
        }

        //----------------------------------Checked box clicked-------------------------------------
        private void CmntCheck_OnChange(object sender, EventArgs e)
        {
            if (cmntCheck.Checked == true)
            {
                BugCheck.Checked = false;
                OtherCheck.Checked = false;
            }
            else
            {
                cmntCheck.Checked = true;
            }
        }

        private void BugCheck_OnChange(object sender, EventArgs e)
        {
            if (BugCheck.Checked == true)
            {
                cmntCheck.Checked = false;
                OtherCheck.Checked = false;
            }
            else
            {
                BugCheck.Checked = true;
            }
        }

        private void OtherCheck_OnChange(object sender, EventArgs e)
        {
            if (OtherCheck.Checked == true)
            {
                cmntCheck.Checked = false;
                BugCheck.Checked = false;
            }
            else
            {
                OtherCheck.Checked = true;
            }
        }




    }
}
