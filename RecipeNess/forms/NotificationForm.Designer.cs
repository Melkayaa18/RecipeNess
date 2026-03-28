namespace RecipeNess
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roundedButton2 = new RecipeNess.controls.RoundedButton();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            dataGridViewNotifications = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotifications).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedButton2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 44);
            panel1.TabIndex = 1;
            // 
            // roundedButton2
            // 
            roundedButton2.BackgroundImage = Properties.Resources.backIcon;
            roundedButton2.BackgroundImageLayout = ImageLayout.Zoom;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton2.Location = new Point(597, 12);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(75, 23);
            roundedButton2.TabIndex = 6;
            roundedButton2.UseVisualStyleBackColor = true;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.seed;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(12, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 33);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(43, 6);
            label2.Name = "label2";
            label2.Size = new Size(152, 30);
            label2.TabIndex = 2;
            label2.Text = "Уведомления";
            // 
            // dataGridViewNotifications
            // 
            dataGridViewNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotifications.Dock = DockStyle.Fill;
            dataGridViewNotifications.Location = new Point(0, 44);
            dataGridViewNotifications.Name = "dataGridViewNotifications";
            dataGridViewNotifications.Size = new Size(684, 317);
            dataGridViewNotifications.TabIndex = 2;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(dataGridViewNotifications);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NotificationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Уведомления";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
        private DataGridView dataGridViewNotifications;
        private controls.RoundedButton roundedButton2;
    }
}