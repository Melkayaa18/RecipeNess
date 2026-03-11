using RecipeNess.classes;

namespace RecipeNess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSampleRecipes();

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
        // Метод для загрузки тестовых данных
        private void LoadSampleRecipes()
        {
            // Создаём список рецептов (в реальности вы будете получать их из БД)
            var recipes = new List<Recipe>
        {
            new Recipe { Id = 1, Title = "Борщ", Image = null },
            new Recipe { Id = 2, Title = "Пельмени", Image = null },
            new Recipe { Id = 3, Title = "Оливье", Image = null },
            new Recipe { Id = 4, Title = "Шашлык", Image = null },
        };

            // Отображаем рецепты
            DisplayRecipes(recipes);
        }
        // Метод, который очищает панель и заполняет её карточками
        private void DisplayRecipes(List<Recipe> recipes)
        {
            // Очищаем панель от старых карточек
            flowLayoutPanel1.Controls.Clear();

            foreach (var recipe in recipes)
            {
                // Создаём новый экземпляр карточки
                var card = new RecipeCard();
                card.Title = recipe.Title;
                // Если нет изображения, можно установить заглушку
                //card.Image = recipe.Image ?? Properties.Resources.default_food; // предполагается, что в ресурсах есть default_food

                // Подписываемся на событие клика по кнопке "Посмотреть больше"
                card.ViewClick += (s, e) => OpenRecipeView(recipe.Id);

                // Добавляем карточку на панель
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        // Метод для открытия окна просмотра рецепта
        private void OpenRecipeView(int recipeId)
        {
            // Создаём форму просмотра и передаём ID рецепта
            var viewForm = new RecipeViewForm(recipeId);
            viewForm.ShowDialog(); // или Show(), если не хотите блокировать
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    // Простой класс для хранения данных рецепта
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
