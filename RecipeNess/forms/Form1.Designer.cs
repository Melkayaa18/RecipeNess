using RecipeNess.controls;

namespace RecipeNess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roundedButton3 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            roundedButton1 = new RoundedButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(roundedButton3);
            panel1.Controls.Add(roundedButton2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 47);
            panel1.TabIndex = 0;
            // 
            // roundedButton3
            // 
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton3.Location = new Point(733, 8);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(39, 32);
            roundedButton3.TabIndex = 4;
            roundedButton3.Text = "👤";
            roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton2
            // 
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton2.Location = new Point(589, 8);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(138, 30);
            roundedButton2.TabIndex = 3;
            roundedButton2.Text = "Добавить рецепт";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(166, 8);
            label6.Name = "label6";
            label6.Size = new Size(185, 28);
            label6.TabIndex = 0;
            label6.Text = "Окно фильтрации";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(38, 8);
            label7.Name = "label7";
            label7.Size = new Size(122, 30);
            label7.TabIndex = 2;
            label7.Text = "RecipeNest";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(47, 6);
            label5.Name = "label5";
            label5.Size = new Size(21, 32);
            label5.TabIndex = 2;
            label5.Text = " ";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 47);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = SystemColors.ButtonFace;
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(784, 514);
            splitContainer1.SplitterDistance = 261;
            splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedButton1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 480);
            panel2.TabIndex = 6;
            // 
            // roundedButton1
            // 
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton1.Location = new Point(26, 423);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(169, 38);
            roundedButton1.TabIndex = 11;
            roundedButton1.Text = "Найти рецепт";
            roundedButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 368);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(199, 20);
            label4.TabIndex = 10;
            label4.Text = "Сложность приготовления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 317);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(159, 20);
            label3.TabIndex = 9;
            label3.Text = "Время приготовления";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 229);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Категория";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 30F);
            button7.Location = new Point(184, 251);
            button7.Name = "button7";
            button7.Size = new Size(55, 49);
            button7.TabIndex = 8;
            button7.Text = "★";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 30F);
            button6.Location = new Point(123, 251);
            button6.Name = "button6";
            button6.Size = new Size(55, 49);
            button6.TabIndex = 7;
            button6.Text = "☾";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(62, 251);
            button5.Name = "button5";
            button5.Size = new Size(55, 49);
            button5.TabIndex = 6;
            button5.Text = "☁︎";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(1, 251);
            button4.Name = "button4";
            button4.Size = new Size(55, 49);
            button4.TabIndex = 0;
            button4.Text = "☀︎";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 37);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(232, 184);
            checkedListBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 390);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 339);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(232, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "🔍︎";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(27, 7);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(211, 23);
            label1.TabIndex = 0;
            label1.Text = "Поиск по ингредиентам";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(519, 514);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton1;
    }
}
