using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageCours
{
    public partial class Frm_PlashScreen : Form
    {
        public Frm_PlashScreen()
        {
            InitializeComponent();
            
        }
        int compteur = 0;
        private void Frm_PlashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer_Pourcentage.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Width += 5;
            if (progressBar1.Width >= 580)
            {
                timer1.Stop();
                Frm_WelcomeApp frm_WelcomeApp = new Frm_WelcomeApp();
                frm_WelcomeApp.Show();
                this.Hide();
            }
        }

        private void timer_Pourcentage_Tick(object sender, EventArgs e)
        {
            compteur += 1;
            pourcentage.Text = compteur + "%";
            if (compteur == 100)
            {
                timer_Pourcentage.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            var dialogResult = MessageBox.Show(
                "Are you sure you want this windows?",
                "Windows Closing",
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
    }
}
