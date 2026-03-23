namespace RecipeNess
{
    partial class RecipeViewForm
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
            splitContainer1 = new SplitContainer();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            roundedButton1 = new RecipeNess.controls.RoundedButton();
            label7 = new Label();
            panel4 = new Panel();
            checkedListBoxIngredients = new CheckedListBox();
            label4 = new Label();
            label1 = new Label();
            roundedButton2 = new RecipeNess.controls.RoundedButton();
            lblTags = new Label();
            txtTime = new TextBox();
            txtComplexity = new TextBox();
            label8 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtInstruction = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ButtonShadow;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.FrameBackgr;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(roundedButton2);
            splitContainer1.Panel2.Controls.Add(lblTags);
            splitContainer1.Panel2.Controls.Add(txtTime);
            splitContainer1.Panel2.Controls.Add(txtComplexity);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.seed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(55, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 32);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Controls.Add(roundedButton1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(15, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 407);
            panel3.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = SystemColors.ControlDarkDark;
            roundedButton1.BackgroundImage = Properties.Resources.heartIcon;
            roundedButton1.BackgroundImageLayout = ImageLayout.Zoom;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Location = new Point(88, 344);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(49, 46);
            roundedButton1.TabIndex = 12;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(14, 311);
            label7.Name = "label7";
            label7.Size = new Size(165, 17);
            label7.TabIndex = 11;
            label7.Text = "Вам понравился рецепт?";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(checkedListBoxIngredients);
            panel4.Location = new Point(14, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 256);
            panel4.TabIndex = 1;
            // 
            // checkedListBoxIngredients
            // 
            checkedListBoxIngredients.BackColor = SystemColors.Window;
            checkedListBoxIngredients.Dock = DockStyle.Fill;
            checkedListBoxIngredients.Font = new Font("Segoe UI", 11F);
            checkedListBoxIngredients.FormattingEnabled = true;
            checkedListBoxIngredients.Location = new Point(0, 0);
            checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            checkedListBoxIngredients.Size = new Size(211, 256);
            checkedListBoxIngredients.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(14, 4);
            label4.Name = "label4";
            label4.Size = new Size(201, 46);
            label4.TabIndex = 0;
            label4.Text = "Отметь ингредиенты\r\nкоторые у тебя есть\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(84, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "RecipeNest";
            // 
            // roundedButton2
            // 
            roundedButton2.BackgroundImage = Properties.Resources.backIcon;
            roundedButton2.BackgroundImageLayout = ImageLayout.Zoom;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton2.Location = new Point(443, 8);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(75, 23);
            roundedButton2.TabIndex = 11;
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTags.Location = new Point(387, 61);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(48, 17);
            lblTags.TabIndex = 10;
            lblTags.Text = "#ТЕГИ";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(388, 150);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(130, 23);
            txtTime.TabIndex = 9;
            // 
            // txtComplexity
            // 
            txtComplexity.Location = new Point(388, 103);
            txtComplexity.Name = "txtComplexity";
            txtComplexity.ReadOnly = true;
            txtComplexity.Size = new Size(130, 23);
            txtComplexity.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(388, 132);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 7;
            label8.Text = "Время приготовления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(388, 86);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "Сложность";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(txtInstruction);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(15, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 233);
            panel1.TabIndex = 5;
            // 
            // txtInstruction
            // 
            txtInstruction.Dock = DockStyle.Fill;
            txtInstruction.Font = new Font("Segoe UI", 13F);
            txtInstruction.Location = new Point(34, 0);
            txtInstruction.Multiline = true;
            txtInstruction.Name = "txtInstruction";
            txtInstruction.ReadOnly = true;
            txtInstruction.Size = new Size(469, 233);
            txtInstruction.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(34, 233);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(15, 174);
            label3.Name = "label3";
            label3.Size = new Size(203, 28);
            label3.TabIndex = 4;
            label3.Text = "Следуй инструкции!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.photoBAck;
            pictureBox1.Location = new Point(15, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 112);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.Location = new Point(15, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 28);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Название данного блюда";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(3, 2);
            label6.Name = "label6";
            label6.Size = new Size(185, 28);
            label6.TabIndex = 1;
            label6.Text = "Эй, @Test_account !";
            label6.Click += label6_Click;
            // 
            // RecipeViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "RecipeViewForm";
            Text = "RecipeViewForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private TextBox txtInstruction;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBox2;
        private controls.RoundedButton roundedButton1;
        private Label label7;
        private Panel panel4;
        private CheckedListBox checkedListBoxIngredients;
        private Label label8;
        private Label label5;
        private Label lblTags;
        private TextBox txtTime;
        private TextBox txtComplexity;
        private controls.RoundedButton roundedButton2;
    }
}