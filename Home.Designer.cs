namespace House_Rent
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MainDataGardView = new System.Windows.Forms.DataGridView();
            this.Home_Search_box = new System.Windows.Forms.TextBox();
            this.home_srch_ins_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGardView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGardView
            // 
            this.MainDataGardView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGardView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MainDataGardView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDataGardView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGardView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGardView.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGardView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGardView.Location = new System.Drawing.Point(67, 81);
            this.MainDataGardView.Name = "MainDataGardView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGardView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MainDataGardView.RowHeadersWidth = 25;
            this.MainDataGardView.RowTemplate.Height = 24;
            this.MainDataGardView.Size = new System.Drawing.Size(1585, 786);
            this.MainDataGardView.TabIndex = 3;
            // 
            // Home_Search_box
            // 
            this.Home_Search_box.BackColor = System.Drawing.Color.White;
            this.Home_Search_box.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Search_box.ForeColor = System.Drawing.Color.Black;
            this.Home_Search_box.Location = new System.Drawing.Point(67, 36);
            this.Home_Search_box.Name = "Home_Search_box";
            this.Home_Search_box.Size = new System.Drawing.Size(1585, 39);
            this.Home_Search_box.TabIndex = 38;
            this.Home_Search_box.TextChanged += new System.EventHandler(this.Home_Search_btn_TextChanged);
            // 
            // home_srch_ins_btn
            // 
            this.home_srch_ins_btn.BackColor = System.Drawing.Color.White;
            this.home_srch_ins_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home_srch_ins_btn.BackgroundImage")));
            this.home_srch_ins_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home_srch_ins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_srch_ins_btn.ForeColor = System.Drawing.Color.White;
            this.home_srch_ins_btn.Location = new System.Drawing.Point(1613, 40);
            this.home_srch_ins_btn.Name = "home_srch_ins_btn";
            this.home_srch_ins_btn.Size = new System.Drawing.Size(30, 30);
            this.home_srch_ins_btn.TabIndex = 40;
            this.home_srch_ins_btn.UseVisualStyleBackColor = false;
            this.home_srch_ins_btn.Click += new System.EventHandler(this.Home_srch_ins_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1738, 929);
            this.Controls.Add(this.home_srch_ins_btn);
            this.Controls.Add(this.Home_Search_box);
            this.Controls.Add(this.MainDataGardView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGardView;
        private System.Windows.Forms.TextBox Home_Search_box;
        private System.Windows.Forms.Button home_srch_ins_btn;
    }
}