using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent.SettingsUI
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void DrupDropPanel_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working heard to bring this functionality","Wait",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }
    }
}
