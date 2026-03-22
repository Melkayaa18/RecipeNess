using RecipeNess.classes;
using RecipeNess.forms;

namespace RecipeNess
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //ApplicationConfiguration.Initialize();
           // Application.Run(new MainWindForm());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Показываем форму входа
            using (Login login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Определяем, какую форму открыть в зависимости от роли
                    if (CurrentUser.IsAdmin)
                    {
                        Application.Run(new AdminForm());   // форма админа
                    }
                    else
                    {
                        Application.Run(new Form1());  // форма фильтрации для пользователя
                    }
                }
                else
                {
                    // Если вход не выполнен или окно закрыто, выходим
                    Application.Exit();
                }
            }

        }
    }
}