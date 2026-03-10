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
            btnView = new Button();
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
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(38, 186);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Название рецепта";
            // 
            // btnView
            // 
            btnView.FlatStyle = FlatStyle.System;
            btnView.Location = new Point(35, 210);
            btnView.Name = "btnView";
            btnView.Size = new Size(112, 35);
            btnView.TabIndex = 2;
            btnView.Text = "Посмотреть больше";
            btnView.UseVisualStyleBackColor = true;
            // 
            // RecipeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnView);
            Controls.Add(lblTitle);
            Controls.Add(pbImage);
            Name = "RecipeCard";
            Size = new Size(200, 250);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lblTitle;
        private Button btnView;
    }
}
