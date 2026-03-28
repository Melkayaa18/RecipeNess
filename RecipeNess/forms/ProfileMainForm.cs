using MySql.Data.MySqlClient;
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
            this.Load += ProfileForm_Load;
            panel1.BackColor = AppColors.Shapka;
            roundedButton1.BackColor = AppColors.AccentOran1;
            roundedButton2.BackColor = AppColors.AccentOran1;
            tabPage1.BackColor = AppColors.AccentGreenLight;
            tabPage2.BackColor = AppColors.AccentGreenLight;
            label7.ForeColor = AppColors.MainText;

        }
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadFavoriteRecipes();
            LoadMyRecipes();
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

        private void LoadFavoriteRecipes()
        {
            flowLayoutPanelFavorite.Controls.Clear();
            string query = @"
                SELECT r.айди_рецепта, r.название_рецепта
                FROM избранное f
                JOIN рецепты r ON f.айди_рецепта = r.айди_рецепта
                WHERE f.айди_пользователя = @userId
                ORDER BY r.название_рецепта";
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Recipe> recipes = new List<Recipe>();
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Id = reader.GetInt32("айди_рецепта"),
                            Title = reader.GetString("название_рецепта")
                        });
                    }
                    reader.Close();
                    DisplayRecipes(recipes, flowLayoutPanelFavorite);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки избранного: " + ex.Message);
                }
            }
        }
        // Загрузка рецептов, созданных пользователем
        private void LoadMyRecipes()
        {
            flowLayoutPanelMyRecipes.Controls.Clear();
            string query = @"
                SELECT айди_рецепта, название_рецепта
                FROM рецепты
                WHERE айди_пользователя = @userId
                ORDER BY название_рецепта";
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Recipe> recipes = new List<Recipe>();
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe
                        {
                            Id = reader.GetInt32("айди_рецепта"),
                            Title = reader.GetString("название_рецепта")
                        });
                    }
                    reader.Close();
                    DisplayRecipes(recipes, flowLayoutPanelMyRecipes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки моих рецептов: " + ex.Message);
                }
            }
        }// Общий метод для отображения карточек в FlowLayoutPanel
        private void DisplayRecipes(List<Recipe> recipes, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();
            if (recipes.Count == 0)
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Нет рецептов";
                lblEmpty.ForeColor = AppColors.MainText;
                lblEmpty.AutoSize = true;
                panel.Controls.Add(lblEmpty);
                return;
            }
            foreach (var recipe in recipes)
            {
                var card = new RecipeCard();
                card.Title = recipe.Title;
                card.ViewClick += (s, e) => OpenRecipeView(recipe.Id);
                panel.Controls.Add(card);
            }
        }

        private void OpenRecipeView(int recipeId)
        {
            RecipeViewForm viewForm = new RecipeViewForm(recipeId);
            viewForm.ShowDialog();
            // После закрытия окна просмотра обновляем списки (на случай, если избранное изменилось)
            LoadFavoriteRecipes();
            LoadMyRecipes();
        }
    }

}

