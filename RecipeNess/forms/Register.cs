using MySql.Data.MySqlClient;
using RecipeNess.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeNess.forms
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
            roundedButton1.BackColor = AppColors.PanelBackground;
            roundedButton2.BackColor = AppColors.PanelBackground;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля.");
            }

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Проверка на дубликат
                    string checkQuery = "SELECT COUNT(*) FROM пользователи WHERE почта_пользователя = @email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@email", email);
                    int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existing > 0)
                    {
                        MessageBox.Show("Пользователь с таким email уже существует.");

                    }
                    
                    string insertQuery = "INSERT INTO пользователи (имя_пользователя, почта_пользователя, пароль_пользователя, роль) " +
                                         "VALUES (@name, @email, @password, 'пользователь')";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@name", name);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    insertCmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message);
                }
            }
        }
        

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
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
