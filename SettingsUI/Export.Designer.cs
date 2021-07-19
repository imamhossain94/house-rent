namespace House_Rent.SettingsUI
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.ExportPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.export_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ExportPrevElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportPanel
            // 
            this.ExportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportPanel.BackColor = System.Drawing.Color.White;
            this.ExportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportPanel.Controls.Add(this.label2);
            this.ExportPanel.Location = new System.Drawing.Point(202, 53);
            this.ExportPanel.Name = "ExportPanel";
            this.ExportPanel.Size = new System.Drawing.Size(549, 417);
            this.ExportPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preview:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXPORT DATA";
            // 
            // export_btn
            // 
            this.export_btn.BackColor = System.Drawing.Color.Transparent;
            this.export_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("export_btn.BackgroundImage")));
            this.export_btn.ButtonText = "EXPORT";
            this.export_btn.ButtonTextMarginLeft = 0;
            this.export_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.export_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.export_btn.DisabledForecolor = System.Drawing.Color.White;
            this.export_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_btn.ForeColor = System.Drawing.Color.Black;
            this.export_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.export_btn.IconPadding = 10;
            this.export_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.export_btn.IdleBorderColor = System.Drawing.Color.Black;
            this.export_btn.IdleBorderRadius = 20;
            this.export_btn.IdleBorderThickness = 2;
            this.export_btn.IdleFillColor = System.Drawing.Color.White;
            this.export_btn.IdleIconLeftImage = null;
            this.export_btn.IdleIconRightImage = null;
            this.export_btn.Location = new System.Drawing.Point(399, 488);
            this.export_btn.Name = "export_btn";
            stateProperties1.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.export_btn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.export_btn.OnPressedState = stateProperties2;
            this.export_btn.Size = new System.Drawing.Size(160, 40);
            this.export_btn.TabIndex = 99;
            this.export_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // ExportPrevElipse
            // 
            this.ExportPrevElipse.ElipseRadius = 15;
            this.ExportPrevElipse.TargetControl = this.ExportPanel;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(966, 551);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Export";
            this.Text = "Export";
            this.ExportPanel.ResumeLayout(false);
            this.ExportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ExportPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton export_btn;
        private Bunifu.Framework.UI.BunifuElipse ExportPrevElipse;
    }
}