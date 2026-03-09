using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class RecipeEditForm : Form
    {
        public RecipeEditForm()
        {
            InitializeComponent();
            this.BackColor = AppColors.MainBackground;

            
            splitContainer1.Panel2.BackColor = AppColors.MainBackground;
            splitContainer1.Panel1.BackColor = AppColors.AccentOran1;
            panel1.BackColor = AppColors.PanelBackground;
            panel3.BackColor = AppColors.PanelBackground;
            panel2.BackColor = AppColors.AccentGreen;
            pictureBox1.BackColor = AppColors.PanelBackground;
            label5.ForeColor = AppColors.MainBackground;
            label6.ForeColor = AppColors.MainBackground;
            label7.ForeColor = AppColors.MainBackground;
            label8.ForeColor = AppColors.MainBackground;
            label9.ForeColor = AppColors.MainBackground;
            label10.ForeColor = AppColors.Separator;
            label11.ForeColor = AppColors.Separator;
            label12.ForeColor = AppColors.Separator;
            label13.ForeColor = AppColors.Separator;
            label2.ForeColor = AppColors.MainText;
            label1.ForeColor = AppColors.MainText;
            label4.ForeColor = AppColors.MainBackground;
            label3.ForeColor = AppColors.MainBackground;
            roundedButton1.BackColor = AppColors.AccentOrangeLight;
            roundedButton2.BackColor = AppColors.AccentOrangeLight;
            roundedButton3.BackColor = AppColors.AccentOrangeLight;
            roundedButton4.BackColor = AppColors.AccentGreenLight;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
