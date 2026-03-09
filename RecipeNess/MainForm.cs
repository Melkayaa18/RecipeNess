using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panel1.BackColor = AppColors.AccentOran1;
            roundedButton1.BackColor = AppColors.AccentOrange;
            tabPage1.BackColor = AppColors.MainBackground;
            tabPage2.BackColor = AppColors.MainBackground;
            label7.ForeColor = AppColors.MainText;
        }
    }
}
