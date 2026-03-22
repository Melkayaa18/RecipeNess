namespace RecipeNess.controls
{
    partial class NewRecipeCard
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
            roundedButton1 = new RoundedButton();
            lblTitle = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.GradientInactiveCaption;
            pbImage.Location = new Point(4, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(185, 117);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 1;
            pbImage.TabStop = false;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(25, 141);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(145, 30);
            roundedButton1.TabIndex = 3;
            roundedButton1.Text = "Посмотреть больше";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(37, 123);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(116, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Название рецепта";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.FrameBackgr;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 168);
            panel1.TabIndex = 5;
            // 
            // NewRecipeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblTitle);
            Controls.Add(roundedButton1);
            Controls.Add(pbImage);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "NewRecipeCard";
            Size = new Size(194, 174);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private RoundedButton roundedButton1;
        private Label lblTitle;
        private Panel panel1;
    }
}
