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
    public partial class RecipeViewForm : Form
    {
        private int recipeId;
        public RecipeViewForm(int id)
        {
            InitializeComponent();
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;//акцценторанжлайт
            panel3.BackColor = AppColors.Shapka;//шапка
            splitContainer1.Panel2.BackColor = AppColors.PanelBackground;
            roundedButton1.BackColor = AppColors.AccentOrange;
            panel2.BackColor = AppColors.AccentGreen2;

            recipeId = id;
            LoadRecipeData();
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

        private void LoadRecipeData()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Основные данные + теги
                    string recipeQuery = @"
                        SELECT r.название_рецепта, r.сложность_рецепта, r.время_приготовления_рецепта, r.инструкция_рецепта,
                               GROUP_CONCAT(t.название_тега SEPARATOR ', ') AS теги
                        FROM рецепты r
                        LEFT JOIN рецепт_тег rt ON r.айди_рецепта = rt.айди_рецепта
                        LEFT JOIN теги t ON rt.айди_тега = t.айди_тега
                        WHERE r.айди_рецепта = @id
                        GROUP BY r.айди_рецепта
                    ";
                    MySqlCommand cmdRecipe = new MySqlCommand(recipeQuery, conn);
                    cmdRecipe.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader reader = cmdRecipe.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTitle.Text = reader.GetString("название_рецепта");
                            txtComplexity.Text = reader.GetString("сложность_рецепта");
                            txtTime.Text = reader.GetInt32("время_приготовления_рецепта").ToString() + " мин";
                            txtInstruction.Text = reader.GetString("инструкция_рецепта");
                            string tags = reader["теги"] == DBNull.Value ? "" : reader.GetString("теги");
                            lblTags.Text = tags;
                        }
                        else
                        {
                            MessageBox.Show("Рецепт не найден.");
                            this.Close();
                        }
                    }

                    // Ингредиенты с количеством
                    string ingredientsQuery = @"
                        SELECT и.название_ингредиента, ри.количество
                        FROM рецепт_ингредиент ри
                        JOIN ингредиенты и ON ри.айди_ингредиента = и.айди_ингредиента
                        WHERE ри.айди_рецепта = @id
                        ORDER BY и.название_ингредиента
                    ";
                    MySqlCommand cmdIngredients = new MySqlCommand(ingredientsQuery, conn);
                    cmdIngredients.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader readerIng = cmdIngredients.ExecuteReader())
                    {
                        checkedListBoxIngredients.Items.Clear();
                        while (readerIng.Read())
                        {
                            string name = readerIng.GetString("название_ингредиента");
                            string quantity = readerIng.GetString("количество");
                            checkedListBoxIngredients.Items.Add($"{name} — {quantity}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецепта: " + ex.Message);
                }
            }
        }
    }
}
