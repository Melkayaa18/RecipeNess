using RecipeNess.controls;

namespace RecipeNess
{
    partial class RecipeEditForm
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
            btnSubmit = new RoundedButton();
            txtDescription = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            roundedButton5 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            panel1 = new Panel();
            checkedListBoxIngredients = new CheckedListBox();
            comboBoxTag = new ComboBox();
            panel3 = new Panel();
            radioButtonHard = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonEasy = new RadioButton();
            comboBoxCategory = new ComboBox();
            pictureBox1 = new PictureBox();
            txtInstruction = new TextBox();
            numericUpDownTime = new NumericUpDown();
            panel2 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            roundedButton1 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ButtonShadow;
            splitContainer1.Panel1.Controls.Add(btnSubmit);
            splitContainer1.Panel1.Controls.Add(txtDescription);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.FrameBackgr;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(roundedButton5);
            splitContainer1.Panel2.Controls.Add(roundedButton3);
            splitContainer1.Panel2.Controls.Add(roundedButton2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(txtTitle);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnSubmit.ForeColor = SystemColors.ControlLightLight;
            btnSubmit.Location = new Point(54, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(165, 54);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Отправить на модерацию";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(12, 58);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(238, 312);
            txtDescription.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 37);
            panel4.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.seed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(53, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 34);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 4);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 1;
            label1.Text = "RecipeNest";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(223, 23);
            label4.TabIndex = 2;
            label4.Text = "Введи короткое описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(54, 369);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 12;
            label3.Text = "Готовы к публикации?";
            // 
            // roundedButton5
            // 
            roundedButton5.BackgroundImage = Properties.Resources.backIcon;
            roundedButton5.BackgroundImageLayout = ImageLayout.Zoom;
            roundedButton5.FlatAppearance.BorderSize = 0;
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton5.Location = new Point(474, 12);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(44, 30);
            roundedButton5.TabIndex = 7;
            roundedButton5.UseVisualStyleBackColor = true;
            roundedButton5.Click += roundedButton5_Click;
            // 
            // roundedButton3
            // 
            roundedButton3.BackgroundImage = Properties.Resources.ProfileIcon;
            roundedButton3.BackgroundImageLayout = ImageLayout.Zoom;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Location = new Point(419, 12);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(44, 31);
            roundedButton3.TabIndex = 0;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackgroundImage = Properties.Resources.notif;
            roundedButton2.BackgroundImageLayout = ImageLayout.Stretch;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roundedButton2.ForeColor = SystemColors.ControlText;
            roundedButton2.Location = new Point(367, 12);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(49, 31);
            roundedButton2.TabIndex = 6;
            roundedButton2.UseVisualStyleBackColor = true;
            roundedButton2.Click += roundedButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(checkedListBoxIngredients);
            panel1.Controls.Add(comboBoxTag);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(comboBoxCategory);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtInstruction);
            panel1.Controls.Add(numericUpDownTime);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(roundedButton1);
            panel1.Location = new Point(13, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 382);
            panel1.TabIndex = 2;
            // 
            // checkedListBoxIngredients
            // 
            checkedListBoxIngredients.FormattingEnabled = true;
            checkedListBoxIngredients.Location = new Point(154, 43);
            checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            checkedListBoxIngredients.Size = new Size(334, 94);
            checkedListBoxIngredients.TabIndex = 9;
            // 
            // comboBoxTag
            // 
            comboBoxTag.FormattingEnabled = true;
            comboBoxTag.Location = new Point(335, 10);
            comboBoxTag.Name = "comboBoxTag";
            comboBoxTag.Size = new Size(153, 23);
            comboBoxTag.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(radioButtonHard);
            panel3.Controls.Add(radioButtonMedium);
            panel3.Controls.Add(radioButtonEasy);
            panel3.Location = new Point(145, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 105);
            panel3.TabIndex = 6;
            // 
            // radioButtonHard
            // 
            radioButtonHard.AutoSize = true;
            radioButtonHard.Font = new Font("Segoe UI", 11F);
            radioButtonHard.Location = new Point(9, 66);
            radioButtonHard.Name = "radioButtonHard";
            radioButtonHard.Size = new Size(82, 24);
            radioButtonHard.TabIndex = 2;
            radioButtonHard.TabStop = true;
            radioButtonHard.Text = "Сложно";
            radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            radioButtonMedium.AutoSize = true;
            radioButtonMedium.Font = new Font("Segoe UI", 11F);
            radioButtonMedium.Location = new Point(9, 37);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(78, 24);
            radioButtonMedium.TabIndex = 1;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Средне";
            radioButtonMedium.UseVisualStyleBackColor = true;
            radioButtonMedium.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonEasy
            // 
            radioButtonEasy.AutoSize = true;
            radioButtonEasy.Font = new Font("Segoe UI", 11F);
            radioButtonEasy.Location = new Point(9, 7);
            radioButtonEasy.Name = "radioButtonEasy";
            radioButtonEasy.Size = new Size(67, 24);
            radioButtonEasy.TabIndex = 0;
            radioButtonEasy.TabStop = true;
            radioButtonEasy.Text = "Легко";
            radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(154, 10);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(153, 23);
            comboBoxCategory.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(336, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 123);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtInstruction
            // 
            txtInstruction.Location = new Point(154, 299);
            txtInstruction.Multiline = true;
            txtInstruction.Name = "txtInstruction";
            txtInstruction.ScrollBars = ScrollBars.Vertical;
            txtInstruction.Size = new Size(334, 74);
            txtInstruction.TabIndex = 3;
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new Point(154, 155);
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new Size(144, 23);
            numericUpDownTime.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 389);
            panel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(5, 121);
            label11.Name = "label11";
            label11.Size = new Size(131, 25);
            label11.TabIndex = 6;
            label11.Text = "_________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(15, 311);
            label9.Name = "label9";
            label9.Size = new Size(103, 46);
            label9.TabIndex = 4;
            label9.Text = "step by step\r\ndescription";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(13, 215);
            label8.Name = "label8";
            label8.Size = new Size(112, 46);
            label8.TabIndex = 3;
            label8.Text = "the difficulty \r\nof cooking";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(13, 154);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 2;
            label7.Text = "cooking time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(19, 80);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 1;
            label6.Text = "ingredients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(28, 8);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 0;
            label5.Text = "category";
            label5.Click += label5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(3, 21);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 5;
            label10.Text = "_________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F);
            label12.Location = new Point(5, 169);
            label12.Name = "label12";
            label12.Size = new Size(131, 25);
            label12.TabIndex = 7;
            label12.Text = "_________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F);
            label13.Location = new Point(3, 268);
            label13.Name = "label13";
            label13.Size = new Size(131, 25);
            label13.TabIndex = 8;
            label13.Text = "_________________";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(158, 14);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 0;
            label2.Text = "enter the name";
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            roundedButton1.Location = new Point(399, 269);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(28, 23);
            roundedButton1.TabIndex = 10;
            roundedButton1.Text = "+";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // RecipeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "RecipeEditForm";
            Text = "RecipeEditForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtInstruction;
        private NumericUpDown numericUpDownTime;
        private Panel panel3;
        private RadioButton radioButtonEasy;
        private ComboBox comboBoxCategory;
        private PictureBox pictureBox1;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMedium;
        private Label label3;
        private RoundedButton roundedButton2;
        private Panel panel4;
        private RoundedButton roundedButton3;
        private PictureBox pictureBox2;
        private ComboBox comboBoxTag;
        private RoundedButton roundedButton5;
        private RoundedButton btnSubmit;
        private CheckedListBox checkedListBoxIngredients;
        private RoundedButton roundedButton1;
    }
}