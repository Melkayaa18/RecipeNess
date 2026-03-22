namespace RecipeNess.forms
{
    partial class Register
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
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            roundedButton1 = new RecipeNess.controls.RoundedButton();
            roundedButton2 = new RecipeNess.controls.RoundedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(267, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 189);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "пароль";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(3, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 27);
            txtPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "почта";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txtEmail.Location = new Point(3, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 27);
            txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "никнейм";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txtName.Location = new Point(3, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 4;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(350, 335);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(114, 33);
            roundedButton1.TabIndex = 2;
            roundedButton1.Text = "РЕГИСТРАЦИЯ";
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Location = new Point(367, 374);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(80, 31);
            roundedButton2.TabIndex = 3;
            roundedButton2.Text = "ВОЙТИ";
            roundedButton2.UseVisualStyleBackColor = true;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RegBack;
            ClientSize = new Size(800, 450);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private controls.RoundedButton roundedButton1;
        private controls.RoundedButton roundedButton2;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtName;
    }
}