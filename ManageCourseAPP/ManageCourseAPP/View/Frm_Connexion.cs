using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCourseAPP.Resources
{
    public partial class Frm_Connexion : Form
    {
        public Frm_Connexion()
        {
            InitializeComponent();
        }

        private void Frm_Connexion_Load(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
                "Are you sure you want to close this window?",
                "Close windows",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }


        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {

        }
    }
}
