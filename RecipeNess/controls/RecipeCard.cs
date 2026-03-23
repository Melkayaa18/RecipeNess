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
    public partial class RecipeCard : UserControl
    {
        public event EventHandler ViewClick;
        public RecipeCard()
        {
            InitializeComponent();


            roundedButton1.BackColor = AppColors.AccentGreen2;
            roundedButton1.ForeColor = AppColors.MainBackground;
            panel1.BackColor = AppColors.PanelBackground;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TagText
        {
            get { return lblTag.Text; }
            set { lblTag.Text = value; }
        }


        private void roundedButton1_Click(object sender, EventArgs e)
        {
            ViewClick?.Invoke(this, EventArgs.Empty);
        }
        private void OpenRecipeView(int recipeId)
        {
            MessageBox.Show($"Открываем рецепт с ID {recipeId}"); // отладка
            RecipeViewForm viewForm = new RecipeViewForm(recipeId);
            viewForm.ShowDialog();
        }
    }
}
