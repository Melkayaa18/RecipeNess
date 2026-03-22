using RecipeNess.classes;
using RecipeNess.controls;
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
            LoadDailyRecipes();
            btnSearch.BackColor = AppColors.AccentGreenLight;
            btnLogin.BackColor = AppColors.AccentGreenLight;
            btnRegister.BackColor = AppColors.AccentGreenLight;
        }

        private void LoadDailyRecipes()
        {
            var dailyRecipes = new List<Recipe>
        {
            new Recipe { Id = 1, Title = "Борщ", Image = null },
            new Recipe { Id = 2, Title = "Пельмени", Image = null },
            new Recipe { Id = 3, Title = "Оливье", Image = null }
        };

            DisplayDailyRecipes(dailyRecipes);
        }

        
        private void DisplayDailyRecipes(List<Recipe> recipes)
        {
            
            flowLayoutPanelDailyRecipes.Controls.Clear();

            foreach (var recipe in recipes)
            {
                
                var card = new NewRecipeCard();
                card.Title = recipe.Title;

                
                if (recipe.Image != null)
                    card.Image = recipe.Image;
                else    
                    card.ViewClick += (s, e) => OpenRecipeView(recipe.Id);
                flowLayoutPanelDailyRecipes.Controls.Add(card);
            }
        }

        private void OpenRecipeView(int recipeId)
        {
            MessageBox.Show($"Открыть рецепт с ID {recipeId}");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {

                UpdateUIForAuth();

                LoadDailyRecipes();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {

                var searchForm = new Form1();
                searchForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для использования поиска необходимо войти или зарегистрироваться.",
                                "Требуется авторизация",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void UpdateUIForAuth()
        {
            if (UserSession.IsLoggedIn)
            {
                btnLogin.Text = $"Привет, {UserSession.Username}";
                btnRegister.Visible = false;
            }
            else
            {
                btnLogin.Text = "Вход";
                btnRegister.Visible = true;
            }
        }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }
    }
}
