using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess.controls
{
    public partial class NewRecipeCard : UserControl
    {
        public NewRecipeCard()
        {
            InitializeComponent();
            roundedButton1.BackColor = AppColors.AccentGreen2;
            roundedButton1.ForeColor = AppColors.MainBackground;
            lblTitle.BackColor = AppColors.AccentGreenLight;


        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image
        {
            get => pbImage.Image;
            set => pbImage.Image = value;
        }

        // Событие, которое вызывается при клике на кнопку
        public event EventHandler ViewClick;

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewClick?.Invoke(this, e);
        }
    }
}
