using House_Rent.Classes;
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

namespace House_Rent.SettingsUI
{
    public partial class Theme : Form
    {
        public Theme()
        {
            InitializeComponent();
        }
        static string myconstring = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        ThemesConfig tc = new ThemesConfig();
        RegistryMd5 re = new RegistryMd5();
        public string versionType;


        //-----------------------Button clicked event--------------------
        private void ThemesApply_btn_Click(object sender, EventArgs e)
        {
            if (versionType == "paid")
            {
                ApplyThemes();
            }
            else
            {
                MessageBox.Show("This is only for premium user.\nPlease Buy a key to use premium features", "Premium Feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //----------------------------All the theme------------------------
        private void LightBox_CheckedChanged(object sender, EventArgs e)
        {
            light();
        }

        private void DarkBox_CheckedChanged(object sender, EventArgs e)
        {
            Dark();
        }

        private void DarkSlateGrayBox_CheckedChanged(object sender, EventArgs e)
        {
            DarkSlateGray();
        }

        private void TealBox_CheckedChanged(object sender, EventArgs e)
        {
            Teal();
        }

        private void CrimsonBox_CheckedChanged(object sender, EventArgs e)
        {
            Crimson();
        }

        private void RedMaroonBox_CheckedChanged(object sender, EventArgs e)
        {
            RedMaroon();
        }

        //----------------------------Themes check box on change methods---------------------------
        public void light()
        {
            if (LightBox.Checked == true)
            {
                DarkBox.Checked = false;
                DarkSlateGrayBox.Checked = false;
                TealBox.Checked = false;
                CrimsonBox.Checked = false;
                RedMaroonBox.Checked = false;
            }
            else
            {
                LightBox.Checked = true;
            }
        }
        public void Dark()
        {

            if (DarkBox.Checked == true)
            {
                LightBox.Checked = false;
                DarkSlateGrayBox.Checked = false;
                TealBox.Checked = false;
                CrimsonBox.Checked = false;
                RedMaroonBox.Checked = false;
            }
            else
            {
                DarkBox.Checked = true;
            }
        }

        public void DarkSlateGray()
        {
            if (DarkSlateGrayBox.Checked == true)
            {
                LightBox.Checked = false;
                DarkBox.Checked = false;
                TealBox.Checked = false;
                CrimsonBox.Checked = false;
                RedMaroonBox.Checked = false;
            }
            else
            {
                DarkSlateGrayBox.Checked = true;
            }
        }

        public void Teal()
        {
            if (TealBox.Checked == true)
            {
                LightBox.Checked = false;
                DarkBox.Checked = false;
                DarkSlateGrayBox.Checked = false;
                CrimsonBox.Checked = false;
                RedMaroonBox.Checked = false;
            }
            else
            {
                TealBox.Checked = true;
            }
        }

        public void Crimson()
        {
            if (CrimsonBox.Checked == true)
            {
                LightBox.Checked = false;
                DarkBox.Checked = false;
                DarkSlateGrayBox.Checked = false;
                TealBox.Checked = false;
                RedMaroonBox.Checked = false;
            }
            else
            {
                CrimsonBox.Checked = true;
            }
        }
        public void RedMaroon()
        {
            if (RedMaroonBox.Checked == true)
            {
                LightBox.Checked = false;
                DarkBox.Checked = false;
                DarkSlateGrayBox.Checked = false;
                TealBox.Checked = false;
                CrimsonBox.Checked = false;
            }
            else
            {
                RedMaroonBox.Checked = true;
            }
        }
        //--------------------------get & set themes-------------------------------
        public void ApplyThemes()
        {
            if(LightBox.Checked == true)
            {
                SetThemes("Light");
            }
            else if (DarkBox.Checked == true)
            {
                SetThemes("Dark");
            }
            else if (DarkSlateGrayBox.Checked == true)
            {
                SetThemes("DarkSlateGray");
            }
            else if (TealBox.Checked == true)
            {
                SetThemes("Teal");
            }
            else if (CrimsonBox.Checked == true)
            {
                SetThemes("Crimson");
            }
            else if (RedMaroonBox.Checked == true)
            {
                SetThemes("RedMaroon");
            }
            else
            {
                SetThemes("Light");
            }
        }

        public void SetThemes(string x)
        {
            tc.ThemesID = x;
            bool success = tc.SetThemesID(tc);
            if (success == true)
            {
                MessageBox.Show("\nYou are about to Sign Out to make this changes fully applied.", "Theme Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LogIncs().Show();
                HouseRentMain obj = (HouseRentMain)Application.OpenForms["HouseRentMain"];
                obj.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! in Theme Manager");
            }
        }

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

        //---------------------------------Loading set theme-----------------------
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

        private void Theme_Load(object sender, EventArgs e)
        {
            ThemeLoad();
            checkVer();
            /*
            DarkBox.Enabled = true;
            DarkSlateGrayBox.Enabled = true;
            TealBox.Enabled = true;
            CrimsonBox.Enabled = true;
            RedMaroonBox.Enabled = true;
            DarkBox.Enabled = false;
            DarkSlateGrayBox.Enabled = false;
            TealBox.Enabled = false;
            CrimsonBox.Enabled = false;
            RedMaroonBox.Enabled = false;
           */
        }

        //--------------------------------Check ver---------------------------
        public void checkedButtonTrue()
        {

        }

        public void checkVer()
        {
            re.getRemainingTrialDay();
            if (re.checkVer() == "trial")
            {
                versionType = "trial";
            }
            else if (re.checkVer() == "paid")
            {
                versionType = "paid";
            }
        }


    }
}
