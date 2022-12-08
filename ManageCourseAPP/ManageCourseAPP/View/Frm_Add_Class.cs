using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCourseAPP.DAL;
using ManageCourseAPP.Entity;
using ManageCourseAPP.Service;


namespace ManageCourseAPP.View
{
    public partial class Frm_Add_Class : Form
    {
        ClasseService classeService;
        public Frm_Add_Class()
        {
            InitializeComponent();
            classeService= new ClasseService();
        }

        private void bnt_reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_RegClass.Text != string.Empty)
                {
                    classeService.CreateClasse(new Classe(txt_RegClass.Text));
                    MessageBox.Show("classe add success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("veuillez renseigner le champ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
