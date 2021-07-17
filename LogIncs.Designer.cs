namespace House_Rent
{
    partial class LogIncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIncs));
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Login_tab = new System.Windows.Forms.Label();
            this.User_pw = new System.Windows.Forms.TextBox();
            this.Sign_name = new System.Windows.Forms.TextBox();
            this.Sign_email = new System.Windows.Forms.TextBox();
            this.Sign_Pw = new System.Windows.Forms.TextBox();
            this.sign_gender = new System.Windows.Forms.ComboBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AppClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateAcc_btn = new System.Windows.Forms.Button();
            this.SignUp_tab = new System.Windows.Forms.Label();
            this.LogIn_leb = new System.Windows.Forms.Label();
            this.SignUp_leb = new System.Windows.Forms.Label();
            this.SignUp_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Sign_DOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Button();
            this.browsePhoto = new System.Windows.Forms.Button();
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SignUp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.LogInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_Name
            // 
            this.User_Name.BackColor = System.Drawing.Color.White;
            this.User_Name.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.ForeColor = System.Drawing.Color.Black;
            this.User_Name.Location = new System.Drawing.Point(18, 206);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(367, 39);
            this.User_Name.TabIndex = 15;
            this.User_Name.Text = "Username";
            this.User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User_Name.Click += new System.EventHandler(this.User_Name_Click);
            // 
            // Login_tab
            // 
            this.Login_tab.BackColor = System.Drawing.Color.Transparent;
            this.Login_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_tab.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_tab.ForeColor = System.Drawing.Color.FloralWhite;
            this.Login_tab.Location = new System.Drawing.Point(21, 81);
            this.Login_tab.Name = "Login_tab";
            this.Login_tab.Size = new System.Drawing.Size(195, 33);
            this.Login_tab.TabIndex = 16;
            this.Login_tab.Text = "Log In";
            this.Login_tab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_tab.Click += new System.EventHandler(this.Login_tab_Click);
            // 
            // User_pw
            // 
            this.User_pw.BackColor = System.Drawing.Color.White;
            this.User_pw.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_pw.ForeColor = System.Drawing.Color.Black;
            this.User_pw.Location = new System.Drawing.Point(18, 251);
            this.User_pw.Name = "User_pw";
            this.User_pw.Size = new System.Drawing.Size(367, 39);
            this.User_pw.TabIndex = 17;
            this.User_pw.Text = "Password";
            this.User_pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.User_pw.Click += new System.EventHandler(this.Passwordbtn_Click);
            // 
            // Sign_name
            // 
            this.Sign_name.BackColor = System.Drawing.Color.White;
            this.Sign_name.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_name.ForeColor = System.Drawing.Color.Black;
            this.Sign_name.Location = new System.Drawing.Point(18, 206);
            this.Sign_name.Name = "Sign_name";
            this.Sign_name.Size = new System.Drawing.Size(367, 39);
            this.Sign_name.TabIndex = 19;
            this.Sign_name.Text = "Name";
            this.Sign_name.Click += new System.EventHandler(this.Sign_name_Click);
            // 
            // Sign_email
            // 
            this.Sign_email.BackColor = System.Drawing.Color.White;
            this.Sign_email.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_email.ForeColor = System.Drawing.Color.Black;
            this.Sign_email.Location = new System.Drawing.Point(18, 251);
            this.Sign_email.Name = "Sign_email";
            this.Sign_email.Size = new System.Drawing.Size(367, 39);
            this.Sign_email.TabIndex = 20;
            this.Sign_email.Text = "Email";
            this.Sign_email.Click += new System.EventHandler(this.Sign_email_Click);
            // 
            // Sign_Pw
            // 
            this.Sign_Pw.BackColor = System.Drawing.Color.White;
            this.Sign_Pw.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Pw.ForeColor = System.Drawing.Color.Black;
            this.Sign_Pw.Location = new System.Drawing.Point(18, 296);
            this.Sign_Pw.Name = "Sign_Pw";
            this.Sign_Pw.Size = new System.Drawing.Size(367, 39);
            this.Sign_Pw.TabIndex = 21;
            this.Sign_Pw.Text = "Password";
            this.Sign_Pw.Click += new System.EventHandler(this.Sign_Pw_Click);
            // 
            // sign_gender
            // 
            this.sign_gender.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_gender.ForeColor = System.Drawing.Color.Black;
            this.sign_gender.FormattingEnabled = true;
            this.sign_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Common"});
            this.sign_gender.Location = new System.Drawing.Point(18, 386);
            this.sign_gender.Name = "sign_gender";
            this.sign_gender.Size = new System.Drawing.Size(367, 40);
            this.sign_gender.TabIndex = 23;
            this.sign_gender.Text = "Gender";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Black;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(18, 432);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(367, 39);
            this.login_btn.TabIndex = 31;
            this.login_btn.Text = "LOG IN";
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.TopPanel.Controls.Add(this.AppClose);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(448, 56);
            this.TopPanel.TabIndex = 33;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // AppClose
            // 
            this.AppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppClose.BackColor = System.Drawing.Color.OrangeRed;
            this.AppClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppClose.BackgroundImage")));
            this.AppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.AppClose.Location = new System.Drawing.Point(397, 9);
            this.AppClose.Name = "AppClose";
            this.AppClose.Size = new System.Drawing.Size(39, 38);
            this.AppClose.TabIndex = 18;
            this.AppClose.UseVisualStyleBackColor = false;
            this.AppClose.Click += new System.EventHandler(this.AppClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "HOUSE RENT";
            // 
            // CreateAcc_btn
            // 
            this.CreateAcc_btn.BackColor = System.Drawing.Color.Black;
            this.CreateAcc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateAcc_btn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAcc_btn.ForeColor = System.Drawing.Color.White;
            this.CreateAcc_btn.Location = new System.Drawing.Point(18, 432);
            this.CreateAcc_btn.Name = "CreateAcc_btn";
            this.CreateAcc_btn.Size = new System.Drawing.Size(367, 39);
            this.CreateAcc_btn.TabIndex = 35;
            this.CreateAcc_btn.Text = "CREATE ACCOUNT";
            this.CreateAcc_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreateAcc_btn.UseVisualStyleBackColor = false;
            this.CreateAcc_btn.Click += new System.EventHandler(this.CreateAcc_btn_Click);
            // 
            // SignUp_tab
            // 
            this.SignUp_tab.BackColor = System.Drawing.Color.Transparent;
            this.SignUp_tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_tab.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_tab.ForeColor = System.Drawing.Color.FloralWhite;
            this.SignUp_tab.Location = new System.Drawing.Point(231, 81);
            this.SignUp_tab.Name = "SignUp_tab";
            this.SignUp_tab.Size = new System.Drawing.Size(192, 33);
            this.SignUp_tab.TabIndex = 36;
            this.SignUp_tab.Text = "Sign Up";
            this.SignUp_tab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUp_tab.Click += new System.EventHandler(this.SignUp_tab_Click);
            // 
            // LogIn_leb
            // 
            this.LogIn_leb.AutoSize = true;
            this.LogIn_leb.BackColor = System.Drawing.Color.Transparent;
            this.LogIn_leb.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_leb.ForeColor = System.Drawing.Color.FloralWhite;
            this.LogIn_leb.Location = new System.Drawing.Point(15, 92);
            this.LogIn_leb.Name = "LogIn_leb";
            this.LogIn_leb.Size = new System.Drawing.Size(210, 33);
            this.LogIn_leb.TabIndex = 38;
            this.LogIn_leb.Text = "_____________";
            // 
            // SignUp_leb
            // 
            this.SignUp_leb.AutoSize = true;
            this.SignUp_leb.BackColor = System.Drawing.Color.Transparent;
            this.SignUp_leb.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_leb.ForeColor = System.Drawing.Color.FloralWhite;
            this.SignUp_leb.Location = new System.Drawing.Point(222, 92);
            this.SignUp_leb.Name = "SignUp_leb";
            this.SignUp_leb.Size = new System.Drawing.Size(210, 33);
            this.SignUp_leb.TabIndex = 39;
            this.SignUp_leb.Text = "_____________";
            // 
            // SignUp_panel
            // 
            this.SignUp_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignUp_panel.Controls.Add(this.button1);
            this.SignUp_panel.Controls.Add(this.Sign_DOB);
            this.SignUp_panel.Controls.Add(this.label1);
            this.SignUp_panel.Controls.Add(this.instruction);
            this.SignUp_panel.Controls.Add(this.browsePhoto);
            this.SignUp_panel.Controls.Add(this.pictureBox_profile);
            this.SignUp_panel.Controls.Add(this.CreateAcc_btn);
            this.SignUp_panel.Controls.Add(this.Sign_name);
            this.SignUp_panel.Controls.Add(this.Sign_email);
            this.SignUp_panel.Controls.Add(this.Sign_Pw);
            this.SignUp_panel.Controls.Add(this.sign_gender);
            this.SignUp_panel.Location = new System.Drawing.Point(21, 128);
            this.SignUp_panel.Name = "SignUp_panel";
            this.SignUp_panel.Size = new System.Drawing.Size(402, 493);
            this.SignUp_panel.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Sign_DOB
            // 
            this.Sign_DOB.CustomFormat = "";
            this.Sign_DOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Sign_DOB.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Sign_DOB.Location = new System.Drawing.Point(18, 341);
            this.Sign_DOB.Name = "Sign_DOB";
            this.Sign_DOB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sign_DOB.Size = new System.Drawing.Size(325, 39);
            this.Sign_DOB.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 40);
            this.label1.TabIndex = 42;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // instruction
            // 
            this.instruction.BackColor = System.Drawing.Color.White;
            this.instruction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instruction.BackgroundImage")));
            this.instruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.ForeColor = System.Drawing.Color.White;
            this.instruction.Location = new System.Drawing.Point(348, 210);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(30, 30);
            this.instruction.TabIndex = 39;
            this.instruction.UseVisualStyleBackColor = false;
            this.instruction.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // browsePhoto
            // 
            this.browsePhoto.Location = new System.Drawing.Point(149, 167);
            this.browsePhoto.Name = "browsePhoto";
            this.browsePhoto.Size = new System.Drawing.Size(108, 29);
            this.browsePhoto.TabIndex = 38;
            this.browsePhoto.Text = "Upload Image";
            this.browsePhoto.UseVisualStyleBackColor = true;
            this.browsePhoto.Click += new System.EventHandler(this.BrowsePhoto_Click);
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_profile.Image")));
            this.pictureBox_profile.Location = new System.Drawing.Point(128, 7);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_profile.TabIndex = 37;
            this.pictureBox_profile.TabStop = false;
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogInPanel.Controls.Add(this.User_Name);
            this.LogInPanel.Controls.Add(this.User_pw);
            this.LogInPanel.Controls.Add(this.login_btn);
            this.LogInPanel.Location = new System.Drawing.Point(21, 128);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(402, 493);
            this.LogInPanel.TabIndex = 41;
            // 
            // LogIncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(448, 640);
            this.Controls.Add(this.SignUp_tab);
            this.Controls.Add(this.SignUp_leb);
            this.Controls.Add(this.Login_tab);
            this.Controls.Add(this.LogIn_leb);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.SignUp_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogIncs";
            this.Load += new System.EventHandler(this.LogIncs_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SignUp_panel.ResumeLayout(false);
            this.SignUp_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.Label Login_tab;
        private System.Windows.Forms.TextBox User_pw;
        private System.Windows.Forms.TextBox Sign_name;
        private System.Windows.Forms.TextBox Sign_email;
        private System.Windows.Forms.TextBox Sign_Pw;
        private System.Windows.Forms.ComboBox sign_gender;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AppClose;
        private System.Windows.Forms.Button CreateAcc_btn;
        private System.Windows.Forms.Label SignUp_tab;
        private System.Windows.Forms.Label LogIn_leb;
        private System.Windows.Forms.Label SignUp_leb;
        private System.Windows.Forms.Panel SignUp_panel;
        private System.Windows.Forms.Button browsePhoto;
        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.Button instruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Sign_DOB;
        private System.Windows.Forms.Button button1;
    }
}