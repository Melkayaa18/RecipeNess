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
            btnSearch = new RecipeNess.controls.RoundedButton();
            label1 = new Label();
            flowLayoutPanelDailyRecipes = new FlowLayoutPanel();
            btnLogin = new RecipeNess.controls.RoundedButton();
            btnRegister = new RecipeNess.controls.RoundedButton();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(303, 404);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(191, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "ОКНО ФИЛТРАЦИИ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            // flowLayoutPanelDailyRecipes
            // 
            flowLayoutPanelDailyRecipes.BackColor = Color.Transparent;
            flowLayoutPanelDailyRecipes.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanelDailyRecipes.Location = new Point(86, 219);
            flowLayoutPanelDailyRecipes.Name = "flowLayoutPanelDailyRecipes";
            flowLayoutPanelDailyRecipes.Size = new Size(628, 192);
            flowLayoutPanelDailyRecipes.TabIndex = 2;
            flowLayoutPanelDailyRecipes.WrapContents = false;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(713, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(613, 12);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // MainWindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainBAck;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(flowLayoutPanelDailyRecipes);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            DoubleBuffered = true;
            Name = "MainWindForm";
            Text = "MainWindForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private controls.RoundedButton btnSearch;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanelDailyRecipes;
        private controls.RoundedButton btnLogin;
        private controls.RoundedButton btnRegister;
    }
}