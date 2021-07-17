namespace House_Rent
{
    partial class ClintReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClintReg));
            this.clint_reg = new System.Windows.Forms.Button();
            this.clint_cmdGender = new System.Windows.Forms.ComboBox();
            this.clint_contactNo = new System.Windows.Forms.TextBox();
            this.clint_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clint_firstName = new System.Windows.Forms.TextBox();
            this.clint_birthday = new System.Windows.Forms.TextBox();
            this.AddClintPanel = new System.Windows.Forms.Panel();
            this.birth_ins_btn = new System.Windows.Forms.Button();
            this.clint_cmbFlat = new System.Windows.Forms.ComboBox();
            this.clint_Email = new System.Windows.Forms.TextBox();
            this.clint_cmbMonth = new System.Windows.Forms.ComboBox();
            this.browse_ClintProfile = new System.Windows.Forms.Button();
            this.Clint_profile = new System.Windows.Forms.PictureBox();
            this.LogIn_leb = new System.Windows.Forms.Label();
            this.Clint_ID = new System.Windows.Forms.ComboBox();
            this.AddClintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clint_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // clint_reg
            // 
            this.clint_reg.BackColor = System.Drawing.Color.Black;
            this.clint_reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clint_reg.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_reg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clint_reg.Location = new System.Drawing.Point(24, 657);
            this.clint_reg.Name = "clint_reg";
            this.clint_reg.Size = new System.Drawing.Size(1155, 39);
            this.clint_reg.TabIndex = 26;
            this.clint_reg.Text = "CONFIRM REGISTRATION";
            this.clint_reg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clint_reg.UseVisualStyleBackColor = false;
            this.clint_reg.Click += new System.EventHandler(this.Clint_reg_Click);
            // 
            // clint_cmdGender
            // 
            this.clint_cmdGender.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_cmdGender.ForeColor = System.Drawing.Color.Black;
            this.clint_cmdGender.FormattingEnabled = true;
            this.clint_cmdGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Common"});
            this.clint_cmdGender.Location = new System.Drawing.Point(24, 520);
            this.clint_cmdGender.Name = "clint_cmdGender";
            this.clint_cmdGender.Size = new System.Drawing.Size(575, 40);
            this.clint_cmdGender.TabIndex = 18;
            this.clint_cmdGender.Text = "Gender";
            // 
            // clint_contactNo
            // 
            this.clint_contactNo.BackColor = System.Drawing.Color.White;
            this.clint_contactNo.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_contactNo.ForeColor = System.Drawing.Color.Black;
            this.clint_contactNo.Location = new System.Drawing.Point(24, 475);
            this.clint_contactNo.Name = "clint_contactNo";
            this.clint_contactNo.Size = new System.Drawing.Size(1155, 39);
            this.clint_contactNo.TabIndex = 17;
            this.clint_contactNo.Text = "Contact Number";
            this.clint_contactNo.Click += new System.EventHandler(this.Clint_contactNo_Click);
            // 
            // clint_lastName
            // 
            this.clint_lastName.BackColor = System.Drawing.Color.White;
            this.clint_lastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clint_lastName.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_lastName.ForeColor = System.Drawing.Color.Black;
            this.clint_lastName.Location = new System.Drawing.Point(604, 385);
            this.clint_lastName.Name = "clint_lastName";
            this.clint_lastName.Size = new System.Drawing.Size(575, 39);
            this.clint_lastName.TabIndex = 16;
            this.clint_lastName.Text = "LAST NAME";
            this.clint_lastName.Click += new System.EventHandler(this.Clint_lastName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(752, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add Clint";
            // 
            // clint_firstName
            // 
            this.clint_firstName.BackColor = System.Drawing.Color.White;
            this.clint_firstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clint_firstName.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_firstName.ForeColor = System.Drawing.Color.Black;
            this.clint_firstName.Location = new System.Drawing.Point(24, 385);
            this.clint_firstName.Name = "clint_firstName";
            this.clint_firstName.Size = new System.Drawing.Size(575, 39);
            this.clint_firstName.TabIndex = 14;
            this.clint_firstName.Text = "FIRST NAME";
            this.clint_firstName.Click += new System.EventHandler(this.Clint_firstName_Click);
            // 
            // clint_birthday
            // 
            this.clint_birthday.BackColor = System.Drawing.Color.White;
            this.clint_birthday.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_birthday.ForeColor = System.Drawing.Color.Black;
            this.clint_birthday.Location = new System.Drawing.Point(24, 566);
            this.clint_birthday.Name = "clint_birthday";
            this.clint_birthday.Size = new System.Drawing.Size(1155, 39);
            this.clint_birthday.TabIndex = 27;
            this.clint_birthday.Text = "Date Of Birth";
            this.clint_birthday.Click += new System.EventHandler(this.Clint_birthday_Click);
            // 
            // AddClintPanel
            // 
            this.AddClintPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddClintPanel.Controls.Add(this.Clint_ID);
            this.AddClintPanel.Controls.Add(this.birth_ins_btn);
            this.AddClintPanel.Controls.Add(this.clint_cmbFlat);
            this.AddClintPanel.Controls.Add(this.clint_Email);
            this.AddClintPanel.Controls.Add(this.clint_cmbMonth);
            this.AddClintPanel.Controls.Add(this.browse_ClintProfile);
            this.AddClintPanel.Controls.Add(this.clint_reg);
            this.AddClintPanel.Controls.Add(this.Clint_profile);
            this.AddClintPanel.Controls.Add(this.clint_firstName);
            this.AddClintPanel.Controls.Add(this.clint_birthday);
            this.AddClintPanel.Controls.Add(this.clint_lastName);
            this.AddClintPanel.Controls.Add(this.clint_contactNo);
            this.AddClintPanel.Controls.Add(this.clint_cmdGender);
            this.AddClintPanel.Location = new System.Drawing.Point(255, 81);
            this.AddClintPanel.Name = "AddClintPanel";
            this.AddClintPanel.Size = new System.Drawing.Size(1209, 714);
            this.AddClintPanel.TabIndex = 42;
            // 
            // birth_ins_btn
            // 
            this.birth_ins_btn.BackColor = System.Drawing.Color.White;
            this.birth_ins_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("birth_ins_btn.BackgroundImage")));
            this.birth_ins_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.birth_ins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birth_ins_btn.ForeColor = System.Drawing.Color.White;
            this.birth_ins_btn.Location = new System.Drawing.Point(1140, 570);
            this.birth_ins_btn.Name = "birth_ins_btn";
            this.birth_ins_btn.Size = new System.Drawing.Size(30, 30);
            this.birth_ins_btn.TabIndex = 44;
            this.birth_ins_btn.UseVisualStyleBackColor = false;
            this.birth_ins_btn.Click += new System.EventHandler(this.Birth_ins_btn_Click);
            // 
            // clint_cmbFlat
            // 
            this.clint_cmbFlat.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_cmbFlat.ForeColor = System.Drawing.Color.Black;
            this.clint_cmbFlat.FormattingEnabled = true;
            this.clint_cmbFlat.Items.AddRange(new object[] {
            "1-A",
            "1-B",
            "1-C",
            "2-A",
            "2-B",
            "2-C",
            "3-A",
            "3-B",
            "3-C",
            "4-A",
            "4-B",
            "4-C"});
            this.clint_cmbFlat.Location = new System.Drawing.Point(24, 611);
            this.clint_cmbFlat.Name = "clint_cmbFlat";
            this.clint_cmbFlat.Size = new System.Drawing.Size(1155, 40);
            this.clint_cmbFlat.TabIndex = 43;
            this.clint_cmbFlat.Text = "Select Flat";
            // 
            // clint_Email
            // 
            this.clint_Email.BackColor = System.Drawing.Color.White;
            this.clint_Email.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_Email.ForeColor = System.Drawing.Color.Black;
            this.clint_Email.Location = new System.Drawing.Point(24, 430);
            this.clint_Email.Name = "clint_Email";
            this.clint_Email.Size = new System.Drawing.Size(1155, 39);
            this.clint_Email.TabIndex = 42;
            this.clint_Email.Text = "Email";
            this.clint_Email.Click += new System.EventHandler(this.Clint_Email_Click);
            // 
            // clint_cmbMonth
            // 
            this.clint_cmbMonth.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clint_cmbMonth.ForeColor = System.Drawing.Color.Black;
            this.clint_cmbMonth.FormattingEnabled = true;
            this.clint_cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.clint_cmbMonth.Location = new System.Drawing.Point(604, 520);
            this.clint_cmbMonth.Name = "clint_cmbMonth";
            this.clint_cmbMonth.Size = new System.Drawing.Size(575, 40);
            this.clint_cmbMonth.TabIndex = 41;
            this.clint_cmbMonth.Text = "Joining Month";
            // 
            // browse_ClintProfile
            // 
            this.browse_ClintProfile.ForeColor = System.Drawing.Color.DarkBlue;
            this.browse_ClintProfile.Location = new System.Drawing.Point(548, 285);
            this.browse_ClintProfile.Name = "browse_ClintProfile";
            this.browse_ClintProfile.Size = new System.Drawing.Size(108, 29);
            this.browse_ClintProfile.TabIndex = 40;
            this.browse_ClintProfile.Text = "Upload Image";
            this.browse_ClintProfile.UseVisualStyleBackColor = true;
            this.browse_ClintProfile.Click += new System.EventHandler(this.Browse_ClintProfile_Click);
            // 
            // Clint_profile
            // 
            this.Clint_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clint_profile.Image = ((System.Drawing.Image)(resources.GetObject("Clint_profile.Image")));
            this.Clint_profile.Location = new System.Drawing.Point(477, 14);
            this.Clint_profile.Name = "Clint_profile";
            this.Clint_profile.Size = new System.Drawing.Size(250, 250);
            this.Clint_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Clint_profile.TabIndex = 39;
            this.Clint_profile.TabStop = false;
            // 
            // LogIn_leb
            // 
            this.LogIn_leb.AutoSize = true;
            this.LogIn_leb.BackColor = System.Drawing.Color.Transparent;
            this.LogIn_leb.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_leb.ForeColor = System.Drawing.Color.FloralWhite;
            this.LogIn_leb.Location = new System.Drawing.Point(627, 45);
            this.LogIn_leb.Name = "LogIn_leb";
            this.LogIn_leb.Size = new System.Drawing.Size(450, 33);
            this.LogIn_leb.TabIndex = 43;
            this.LogIn_leb.Text = "_____________________________";
            // 
            // Clint_ID
            // 
            this.Clint_ID.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clint_ID.ForeColor = System.Drawing.Color.Black;
            this.Clint_ID.FormattingEnabled = true;
            this.Clint_ID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Clint_ID.Location = new System.Drawing.Point(27, 338);
            this.Clint_ID.Name = "Clint_ID";
            this.Clint_ID.Size = new System.Drawing.Size(1152, 40);
            this.Clint_ID.TabIndex = 46;
            this.Clint_ID.Text = "ID";
            // 
            // ClintReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1693, 850);
            this.Controls.Add(this.AddClintPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn_leb);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClintReg";
            this.Text = "ClintReg";
            this.Load += new System.EventHandler(this.ClintReg_Load);
            this.AddClintPanel.ResumeLayout(false);
            this.AddClintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clint_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clint_reg;
        private System.Windows.Forms.ComboBox clint_cmdGender;
        private System.Windows.Forms.TextBox clint_contactNo;
        private System.Windows.Forms.TextBox clint_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clint_firstName;
        private System.Windows.Forms.TextBox clint_birthday;
        private System.Windows.Forms.Panel AddClintPanel;
        private System.Windows.Forms.Label LogIn_leb;
        private System.Windows.Forms.Button browse_ClintProfile;
        private System.Windows.Forms.PictureBox Clint_profile;
        private System.Windows.Forms.ComboBox clint_cmbMonth;
        private System.Windows.Forms.TextBox clint_Email;
        private System.Windows.Forms.ComboBox clint_cmbFlat;
        private System.Windows.Forms.Button birth_ins_btn;
        private System.Windows.Forms.ComboBox Clint_ID;
    }
}