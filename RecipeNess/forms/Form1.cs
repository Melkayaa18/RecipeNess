using MySql.Data.MySqlClient;
using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class Form1 : Form
    {
        // Список всех ингредиентов для поиска
        private List<IngredientItem> allIngredients = new List<IngredientItem>();
        private int? selectedCategoryId = null;
        private Dictionary<Button, int> categoryButtons = new Dictionary<Button, int>();

        public Form1()
        {
            InitializeComponent();

            LoadIngredients();
            LoadComplexity();
            SetupCategoryButtons();
            textBox1.TextChanged += TextBox1_TextChanged;

            // Оформление (оставляем как было)
            panel1.BackColor = AppColors.Shapka;
            flowLayoutPanel1.BackColor = AppColors.AccentGreenLight;
            label7.ForeColor = AppColors.MainText;
            label1.ForeColor = AppColors.MainText;
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;
            roundedButton1.BackColor = AppColors.Shapka;
            roundedButton2.BackColor = AppColors.AccentOran1;
            roundedButton3.BackColor = AppColors.Shapka;
            roundedButton4.BackColor = AppColors.Shapka;
            roundedButton5.BackColor = AppColors.Shapka;
            roundedButton6.BackColor = AppColors.Shapka;
            roundedButton7.BackColor = AppColors.Shapka;
        }

        private void LoadIngredients()
        {
            string query = "SELECT айди_ингредиента, название_ингредиента FROM ингредиенты ORDER BY название_ингредиента";
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    allIngredients.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_ингредиента");
                        string name = reader.GetString("название_ингредиента");
                        allIngredients.Add(new IngredientItem(id, name));
                    }
                    reader.Close();

                    // Отображаем все ингредиенты
                    RefreshIngredientList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки ингредиентов: " + ex.Message);
                }
            }
        }

        private void RefreshIngredientList()
        {
            string searchText = textBox1?.Text.Trim().ToLower() ?? "";
            checkedListBoxIngredients.Items.Clear();

            foreach (var ing in allIngredients)
            {
                if (string.IsNullOrEmpty(searchText) || ing.Name.ToLower().Contains(searchText))
                {
                    checkedListBoxIngredients.Items.Add(ing);
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshIngredientList();
        }

        private void LoadComplexity()
        {
            comboBoxComplexity.Items.Clear();
            comboBoxComplexity.Items.Add("Любая");
            comboBoxComplexity.Items.Add("легко");
            comboBoxComplexity.Items.Add("средне");
            comboBoxComplexity.Items.Add("сложно");
            comboBoxComplexity.SelectedIndex = 0;
        }

        private void SetupCategoryButtons()
        {
            // Загружаем ID категорий из БД
            Dictionary<string, int> catIds = new Dictionary<string, int>();
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_категории_рецепта, название_категории FROM категории_рецептов";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_категории_рецепта");
                        string name = reader.GetString("название_категории");
                        catIds[name] = id;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
                    return;
                }
            }

            var buttons = new[] { roundedButton4, roundedButton5, roundedButton6, roundedButton7 };
            var catNames = new[] { "Завтрак", "Обед", "Ужин", "Перекус" };
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != null && catIds.ContainsKey(catNames[i]))
                {
                    categoryButtons[buttons[i]] = catIds[catNames[i]];
                    buttons[i].Click += CategoryButton_Click;
                }
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null) return;

            if (selectedCategoryId.HasValue && selectedCategoryId.Value == categoryButtons[clicked])
            {
                selectedCategoryId = null;
                ResetCategoryButtonsAppearance();
            }
            else
            {
                selectedCategoryId = categoryButtons[clicked];
                ResetCategoryButtonsAppearance();
                clicked.BackColor = Color.LightGreen;
            }
        }

        private void ResetCategoryButtonsAppearance()
        {
            foreach (var btn in categoryButtons.Keys)
            {
                btn.BackColor = AppColors.Shapka;
            }
            if (selectedCategoryId.HasValue)
            {
                foreach (var kvp in categoryButtons)
                {
                    if (kvp.Value == selectedCategoryId.Value)
                    {
                        kvp.Key.BackColor = Color.LightGreen;
                        break;
                    }
                }
            }
        }

        private void DisplayRecipes(List<Recipe> recipes)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var recipe in recipes)
            {
                var card = new RecipeCard();
                card.Title = recipe.Title;
                card.TagText = recipe.Tags;       
                card.ViewClick += (s, e) => OpenRecipeView(recipe.Id);

                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void OpenRecipeView(int recipeId)
        {
            RecipeViewForm viewForm = new RecipeViewForm(recipeId);
            viewForm.ShowDialog();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            List<int> selectedIngredientIds = new List<int>();
            foreach (var item in checkedListBoxIngredients.CheckedItems)
            {
                if (item is IngredientItem ing)
                {
                    selectedIngredientIds.Add(ing.Id);
                }
            }

            string complexity = comboBoxComplexity.SelectedItem?.ToString() ?? "Любая";
            string complexityFilter = complexity == "Любая" ? null : complexity;
            int maxTime = (int)numericUpDown1.Value;

            List<Recipe> filteredRecipes = LoadRecipesFromDb(selectedIngredientIds, complexityFilter, maxTime, selectedCategoryId);
            DisplayRecipes(filteredRecipes);
        }

        private List<Recipe> LoadRecipesFromDb(List<int> ingredientIds, string complexity, int maxTime, int? categoryId)
        {
            List<Recipe> recipes = new List<Recipe>();

            // Базовый подзапрос для фильтрации по ингредиентам (если выбраны)
            string subquery = "";
            if (ingredientIds.Count > 0)
            {
                string ids = string.Join(",", ingredientIds);
                subquery = $@"
            SELECT ri.айди_рецепта
            FROM рецепт_ингредиент ri
            WHERE ri.айди_ингредиента IN ({ids})
            GROUP BY ri.айди_рецепта
            HAVING COUNT(DISTINCT ri.айди_ингредиента) = {ingredientIds.Count}
        ";
            }

            // Дополнительные условия фильтрации (сложность, время, категория)
            string additionalFilters = "";
            if (!string.IsNullOrEmpty(complexity))
                additionalFilters += $" AND r.сложность_рецепта = '{complexity}'";
            if (maxTime > 0)
                additionalFilters += $" AND r.время_приготовления_рецепта <= {maxTime}";
            if (categoryId.HasValue)
                additionalFilters += $" AND r.айди_категории_рецепта = {categoryId.Value}";

            // Формируем итоговый запрос
            string finalSql;
            if (ingredientIds.Count == 0)
            {
                finalSql = $@"
            SELECT r.айди_рецепта, r.название_рецепта, GROUP_CONCAT(t.название_тега SEPARATOR ', ') AS теги
            FROM рецепты r
            LEFT JOIN рецепт_тег rt ON r.айди_рецепта = rt.айди_рецепта
            LEFT JOIN теги t ON rt.айди_тега = t.айди_тега
            WHERE 1=1 {additionalFilters}
            GROUP BY r.айди_рецепта
        ";
            }
            else
            {
                finalSql = $@"
            SELECT r.айди_рецепта, r.название_рецепта, GROUP_CONCAT(t.название_тега SEPARATOR ', ') AS теги
            FROM рецепты r
            LEFT JOIN рецепт_тег rt ON r.айди_рецепта = rt.айди_рецепта
            LEFT JOIN теги t ON rt.айди_тега = t.айди_тега
            WHERE r.айди_рецепта IN ({subquery}) {additionalFilters}
            GROUP BY r.айди_рецепта
        ";
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(finalSql, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("айди_рецепта");
                            string title = reader.GetString("название_рецепта");
                            string tags = reader["теги"] == DBNull.Value ? "" : reader.GetString("теги");
                            recipes.Add(new Recipe { Id = id, Title = title, Tags = tags });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецептов: " + ex.Message);
                }
            }

            return recipes;
        }

        // Остальные обработчики
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RecipeEditForm recipeEditForm = new RecipeEditForm())
            {
                if (recipeEditForm.ShowDialog() == DialogResult.OK)
                    this.Show();
                else
                    this.Show();
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ProfileMainForm profileMainForm = new ProfileMainForm())
            {
                if (profileMainForm.ShowDialog() == DialogResult.OK)
                    this.Show();
                else
                    this.Show();
            }
        }
    }

    public class IngredientItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IngredientItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }
        public string Tags { get; set; }
    }
}