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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            roundedButton1.BackColor = AppColors.PanelBackground;
            roundedButton2.BackColor = AppColors.PanelBackground;
        }
    }
}
