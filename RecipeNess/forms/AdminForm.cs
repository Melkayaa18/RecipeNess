using MySql.Data.MySqlClient;
using RecipeNess.classes;
using System;
using System.Windows.Forms;

namespace RecipeNess
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load; // <-- ВАЖНО!

            // Остальные настройки цветов (оставь свои)
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

            splitContainer2.Panel2.BackColor = AppColors.AccentGreenLight;
            splitContainer2.Panel1.BackColor = AppColors.AccentOrangeLight;
            roundedButton6.BackColor = AppColors.Shapka;
            roundedButton7.BackColor = AppColors.Shapka;
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
        }

        private void LoadRecipes()
        {
            // Проверка существования элементов
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
                    // Для отладки (после проверки можно убрать)
                    MessageBox.Show($"Загружено рецептов: {count}");
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

            public RecipeItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

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
    }
}