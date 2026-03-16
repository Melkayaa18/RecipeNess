namespace RecipeNess.forms
{
    partial class MainWindForm
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
            roundedButton1 = new RecipeNess.controls.RoundedButton();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedButton2 = new RecipeNess.controls.RoundedButton();
            roundedButton3 = new RecipeNess.controls.RoundedButton();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(303, 404);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(191, 34);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "ОКНО ФИЛТРАЦИИ";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(349, 196);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Рецепты дня";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(86, 219);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(628, 179);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // roundedButton2
            // 
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton2.Location = new Point(713, 12);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(75, 23);
            roundedButton2.TabIndex = 3;
            roundedButton2.Text = "Вход";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton3
            // 
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton3.Location = new Point(613, 12);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(94, 23);
            roundedButton3.TabIndex = 4;
            roundedButton3.Text = "Регистрация";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // MainWindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainBAck;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(roundedButton1);
            DoubleBuffered = true;
            Name = "MainWindForm";
            Text = "MainWindForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private controls.RoundedButton roundedButton1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private controls.RoundedButton roundedButton2;
        private controls.RoundedButton roundedButton3;
    }
}