using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class RecipeViewForm : Form
    {
        public RecipeViewForm()
        {
            InitializeComponent();
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;//акцценторанжлайт
            panel3.BackColor = AppColors.Shapka;//шапка
            splitContainer1.Panel2.BackColor = AppColors.PanelBackground;
            roundedButton1.BackColor = AppColors.AccentOrange;
            panel2.BackColor = AppColors.AccentGreen2;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
