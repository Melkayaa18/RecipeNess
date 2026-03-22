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
    public partial class ProfileMainForm : Form
    {
        public ProfileMainForm()
        {
            InitializeComponent();
            panel1.BackColor = AppColors.Shapka;
            roundedButton1.BackColor = AppColors.AccentOran1;
            roundedButton2.BackColor = AppColors.AccentOran1;
            tabPage1.BackColor = AppColors.AccentGreenLight;
            tabPage2.BackColor = AppColors.AccentGreenLight;
            label7.ForeColor = AppColors.MainText;

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form1 form1 = new Form1())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}
