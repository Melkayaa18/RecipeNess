namespace RecipeNess.forms
{
    partial class Login
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            roundedButton1 = new RecipeNess.controls.RoundedButton();
            roundedButton2 = new RecipeNess.controls.RoundedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(267, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 133);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 3;
            label2.Text = "введите Ваш пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 1);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "введите Вашу почту";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(10, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(10, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(357, 274);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(97, 34);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "ВОЙТИ";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Location = new Point(342, 314);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(127, 34);
            roundedButton2.TabIndex = 2;
            roundedButton2.Text = "СОЗДАТЬ АККАУНТ";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LogBack;
            ClientSize = new Size(800, 450);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private controls.RoundedButton roundedButton1;
        private controls.RoundedButton roundedButton2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}