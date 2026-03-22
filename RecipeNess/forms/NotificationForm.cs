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
            this.BackColor = AppColors.MainBackground;
            dgvNotifications.BackgroundColor = AppColors.PanelBackground;
            dgvNotifications.DefaultCellStyle.BackColor = AppColors.PanelBackground;
            dgvNotifications.DefaultCellStyle.ForeColor = AppColors.MainText;
            dgvNotifications.ColumnHeadersDefaultCellStyle.BackColor = AppColors.AccentGreenLight;
            dgvNotifications.ColumnHeadersDefaultCellStyle.ForeColor = AppColors.MainText;
            dgvNotifications.EnableHeadersVisualStyles = false; // чтобы наши цвета применились
            dgvNotifications.BorderStyle = BorderStyle.None;
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
    }
}
