using MySql.Data.MySqlClient;
using System.Data;
using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeNess.forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            roundedButton1.BackColor = AppColors.PanelBackground;
            roundedButton2.BackColor = AppColors.PanelBackground;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите email и пароль.");
                //lblMessage.Text = "Введите email и пароль.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT айди_пользователя, имя_пользователя, роль FROM пользователи " +
                                   "WHERE почта_пользователя = @email AND пароль_пользователя = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Авторизация успешна
                            CurrentUser.Id = reader.GetInt32("айди_пользователя");
                            CurrentUser.Name = reader.GetString("имя_пользователя");
                            CurrentUser.Email = email;
                            CurrentUser.Role = reader.GetString("роль");

                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный email или пароль.");
                            //lblMessage.Text = "Неверный email или пароль.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения:" + ex.Message);
                    //lblMessage.Text = "Ошибка подключения: " + ex.Message;
                }
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Register register = new Register())
            {
                if (register.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Show();
                }
            }


        }
    }
}
