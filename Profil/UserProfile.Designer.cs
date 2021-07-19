namespace House_Rent.Profil
{
    partial class UserProfile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Profile_Text = new System.Windows.Forms.Label();
            this.Ok_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.installedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailLab = new System.Windows.Forms.Label();
            this.GenderLab = new System.Windows.Forms.Label();
            this.PasswordLab = new System.Windows.Forms.Label();
            this.DateOFBirthLab = new System.Windows.Forms.Label();
            this.NameLab = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.AdmiUserPicBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdmiUserPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.TopPanel.Controls.Add(this.Profile_Text);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(500, 54);
            this.TopPanel.TabIndex = 2;
            // 
            // Profile_Text
            // 
            this.Profile_Text.AutoSize = true;
            this.Profile_Text.BackColor = System.Drawing.Color.Transparent;
            this.Profile_Text.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Text.ForeColor = System.Drawing.Color.FloralWhite;
            this.Profile_Text.Location = new System.Drawing.Point(187, 9);
            this.Profile_Text.Name = "Profile_Text";
            this.Profile_Text.Size = new System.Drawing.Size(120, 33);
            this.Profile_Text.TabIndex = 20;
            this.Profile_Text.Text = "PROFILE";
            // 
            // Ok_btn
            // 
            this.Ok_btn.BackColor = System.Drawing.Color.Transparent;
            this.Ok_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ok_btn.BackgroundImage")));
            this.Ok_btn.ButtonText = "OK";
            this.Ok_btn.ButtonTextMarginLeft = 0;
            this.Ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Ok_btn.DisabledFillColor = System.Drawing.Color.Snow;
            this.Ok_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Ok_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_btn.ForeColor = System.Drawing.Color.White;
            this.Ok_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Ok_btn.IconPadding = 10;
            this.Ok_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Ok_btn.IdleBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ok_btn.IdleBorderRadius = 5;
            this.Ok_btn.IdleBorderThickness = 2;
            this.Ok_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Ok_btn.IdleIconLeftImage = null;
            this.Ok_btn.IdleIconRightImage = null;
            this.Ok_btn.Location = new System.Drawing.Point(388, 548);
            this.Ok_btn.Name = "Ok_btn";
            stateProperties1.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Ok_btn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Ok_btn.OnPressedState = stateProperties2;
            this.Ok_btn.Size = new System.Drawing.Size(100, 40);
            this.Ok_btn.TabIndex = 95;
            this.Ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // installedTime
            // 
            this.installedTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installedTime.AutoSize = true;
            this.installedTime.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installedTime.ForeColor = System.Drawing.Color.White;
            this.installedTime.Location = new System.Drawing.Point(12, 475);
            this.installedTime.Name = "installedTime";
            this.installedTime.Size = new System.Drawing.Size(39, 14);
            this.installedTime.TabIndex = 110;
            this.installedTime.Text = "Name";
            this.installedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassLab
            // 
            this.PassLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassLab.AutoSize = true;
            this.PassLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLab.ForeColor = System.Drawing.Color.White;
            this.PassLab.Location = new System.Drawing.Point(12, 550);
            this.PassLab.Name = "PassLab";
            this.PassLab.Size = new System.Drawing.Size(71, 14);
            this.PassLab.TabIndex = 112;
            this.PassLab.Text = "Password";
            this.PassLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 114;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 113;
            this.label4.Text = "Date of Birth";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailLab
            // 
            this.EmailLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailLab.AutoSize = true;
            this.EmailLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLab.ForeColor = System.Drawing.Color.White;
            this.EmailLab.Location = new System.Drawing.Point(147, 500);
            this.EmailLab.Name = "EmailLab";
            this.EmailLab.Size = new System.Drawing.Size(55, 14);
            this.EmailLab.TabIndex = 115;
            this.EmailLab.Text = ": ----";
            this.EmailLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenderLab
            // 
            this.GenderLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenderLab.AutoSize = true;
            this.GenderLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLab.ForeColor = System.Drawing.Color.White;
            this.GenderLab.Location = new System.Drawing.Point(147, 525);
            this.GenderLab.Name = "GenderLab";
            this.GenderLab.Size = new System.Drawing.Size(55, 14);
            this.GenderLab.TabIndex = 116;
            this.GenderLab.Text = ": ----";
            this.GenderLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLab
            // 
            this.PasswordLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordLab.AutoSize = true;
            this.PasswordLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLab.ForeColor = System.Drawing.Color.White;
            this.PasswordLab.Location = new System.Drawing.Point(147, 550);
            this.PasswordLab.Name = "PasswordLab";
            this.PasswordLab.Size = new System.Drawing.Size(55, 14);
            this.PasswordLab.TabIndex = 117;
            this.PasswordLab.Text = ": ----";
            this.PasswordLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateOFBirthLab
            // 
            this.DateOFBirthLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOFBirthLab.AutoSize = true;
            this.DateOFBirthLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOFBirthLab.ForeColor = System.Drawing.Color.White;
            this.DateOFBirthLab.Location = new System.Drawing.Point(147, 574);
            this.DateOFBirthLab.Name = "DateOFBirthLab";
            this.DateOFBirthLab.Size = new System.Drawing.Size(55, 14);
            this.DateOFBirthLab.TabIndex = 118;
            this.DateOFBirthLab.Text = ": ----";
            this.DateOFBirthLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLab
            // 
            this.NameLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLab.ForeColor = System.Drawing.Color.White;
            this.NameLab.Location = new System.Drawing.Point(147, 475);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(55, 14);
            this.NameLab.TabIndex = 119;
            this.NameLab.Text = ": ----";
            this.NameLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TopPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Profile_Text;
            this.bunifuDragControl2.Vertical = true;
            // 
            // AdmiUserPicBox
            // 
            this.AdmiUserPicBox.AllowFocused = false;
            this.AdmiUserPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdmiUserPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AdmiUserPicBox.BorderRadius = 50;
            this.AdmiUserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AdmiUserPicBox.Image")));
            this.AdmiUserPicBox.IsCircle = true;
            this.AdmiUserPicBox.Location = new System.Drawing.Point(56, 70);
            this.AdmiUserPicBox.Name = "AdmiUserPicBox";
            this.AdmiUserPicBox.Size = new System.Drawing.Size(391, 391);
            this.AdmiUserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdmiUserPicBox.TabIndex = 120;
            this.AdmiUserPicBox.TabStop = false;
            this.AdmiUserPicBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(500, 599);
            this.Controls.Add(this.AdmiUserPicBox);
            this.Controls.Add(this.NameLab);
            this.Controls.Add(this.DateOFBirthLab);
            this.Controls.Add(this.PasswordLab);
            this.Controls.Add(this.GenderLab);
            this.Controls.Add(this.EmailLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.installedTime);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdmiUserPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Profile_Text;
        //private ns1.BunifuElipse bunifuElipse1;
        //private ns1.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Ok_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label installedTime;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.Label DateOFBirthLab;
        private System.Windows.Forms.Label PasswordLab;
        private System.Windows.Forms.Label GenderLab;
        private System.Windows.Forms.Label EmailLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PassLab;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.UI.WinForms.BunifuPictureBox AdmiUserPicBox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}