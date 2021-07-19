using Bunifu.UI.WinForms;

namespace House_Rent
{
    partial class HouseRentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseRentMain));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LogOutButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.HomeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.HelpButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AboutUsButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.StatisticButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.ResetButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MessageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeMinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AppCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddTenantPanel = new System.Windows.Forms.Panel();
            this.AddTenantButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.AddTenantLabel = new System.Windows.Forms.Label();
            this.SidePanelTenants = new System.Windows.Forms.FlowLayoutPanel();
            this.SidePanelTenant = new System.Windows.Forms.Panel();
            this.ProfilePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.TenantsDotMenu = new System.Windows.Forms.Panel();
            this.TenantSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TenantEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TenantDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CountTenants = new System.Windows.Forms.Label();
            this.LeftDot = new Bunifu.Framework.UI.BunifuImageButton();
            this.LogInUserNameBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.SidePanelMessage = new System.Windows.Forms.Panel();
            this.MessageDotMenu = new System.Windows.Forms.Panel();
            this.MessageSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MessageEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MessageDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidePanelMessae = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateMessagePanel = new System.Windows.Forms.Panel();
            this.CreateMessageButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CreateMessageLabel = new System.Windows.Forms.Label();
            this.MessagePicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MessageName = new System.Windows.Forms.Label();
            this.CountMessages = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.RightDot = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoadAnotherForm = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutUsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppCloseButton)).BeginInit();
            this.AddTenantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddTenantButton)).BeginInit();
            this.SidePanelTenants.SuspendLayout();
            this.SidePanelTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.TenantsDotMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDot)).BeginInit();
            this.SidePanelMessage.SuspendLayout();
            this.MessageDotMenu.SuspendLayout();
            this.SidePanelMessae.SuspendLayout();
            this.CreateMessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateMessageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDot)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.TopPanel.Controls.Add(this.LogOutButton);
            this.TopPanel.Controls.Add(this.HomeButton);
            this.TopPanel.Controls.Add(this.HelpButton);
            this.TopPanel.Controls.Add(this.AboutUsButton);
            this.TopPanel.Controls.Add(this.SettingsButton);
            this.TopPanel.Controls.Add(this.StatisticButton);
            this.TopPanel.Controls.Add(this.UpperPanel);
            this.TopPanel.Controls.Add(this.ResetButton);
            this.TopPanel.Controls.Add(this.MenuButton);
            this.TopPanel.Controls.Add(this.MessageButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MaximizeMinimizeButton);
            this.TopPanel.Controls.Add(this.AppCloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.White;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1500, 90);
            this.TopPanel.TabIndex = 42;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogOutButton.Image")));
            this.LogOutButton.ImageActive = null;
            this.LogOutButton.Location = new System.Drawing.Point(658, 30);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(50, 50);
            this.LogOutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOutButton.TabIndex = 50;
            this.LogOutButton.TabStop = false;
            this.LogOutButton.Zoom = 10;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageActive = null;
            this.HomeButton.Location = new System.Drawing.Point(170, 30);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(50, 50);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeButton.TabIndex = 49;
            this.HomeButton.TabStop = false;
            this.HomeButton.Zoom = 10;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageActive = null;
            this.HelpButton.Location = new System.Drawing.Point(578, 30);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(50, 50);
            this.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpButton.TabIndex = 48;
            this.HelpButton.TabStop = false;
            this.HelpButton.Zoom = 10;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutUsButton.Image")));
            this.AboutUsButton.ImageActive = null;
            this.AboutUsButton.Location = new System.Drawing.Point(494, 30);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(50, 50);
            this.AboutUsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutUsButton.TabIndex = 47;
            this.AboutUsButton.TabStop = false;
            this.AboutUsButton.Zoom = 10;
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageActive = null;
            this.SettingsButton.Location = new System.Drawing.Point(411, 30);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(50, 50);
            this.SettingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsButton.TabIndex = 46;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Zoom = 10;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.BackColor = System.Drawing.Color.Transparent;
            this.StatisticButton.Image = ((System.Drawing.Image)(resources.GetObject("StatisticButton.Image")));
            this.StatisticButton.ImageActive = null;
            this.StatisticButton.Location = new System.Drawing.Point(333, 30);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(50, 50);
            this.StatisticButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StatisticButton.TabIndex = 44;
            this.StatisticButton.TabStop = false;
            this.StatisticButton.Zoom = 10;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Crimson;
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1500, 20);
            this.UpperPanel.TabIndex = 45;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageActive = null;
            this.ResetButton.Location = new System.Drawing.Point(253, 30);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(50, 50);
            this.ResetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetButton.TabIndex = 43;
            this.ResetButton.TabStop = false;
            this.ResetButton.Zoom = 10;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImageActive = null;
            this.MenuButton.Location = new System.Drawing.Point(15, 30);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(50, 50);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Zoom = 10;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MessageButton
            // 
            this.MessageButton.BackColor = System.Drawing.Color.Transparent;
            this.MessageButton.Image = ((System.Drawing.Image)(resources.GetObject("MessageButton.Image")));
            this.MessageButton.ImageActive = null;
            this.MessageButton.Location = new System.Drawing.Point(92, 30);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(50, 50);
            this.MessageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MessageButton.TabIndex = 42;
            this.MessageButton.TabStop = false;
            this.MessageButton.Zoom = 10;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1355, 30);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 43;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeMinimizeButton
            // 
            this.MaximizeMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeMinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeMinimizeButton.Image")));
            this.MaximizeMinimizeButton.ImageActive = null;
            this.MaximizeMinimizeButton.Location = new System.Drawing.Point(1403, 30);
            this.MaximizeMinimizeButton.Name = "MaximizeMinimizeButton";
            this.MaximizeMinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MaximizeMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeMinimizeButton.TabIndex = 42;
            this.MaximizeMinimizeButton.TabStop = false;
            this.MaximizeMinimizeButton.Zoom = 10;
            this.MaximizeMinimizeButton.Click += new System.EventHandler(this.MaximizeMinimizeButton_Click);
            // 
            // AppCloseButton
            // 
            this.AppCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("AppCloseButton.Image")));
            this.AppCloseButton.ImageActive = null;
            this.AppCloseButton.Location = new System.Drawing.Point(1450, 30);
            this.AppCloseButton.Name = "AppCloseButton";
            this.AppCloseButton.Size = new System.Drawing.Size(40, 40);
            this.AppCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppCloseButton.TabIndex = 41;
            this.AppCloseButton.TabStop = false;
            this.AppCloseButton.Zoom = 10;
            this.AppCloseButton.Click += new System.EventHandler(this.AppCloseButton_Click);
            // 
            // AddTenantPanel
            // 
            this.AddTenantPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTenantPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.AddTenantPanel.Controls.Add(this.AddTenantButton);
            this.AddTenantPanel.Controls.Add(this.AddTenantLabel);
            this.AddTenantPanel.Location = new System.Drawing.Point(0, 1);
            this.AddTenantPanel.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.AddTenantPanel.Name = "AddTenantPanel";
            this.AddTenantPanel.Size = new System.Drawing.Size(330, 60);
            this.AddTenantPanel.TabIndex = 40;
            this.AddTenantPanel.Click += new System.EventHandler(this.AddTenantButton_Click);
            // 
            // AddTenantButton
            // 
            this.AddTenantButton.AllowFocused = false;
            this.AddTenantButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTenantButton.BackColor = System.Drawing.Color.Transparent;
            this.AddTenantButton.BorderRadius = 30;
            this.AddTenantButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTenantButton.Image")));
            this.AddTenantButton.IsCircle = true;
            this.AddTenantButton.Location = new System.Drawing.Point(8, 1);
            this.AddTenantButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddTenantButton.Name = "AddTenantButton";
            this.AddTenantButton.Size = new System.Drawing.Size(60, 60);
            this.AddTenantButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddTenantButton.TabIndex = 52;
            this.AddTenantButton.TabStop = false;
            this.AddTenantButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.AddTenantButton.Click += new System.EventHandler(this.AddTenantButton_Click);
            // 
            // AddTenantLabel
            // 
            this.AddTenantLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTenantLabel.Font = new System.Drawing.Font("Dosis", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTenantLabel.ForeColor = System.Drawing.Color.White;
            this.AddTenantLabel.Location = new System.Drawing.Point(80, 5);
            this.AddTenantLabel.Name = "AddTenantLabel";
            this.AddTenantLabel.Size = new System.Drawing.Size(210, 50);
            this.AddTenantLabel.TabIndex = 51;
            this.AddTenantLabel.Text = "Add Tenants";
            this.AddTenantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTenantLabel.Click += new System.EventHandler(this.AddTenantButton_Click);
            // 
            // SidePanelTenants
            // 
            this.SidePanelTenants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanelTenants.AutoScroll = true;
            this.SidePanelTenants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.SidePanelTenants.Controls.Add(this.AddTenantPanel);
            this.SidePanelTenants.Location = new System.Drawing.Point(0, 275);
            this.SidePanelTenants.Name = "SidePanelTenants";
            this.SidePanelTenants.Size = new System.Drawing.Size(331, 410);
            this.SidePanelTenants.TabIndex = 41;
            // 
            // SidePanelTenant
            // 
            this.SidePanelTenant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.SidePanelTenant.Controls.Add(this.ProfilePicture);
            this.SidePanelTenant.Controls.Add(this.TenantsDotMenu);
            this.SidePanelTenant.Controls.Add(this.SidePanelTenants);
            this.SidePanelTenant.Controls.Add(this.CountTenants);
            this.SidePanelTenant.Controls.Add(this.LeftDot);
            this.SidePanelTenant.Controls.Add(this.LogInUserNameBox);
            this.SidePanelTenant.Controls.Add(this.ProfileName);
            this.SidePanelTenant.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelTenant.ForeColor = System.Drawing.Color.White;
            this.SidePanelTenant.Location = new System.Drawing.Point(0, 90);
            this.SidePanelTenant.Name = "SidePanelTenant";
            this.SidePanelTenant.Size = new System.Drawing.Size(330, 710);
            this.SidePanelTenant.TabIndex = 45;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.AllowFocused = false;
            this.ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicture.BorderRadius = 69;
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.IsCircle = true;
            this.ProfilePicture.Location = new System.Drawing.Point(92, 15);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(138, 138);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 57;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // TenantsDotMenu
            // 
            this.TenantsDotMenu.BackColor = System.Drawing.SystemColors.WindowText;
            this.TenantsDotMenu.Controls.Add(this.TenantSettings);
            this.TenantsDotMenu.Controls.Add(this.TenantEdit);
            this.TenantsDotMenu.Controls.Add(this.TenantDelete);
            this.TenantsDotMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TenantsDotMenu.Location = new System.Drawing.Point(233, 115);
            this.TenantsDotMenu.Name = "TenantsDotMenu";
            this.TenantsDotMenu.Size = new System.Drawing.Size(95, 115);
            this.TenantsDotMenu.TabIndex = 56;
            // 
            // TenantSettings
            // 
            this.TenantSettings.Active = false;
            this.TenantSettings.Activecolor = System.Drawing.Color.Indigo;
            this.TenantSettings.BackColor = System.Drawing.Color.Indigo;
            this.TenantSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenantSettings.BorderRadius = 0;
            this.TenantSettings.ButtonText = "Settings";
            this.TenantSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TenantSettings.DisabledColor = System.Drawing.Color.Gray;
            this.TenantSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.TenantSettings.Iconimage = null;
            this.TenantSettings.Iconimage_right = null;
            this.TenantSettings.Iconimage_right_Selected = null;
            this.TenantSettings.Iconimage_Selected = null;
            this.TenantSettings.IconMarginLeft = 0;
            this.TenantSettings.IconMarginRight = 0;
            this.TenantSettings.IconRightVisible = true;
            this.TenantSettings.IconRightZoom = 0D;
            this.TenantSettings.IconVisible = true;
            this.TenantSettings.IconZoom = 90D;
            this.TenantSettings.IsTab = false;
            this.TenantSettings.Location = new System.Drawing.Point(5, 75);
            this.TenantSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenantSettings.Name = "TenantSettings";
            this.TenantSettings.Normalcolor = System.Drawing.Color.Indigo;
            this.TenantSettings.OnHovercolor = System.Drawing.Color.Gray;
            this.TenantSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.TenantSettings.selected = false;
            this.TenantSettings.Size = new System.Drawing.Size(85, 35);
            this.TenantSettings.TabIndex = 2;
            this.TenantSettings.Text = "Settings";
            this.TenantSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TenantSettings.Textcolor = System.Drawing.Color.White;
            this.TenantSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantSettings.Click += new System.EventHandler(this.TenantSettings_Click);
            // 
            // TenantEdit
            // 
            this.TenantEdit.Active = false;
            this.TenantEdit.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.TenantEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TenantEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenantEdit.BorderRadius = 0;
            this.TenantEdit.ButtonText = "Edit";
            this.TenantEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TenantEdit.DisabledColor = System.Drawing.Color.Gray;
            this.TenantEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.TenantEdit.Iconimage = null;
            this.TenantEdit.Iconimage_right = null;
            this.TenantEdit.Iconimage_right_Selected = null;
            this.TenantEdit.Iconimage_Selected = null;
            this.TenantEdit.IconMarginLeft = 0;
            this.TenantEdit.IconMarginRight = 0;
            this.TenantEdit.IconRightVisible = true;
            this.TenantEdit.IconRightZoom = 0D;
            this.TenantEdit.IconVisible = true;
            this.TenantEdit.IconZoom = 90D;
            this.TenantEdit.IsTab = false;
            this.TenantEdit.Location = new System.Drawing.Point(5, 40);
            this.TenantEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenantEdit.Name = "TenantEdit";
            this.TenantEdit.Normalcolor = System.Drawing.Color.MediumSlateBlue;
            this.TenantEdit.OnHovercolor = System.Drawing.Color.Gray;
            this.TenantEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.TenantEdit.selected = false;
            this.TenantEdit.Size = new System.Drawing.Size(85, 35);
            this.TenantEdit.TabIndex = 1;
            this.TenantEdit.Text = "Edit";
            this.TenantEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TenantEdit.Textcolor = System.Drawing.Color.White;
            this.TenantEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantEdit.Click += new System.EventHandler(this.TenantEdit_Click);
            // 
            // TenantDelete
            // 
            this.TenantDelete.Active = false;
            this.TenantDelete.Activecolor = System.Drawing.Color.Firebrick;
            this.TenantDelete.BackColor = System.Drawing.Color.Firebrick;
            this.TenantDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenantDelete.BorderRadius = 0;
            this.TenantDelete.ButtonText = "Delete";
            this.TenantDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TenantDelete.DisabledColor = System.Drawing.Color.Gray;
            this.TenantDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.TenantDelete.Iconimage = null;
            this.TenantDelete.Iconimage_right = null;
            this.TenantDelete.Iconimage_right_Selected = null;
            this.TenantDelete.Iconimage_Selected = null;
            this.TenantDelete.IconMarginLeft = 0;
            this.TenantDelete.IconMarginRight = 0;
            this.TenantDelete.IconRightVisible = true;
            this.TenantDelete.IconRightZoom = 0D;
            this.TenantDelete.IconVisible = true;
            this.TenantDelete.IconZoom = 90D;
            this.TenantDelete.IsTab = false;
            this.TenantDelete.Location = new System.Drawing.Point(5, 5);
            this.TenantDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenantDelete.Name = "TenantDelete";
            this.TenantDelete.Normalcolor = System.Drawing.Color.Firebrick;
            this.TenantDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.TenantDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.TenantDelete.selected = false;
            this.TenantDelete.Size = new System.Drawing.Size(85, 35);
            this.TenantDelete.TabIndex = 0;
            this.TenantDelete.Text = "Delete";
            this.TenantDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TenantDelete.Textcolor = System.Drawing.Color.White;
            this.TenantDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantDelete.Click += new System.EventHandler(this.TenantDelete_Click);
            // 
            // CountTenants
            // 
            this.CountTenants.BackColor = System.Drawing.Color.Transparent;
            this.CountTenants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountTenants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountTenants.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountTenants.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.CountTenants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CountTenants.Location = new System.Drawing.Point(15, 203);
            this.CountTenants.Name = "CountTenants";
            this.CountTenants.Size = new System.Drawing.Size(297, 21);
            this.CountTenants.TabIndex = 55;
            this.CountTenants.Text = "You Have 15 Tenants";
            this.CountTenants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftDot
            // 
            this.LeftDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftDot.Image = ((System.Drawing.Image)(resources.GetObject("LeftDot.Image")));
            this.LeftDot.ImageActive = null;
            this.LeftDot.Location = new System.Drawing.Point(290, 230);
            this.LeftDot.Name = "LeftDot";
            this.LeftDot.Size = new System.Drawing.Size(35, 35);
            this.LeftDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftDot.TabIndex = 54;
            this.LeftDot.TabStop = false;
            this.LeftDot.Zoom = 10;
            this.LeftDot.Click += new System.EventHandler(this.LeftDot_Click);
            // 
            // LogInUserNameBox
            // 
            this.LogInUserNameBox.AcceptsReturn = false;
            this.LogInUserNameBox.AcceptsTab = false;
            this.LogInUserNameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LogInUserNameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LogInUserNameBox.AutoSize = true;
            this.LogInUserNameBox.BackColor = System.Drawing.Color.White;
            this.LogInUserNameBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInUserNameBox.BackgroundImage")));
            this.LogInUserNameBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.LogInUserNameBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.LogInUserNameBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.LogInUserNameBox.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.LogInUserNameBox.BorderRadius = 50;
            this.LogInUserNameBox.BorderThickness = 0;
            this.LogInUserNameBox.CausesValidation = false;
            this.LogInUserNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LogInUserNameBox.DefaultFont = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInUserNameBox.DefaultText = "";
            this.LogInUserNameBox.FillColor = System.Drawing.Color.White;
            this.LogInUserNameBox.ForeColor = System.Drawing.Color.White;
            this.LogInUserNameBox.HideSelection = true;
            this.LogInUserNameBox.IconLeft = null;
            this.LogInUserNameBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogInUserNameBox.IconPadding = 3;
            this.LogInUserNameBox.IconRight = ((System.Drawing.Image)(resources.GetObject("LogInUserNameBox.IconRight")));
            this.LogInUserNameBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogInUserNameBox.Location = new System.Drawing.Point(15, 230);
            this.LogInUserNameBox.MaxLength = 32767;
            this.LogInUserNameBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.LogInUserNameBox.Modified = false;
            this.LogInUserNameBox.Name = "LogInUserNameBox";
            this.LogInUserNameBox.PasswordChar = '\0';
            this.LogInUserNameBox.ReadOnly = false;
            this.LogInUserNameBox.SelectedText = "";
            this.LogInUserNameBox.SelectionLength = 0;
            this.LogInUserNameBox.SelectionStart = 0;
            this.LogInUserNameBox.ShortcutsEnabled = true;
            this.LogInUserNameBox.Size = new System.Drawing.Size(255, 35);
            this.LogInUserNameBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.LogInUserNameBox.TabIndex = 91;
            this.LogInUserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogInUserNameBox.TextMarginLeft = 8;
            this.LogInUserNameBox.TextPlaceholder = "Search";
            this.LogInUserNameBox.UseSystemPasswordChar = false;
            // 
            // ProfileName
            // 
            this.ProfileName.BackColor = System.Drawing.Color.Transparent;
            this.ProfileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileName.Font = new System.Drawing.Font("Dosis", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.ForeColor = System.Drawing.Color.White;
            this.ProfileName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileName.Location = new System.Drawing.Point(45, 163);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(225, 30);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.Text = "IMAM AGUN";
            this.ProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProfileName.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.TopPanel;
            this.bunifuDragControl.Vertical = true;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerPanel.BackColor = System.Drawing.Color.Crimson;
            this.LowerPanel.Location = new System.Drawing.Point(0, 775);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(1500, 25);
            this.LowerPanel.TabIndex = 47;
            // 
            // SidePanelMessage
            // 
            this.SidePanelMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.SidePanelMessage.Controls.Add(this.MessageDotMenu);
            this.SidePanelMessage.Controls.Add(this.SidePanelMessae);
            this.SidePanelMessage.Controls.Add(this.MessagePicture);
            this.SidePanelMessage.Controls.Add(this.MessageName);
            this.SidePanelMessage.Controls.Add(this.CountMessages);
            this.SidePanelMessage.Controls.Add(this.bunifuTextBox1);
            this.SidePanelMessage.Controls.Add(this.RightDot);
            this.SidePanelMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanelMessage.Location = new System.Drawing.Point(1170, 90);
            this.SidePanelMessage.Name = "SidePanelMessage";
            this.SidePanelMessage.Size = new System.Drawing.Size(330, 710);
            this.SidePanelMessage.TabIndex = 49;
            // 
            // MessageDotMenu
            // 
            this.MessageDotMenu.BackColor = System.Drawing.SystemColors.WindowText;
            this.MessageDotMenu.Controls.Add(this.MessageSettings);
            this.MessageDotMenu.Controls.Add(this.MessageEdit);
            this.MessageDotMenu.Controls.Add(this.MessageDelete);
            this.MessageDotMenu.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MessageDotMenu.Location = new System.Drawing.Point(233, 115);
            this.MessageDotMenu.Name = "MessageDotMenu";
            this.MessageDotMenu.Size = new System.Drawing.Size(95, 115);
            this.MessageDotMenu.TabIndex = 57;
            // 
            // MessageSettings
            // 
            this.MessageSettings.Active = false;
            this.MessageSettings.Activecolor = System.Drawing.Color.Indigo;
            this.MessageSettings.BackColor = System.Drawing.Color.Indigo;
            this.MessageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageSettings.BorderRadius = 0;
            this.MessageSettings.ButtonText = "Settings";
            this.MessageSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageSettings.DisabledColor = System.Drawing.Color.Gray;
            this.MessageSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.MessageSettings.Iconimage = null;
            this.MessageSettings.Iconimage_right = null;
            this.MessageSettings.Iconimage_right_Selected = null;
            this.MessageSettings.Iconimage_Selected = null;
            this.MessageSettings.IconMarginLeft = 0;
            this.MessageSettings.IconMarginRight = 0;
            this.MessageSettings.IconRightVisible = true;
            this.MessageSettings.IconRightZoom = 0D;
            this.MessageSettings.IconVisible = true;
            this.MessageSettings.IconZoom = 90D;
            this.MessageSettings.IsTab = false;
            this.MessageSettings.Location = new System.Drawing.Point(5, 75);
            this.MessageSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageSettings.Name = "MessageSettings";
            this.MessageSettings.Normalcolor = System.Drawing.Color.Indigo;
            this.MessageSettings.OnHovercolor = System.Drawing.Color.Gray;
            this.MessageSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.MessageSettings.selected = false;
            this.MessageSettings.Size = new System.Drawing.Size(85, 35);
            this.MessageSettings.TabIndex = 2;
            this.MessageSettings.Text = "Settings";
            this.MessageSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageSettings.Textcolor = System.Drawing.Color.White;
            this.MessageSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageSettings.Click += new System.EventHandler(this.MessageSettings_Click);
            // 
            // MessageEdit
            // 
            this.MessageEdit.Active = false;
            this.MessageEdit.Activecolor = System.Drawing.Color.MediumSlateBlue;
            this.MessageEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.MessageEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageEdit.BorderRadius = 0;
            this.MessageEdit.ButtonText = "Edit";
            this.MessageEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageEdit.DisabledColor = System.Drawing.Color.Gray;
            this.MessageEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.MessageEdit.Iconimage = null;
            this.MessageEdit.Iconimage_right = null;
            this.MessageEdit.Iconimage_right_Selected = null;
            this.MessageEdit.Iconimage_Selected = null;
            this.MessageEdit.IconMarginLeft = 0;
            this.MessageEdit.IconMarginRight = 0;
            this.MessageEdit.IconRightVisible = true;
            this.MessageEdit.IconRightZoom = 0D;
            this.MessageEdit.IconVisible = true;
            this.MessageEdit.IconZoom = 90D;
            this.MessageEdit.IsTab = false;
            this.MessageEdit.Location = new System.Drawing.Point(5, 40);
            this.MessageEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageEdit.Name = "MessageEdit";
            this.MessageEdit.Normalcolor = System.Drawing.Color.MediumSlateBlue;
            this.MessageEdit.OnHovercolor = System.Drawing.Color.Gray;
            this.MessageEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.MessageEdit.selected = false;
            this.MessageEdit.Size = new System.Drawing.Size(85, 35);
            this.MessageEdit.TabIndex = 1;
            this.MessageEdit.Text = "Edit";
            this.MessageEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageEdit.Textcolor = System.Drawing.Color.White;
            this.MessageEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageEdit.Click += new System.EventHandler(this.MessageEdit_Click);
            // 
            // MessageDelete
            // 
            this.MessageDelete.Active = false;
            this.MessageDelete.Activecolor = System.Drawing.Color.Firebrick;
            this.MessageDelete.BackColor = System.Drawing.Color.Firebrick;
            this.MessageDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessageDelete.BorderRadius = 0;
            this.MessageDelete.ButtonText = "Delete";
            this.MessageDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageDelete.DisabledColor = System.Drawing.Color.Gray;
            this.MessageDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.MessageDelete.Iconimage = null;
            this.MessageDelete.Iconimage_right = null;
            this.MessageDelete.Iconimage_right_Selected = null;
            this.MessageDelete.Iconimage_Selected = null;
            this.MessageDelete.IconMarginLeft = 0;
            this.MessageDelete.IconMarginRight = 0;
            this.MessageDelete.IconRightVisible = true;
            this.MessageDelete.IconRightZoom = 0D;
            this.MessageDelete.IconVisible = true;
            this.MessageDelete.IconZoom = 90D;
            this.MessageDelete.IsTab = false;
            this.MessageDelete.Location = new System.Drawing.Point(5, 5);
            this.MessageDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageDelete.Name = "MessageDelete";
            this.MessageDelete.Normalcolor = System.Drawing.Color.Firebrick;
            this.MessageDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.MessageDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.MessageDelete.selected = false;
            this.MessageDelete.Size = new System.Drawing.Size(85, 35);
            this.MessageDelete.TabIndex = 0;
            this.MessageDelete.Text = "Delete";
            this.MessageDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageDelete.Textcolor = System.Drawing.Color.White;
            this.MessageDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageDelete.Click += new System.EventHandler(this.MessageDelete_Click);
            // 
            // SidePanelMessae
            // 
            this.SidePanelMessae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanelMessae.AutoScroll = true;
            this.SidePanelMessae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.SidePanelMessae.Controls.Add(this.CreateMessagePanel);
            this.SidePanelMessae.Location = new System.Drawing.Point(0, 275);
            this.SidePanelMessae.Name = "SidePanelMessae";
            this.SidePanelMessae.Size = new System.Drawing.Size(331, 410);
            this.SidePanelMessae.TabIndex = 50;
            // 
            // CreateMessagePanel
            // 
            this.CreateMessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateMessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CreateMessagePanel.Controls.Add(this.CreateMessageButton);
            this.CreateMessagePanel.Controls.Add(this.CreateMessageLabel);
            this.CreateMessagePanel.Location = new System.Drawing.Point(0, 1);
            this.CreateMessagePanel.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.CreateMessagePanel.Name = "CreateMessagePanel";
            this.CreateMessagePanel.Size = new System.Drawing.Size(330, 60);
            this.CreateMessagePanel.TabIndex = 40;
            this.CreateMessagePanel.Click += new System.EventHandler(this.CreateMessageButton_Click);
            // 
            // CreateMessageButton
            // 
            this.CreateMessageButton.AllowFocused = false;
            this.CreateMessageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateMessageButton.BorderRadius = 30;
            this.CreateMessageButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateMessageButton.Image")));
            this.CreateMessageButton.IsCircle = true;
            this.CreateMessageButton.Location = new System.Drawing.Point(8, 1);
            this.CreateMessageButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateMessageButton.Name = "CreateMessageButton";
            this.CreateMessageButton.Size = new System.Drawing.Size(60, 60);
            this.CreateMessageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreateMessageButton.TabIndex = 52;
            this.CreateMessageButton.TabStop = false;
            this.CreateMessageButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.CreateMessageButton.Click += new System.EventHandler(this.CreateMessageButton_Click);
            // 
            // CreateMessageLabel
            // 
            this.CreateMessageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateMessageLabel.Font = new System.Drawing.Font("Dosis", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMessageLabel.ForeColor = System.Drawing.Color.White;
            this.CreateMessageLabel.Location = new System.Drawing.Point(80, 5);
            this.CreateMessageLabel.Name = "CreateMessageLabel";
            this.CreateMessageLabel.Size = new System.Drawing.Size(210, 50);
            this.CreateMessageLabel.TabIndex = 51;
            this.CreateMessageLabel.Text = "New Message";
            this.CreateMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateMessageLabel.Click += new System.EventHandler(this.CreateMessageButton_Click);
            // 
            // MessagePicture
            // 
            this.MessagePicture.AllowFocused = false;
            this.MessagePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePicture.BackColor = System.Drawing.Color.Transparent;
            this.MessagePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MessagePicture.BorderRadius = 69;
            this.MessagePicture.Image = ((System.Drawing.Image)(resources.GetObject("MessagePicture.Image")));
            this.MessagePicture.IsCircle = true;
            this.MessagePicture.Location = new System.Drawing.Point(92, 15);
            this.MessagePicture.Name = "MessagePicture";
            this.MessagePicture.Size = new System.Drawing.Size(138, 138);
            this.MessagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MessagePicture.TabIndex = 49;
            this.MessagePicture.TabStop = false;
            this.MessagePicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // MessageName
            // 
            this.MessageName.BackColor = System.Drawing.Color.Transparent;
            this.MessageName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageName.Font = new System.Drawing.Font("Dosis", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageName.ForeColor = System.Drawing.Color.White;
            this.MessageName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageName.Location = new System.Drawing.Point(86, 165);
            this.MessageName.Name = "MessageName";
            this.MessageName.Size = new System.Drawing.Size(153, 30);
            this.MessageName.TabIndex = 48;
            this.MessageName.Text = "MESSAGE";
            this.MessageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountMessages
            // 
            this.CountMessages.BackColor = System.Drawing.Color.Transparent;
            this.CountMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountMessages.Font = new System.Drawing.Font("Dosis", 9F, System.Drawing.FontStyle.Bold);
            this.CountMessages.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.CountMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CountMessages.Location = new System.Drawing.Point(15, 203);
            this.CountMessages.Name = "CountMessages";
            this.CountMessages.Size = new System.Drawing.Size(297, 21);
            this.CountMessages.TabIndex = 56;
            this.CountMessages.Text = "You Have 0 Messages";
            this.CountMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSize = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.bunifuTextBox1.BorderRadius = 50;
            this.bunifuTextBox1.BorderThickness = 0;
            this.bunifuTextBox1.CausesValidation = false;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 3;
            this.bunifuTextBox1.IconRight = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconRight")));
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(15, 230);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(255, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox1.TabIndex = 92;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 8;
            this.bunifuTextBox1.TextPlaceholder = "Search";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // RightDot
            // 
            this.RightDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightDot.Image = ((System.Drawing.Image)(resources.GetObject("RightDot.Image")));
            this.RightDot.ImageActive = null;
            this.RightDot.Location = new System.Drawing.Point(288, 230);
            this.RightDot.Name = "RightDot";
            this.RightDot.Size = new System.Drawing.Size(35, 35);
            this.RightDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightDot.TabIndex = 53;
            this.RightDot.TabStop = false;
            this.RightDot.Zoom = 10;
            this.RightDot.Click += new System.EventHandler(this.RightDot_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.LoadAnotherForm);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(330, 90);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(840, 710);
            this.MainPanel.TabIndex = 50;
            // 
            // LoadAnotherForm
            // 
            this.LoadAnotherForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadAnotherForm.Location = new System.Drawing.Point(10, 10);
            this.LoadAnotherForm.Name = "LoadAnotherForm";
            this.LoadAnotherForm.Size = new System.Drawing.Size(820, 665);
            this.LoadAnotherForm.TabIndex = 0;
            // 
            // HouseRentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanelMessage);
            this.Controls.Add(this.SidePanelTenant);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "HouseRentMain";
            this.Text = "HouseRentMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HouseRentMain_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogOutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutUsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppCloseButton)).EndInit();
            this.AddTenantPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddTenantButton)).EndInit();
            this.SidePanelTenants.ResumeLayout(false);
            this.SidePanelTenant.ResumeLayout(false);
            this.SidePanelTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.TenantsDotMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftDot)).EndInit();
            this.SidePanelMessage.ResumeLayout(false);
            this.SidePanelMessage.PerformLayout();
            this.MessageDotMenu.ResumeLayout(false);
            this.SidePanelMessae.ResumeLayout(false);
            this.CreateMessagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateMessageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightDot)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel AddTenantPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox AddTenantButton;
        private System.Windows.Forms.Label AddTenantLabel;
        private Bunifu.Framework.UI.BunifuImageButton MenuButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.FlowLayoutPanel SidePanelTenants;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeMinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton AppCloseButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MessageButton;
        private Bunifu.Framework.UI.BunifuImageButton StatisticButton;
        private Bunifu.Framework.UI.BunifuImageButton ResetButton;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Panel SidePanelTenant;
        private System.Windows.Forms.Label ProfileName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.Panel SidePanelMessage;
        private Bunifu.Framework.UI.BunifuImageButton SettingsButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LoadAnotherForm;
        private System.Windows.Forms.FlowLayoutPanel SidePanelMessae;
        private System.Windows.Forms.Panel CreateMessagePanel;
        private BunifuPictureBox CreateMessageButton;
        private System.Windows.Forms.Label CreateMessageLabel;
        private BunifuPictureBox MessagePicture;
        private System.Windows.Forms.Label MessageName;
        private Bunifu.Framework.UI.BunifuImageButton RightDot;
        private System.Windows.Forms.Panel TenantsDotMenu;
        private Bunifu.Framework.UI.BunifuFlatButton TenantSettings;
        private Bunifu.Framework.UI.BunifuFlatButton TenantEdit;
        private Bunifu.Framework.UI.BunifuFlatButton TenantDelete;
        private System.Windows.Forms.Label CountTenants;
        private Bunifu.Framework.UI.BunifuImageButton LeftDot;
        private System.Windows.Forms.Label CountMessages;
        private System.Windows.Forms.Panel MessageDotMenu;
        private Bunifu.Framework.UI.BunifuFlatButton MessageSettings;
        private Bunifu.Framework.UI.BunifuFlatButton MessageEdit;
        private Bunifu.Framework.UI.BunifuFlatButton MessageDelete;
        private BunifuPictureBox ProfilePicture;
        private Bunifu.Framework.UI.BunifuImageButton AboutUsButton;
        private Bunifu.Framework.UI.BunifuImageButton HelpButton;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox LogInUserNameBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        private Bunifu.Framework.UI.BunifuImageButton HomeButton;
        private Bunifu.Framework.UI.BunifuImageButton LogOutButton;
    }
}