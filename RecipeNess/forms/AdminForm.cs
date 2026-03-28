using MySql.Data.MySqlClient;
using RecipeNess.classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class AdminForm : Form
    {
        private int currentRecipeId = -1; // ID текущего выбранного рецепта
        private int currentModerationRecipeId = -1;

        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
            listBoxRecipes.SelectedIndexChanged += listBoxRecipes_SelectedIndexChanged;
            textBoxSearchIngredient.TextChanged += textBoxSearchIngredient_TextChanged;
            comboBoxSortIngredient.SelectedIndexChanged += comboBoxSortIngredient_SelectedIndexChanged;
            roundedButton2.Click += roundedButton2_Click;
            listBoxModerationRecipes.SelectedIndexChanged += listBoxModerationRecipes_SelectedIndexChanged;
            roundedButtonDelete.Click += btnDeleteRecipe_Click_1;

            panel1.BackColor = AppColors.AccentOran1;
            label1.ForeColor = AppColors.MainText;
            label2.ForeColor = AppColors.MainBackground;
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;
            panel3.BackColor = AppColors.AccentOrangeLight;
            splitContainer1.Panel2.BackColor = AppColors.MainBackground;
            panel2.BackColor = AppColors.Shapka;
            panel4.BackColor = AppColors.PanelBackground;
            panel5.BackColor = AppColors.PanelBackground;
            panel6.BackColor = AppColors.AccentGreen2;
            roundedButton2.BackColor = AppColors.Shapka;
            roundedButton3.BackColor = AppColors.Shapka;
            label5.ForeColor = AppColors.MainBackground;
            label6.ForeColor = AppColors.MainBackground;
            label7.ForeColor = AppColors.MainBackground;
            label8.ForeColor = AppColors.MainBackground;
            label9.ForeColor = AppColors.MainBackground;
            label10.ForeColor = AppColors.MainBackground;
            label11.ForeColor = AppColors.MainBackground;
            label12.ForeColor = AppColors.MainBackground;
            label13.ForeColor = AppColors.MainBackground;
            label15.ForeColor = AppColors.MainBackground;
            roundedButton4.BackColor = AppColors.AccentGreenLight;
            roundedButton5.BackColor = AppColors.Shapka;
            roundedButtonDelete.BackColor = AppColors.MainBackground;

            splitContainer2.Panel2.BackColor = AppColors.AccentGreenLight;
            splitContainer2.Panel1.BackColor = AppColors.AccentOrangeLight;
            btnApprove.BackColor = AppColors.Shapka;
            btnReject.BackColor = AppColors.Shapka;
            panel7.BackColor = AppColors.Shapka;
            label23.ForeColor = AppColors.MainText;
            pictureBox2.BackColor = AppColors.AccentGreen2;

            panel8.BackColor = AppColors.AccentOrangeLight;
            tabPage3.BackColor = AppColors.AccentGreenLight;
            roundedButton8.BackColor = AppColors.Shapka;
            label26.ForeColor = AppColors.MainText;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadRecipes();
            LoadCategories();
            LoadSortOptions();
            LoadIngredientsAdmin();
            LoadSortOptions();
            LoadIngredientsAdmin();
            SetupIngredientsEvents();
            LoadModerationRecipes();
        }

        private void LoadRecipes()
        {
            if (listBoxRecipes == null || textBoxCount == null)
            {
                MessageBox.Show("Элементы listBoxRecipes или textBoxCount не найдены на форме!");
                return;
            }

            listBoxRecipes.Items.Clear();

            string query = "SELECT айди_рецепта, название_рецепта FROM рецепты ORDER BY название_рецепта";

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int count = 0;
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_рецепта");
                        string title = reader.GetString("название_рецепта");
                        listBoxRecipes.Items.Add(new RecipeItem(id, title));
                        count++;
                    }
                    reader.Close();

                    textBoxCount.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецептов: " + ex.Message);
                }
            }
        }

        public class RecipeItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public RecipeItem(int id, string name) { Id = id; Name = name; }
            public override string ToString() => Name;
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem is RecipeItem selected)
            {
                currentRecipeId = selected.Id;
                LoadRecipeDetails(currentRecipeId);
            }
            else
            {
                ClearRecipeDetails();
            }
        }

        private void LoadRecipeDetails(int recipeId)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Основные данные + категория
                    string recipeQuery = @"
                        SELECT r.название_рецепта, r.время_приготовления_рецепта, r.сложность_рецепта, r.инструкция_рецепта,
                               кр.название_категории AS категория
                        FROM рецепты r
                        LEFT JOIN категории_рецептов кр ON r.айди_категории_рецепта = кр.айди_категории_рецепта
                        WHERE r.айди_рецепта = @id";
                    MySqlCommand cmd = new MySqlCommand(recipeQuery, conn);
                    cmd.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblRecipeName.Text = reader["название_рецепта"]?.ToString() ?? "";
                            numericUpDownTime.Value = reader["время_приготовления_рецепта"] != DBNull.Value
                                ? Convert.ToDecimal(reader["время_приготовления_рецепта"])
                                : 0;
                            string complexity = reader["сложность_рецепта"]?.ToString();
                            radioButtonEasy.Checked = (complexity == "легко");
                            radioButtonMedium.Checked = (complexity == "средне");
                            radioButtonHard.Checked = (complexity == "сложно");
                            textBoxInstruction.Text = reader["инструкция_рецепта"]?.ToString() ?? "";
                            string category = reader["категория"]?.ToString() ?? "";
                            if (comboBoxCategory.Items.Count > 0 && !string.IsNullOrEmpty(category))
                            {
                                int idx = comboBoxCategory.FindStringExact(category);
                                comboBoxCategory.SelectedIndex = idx != -1 ? idx : -1;
                            }
                            else
                                comboBoxCategory.SelectedIndex = -1;
                        }
                        else
                        {
                            ClearRecipeDetails();
                            return;
                        }
                    }

                    // Ингредиенты
                    string ingQuery = @"
                        SELECT и.название_ингредиента, ри.количество
                        FROM рецепт_ингредиент ри
                        JOIN ингредиенты и ON ри.айди_ингредиента = и.айди_ингредиента
                        WHERE ри.айди_рецепта = @id
                        ORDER BY и.название_ингредиента";
                    MySqlCommand cmdIng = new MySqlCommand(ingQuery, conn);
                    cmdIng.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader readerIng = cmdIng.ExecuteReader())
                    {
                        listBoxIngredients.Items.Clear();
                        while (readerIng.Read())
                        {
                            string name = readerIng.GetString("название_ингредиента");
                            string quantity = readerIng.GetString("количество");
                            listBoxIngredients.Items.Add($"{name} — {quantity}");
                        }
                    }

                    // Теги (один тег в ComboBox)
                    string tagQuery = @"
                        SELECT т.название_тега
                        FROM рецепт_тег рт
                        JOIN теги т ON рт.айди_тега = т.айди_тега
                        WHERE рт.айди_рецепта = @id
                        ORDER BY т.название_тега";
                    MySqlCommand cmdTag = new MySqlCommand(tagQuery, conn);
                    cmdTag.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader readerTag = cmdTag.ExecuteReader())
                    {
                        comboBoxTag.Items.Clear();
                        while (readerTag.Read())
                        {
                            comboBoxTag.Items.Add(readerTag.GetString("название_тега"));
                        }
                        if (comboBoxTag.Items.Count > 0)
                            comboBoxTag.SelectedIndex = 0;
                        else
                            comboBoxTag.SelectedIndex = -1;
                    }

                    pictureBoxRecipeImage.Image = null; // заглушка
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецепта: " + ex.Message);
                }
            }
        }

        private void ClearRecipeDetails()
        {
            currentRecipeId = -1;
            lblRecipeName.Text = "";
            numericUpDownTime.Value = 0;
            radioButtonEasy.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonHard.Checked = false;
            textBoxInstruction.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            listBoxIngredients.Items.Clear();
            comboBoxTag.Items.Clear();
            pictureBoxRecipeImage.Image = null;
        }

        private void LoadCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT название_категории FROM категории_рецептов ORDER BY название_категории";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBoxCategory.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxCategory.Items.Add(reader.GetString("название_категории"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
                }
            }
        }

        // ==================== СОХРАНЕНИЕ ====================
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (currentRecipeId == -1)
            {
                MessageBox.Show("Выберите рецепт для сохранения.");
                return;
            }

            string name = lblRecipeName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название рецепта.");
                return;
            }

            string complexity = "";
            if (radioButtonEasy.Checked) complexity = "легко";
            else if (radioButtonMedium.Checked) complexity = "средне";
            else if (radioButtonHard.Checked) complexity = "сложно";
            else
            {
                MessageBox.Show("Выберите сложность.");
                return;
            }

            int time = (int)numericUpDownTime.Value;
            string instruction = textBoxInstruction.Text;

            string categoryName = comboBoxCategory.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Выберите категорию.");
                return;
            }
            int categoryId = GetCategoryIdByName(categoryName);
            if (categoryId == -1)
            {
                MessageBox.Show("Категория не найдена.");
                return;
            }

            string tagName = comboBoxTag.SelectedItem?.ToString();
            int? tagId = null;
            if (!string.IsNullOrEmpty(tagName))
            {
                tagId = GetTagIdByName(tagName);
                if (tagId == -1)
                {
                    MessageBox.Show("Тег не найден.");
                    return;
                }
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Обновление основной информации
                            string updateSql = @"
                                UPDATE рецепты
                                SET название_рецепта = @name,
                                    время_приготовления_рецепта = @time,
                                    сложность_рецепта = @complexity,
                                    инструкция_рецепта = @instruction,
                                    айди_категории_рецепта = @categoryId
                                WHERE айди_рецепта = @id";
                            MySqlCommand cmdUpdate = new MySqlCommand(updateSql, conn, transaction);
                            cmdUpdate.Parameters.AddWithValue("@name", name);
                            cmdUpdate.Parameters.AddWithValue("@time", time);
                            cmdUpdate.Parameters.AddWithValue("@complexity", complexity);
                            cmdUpdate.Parameters.AddWithValue("@instruction", instruction);
                            cmdUpdate.Parameters.AddWithValue("@categoryId", categoryId);
                            cmdUpdate.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdUpdate.ExecuteNonQuery();

                            // Обновление ингредиентов
                            string deleteIngSql = "DELETE FROM рецепт_ингредиент WHERE айди_рецепта = @id";
                            MySqlCommand cmdDelIng = new MySqlCommand(deleteIngSql, conn, transaction);
                            cmdDelIng.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdDelIng.ExecuteNonQuery();

                            string insertIngSql = "INSERT INTO рецепт_ингредиент (айди_рецепта, айди_ингредиента, количество) VALUES (@recipeId, @ingredientId, @quantity)";
                            foreach (var item in listBoxIngredients.Items)
                            {
                                string itemText = item.ToString();
                                string[] parts = itemText.Split(new[] { " — " }, StringSplitOptions.None);
                                if (parts.Length != 2) continue;
                                string ingredientName = parts[0].Trim();
                                string quantity = parts[1].Trim();

                                int ingredientId = GetIngredientIdByName(ingredientName);
                                if (ingredientId == -1)
                                {
                                    MessageBox.Show($"Ингредиент '{ingredientName}' не найден. Пропускаем.");
                                    continue;
                                }

                                MySqlCommand cmdIns = new MySqlCommand(insertIngSql, conn, transaction);
                                cmdIns.Parameters.AddWithValue("@recipeId", currentRecipeId);
                                cmdIns.Parameters.AddWithValue("@ingredientId", ingredientId);
                                cmdIns.Parameters.AddWithValue("@quantity", quantity);
                                cmdIns.ExecuteNonQuery();
                            }

                            // Обновление тегов
                            string deleteTagSql = "DELETE FROM рецепт_тег WHERE айди_рецепта = @id";
                            MySqlCommand cmdDelTag = new MySqlCommand(deleteTagSql, conn, transaction);
                            cmdDelTag.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdDelTag.ExecuteNonQuery();

                            if (tagId.HasValue)
                            {
                                string insertTagSql = "INSERT INTO рецепт_тег (айди_рецепта, айди_тега) VALUES (@recipeId, @tagId)";
                                MySqlCommand cmdInsTag = new MySqlCommand(insertTagSql, conn, transaction);
                                cmdInsTag.Parameters.AddWithValue("@recipeId", currentRecipeId);
                                cmdInsTag.Parameters.AddWithValue("@tagId", tagId.Value);
                                cmdInsTag.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Рецепт успешно сохранён.");
                            LoadRecipes();
                            LoadRecipeDetails(currentRecipeId);
                            foreach (var item in listBoxRecipes.Items)
                            {
                                if (item is RecipeItem ri && ri.Id == currentRecipeId)
                                {
                                    listBoxRecipes.SelectedItem = item;
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }

        private int GetCategoryIdByName(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_категории_рецепта FROM категории_рецептов WHERE название_категории = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }

        private int GetTagIdByName(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_тега FROM теги WHERE название_тега = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }
        private int GetIngredientIdByName(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_ингредиента FROM ингредиенты WHERE название_ингредиента = @name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                if (page.Text == "Управление ингредиентами")
                {
                    tabControl1.SelectedTab = page;
                    break;
                }
            }
        }














        public class Ingredient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Quantity { get; set; }
            public override string ToString() => $"{Name} — {Quantity}";
        }

        private List<Ingredient> allIngredients = new List<Ingredient>();

        private void LoadSortOptions()
        {
            comboBoxSortIngredient.Items.Clear();
            comboBoxSortIngredient.Items.Add("По названию (А-Я)");
            comboBoxSortIngredient.Items.Add("По названию (Я-А)");
            comboBoxSortIngredient.Items.Add("По количеству (возраст.)");
            comboBoxSortIngredient.Items.Add("По количеству (убыв.)");
            comboBoxSortIngredient.SelectedIndex = 0;
        }

        private void LoadIngredientsAdmin()
        {
            string query = "SELECT айди_ингредиента, название_ингредиента, кол_во_ингредиента FROM ингредиенты";
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
                        string quantity = reader["кол_во_ингредиента"]?.ToString() ?? "";
                        allIngredients.Add(new Ingredient { Id = id, Name = name, Quantity = quantity });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки ингредиентов: " + ex.Message);
                }
            }
            RefreshIngredientsDisplay();
        }

        private void RefreshIngredientsDisplay()
        {
            if (listBoxIngredientsAdmin == null) return;

            // Фильтрация по тексту поиска
            string search = textBoxSearchIngredient?.Text.Trim().ToLower() ?? "";
            var filtered = allIngredients;
            if (!string.IsNullOrEmpty(search))
            {
                filtered = allIngredients.Where(i => i.Name.ToLower().Contains(search)).ToList();
            }

            // Сортировка
            string sortOption = comboBoxSortIngredient?.SelectedItem?.ToString() ?? "По названию (А-Я)";
            switch (sortOption)
            {
                case "По названию (А-Я)":
                    filtered = filtered.OrderBy(i => i.Name).ToList();
                    break;
                case "По названию (Я-А)":
                    filtered = filtered.OrderByDescending(i => i.Name).ToList();
                    break;
                case "По количеству (возраст.)":
                    filtered = filtered.OrderBy(i => i.Quantity).ToList();
                    break;
                case "По количеству (убыв.)":
                    filtered = filtered.OrderByDescending(i => i.Quantity).ToList();
                    break;
                default:
                    filtered = filtered.OrderBy(i => i.Name).ToList();
                    break;
            }

            listBoxIngredientsAdmin.Items.Clear();
            foreach (var ing in filtered)
            {
                listBoxIngredientsAdmin.Items.Add(ing);
            }
        }

        // Обработчики событий (можно разместить после конструктора)
        private void textBoxSearchIngredient_TextChanged(object sender, EventArgs e)
        {
            RefreshIngredientsDisplay();
        }

        private void comboBoxSortIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIngredientsDisplay();
        }










        // Добавляем поля
        private int currentIngredientId = -1;
        private Ingredient selectedIngredient = null;
        private int currentModerationUserId = -1;
        private string currentModerationRecipeTitle = "";
        // Подписка на события (в конструкторе или в Load)
        private void SetupIngredientsEvents()
        {
            listBoxIngredientsAdmin.SelectedIndexChanged += listBoxIngredientsAdmin_SelectedIndexChanged;
            roundedButton8.Click += buttonAddEdit_Click;
            roundedButton5.Click += buttonDelete_Click;
        }

        // Обработчик выбора ингредиента
        private void listBoxIngredientsAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIngredientsAdmin.SelectedItem is Ingredient ing)
            {
                currentIngredientId = ing.Id;
                selectedIngredient = ing;
                textBoxIngredientName.Text = ing.Name;
            }
            else
            {
                currentIngredientId = -1;
                selectedIngredient = null;
                textBoxIngredientName.Text = "";
            }
        }

        // Обработчик добавления/изменения
        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            string newName = textBoxIngredientName.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Введите название ингредиента.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    if (currentIngredientId == -1) // Добавление
                    {
                        // Проверка, существует ли уже ингредиент с таким названием
                        string checkQuery = "SELECT COUNT(*) FROM ингредиенты WHERE название_ингредиента = @name";
                        MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                        cmdCheck.Parameters.AddWithValue("@name", newName);
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Ингредиент с таким названием уже существует.");
                            return;
                        }

                        // Добавление
                        string insertQuery = "INSERT INTO ингредиенты (название_ингредиента) VALUES (@name)";
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn);
                        cmdInsert.Parameters.AddWithValue("@name", newName);
                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Ингредиент добавлен.");
                    }
                    else // Изменение
                    {
                        // Проверка, что новое название не совпадает с существующим (кроме текущего)
                        string checkQuery = "SELECT COUNT(*) FROM ингредиенты WHERE название_ингредиента = @name AND айди_ингредиента != @id";
                        MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                        cmdCheck.Parameters.AddWithValue("@name", newName);
                        cmdCheck.Parameters.AddWithValue("@id", currentIngredientId);
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Ингредиент с таким названием уже существует.");
                            return;
                        }

                        string updateQuery = "UPDATE ингредиенты SET название_ингредиента = @name WHERE айди_ингредиента = @id";
                        MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn);
                        cmdUpdate.Parameters.AddWithValue("@name", newName);
                        cmdUpdate.Parameters.AddWithValue("@id", currentIngredientId);
                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Ингредиент изменён.");
                    }

                    // Обновляем список ингредиентов
                    LoadIngredientsAdmin();
                    // Сбрасываем выделение
                    currentIngredientId = -1;
                    selectedIngredient = null;
                    textBoxIngredientName.Text = "";
                    // Восстанавливаем выделение, если нужно (можно оставить как есть)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        // Обработчик удаления
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentIngredientId == -1)
            {
                MessageBox.Show("Выберите ингредиент для удаления.");
                return;
            }

            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить ингредиент?",
                                               "Подтверждение",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    // Удаляем связи с рецептами
                    string deleteRefs = "DELETE FROM рецепт_ингредиент WHERE айди_ингредиента = @id";
                    MySqlCommand cmdRefs = new MySqlCommand(deleteRefs, conn);
                    cmdRefs.Parameters.AddWithValue("@id", currentIngredientId);
                    cmdRefs.ExecuteNonQuery();

                    // Удаляем сам ингредиент
                    string deleteIng = "DELETE FROM ингредиенты WHERE айди_ингредиента = @id";
                    MySqlCommand cmdIng = new MySqlCommand(deleteIng, conn);
                    cmdIng.Parameters.AddWithValue("@id", currentIngredientId);
                    cmdIng.ExecuteNonQuery();

                    MessageBox.Show("Ингредиент удалён.");
                    LoadIngredientsAdmin();
                    currentIngredientId = -1;
                    selectedIngredient = null;
                    textBoxIngredientName.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void LoadModerationRecipes()
        {
            // Загрузка рецептов со статусом "на проверке"
            string query = @"
        SELECT r.айди_рецепта, r.название_рецепта
        FROM рецепты r
        JOIN модерация m ON r.айди_рецепта = m.айди_рецепта
        WHERE m.статус = 'на проверке'
        ORDER BY r.название_рецепта";
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    listBoxModerationRecipes.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_рецепта");
                        string name = reader.GetString("название_рецепта");
                        listBoxModerationRecipes.Items.Add(new RecipeItem(id, name));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки рецептов на модерацию: " + ex.Message);
                }
            }
        }
        private void listBoxModerationRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Выбран элемент");
            if (listBoxModerationRecipes.SelectedItem is RecipeItem selected)
            {
                currentModerationRecipeId = selected.Id;
                LoadModerationRecipeDetails(currentModerationRecipeId);
            }
            else
            {
                ClearModerationDetails();
            }
        }

        // 4. Загрузка деталей рецепта для модерации
        private void LoadModerationRecipeDetails(int recipeId)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    // Основные данные + категория + тег
                    string query = @"
    SELECT r.айди_пользователя, r.название_рецепта, r.описание_рецепта, r.инструкция_рецепта,
           r.время_приготовления_рецепта, r.сложность_рецепта,
           кр.название_категории AS категория,
           GROUP_CONCAT(т.название_тега SEPARATOR ', ') AS теги
    FROM рецепты r
    LEFT JOIN категории_рецептов кр ON r.айди_категории_рецепта = кр.айди_категории_рецепта
    LEFT JOIN рецепт_тег рт ON r.айди_рецепта = рт.айди_рецепта
    LEFT JOIN теги т ON рт.айди_тега = т.айди_тега
    WHERE r.айди_рецепта = @id
    GROUP BY r.айди_рецепта";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentModerationUserId = reader.IsDBNull("айди_пользователя") ? -1 : reader.GetInt32("айди_пользователя");
                            currentModerationRecipeTitle = reader["название_рецепта"]?.ToString() ?? "";
                            lblModerationTitle.Text = reader["название_рецепта"]?.ToString() ?? "";
                            lblModerationCategory.Text = reader["категория"]?.ToString() ?? "";
                            lblModerationTags.Text = reader["теги"]?.ToString() ?? "";
                            txtModerationDescription.Text = reader["описание_рецепта"]?.ToString() ?? "";
                            txtModerationInstruction.Text = reader["инструкция_рецепта"]?.ToString() ?? "";
                            numericModerationTime.Value = reader["время_приготовления_рецепта"] != DBNull.Value
                                ? Convert.ToDecimal(reader["время_приготовления_рецепта"])
                                : 0;
                            string complexity = reader["сложность_рецепта"]?.ToString() ?? "";
                            if (complexity == "легко") radioModerationEasy.Checked = true;
                            else if (complexity == "средне") radioModerationMedium.Checked = true;
                            else if (complexity == "сложно") radioModerationHard.Checked = true;
                            else { radioModerationEasy.Checked = false; radioModerationMedium.Checked = false; radioModerationHard.Checked = false; }
                        }
                        else
                        {
                            ClearModerationDetails();
                            return;
                        }
                    }

                    // Ингредиенты
                    string ingQuery = @"
                SELECT и.название_ингредиента, ри.количество
                FROM рецепт_ингредиент ри
                JOIN ингредиенты и ON ри.айди_ингредиента = и.айди_ингредиента
                WHERE ри.айди_рецепта = @id
                ORDER BY и.название_ингредиента";
                    MySqlCommand cmdIng = new MySqlCommand(ingQuery, conn);
                    cmdIng.Parameters.AddWithValue("@id", recipeId);
                    using (MySqlDataReader readerIng = cmdIng.ExecuteReader())
                    {
                        listBoxModerationIngredients.Items.Clear();
                        while (readerIng.Read())
                        {
                            string name = readerIng.GetString("название_ингредиента");
                            string quantity = readerIng.GetString("количество");
                            listBoxModerationIngredients.Items.Add($"{name} — {quantity}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки деталей рецепта: " + ex.Message);
                }
            }
        }
        private void ClearModerationDetails()
        {
            lblModerationTitle.Text = "";
            lblModerationCategory.Text = "";
            lblModerationTags.Text = "";
            txtModerationDescription.Text = "";
            txtModerationInstruction.Text = "";
            numericModerationTime.Value = 0;
            radioModerationEasy.Checked = false;
            radioModerationMedium.Checked = false;
            radioModerationHard.Checked = false;
            listBoxModerationIngredients.Items.Clear();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (currentModerationRecipeId == -1)
            {
                MessageBox.Show("Выберите рецепт.");
                return;
            }
            string comment = txtModerationComment.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Введите комментарий.");
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string updateSql = @"
                UPDATE модерация
                SET статус = 'одобрено', комментарий = @comment, дата = NOW()
                WHERE айди_рецепта = @id";
                    MySqlCommand cmd = new MySqlCommand(updateSql, conn);
                    cmd.Parameters.AddWithValue("@comment", comment);
                    cmd.Parameters.AddWithValue("@id", currentModerationRecipeId);
                    cmd.ExecuteNonQuery();
                    // Добавляем уведомление пользователю
                    if (currentModerationUserId != -1)
                    {
                        string insertNotify = @"
        INSERT INTO уведомления (айди_пользователя, название_рецепта, статус, комментарий)
        VALUES (@userId, @title, 'одобрено', @comment)";
                        MySqlCommand cmdNotify = new MySqlCommand(insertNotify, conn);
                        cmdNotify.Parameters.AddWithValue("@userId", currentModerationUserId);
                        cmdNotify.Parameters.AddWithValue("@title", currentModerationRecipeTitle);
                        cmdNotify.Parameters.AddWithValue("@comment", comment);
                        cmdNotify.ExecuteNonQuery();
                    }
                    MessageBox.Show("Рецепт одобрен.");
                    LoadModerationRecipes();
                    ClearModerationDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (currentModerationRecipeId == -1)
            {
                MessageBox.Show("Выберите рецепт.");
                return;
            }
            string comment = txtModerationComment.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Введите комментарий.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Добавляем уведомление
                            if (currentModerationUserId != -1)
                            {
                                string insertNotify = @"
                            INSERT INTO уведомления (айди_пользователя, название_рецепта, статус, комментарий)
                            VALUES (@userId, @title, 'отклонено', @comment)";
                                MySqlCommand cmdNotify = new MySqlCommand(insertNotify, conn, transaction);
                                cmdNotify.Parameters.AddWithValue("@userId", currentModerationUserId);
                                cmdNotify.Parameters.AddWithValue("@title", currentModerationRecipeTitle);
                                cmdNotify.Parameters.AddWithValue("@comment", comment);
                                cmdNotify.ExecuteNonQuery();
                            }

                            // 2. Удаляем запись из модерации
                            string deleteMod = "DELETE FROM модерация WHERE айди_рецепта = @id";
                            MySqlCommand cmdDelMod = new MySqlCommand(deleteMod, conn, transaction);
                            cmdDelMod.Parameters.AddWithValue("@id", currentModerationRecipeId);
                            cmdDelMod.ExecuteNonQuery();

                            // 3. Удаляем связи рецепт_тег
                            string deleteTag = "DELETE FROM рецепт_тег WHERE айди_рецепта = @id";
                            MySqlCommand cmdTag = new MySqlCommand(deleteTag, conn, transaction);
                            cmdTag.Parameters.AddWithValue("@id", currentModerationRecipeId);
                            cmdTag.ExecuteNonQuery();

                            // 4. Удаляем связи рецепт_ингредиент
                            string deleteIng = "DELETE FROM рецепт_ингредиент WHERE айди_рецепта = @id";
                            MySqlCommand cmdIng = new MySqlCommand(deleteIng, conn, transaction);
                            cmdIng.Parameters.AddWithValue("@id", currentModerationRecipeId);
                            cmdIng.ExecuteNonQuery();

                            // 5. Удаляем сам рецепт
                            string deleteRecipe = "DELETE FROM рецепты WHERE айди_рецепта = @id";
                            MySqlCommand cmdRecipe = new MySqlCommand(deleteRecipe, conn, transaction);
                            cmdRecipe.Parameters.AddWithValue("@id", currentModerationRecipeId);
                            cmdRecipe.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Рецепт отклонён и удалён.");
                            LoadModerationRecipes();      // обновляем список модерации
                            ClearModerationDetails();     // очищаем правую панель
                            LoadRecipes();                // обновляем общий список рецептов (админ)
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при отклонении рецепта: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }

        private void btnDeleteRecipe_Click_1(object sender, EventArgs e)
        {
            if (currentRecipeId == -1)
            {
                MessageBox.Show("Выберите рецепт для удаления.");
                return;
            }

            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить рецепт? Это действие необратимо.",
                                               "Подтверждение",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Удаляем записи из рецепт_тег
                            string deleteTag = "DELETE FROM рецепт_тег WHERE айди_рецепта = @id";
                            MySqlCommand cmdTag = new MySqlCommand(deleteTag, conn, transaction);
                            cmdTag.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdTag.ExecuteNonQuery();

                            // 2. Удаляем записи из рецепт_ингредиент
                            string deleteIng = "DELETE FROM рецепт_ингредиент WHERE айди_рецепта = @id";
                            MySqlCommand cmdIng = new MySqlCommand(deleteIng, conn, transaction);
                            cmdIng.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdIng.ExecuteNonQuery();

                            // 3. Удаляем запись из модерации (если есть)
                            string deleteMod = "DELETE FROM модерация WHERE айди_рецепта = @id";
                            MySqlCommand cmdMod = new MySqlCommand(deleteMod, conn, transaction);
                            cmdMod.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdMod.ExecuteNonQuery();

                            // 4. Удаляем сам рецепт
                            string deleteRecipe = "DELETE FROM рецепты WHERE айди_рецепта = @id";
                            MySqlCommand cmdRecipe = new MySqlCommand(deleteRecipe, conn, transaction);
                            cmdRecipe.Parameters.AddWithValue("@id", currentRecipeId);
                            cmdRecipe.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Рецепт удалён.");
                            LoadRecipes();               // обновляем список рецептов
                            ClearRecipeDetails();        // очищаем правую панель
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при удалении: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }
    }
}