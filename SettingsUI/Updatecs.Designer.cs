namespace House_Rent.SettingsUI
{
    partial class Updatecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updatecs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.currentVer_lab = new System.Windows.Forms.Label();
            this.Curreent_ver = new System.Windows.Forms.Panel();
            this.CurrentverElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UpdateCheckBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.updateCheck_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.progressTime = new System.Windows.Forms.Timer(this.components);
            this.Curreent_ver.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPDATE\r\n";
            // 
            // currentVer_lab
            // 
            this.currentVer_lab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentVer_lab.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVer_lab.ForeColor = System.Drawing.Color.Black;
            this.currentVer_lab.Location = new System.Drawing.Point(0, 0);
            this.currentVer_lab.Name = "currentVer_lab";
            this.currentVer_lab.Size = new System.Drawing.Size(509, 333);
            this.currentVer_lab.TabIndex = 105;
            this.currentVer_lab.Text = resources.GetString("currentVer_lab.Text");
            this.currentVer_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Curreent_ver
            // 
            this.Curreent_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Curreent_ver.AutoScroll = true;
            this.Curreent_ver.BackColor = System.Drawing.Color.White;
            this.Curreent_ver.Controls.Add(this.currentVer_lab);
            this.Curreent_ver.Location = new System.Drawing.Point(228, 72);
            this.Curreent_ver.Name = "Curreent_ver";
            this.Curreent_ver.Size = new System.Drawing.Size(509, 333);
            this.Curreent_ver.TabIndex = 106;
            // 
            // CurrentverElipse
            // 
            this.CurrentverElipse.ElipseRadius = 15;
            this.CurrentverElipse.TargetControl = this.Curreent_ver;
            // 
            // UpdateCheckBar
            // 
            this.UpdateCheckBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateCheckBar.BackColor = System.Drawing.Color.Silver;
            this.UpdateCheckBar.BorderRadius = 5;
            this.UpdateCheckBar.Location = new System.Drawing.Point(63, 450);
            this.UpdateCheckBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateCheckBar.MaximumValue = 100;
            this.UpdateCheckBar.Name = "UpdateCheckBar";
            this.UpdateCheckBar.ProgressColor = System.Drawing.Color.NavajoWhite;
            this.UpdateCheckBar.Size = new System.Drawing.Size(834, 12);
            this.UpdateCheckBar.TabIndex = 107;
            this.UpdateCheckBar.Value = 0;
            // 
            // updateCheck_btn
            // 
            this.updateCheck_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateCheck_btn.BackColor = System.Drawing.Color.Transparent;
            this.updateCheck_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateCheck_btn.BackgroundImage")));
            this.updateCheck_btn.ButtonText = "CHECK FOR UPDATE";
            this.updateCheck_btn.ButtonTextMarginLeft = 0;
            this.updateCheck_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCheck_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.updateCheck_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.updateCheck_btn.DisabledForecolor = System.Drawing.Color.White;
            this.updateCheck_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCheck_btn.ForeColor = System.Drawing.Color.Teal;
            this.updateCheck_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.updateCheck_btn.IconPadding = 10;
            this.updateCheck_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.updateCheck_btn.IdleBorderColor = System.Drawing.Color.Teal;
            this.updateCheck_btn.IdleBorderRadius = 20;
            this.updateCheck_btn.IdleBorderThickness = 2;
            this.updateCheck_btn.IdleFillColor = System.Drawing.Color.White;
            this.updateCheck_btn.IdleIconLeftImage = null;
            this.updateCheck_btn.IdleIconRightImage = null;
            this.updateCheck_btn.Location = new System.Drawing.Point(356, 489);
            this.updateCheck_btn.Name = "updateCheck_btn";
            stateProperties13.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties13.BorderRadius = 1;
            stateProperties13.BorderThickness = 1;
            stateProperties13.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties13.ForeColor = System.Drawing.Color.White;
            stateProperties13.IconLeftImage = null;
            stateProperties13.IconRightImage = null;
            this.updateCheck_btn.onHoverState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties14.BorderRadius = 1;
            stateProperties14.BorderThickness = 1;
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties14.ForeColor = System.Drawing.Color.White;
            stateProperties14.IconLeftImage = null;
            stateProperties14.IconRightImage = null;
            this.updateCheck_btn.OnPressedState = stateProperties14;
            this.updateCheck_btn.Size = new System.Drawing.Size(250, 40);
            this.updateCheck_btn.TabIndex = 108;
            this.updateCheck_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateCheck_btn.Click += new System.EventHandler(this.UpdateCheck_btn_Click);
            // 
            // progressTime
            // 
            this.progressTime.Interval = 30;
            this.progressTime.Tick += new System.EventHandler(this.ProgressTime_Tick);
            // 
            // Updatecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(966, 551);
            this.Controls.Add(this.updateCheck_btn);
            this.Controls.Add(this.UpdateCheckBar);
            this.Controls.Add(this.Curreent_ver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updatecs";
            this.Text = "Updatecs";
            this.Curreent_ver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentVer_lab;
        private System.Windows.Forms.Panel Curreent_ver;
        private Bunifu.Framework.UI.BunifuElipse CurrentverElipse;
        private Bunifu.Framework.UI.BunifuProgressBar UpdateCheckBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updateCheck_btn;
        private System.Windows.Forms.Timer progressTime;
    }
}