namespace RecipeNess
{
    partial class RecipeCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            lblTitle = new Label();
            roundedButton1 = new RecipeNess.controls.RoundedButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.GradientInactiveCaption;
            pbImage.Location = new Point(3, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(194, 180);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(38, 186);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Название рецепта";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(49, 204);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(97, 43);
            roundedButton1.TabIndex = 2;
            roundedButton1.Text = "Посмотреть больше";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 250);
            panel1.TabIndex = 3;
            // 
            // RecipeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(roundedButton1);
            Controls.Add(lblTitle);
            Controls.Add(pbImage);
            Controls.Add(panel1);
            Name = "RecipeCard";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lblTitle;
        private controls.RoundedButton roundedButton1;
        private Panel panel1;
    }
}
