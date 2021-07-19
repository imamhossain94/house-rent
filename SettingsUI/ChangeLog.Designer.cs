namespace House_Rent.SettingsUI
{
    partial class ChangeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLog));
            this.label1 = new System.Windows.Forms.Label();
            this.ChangelogBox = new System.Windows.Forms.TextBox();
            this.ChnglogBoxElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textPanel = new System.Windows.Forms.Panel();
            this.TimerForLog = new System.Windows.Forms.Timer(this.components);
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHANGELOG";
            // 
            // ChangelogBox
            // 
            this.ChangelogBox.BackColor = System.Drawing.Color.White;
            this.ChangelogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangelogBox.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangelogBox.Location = new System.Drawing.Point(16, 0);
            this.ChangelogBox.Multiline = true;
            this.ChangelogBox.Name = "ChangelogBox";
            this.ChangelogBox.Size = new System.Drawing.Size(860, 2000);
            this.ChangelogBox.TabIndex = 5;
            this.ChangelogBox.Text = resources.GetString("ChangelogBox.Text");
            this.ChangelogBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChnglogBoxElipse
            // 
            this.ChnglogBoxElipse.ElipseRadius = 15;
            this.ChnglogBoxElipse.TargetControl = this.textPanel;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.White;
            this.textPanel.Controls.Add(this.ChangelogBox);
            this.textPanel.Location = new System.Drawing.Point(35, 60);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(893, 449);
            this.textPanel.TabIndex = 6;
            // 
            // TimerForLog
            // 
            this.TimerForLog.Enabled = true;
            this.TimerForLog.Interval = 5;
            this.TimerForLog.Tick += new System.EventHandler(this.TimerForLog_Tick);
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(966, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeLog";
            this.Text = "ChangeLog";
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangelogBox;
        private Bunifu.Framework.UI.BunifuElipse ChnglogBoxElipse;
        private System.Windows.Forms.Timer TimerForLog;
        private System.Windows.Forms.Panel textPanel;
    }
}