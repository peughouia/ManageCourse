﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCourseAPP.View
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(
             "Are you sure you want to close application?",
             "Close Application",
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
