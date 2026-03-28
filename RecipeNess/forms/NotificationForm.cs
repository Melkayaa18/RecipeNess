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
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
            this.Load += NotificationForm_Load;
            this.BackColor = AppColors.MainBackground;
            dataGridViewNotifications.BackgroundColor = AppColors.PanelBackground;
            dataGridViewNotifications.DefaultCellStyle.BackColor = AppColors.PanelBackground;
            dataGridViewNotifications.DefaultCellStyle.ForeColor = AppColors.MainText;
            dataGridViewNotifications.ColumnHeadersDefaultCellStyle.BackColor = AppColors.AccentGreenLight;
            dataGridViewNotifications.ColumnHeadersDefaultCellStyle.ForeColor = AppColors.MainText;
            dataGridViewNotifications.EnableHeadersVisualStyles = false; // чтобы наши цвета применились
            dataGridViewNotifications.BorderStyle = BorderStyle.None;
            dataGridViewNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }
        private void NotificationForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Текущий пользователь: ID = {CurrentUser.Id}");
            LoadNotifications();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
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
        private void LoadNotifications()
        {
            string query = @"
    SELECT название_рецепта, статус, комментарий, дата
    FROM уведомления
    WHERE айди_пользователя = @userId
    ORDER BY дата DESC";
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", CurrentUser.Id);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewNotifications.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки уведомлений: " + ex.Message);
                }
            }
        }
    }
}
