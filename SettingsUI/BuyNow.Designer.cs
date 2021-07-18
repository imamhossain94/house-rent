namespace House_Rent.SettingsUI
{
    partial class BuyNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyNow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.topLabel = new System.Windows.Forms.Label();
            this.ActivationLabel = new System.Windows.Forms.Label();
            this.TrialLabel = new System.Windows.Forms.Label();
            this.TrialBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.AllFeatureLab = new System.Windows.Forms.Label();
            this.discountlabel = new System.Windows.Forms.Label();
            this.priceOffLabel = new System.Windows.Forms.Label();
            this.priceAfterOfflab = new System.Windows.Forms.Label();
            this.ActiveBox_btn = new System.Windows.Forms.Button();
            this.activationCode_Box = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.buynow_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.active_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.installedTime = new System.Windows.Forms.Label();
            this.featurelab = new System.Windows.Forms.Label();
            this.serialkeylab = new System.Windows.Forms.Label();
            this.trialBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ExpireClose_btn = new System.Windows.Forms.Button();
            this.TrialOrPaidClose_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topLabel.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(100, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(758, 36);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "PREMIUM FEATURES";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActivationLabel
            // 
            this.ActivationLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ActivationLabel.AutoSize = true;
            this.ActivationLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivationLabel.ForeColor = System.Drawing.Color.White;
            this.ActivationLabel.Location = new System.Drawing.Point(330, 463);
            this.ActivationLabel.Name = "ActivationLabel";
            this.ActivationLabel.Size = new System.Drawing.Size(290, 24);
            this.ActivationLabel.TabIndex = 101;
            this.ActivationLabel.Text = "Click here to enter activation code";
            this.ActivationLabel.Click += new System.EventHandler(this.ActivationLabel_Click);
            // 
            // TrialLabel
            // 
            this.TrialLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrialLabel.ForeColor = System.Drawing.Color.White;
            this.TrialLabel.Location = new System.Drawing.Point(334, 500);
            this.TrialLabel.Name = "TrialLabel";
            this.TrialLabel.Size = new System.Drawing.Size(286, 17);
            this.TrialLabel.TabIndex = 102;
            this.TrialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrialBar
            // 
            this.TrialBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrialBar.BackColor = System.Drawing.Color.Silver;
            this.TrialBar.BorderRadius = 5;
            this.TrialBar.Location = new System.Drawing.Point(211, 530);
            this.TrialBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrialBar.MaximumValue = 300;
            this.TrialBar.Name = "TrialBar";
            this.TrialBar.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.TrialBar.Size = new System.Drawing.Size(547, 12);
            this.TrialBar.TabIndex = 103;
            this.TrialBar.Value = 0;
            // 
            // AllFeatureLab
            // 
            this.AllFeatureLab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllFeatureLab.AutoSize = true;
            this.AllFeatureLab.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.AllFeatureLab.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AllFeatureLab.Location = new System.Drawing.Point(197, 120);
            this.AllFeatureLab.Name = "AllFeatureLab";
            this.AllFeatureLab.Size = new System.Drawing.Size(369, 120);
            this.AllFeatureLab.TabIndex = 104;
            this.AllFeatureLab.Text = "-Unlimited Client.\r\n-Themes store.\r\n-Import & Export Functionality.\r\n-Online Tran" +
    "saction.\r\n-Biometrics & Security\r\n-1GB of cloud storage.\r\n";
            this.AllFeatureLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountlabel
            // 
            this.discountlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.discountlabel.AutoSize = true;
            this.discountlabel.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.discountlabel.Location = new System.Drawing.Point(263, 14);
            this.discountlabel.Name = "discountlabel";
            this.discountlabel.Size = new System.Drawing.Size(225, 36);
            this.discountlabel.TabIndex = 105;
            this.discountlabel.Text = "50% Discount";
            // 
            // priceOffLabel
            // 
            this.priceOffLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceOffLabel.AutoSize = true;
            this.priceOffLabel.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOffLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.priceOffLabel.Location = new System.Drawing.Point(15, 14);
            this.priceOffLabel.Name = "priceOffLabel";
            this.priceOffLabel.Size = new System.Drawing.Size(119, 36);
            this.priceOffLabel.TabIndex = 106;
            this.priceOffLabel.Text = "$60.00";
            // 
            // priceAfterOfflab
            // 
            this.priceAfterOfflab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceAfterOfflab.AutoSize = true;
            this.priceAfterOfflab.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceAfterOfflab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.priceAfterOfflab.Location = new System.Drawing.Point(618, 14);
            this.priceAfterOfflab.Name = "priceAfterOfflab";
            this.priceAfterOfflab.Size = new System.Drawing.Size(119, 36);
            this.priceAfterOfflab.TabIndex = 107;
            this.priceAfterOfflab.Text = "$30.00";
            // 
            // ActiveBox_btn
            // 
            this.ActiveBox_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveBox_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActiveBox_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ActiveBox_btn.BackgroundImage")));
            this.ActiveBox_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ActiveBox_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveBox_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActiveBox_btn.Location = new System.Drawing.Point(616, 370);
            this.ActiveBox_btn.Name = "ActiveBox_btn";
            this.ActiveBox_btn.Size = new System.Drawing.Size(40, 40);
            this.ActiveBox_btn.TabIndex = 111;
            this.ActiveBox_btn.UseVisualStyleBackColor = false;
            this.ActiveBox_btn.Click += new System.EventHandler(this.ActiveBox_btn_Click);
            // 
            // activationCode_Box
            // 
            this.activationCode_Box.AcceptsReturn = false;
            this.activationCode_Box.AcceptsTab = false;
            this.activationCode_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.activationCode_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.activationCode_Box.AutoSize = true;
            this.activationCode_Box.BackColor = System.Drawing.Color.White;
            this.activationCode_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activationCode_Box.BackgroundImage")));
            this.activationCode_Box.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.activationCode_Box.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.activationCode_Box.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.activationCode_Box.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.activationCode_Box.BorderRadius = 1;
            this.activationCode_Box.BorderThickness = 1;
            this.activationCode_Box.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.activationCode_Box.DefaultFont = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationCode_Box.DefaultText = "";
            this.activationCode_Box.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.activationCode_Box.ForeColor = System.Drawing.Color.Black;
            this.activationCode_Box.HideSelection = true;
            this.activationCode_Box.IconLeft = null;
            this.activationCode_Box.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.activationCode_Box.IconPadding = 10;
            this.activationCode_Box.IconRight = null;
            this.activationCode_Box.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.activationCode_Box.Location = new System.Drawing.Point(295, 367);
            this.activationCode_Box.MaxLength = 15;
            this.activationCode_Box.MinimumSize = new System.Drawing.Size(100, 35);
            this.activationCode_Box.Modified = false;
            this.activationCode_Box.Name = "activationCode_Box";
            this.activationCode_Box.PasswordChar = '\0';
            this.activationCode_Box.ReadOnly = false;
            this.activationCode_Box.SelectedText = "";
            this.activationCode_Box.SelectionLength = 0;
            this.activationCode_Box.SelectionStart = 0;
            this.activationCode_Box.ShortcutsEnabled = true;
            this.activationCode_Box.Size = new System.Drawing.Size(367, 47);
            this.activationCode_Box.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.activationCode_Box.TabIndex = 108;
            this.activationCode_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activationCode_Box.TextMarginLeft = 5;
            this.activationCode_Box.TextPlaceholder = "";
            this.activationCode_Box.UseSystemPasswordChar = false;
            // 
            // buynow_btn
            // 
            this.buynow_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buynow_btn.BackColor = System.Drawing.Color.Transparent;
            this.buynow_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buynow_btn.BackgroundImage")));
            this.buynow_btn.ButtonText = "BUY NOW";
            this.buynow_btn.ButtonTextMarginLeft = 0;
            this.buynow_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buynow_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.buynow_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.buynow_btn.DisabledForecolor = System.Drawing.Color.White;
            this.buynow_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buynow_btn.ForeColor = System.Drawing.Color.Teal;
            this.buynow_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.buynow_btn.IconPadding = 10;
            this.buynow_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.buynow_btn.IdleBorderColor = System.Drawing.Color.Teal;
            this.buynow_btn.IdleBorderRadius = 20;
            this.buynow_btn.IdleBorderThickness = 2;
            this.buynow_btn.IdleFillColor = System.Drawing.Color.White;
            this.buynow_btn.IdleIconLeftImage = null;
            this.buynow_btn.IdleIconRightImage = null;
            this.buynow_btn.Location = new System.Drawing.Point(399, 420);
            this.buynow_btn.Name = "buynow_btn";
            stateProperties1.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.buynow_btn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.buynow_btn.OnPressedState = stateProperties2;
            this.buynow_btn.Size = new System.Drawing.Size(160, 40);
            this.buynow_btn.TabIndex = 100;
            this.buynow_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buynow_btn.Click += new System.EventHandler(this.Buynow_btn_Click);
            // 
            // active_btn
            // 
            this.active_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.active_btn.BackColor = System.Drawing.Color.Transparent;
            this.active_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("active_btn.BackgroundImage")));
            this.active_btn.ButtonText = "ACTIVE";
            this.active_btn.ButtonTextMarginLeft = 0;
            this.active_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.active_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.active_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.active_btn.DisabledForecolor = System.Drawing.Color.White;
            this.active_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active_btn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.active_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.active_btn.IconPadding = 10;
            this.active_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.active_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.active_btn.IdleBorderRadius = 20;
            this.active_btn.IdleBorderThickness = 2;
            this.active_btn.IdleFillColor = System.Drawing.Color.AliceBlue;
            this.active_btn.IdleIconLeftImage = null;
            this.active_btn.IdleIconRightImage = null;
            this.active_btn.Location = new System.Drawing.Point(399, 420);
            this.active_btn.Name = "active_btn";
            stateProperties3.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.active_btn.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.active_btn.OnPressedState = stateProperties4;
            this.active_btn.Size = new System.Drawing.Size(160, 40);
            this.active_btn.TabIndex = 110;
            this.active_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.active_btn.Click += new System.EventHandler(this.Active_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.installedTime);
            this.panel1.Controls.Add(this.AllFeatureLab);
            this.panel1.Controls.Add(this.discountlabel);
            this.panel1.Controls.Add(this.priceAfterOfflab);
            this.panel1.Controls.Add(this.priceOffLabel);
            this.panel1.Controls.Add(this.featurelab);
            this.panel1.Controls.Add(this.serialkeylab);
            this.panel1.Location = new System.Drawing.Point(100, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 275);
            this.panel1.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(715, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 111;
            this.label1.Text = "***";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // installedTime
            // 
            this.installedTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.installedTime.AutoSize = true;
            this.installedTime.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.installedTime.Location = new System.Drawing.Point(3, 258);
            this.installedTime.Name = "installedTime";
            this.installedTime.Size = new System.Drawing.Size(39, 14);
            this.installedTime.TabIndex = 109;
            this.installedTime.Text = "Time\r\n";
            this.installedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // featurelab
            // 
            this.featurelab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.featurelab.AutoSize = true;
            this.featurelab.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.featurelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.featurelab.Location = new System.Drawing.Point(185, 14);
            this.featurelab.Name = "featurelab";
            this.featurelab.Size = new System.Drawing.Size(381, 20);
            this.featurelab.TabIndex = 108;
            this.featurelab.Text = ">------Features you have------<";
            this.featurelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialkeylab
            // 
            this.serialkeylab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialkeylab.AutoSize = true;
            this.serialkeylab.Font = new System.Drawing.Font("Lucida Console", 7.8F);
            this.serialkeylab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.serialkeylab.Location = new System.Drawing.Point(560, 258);
            this.serialkeylab.Name = "serialkeylab";
            this.serialkeylab.Size = new System.Drawing.Size(39, 14);
            this.serialkeylab.TabIndex = 110;
            this.serialkeylab.Text = "Time\r\n";
            this.serialkeylab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trialBarTimer
            // 
            this.trialBarTimer.Interval = 5;
            this.trialBarTimer.Tick += new System.EventHandler(this.TrialBarTimer_Tick);
            // 
            // ExpireClose_btn
            // 
            this.ExpireClose_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpireClose_btn.BackColor = System.Drawing.Color.Transparent;
            this.ExpireClose_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExpireClose_btn.BackgroundImage")));
            this.ExpireClose_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExpireClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpireClose_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ExpireClose_btn.Location = new System.Drawing.Point(923, 2);
            this.ExpireClose_btn.Name = "ExpireClose_btn";
            this.ExpireClose_btn.Size = new System.Drawing.Size(40, 40);
            this.ExpireClose_btn.TabIndex = 113;
            this.ExpireClose_btn.UseVisualStyleBackColor = false;
            this.ExpireClose_btn.Click += new System.EventHandler(this.ExpireClose_btn_Click);
            // 
            // TrialOrPaidClose_btn
            // 
            this.TrialOrPaidClose_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrialOrPaidClose_btn.BackColor = System.Drawing.Color.Transparent;
            this.TrialOrPaidClose_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrialOrPaidClose_btn.BackgroundImage")));
            this.TrialOrPaidClose_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TrialOrPaidClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrialOrPaidClose_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.TrialOrPaidClose_btn.Location = new System.Drawing.Point(923, 2);
            this.TrialOrPaidClose_btn.Name = "TrialOrPaidClose_btn";
            this.TrialOrPaidClose_btn.Size = new System.Drawing.Size(40, 40);
            this.TrialOrPaidClose_btn.TabIndex = 114;
            this.TrialOrPaidClose_btn.UseVisualStyleBackColor = false;
            this.TrialOrPaidClose_btn.Click += new System.EventHandler(this.TrialOrPaidClose_btn_Click);
            // 
            // BuyNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(966, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ActiveBox_btn);
            this.Controls.Add(this.activationCode_Box);
            this.Controls.Add(this.TrialBar);
            this.Controls.Add(this.TrialLabel);
            this.Controls.Add(this.ActivationLabel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.buynow_btn);
            this.Controls.Add(this.active_btn);
            this.Controls.Add(this.ExpireClose_btn);
            this.Controls.Add(this.TrialOrPaidClose_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuyNow";
            this.Load += new System.EventHandler(this.BuyNow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buynow_btn;
        private System.Windows.Forms.Label ActivationLabel;
        private System.Windows.Forms.Label TrialLabel;
        private Bunifu.Framework.UI.BunifuProgressBar TrialBar;
        private System.Windows.Forms.Label AllFeatureLab;
        private System.Windows.Forms.Label discountlabel;
        private System.Windows.Forms.Label priceOffLabel;
        private System.Windows.Forms.Label priceAfterOfflab;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox activationCode_Box;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton active_btn;
        private System.Windows.Forms.Button ActiveBox_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer trialBarTimer;
        private System.Windows.Forms.Button ExpireClose_btn;
        private System.Windows.Forms.Button TrialOrPaidClose_btn;
        private System.Windows.Forms.Label featurelab;
        private System.Windows.Forms.Label installedTime;
        private System.Windows.Forms.Label serialkeylab;
        private System.Windows.Forms.Label label1;
    }
}