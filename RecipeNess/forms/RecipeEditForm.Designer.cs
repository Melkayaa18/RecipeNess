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
            roundedButton1 = new RoundedButton();
            textBox1 = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            roundedButton5 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            panel3 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
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
            roundedButton4 = new RoundedButton();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(roundedButton1);
            splitContainer1.Panel1.Controls.Add(textBox1);
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
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton1.ForeColor = SystemColors.ControlLightLight;
            roundedButton1.Location = new Point(54, 392);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(165, 54);
            roundedButton1.TabIndex = 13;
            roundedButton1.Text = "Отправить на модерацию";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(12, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 312);
            textBox1.TabIndex = 3;
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
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(roundedButton4);
            panel1.Location = new Point(13, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 382);
            panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(335, 10);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(radioButton3);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton1);
            panel3.Location = new Point(145, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 105);
            panel3.TabIndex = 6;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 11F);
            radioButton3.Location = new Point(9, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Сложно";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11F);
            radioButton2.Location = new Point(9, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Средне";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F);
            radioButton1.Location = new Point(9, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Легко";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(336, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 139);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 299);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(334, 74);
            textBox3.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(154, 155);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(154, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(334, 79);
            listBox1.TabIndex = 1;
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
            // roundedButton4
            // 
            roundedButton4.FlatAppearance.BorderSize = 0;
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton4.Location = new Point(310, 110);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(38, 27);
            roundedButton4.TabIndex = 7;
            roundedButton4.Text = "+";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
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
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private Panel panel3;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label3;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton4;
        private Panel panel4;
        private RoundedButton roundedButton3;
        private PictureBox pictureBox2;
        private ComboBox comboBox2;
        private RoundedButton roundedButton5;
    }
}