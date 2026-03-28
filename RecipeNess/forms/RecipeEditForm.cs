using MySql.Data.MySqlClient;
using RecipeNess.classes;
using RecipeNess.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class RecipeEditForm : Form
    {
        private List<IngredientItem> allIngredients = new List<IngredientItem>();
        private List<CategoryItem> allCategories = new List<CategoryItem>();
        private List<TagItem> allTags = new List<TagItem>();
        public RecipeEditForm()
        {
            InitializeComponent();
            this.BackColor = AppColors.MainBackground;
            roundedButton1.BackColor = AppColors.AccentGreen;
            panel4.BackColor = AppColors.Shapka;
            splitContainer1.Panel2.BackColor = AppColors.MainBackground;
            splitContainer1.Panel1.BackColor = AppColors.AccentOrangeLight;
            panel1.BackColor = AppColors.PanelBackground;
            panel3.BackColor = AppColors.PanelBackground;
            panel2.BackColor = AppColors.AccentGreen;
            pictureBox1.BackColor = AppColors.PanelBackground;
            label5.ForeColor = AppColors.MainBackground;
            label6.ForeColor = AppColors.MainBackground;
            label7.ForeColor = AppColors.MainBackground;
            label8.ForeColor = AppColors.MainBackground;
            label9.ForeColor = AppColors.MainBackground;
            label10.ForeColor = AppColors.Separator;
            label11.ForeColor = AppColors.Separator;
            label12.ForeColor = AppColors.Separator;
            label13.ForeColor = AppColors.Separator;
            label2.ForeColor = AppColors.MainText;
            label1.ForeColor = AppColors.MainText;
            label4.ForeColor = AppColors.MainBackground;
            label3.ForeColor = AppColors.MainText;
            btnSubmit.BackColor = AppColors.Shapka;
            roundedButton2.BackColor = AppColors.AccentGreenLight;
            roundedButton3.BackColor = AppColors.AccentGreenLight;
            //roundedButton4.BackColor = AppColors.AccentGreenLight;
            pictureBox1.BackColor = AppColors.AccentGreenLight;


            this.Load += RecipeCreateForm_Load;
            //btnSubmit.Click += btnSubmit_Click;
            
        }
        private void RecipeCreateForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadTags();
            LoadIngredients();
        }
        private void LoadCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_категории_рецепта, название_категории FROM категории_рецептов ORDER BY название_категории";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBoxCategory.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_категории_рецепта");
                        string name = reader.GetString("название_категории");
                        var item = new CategoryItem { Id = id, Name = name };
                        allCategories.Add(item);
                        comboBoxCategory.Items.Add(item);
                    }
                    reader.Close();
                    if (comboBoxCategory.Items.Count > 0)
                        comboBoxCategory.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
                }
            }
        }
        private void LoadTags()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_тега, название_тега FROM теги ORDER BY название_тега";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    comboBoxTag.Items.Clear();
                    // Добавим пустой пункт для возможности не выбирать тег
                    comboBoxTag.Items.Add(new TagItem { Id = -1, Name = "(без тега)" });
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_тега");
                        string name = reader.GetString("название_тега");
                        var item = new TagItem { Id = id, Name = name };
                        allTags.Add(item);
                        comboBoxTag.Items.Add(item);
                    }
                    reader.Close();
                    if (comboBoxTag.Items.Count > 0)
                        comboBoxTag.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки тегов: " + ex.Message);
                }
            }
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
                    checkedListBoxIngredients.Items.Clear();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("айди_ингредиента");
                        string name = reader.GetString("название_ингредиента");
                        var ing = new IngredientItem(id, name);
                        allIngredients.Add(ing);
                        checkedListBoxIngredients.Items.Add(ing);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки ингредиентов: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ProfileMainForm profileMainForm = new ProfileMainForm())
            {
                if (profileMainForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (NotificationForm notificationForm = new NotificationForm())
            {
                if (notificationForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void roundedButton5_Click(object sender, EventArgs e)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название рецепта.");
                txtTitle.Focus();
                return;
            }

            if (comboBoxCategory.SelectedItem == null || (comboBoxCategory.SelectedItem is CategoryItem cat && cat.Id == -1))
            {
                MessageBox.Show("Выберите категорию.");
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

            // Если инструкция пустая, можно разрешить, но предупредим
            if (string.IsNullOrWhiteSpace(txtInstruction.Text))
            {
                if (MessageBox.Show("Инструкция не заполнена. Продолжить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            // Получаем ID выбранной категории
            CategoryItem selectedCat = (CategoryItem)comboBoxCategory.SelectedItem;
            int categoryId = selectedCat.Id;

            // Получаем ID выбранного тега (если есть)
            int? tagId = null;
            if (comboBoxTag.SelectedItem is TagItem tag && tag.Id != -1)
            {
                tagId = tag.Id;
            }

            // Собираем выбранные ингредиенты
            List<int> selectedIngredientIds = new List<int>();
            foreach (var item in checkedListBoxIngredients.CheckedItems)
            {
                if (item is IngredientItem ing)
                {
                    selectedIngredientIds.Add(ing.Id);
                }
            }

            if (selectedIngredientIds.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один ингредиент.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Получаем ID первого администратора (чтобы вставить в модерацию)
                    string getAdminSql = "SELECT айди_пользователя FROM пользователи WHERE роль = 'администратор' LIMIT 1";
                    MySqlCommand cmdGetAdmin = new MySqlCommand(getAdminSql, conn);
                    object adminObj = cmdGetAdmin.ExecuteScalar();
                    if (adminObj == null)
                    {
                        MessageBox.Show("В системе нет администратора. Рецепт не может быть отправлен на модерацию.");
                        return;
                    }
                    int adminId = Convert.ToInt32(adminObj);

                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Вставка в таблицу рецепты
                            string insertRecipeSql = @"
                        INSERT INTO рецепты 
                        (название_рецепта, описание_рецепта, инструкция_рецепта, время_приготовления_рецепта, 
                         сложность_рецепта, айди_категории_рецепта, айди_пользователя)
                        VALUES (@title, @description, @instruction, @time, @complexity, @categoryId, @userId);
                        SELECT LAST_INSERT_ID();";

                            MySqlCommand cmd = new MySqlCommand(insertRecipeSql, conn, transaction);
                            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                            cmd.Parameters.AddWithValue("@instruction", txtInstruction.Text);
                            cmd.Parameters.AddWithValue("@time", (int)numericUpDownTime.Value);
                            cmd.Parameters.AddWithValue("@complexity", complexity);
                            cmd.Parameters.AddWithValue("@categoryId", ((CategoryItem)comboBoxCategory.SelectedItem).Id);
                            cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);

                            int recipeId = Convert.ToInt32(cmd.ExecuteScalar());

                            // 2. Вставка связей с ингредиентами (без количества)
                            string insertIngSql = "INSERT INTO рецепт_ингредиент (айди_рецепта, айди_ингредиента, количество) VALUES (@recipeId, @ingredientId, '')";
                            foreach (int ingId in selectedIngredientIds)
                            {
                                MySqlCommand cmdIng = new MySqlCommand(insertIngSql, conn, transaction);
                                cmdIng.Parameters.AddWithValue("@recipeId", recipeId);
                                cmdIng.Parameters.AddWithValue("@ingredientId", ingId);
                                cmdIng.ExecuteNonQuery();
                            }

                            // 3. Вставка связи с тегом (если выбран)
                            if (tagId.HasValue)
                            {
                                string insertTagSql = "INSERT INTO рецепт_тег (айди_рецепта, айди_тега) VALUES (@recipeId, @tagId)";
                                MySqlCommand cmdTag = new MySqlCommand(insertTagSql, conn, transaction);
                                cmdTag.Parameters.AddWithValue("@recipeId", recipeId);
                                cmdTag.Parameters.AddWithValue("@tagId", tagId.Value);
                                cmdTag.ExecuteNonQuery();
                            }

                            // 4. Вставка записи в модерацию (статус "на проверке")
                            string insertModSql = @"
    INSERT INTO модерация (айди_рецепта, айди_пользователя, комментарий, статус)
    VALUES (@recipeId, @userId, '', 'на проверке')";
                            MySqlCommand cmdMod = new MySqlCommand(insertModSql, conn, transaction);
                            cmdMod.Parameters.AddWithValue("@recipeId", recipeId);
                            cmdMod.Parameters.AddWithValue("@userId", CurrentUser.Id);
                            cmdMod.ExecuteNonQuery();

                            transaction.Commit();

                            MessageBox.Show("Рецепт успешно отправлен на модерацию!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ошибка при сохранении рецепта: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
        }
        public class CategoryItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        public class TagItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }
    }
    }

