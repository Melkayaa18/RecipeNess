using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess.forms
{
    public partial class MainWindForm : Form
    {
        public MainWindForm()
        {
            InitializeComponent();
            roundedButton1.BackColor = AppColors.AccentGreenLight;
            roundedButton2.BackColor = AppColors.AccentGreenLight;
            roundedButton3.BackColor = AppColors.AccentGreenLight;
        }

    }
}
