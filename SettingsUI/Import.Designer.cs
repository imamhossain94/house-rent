namespace House_Rent.SettingsUI
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.DrupDropPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.import_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DrupDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DrupDropPanel
            // 
            this.DrupDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrupDropPanel.BackColor = System.Drawing.Color.White;
            this.DrupDropPanel.Controls.Add(this.pictureBox1);
            this.DrupDropPanel.Controls.Add(this.label2);
            this.DrupDropPanel.Location = new System.Drawing.Point(202, 64);
            this.DrupDropPanel.Name = "DrupDropPanel";
            this.DrupDropPanel.Size = new System.Drawing.Size(549, 406);
            this.DrupDropPanel.TabIndex = 0;
            this.DrupDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DrupDropPanel_DragDrop);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag and drop file here or click to browse for a file";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORT EXISTING DATA";
            // 
            // import_btn
            // 
            this.import_btn.BackColor = System.Drawing.Color.Transparent;
            this.import_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("import_btn.BackgroundImage")));
            this.import_btn.ButtonText = "IMPORT";
            this.import_btn.ButtonTextMarginLeft = 0;
            this.import_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.import_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.import_btn.DisabledForecolor = System.Drawing.Color.White;
            this.import_btn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_btn.ForeColor = System.Drawing.Color.Black;
            this.import_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.import_btn.IconPadding = 10;
            this.import_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.import_btn.IdleBorderColor = System.Drawing.Color.Black;
            this.import_btn.IdleBorderRadius = 20;
            this.import_btn.IdleBorderThickness = 2;
            this.import_btn.IdleFillColor = System.Drawing.Color.White;
            this.import_btn.IdleIconLeftImage = null;
            this.import_btn.IdleIconRightImage = null;
            this.import_btn.Location = new System.Drawing.Point(399, 488);
            this.import_btn.Name = "import_btn";
            stateProperties1.BorderColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.DarkSlateGray;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.import_btn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.import_btn.OnPressedState = stateProperties2;
            this.import_btn.Size = new System.Drawing.Size(160, 40);
            this.import_btn.TabIndex = 98;
            this.import_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.DrupDropPanel;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(966, 551);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.DrupDropPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Import";
            this.Text = "Import";
            this.DrupDropPanel.ResumeLayout(false);
            this.DrupDropPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrupDropPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton import_btn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}