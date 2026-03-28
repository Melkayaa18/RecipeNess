using MySql.Data.MySqlClient;
using RecipeNess.classes;
using System;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class RecipeViewForm : Form
    {
        private int recipeId;
        private bool isFavorite = false;

        public RecipeViewForm(int id)
        {
            InitializeComponent();
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;
            panel3.BackColor = AppColors.Shapka;
            splitContainer1.Panel2.BackColor = AppColors.PanelBackground;
            btnFavorite.BackColor = AppColors.AccentOrange; // по умолчанию, но переопределится после проверки
            panel2.BackColor = AppColors.AccentGreen2;
            recipeId = id;
            LoadRecipeData();

        }

        private void LoadRecipeData()
        {
            //MessageBox.Show($"CurrentUser.Id = {CurrentUser.Id}");
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
                        GROUP BY r.айди_рецепта";
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
                            return;
                        }
                    }

                    // Ингредиенты
                    string ingredientsQuery = @"
                        SELECT и.название_ингредиента, ри.количество
                        FROM рецепт_ингредиент ри
                        JOIN ингредиенты и ON ри.айди_ингредиента = и.айди_ингредиента
                        WHERE ри.айди_рецепта = @id
                        ORDER BY и.название_ингредиента";
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

                    // Проверка, добавлен ли рецепт в избранное
                    string checkFav = "SELECT COUNT(*) FROM избранное WHERE айди_пользователя = @userId AND айди_рецепта = @recipeId";
                    MySqlCommand cmdFav = new MySqlCommand(checkFav, conn);
                    cmdFav.Parameters.AddWithValue("@userId", CurrentUser.Id);
                    cmdFav.Parameters.AddWithValue("@recipeId", recipeId);
                    int count = Convert.ToInt32(cmdFav.ExecuteScalar());
                    isFavorite = (count > 0);
                    if (isFavorite)
                        btnFavorite.BackColor = AppColors.AccentOrange; // активный цвет
                    else
                        btnFavorite.BackColor = Color.Transparent; // прозрачный или другой цвет по умолчанию
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецепта: " + ex.Message);
                }
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnFavorite_Click вызван");
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    if (isFavorite)
                    {
                        // Удаляем из избранного
                        string deleteSql = "DELETE FROM избранное WHERE айди_пользователя = @userId AND айди_рецепта = @recipeId";
                        MySqlCommand cmd = new MySqlCommand(deleteSql, conn);
                        cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);
                        cmd.Parameters.AddWithValue("@recipeId", recipeId);
                        cmd.ExecuteNonQuery();
                        btnFavorite.BackColor = Color.Transparent;
                        isFavorite = false;
                    }
                    else
                    {
                        // Добавляем в избранное
                        string insertSql = "INSERT INTO избранное (айди_пользователя, айди_рецепта) VALUES (@userId, @recipeId)";
                        MySqlCommand cmd = new MySqlCommand(insertSql, conn);
                        cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);
                        cmd.Parameters.AddWithValue("@recipeId", recipeId);
                        cmd.ExecuteNonQuery();
                        btnFavorite.BackColor = AppColors.AccentOrange;
                        isFavorite = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении избранного: " + ex.Message);
                }
            }
        }
    }
}