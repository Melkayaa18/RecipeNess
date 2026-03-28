using RecipeNess.controls;

namespace RecipeNess
{
    partial class AdminForm
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
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            roundedButton3 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            panel3 = new Panel();
            listBoxRecipes = new ListBox();
            label14 = new Label();
            textBoxCount = new TextBox();
            label15 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            comboBoxTag = new ComboBox();
            panel5 = new Panel();
            radioButtonHard = new RadioButton();
            radioButtonMedium = new RadioButton();
            radioButtonEasy = new RadioButton();
            comboBoxCategory = new ComboBox();
            pictureBoxRecipeImage = new PictureBox();
            textBoxInstruction = new TextBox();
            numericUpDownTime = new NumericUpDown();
            listBoxIngredients = new ListBox();
            panel6 = new Panel();
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
            roundedButtonDelete = new RoundedButton();
            lblRecipeName = new Label();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            btnReject = new RoundedButton();
            btnApprove = new RoundedButton();
            listBoxModerationRecipes = new ListBox();
            panel7 = new Panel();
            txtModerationComment = new TextBox();
            label23 = new Label();
            numericModerationTime = new NumericUpDown();
            radioModerationHard = new RadioButton();
            radioModerationMedium = new RadioButton();
            radioModerationEasy = new RadioButton();
            label4 = new Label();
            lblModerationCategory = new TextBox();
            lblModerationTags = new TextBox();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            pictureBox2 = new PictureBox();
            txtModerationInstruction = new TextBox();
            listBoxModerationIngredients = new ListBox();
            label17 = new Label();
            label16 = new Label();
            txtModerationDescription = new TextBox();
            lblModerationTitle = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label28 = new Label();
            tabPage3 = new TabPage();
            textBoxSearchIngredient = new TextBox();
            label27 = new Label();
            comboBoxSortIngredient = new ComboBox();
            listBoxIngredientsAdmin = new ListBox();
            label26 = new Label();
            panel8 = new Panel();
            roundedButton5 = new RoundedButton();
            roundedButton8 = new RoundedButton();
            label24 = new Label();
            textBoxIngredientName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).BeginInit();
            panel6.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericModerationTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.seed;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(18, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 36);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(689, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "андминистратор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(46, 5);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 1;
            label1.Text = "RecipeNest";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 412);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Главная";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkGray;
            splitContainer1.Panel1.Controls.Add(roundedButton3);
            splitContainer1.Panel1.Controls.Add(roundedButton2);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.BackgroundImage = Properties.Resources.FrameBackgr;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(lblRecipeName);
            splitContainer1.Size = new Size(786, 378);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 0;
            // 
            // roundedButton3
            // 
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Location = new Point(16, 349);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(193, 23);
            roundedButton3.TabIndex = 6;
            roundedButton3.Text = "Управление ингредиентами";
            roundedButton3.UseVisualStyleBackColor = true;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Location = new Point(39, 320);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(151, 23);
            roundedButton2.TabIndex = 5;
            roundedButton2.Text = "СОХРАНИТЬ РЕЦЕПТ";
            roundedButton2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(listBoxRecipes);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(textBoxCount);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(14, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 275);
            panel3.TabIndex = 4;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.Font = new Font("Segoe UI", 11F);
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.Location = new Point(11, 9);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.ScrollAlwaysVisible = true;
            listBoxRecipes.Size = new Size(176, 204);
            listBoxRecipes.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 223);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 1;
            label14.Text = "всего рецептов";
            // 
            // textBoxCount
            // 
            textBoxCount.Font = new Font("Segoe UI", 12F);
            textBoxCount.Location = new Point(11, 239);
            textBoxCount.Multiline = true;
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(176, 29);
            textBoxCount.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F);
            label15.Location = new Point(24, 197);
            label15.Name = "label15";
            label15.Size = new Size(152, 25);
            label15.TabIndex = 9;
            label15.Text = "____________________";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 31);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(39, -3);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 4;
            label3.Text = "Статистика";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(comboBoxTag);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(comboBoxCategory);
            panel4.Controls.Add(pictureBoxRecipeImage);
            panel4.Controls.Add(textBoxInstruction);
            panel4.Controls.Add(numericUpDownTime);
            panel4.Controls.Add(listBoxIngredients);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(roundedButton4);
            panel4.Controls.Add(roundedButtonDelete);
            panel4.Location = new Point(12, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 361);
            panel4.TabIndex = 3;
            // 
            // comboBoxTag
            // 
            comboBoxTag.FormattingEnabled = true;
            comboBoxTag.Location = new Point(336, 5);
            comboBoxTag.Name = "comboBoxTag";
            comboBoxTag.Size = new Size(153, 23);
            comboBoxTag.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(radioButtonHard);
            panel5.Controls.Add(radioButtonMedium);
            panel5.Controls.Add(radioButtonEasy);
            panel5.Location = new Point(154, 162);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 91);
            panel5.TabIndex = 6;
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
            radioButtonMedium.Location = new Point(9, 36);
            radioButtonMedium.Name = "radioButtonMedium";
            radioButtonMedium.Size = new Size(78, 24);
            radioButtonMedium.TabIndex = 1;
            radioButtonMedium.TabStop = true;
            radioButtonMedium.Text = "Средне";
            radioButtonMedium.UseVisualStyleBackColor = true;
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
            comboBoxCategory.Location = new Point(154, 6);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(153, 23);
            comboBoxCategory.TabIndex = 5;
            // 
            // pictureBoxRecipeImage
            // 
            pictureBoxRecipeImage.Location = new Point(336, 137);
            pictureBoxRecipeImage.Name = "pictureBoxRecipeImage";
            pictureBoxRecipeImage.Size = new Size(183, 116);
            pictureBoxRecipeImage.TabIndex = 4;
            pictureBoxRecipeImage.TabStop = false;
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new Point(154, 258);
            textBoxInstruction.Multiline = true;
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.ScrollBars = ScrollBars.Vertical;
            textBoxInstruction.Size = new Size(365, 74);
            textBoxInstruction.TabIndex = 3;
            // 
            // numericUpDownTime
            // 
            numericUpDownTime.Location = new Point(154, 138);
            numericUpDownTime.Name = "numericUpDownTime";
            numericUpDownTime.Size = new Size(144, 23);
            numericUpDownTime.TabIndex = 2;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.HorizontalScrollbar = true;
            listBoxIngredients.Location = new Point(154, 37);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(365, 79);
            listBoxIngredients.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(139, 357);
            panel6.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(5, 106);
            label11.Name = "label11";
            label11.Size = new Size(131, 25);
            label11.TabIndex = 6;
            label11.Text = "_________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(15, 275);
            label9.Name = "label9";
            label9.Size = new Size(103, 46);
            label9.TabIndex = 4;
            label9.Text = "step by step\r\ndescription";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(13, 185);
            label8.Name = "label8";
            label8.Size = new Size(112, 46);
            label8.TabIndex = 3;
            label8.Text = "the difficulty \r\nof cooking";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(13, 137);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 2;
            label7.Text = "cooking time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(19, 69);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 1;
            label6.Text = "ingredients";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(28, 5);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 0;
            label5.Text = "category";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(3, 11);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 5;
            label10.Text = "_________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13F);
            label12.Location = new Point(5, 147);
            label12.Name = "label12";
            label12.Size = new Size(131, 25);
            label12.TabIndex = 7;
            label12.Text = "_________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F);
            label13.Location = new Point(3, 228);
            label13.Name = "label13";
            label13.Size = new Size(131, 25);
            label13.TabIndex = 8;
            label13.Text = "_________________";
            // 
            // roundedButton4
            // 
            roundedButton4.FlatAppearance.BorderSize = 0;
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            roundedButton4.Location = new Point(313, 105);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(26, 25);
            roundedButton4.TabIndex = 9;
            roundedButton4.Text = "+";
            roundedButton4.UseVisualStyleBackColor = true;
            // 
            // roundedButtonDelete
            // 
            roundedButtonDelete.FlatAppearance.BorderSize = 0;
            roundedButtonDelete.FlatStyle = FlatStyle.Flat;
            roundedButtonDelete.Location = new Point(273, 328);
            roundedButtonDelete.Name = "roundedButtonDelete";
            roundedButtonDelete.Size = new Size(118, 24);
            roundedButtonDelete.TabIndex = 12;
            roundedButtonDelete.Text = "Удалить рецепт";
            roundedButtonDelete.UseVisualStyleBackColor = true;
            roundedButtonDelete.Click += btnDeleteRecipe_Click_1;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lblRecipeName.Location = new Point(23, 6);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(114, 15);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "название рецепта";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Модерация";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Silver;
            splitContainer2.Panel1.Controls.Add(btnReject);
            splitContainer2.Panel1.Controls.Add(btnApprove);
            splitContainer2.Panel1.Controls.Add(listBoxModerationRecipes);
            splitContainer2.Panel1.Controls.Add(panel7);
            splitContainer2.Panel1.Controls.Add(txtModerationComment);
            splitContainer2.Panel1.Controls.Add(label23);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.Gainsboro;
            splitContainer2.Panel2.BackgroundImage = Properties.Resources.FrameBackgr;
            splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer2.Panel2.Controls.Add(numericModerationTime);
            splitContainer2.Panel2.Controls.Add(radioModerationHard);
            splitContainer2.Panel2.Controls.Add(radioModerationMedium);
            splitContainer2.Panel2.Controls.Add(radioModerationEasy);
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(lblModerationCategory);
            splitContainer2.Panel2.Controls.Add(lblModerationTags);
            splitContainer2.Panel2.Controls.Add(label22);
            splitContainer2.Panel2.Controls.Add(label19);
            splitContainer2.Panel2.Controls.Add(label18);
            splitContainer2.Panel2.Controls.Add(pictureBox2);
            splitContainer2.Panel2.Controls.Add(txtModerationInstruction);
            splitContainer2.Panel2.Controls.Add(listBoxModerationIngredients);
            splitContainer2.Panel2.Controls.Add(label17);
            splitContainer2.Panel2.Controls.Add(label16);
            splitContainer2.Panel2.Controls.Add(txtModerationDescription);
            splitContainer2.Panel2.Controls.Add(lblModerationTitle);
            splitContainer2.Panel2.Controls.Add(label20);
            splitContainer2.Panel2.Controls.Add(label21);
            splitContainer2.Panel2.Controls.Add(label28);
            splitContainer2.Size = new Size(786, 378);
            splitContainer2.SplitterDistance = 262;
            splitContainer2.TabIndex = 0;
            // 
            // btnReject
            // 
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Location = new Point(70, 340);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(115, 26);
            btnReject.TabIndex = 15;
            btnReject.Text = "Отклонить";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Location = new Point(30, 306);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(193, 28);
            btnApprove.TabIndex = 14;
            btnApprove.Text = "Одобрить и выложить";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // listBoxModerationRecipes
            // 
            listBoxModerationRecipes.Font = new Font("Segoe UI", 12F);
            listBoxModerationRecipes.FormattingEnabled = true;
            listBoxModerationRecipes.Location = new Point(30, 13);
            listBoxModerationRecipes.Name = "listBoxModerationRecipes";
            listBoxModerationRecipes.Size = new Size(218, 172);
            listBoxModerationRecipes.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkGray;
            panel7.Location = new Point(15, 13);
            panel7.Name = "panel7";
            panel7.Size = new Size(17, 172);
            panel7.TabIndex = 3;
            // 
            // txtModerationComment
            // 
            txtModerationComment.Location = new Point(15, 200);
            txtModerationComment.Multiline = true;
            txtModerationComment.Name = "txtModerationComment";
            txtModerationComment.Size = new Size(233, 102);
            txtModerationComment.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label23.Location = new Point(15, 185);
            label23.Name = "label23";
            label23.Size = new Size(168, 15);
            label23.TabIndex = 14;
            label23.Text = "Комментарий к модерации";
            // 
            // numericModerationTime
            // 
            numericModerationTime.Location = new Point(16, 186);
            numericModerationTime.Name = "numericModerationTime";
            numericModerationTime.Size = new Size(161, 23);
            numericModerationTime.TabIndex = 22;
            // 
            // radioModerationHard
            // 
            radioModerationHard.AutoSize = true;
            radioModerationHard.Location = new Point(172, 244);
            radioModerationHard.Name = "radioModerationHard";
            radioModerationHard.Size = new Size(68, 19);
            radioModerationHard.TabIndex = 21;
            radioModerationHard.TabStop = true;
            radioModerationHard.Text = "сложно";
            radioModerationHard.UseVisualStyleBackColor = true;
            // 
            // radioModerationMedium
            // 
            radioModerationMedium.AutoSize = true;
            radioModerationMedium.Location = new Point(78, 244);
            radioModerationMedium.Name = "radioModerationMedium";
            radioModerationMedium.Size = new Size(88, 19);
            radioModerationMedium.TabIndex = 20;
            radioModerationMedium.TabStop = true;
            radioModerationMedium.Text = "нормально";
            radioModerationMedium.UseVisualStyleBackColor = true;
            // 
            // radioModerationEasy
            // 
            radioModerationEasy.AutoSize = true;
            radioModerationEasy.Location = new Point(16, 244);
            radioModerationEasy.Name = "radioModerationEasy";
            radioModerationEasy.Size = new Size(56, 19);
            radioModerationEasy.TabIndex = 19;
            radioModerationEasy.TabStop = true;
            radioModerationEasy.Text = "легко";
            radioModerationEasy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(183, 122);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 18;
            label4.Text = "Категория";
            // 
            // lblModerationCategory
            // 
            lblModerationCategory.Location = new Point(183, 140);
            lblModerationCategory.Name = "lblModerationCategory";
            lblModerationCategory.Size = new Size(95, 23);
            lblModerationCategory.TabIndex = 17;
            // 
            // lblModerationTags
            // 
            lblModerationTags.Location = new Point(183, 89);
            lblModerationTags.Name = "lblModerationTags";
            lblModerationTags.Size = new Size(95, 23);
            lblModerationTags.TabIndex = 16;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label22.Location = new Point(16, 273);
            label22.Name = "label22";
            label22.Size = new Size(167, 15);
            label22.TabIndex = 13;
            label22.Text = "Сложность приготовления";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label19.Location = new Point(16, 168);
            label19.Name = "label19";
            label19.Size = new Size(135, 15);
            label19.TabIndex = 10;
            label19.Text = "Время приготовления";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label18.Location = new Point(16, 54);
            label18.Name = "label18";
            label18.Size = new Size(88, 15);
            label18.TabIndex = 9;
            label18.Text = "Ингредиенты";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(293, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 173);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txtModerationInstruction
            // 
            txtModerationInstruction.Font = new Font("Segoe UI", 11F);
            txtModerationInstruction.Location = new Point(16, 288);
            txtModerationInstruction.Multiline = true;
            txtModerationInstruction.Name = "txtModerationInstruction";
            txtModerationInstruction.Size = new Size(495, 90);
            txtModerationInstruction.TabIndex = 7;
            txtModerationInstruction.TextChanged += textBox8_TextChanged;
            // 
            // listBoxModerationIngredients
            // 
            listBoxModerationIngredients.FormattingEnabled = true;
            listBoxModerationIngredients.Location = new Point(16, 70);
            listBoxModerationIngredients.Name = "listBoxModerationIngredients";
            listBoxModerationIngredients.Size = new Size(161, 94);
            listBoxModerationIngredients.TabIndex = 4;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label17.Location = new Point(293, 7);
            label17.Name = "label17";
            label17.Size = new Size(122, 15);
            label17.TabIndex = 3;
            label17.Text = "Короткое описание";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label16.Location = new Point(16, 7);
            label16.Name = "label16";
            label16.Size = new Size(116, 15);
            label16.TabIndex = 2;
            label16.Text = "Название рецепта";
            // 
            // txtModerationDescription
            // 
            txtModerationDescription.Font = new Font("Segoe UI", 11F);
            txtModerationDescription.Location = new Point(293, 25);
            txtModerationDescription.Multiline = true;
            txtModerationDescription.Name = "txtModerationDescription";
            txtModerationDescription.Size = new Size(218, 51);
            txtModerationDescription.TabIndex = 1;
            // 
            // lblModerationTitle
            // 
            lblModerationTitle.Font = new Font("Segoe UI", 11F);
            lblModerationTitle.Location = new Point(16, 25);
            lblModerationTitle.Multiline = true;
            lblModerationTitle.Name = "lblModerationTitle";
            lblModerationTitle.Size = new Size(262, 29);
            lblModerationTitle.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label20.Location = new Point(293, 79);
            label20.Name = "label20";
            label20.Size = new Size(42, 15);
            label20.TabIndex = 11;
            label20.Text = "Фото";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label21.Location = new Point(14, 223);
            label21.Name = "label21";
            label21.Size = new Size(167, 15);
            label21.TabIndex = 12;
            label21.Text = "Сложность приготовления";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label28.Location = new Point(183, 70);
            label28.Name = "label28";
            label28.Size = new Size(25, 15);
            label28.TabIndex = 15;
            label28.Text = "Тег";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.FrameBackgr;
            tabPage3.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage3.Controls.Add(textBoxSearchIngredient);
            tabPage3.Controls.Add(label27);
            tabPage3.Controls.Add(comboBoxSortIngredient);
            tabPage3.Controls.Add(listBoxIngredientsAdmin);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(panel8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 384);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Управление ингредиентами";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchIngredient
            // 
            textBoxSearchIngredient.Font = new Font("Segoe UI", 12F);
            textBoxSearchIngredient.Location = new Point(190, 21);
            textBoxSearchIngredient.Multiline = true;
            textBoxSearchIngredient.Name = "textBoxSearchIngredient";
            textBoxSearchIngredient.Size = new Size(325, 20);
            textBoxSearchIngredient.TabIndex = 7;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label27.Location = new Point(526, 19);
            label27.Name = "label27";
            label27.Size = new Size(117, 17);
            label27.TabIndex = 4;
            label27.Text = "Сортировать по:";
            // 
            // comboBoxSortIngredient
            // 
            comboBoxSortIngredient.FormattingEnabled = true;
            comboBoxSortIngredient.Location = new Point(646, 16);
            comboBoxSortIngredient.Name = "comboBoxSortIngredient";
            comboBoxSortIngredient.Size = new Size(121, 23);
            comboBoxSortIngredient.TabIndex = 3;
            // 
            // listBoxIngredientsAdmin
            // 
            listBoxIngredientsAdmin.Font = new Font("Segoe UI", 14F);
            listBoxIngredientsAdmin.FormattingEnabled = true;
            listBoxIngredientsAdmin.Location = new Point(19, 45);
            listBoxIngredientsAdmin.Name = "listBoxIngredientsAdmin";
            listBoxIngredientsAdmin.Size = new Size(748, 254);
            listBoxIngredientsAdmin.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label26.Location = new Point(19, 19);
            label26.Name = "label26";
            label26.Size = new Size(165, 20);
            label26.TabIndex = 1;
            label26.Text = "Список ингредиентов";
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkGray;
            panel8.Controls.Add(roundedButton5);
            panel8.Controls.Add(roundedButton8);
            panel8.Controls.Add(label24);
            panel8.Controls.Add(textBoxIngredientName);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 322);
            panel8.Name = "panel8";
            panel8.Size = new Size(792, 62);
            panel8.TabIndex = 0;
            // 
            // roundedButton5
            // 
            roundedButton5.FlatAppearance.BorderSize = 0;
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton5.Location = new Point(526, 7);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(86, 46);
            roundedButton5.TabIndex = 7;
            roundedButton5.Text = "УДАЛИТЬ";
            roundedButton5.UseVisualStyleBackColor = true;
            // 
            // roundedButton8
            // 
            roundedButton8.FlatAppearance.BorderSize = 0;
            roundedButton8.FlatStyle = FlatStyle.Flat;
            roundedButton8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            roundedButton8.Location = new Point(629, 8);
            roundedButton8.Name = "roundedButton8";
            roundedButton8.Size = new Size(155, 46);
            roundedButton8.TabIndex = 6;
            roundedButton8.Text = "Добавить/изменить";
            roundedButton8.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label24.Location = new Point(8, 42);
            label24.Name = "label24";
            label24.Size = new Size(123, 15);
            label24.TabIndex = 4;
            label24.Text = "Название продукта";
            // 
            // textBoxIngredientName
            // 
            textBoxIngredientName.Font = new Font("Segoe UI", 12F);
            textBoxIngredientName.Location = new Point(8, 7);
            textBoxIngredientName.Multiline = true;
            textBoxIngredientName.Name = "textBoxIngredientName";
            textBoxIngredientName.Size = new Size(316, 35);
            textBoxIngredientName.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTime).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericModerationTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private Label label3;
        private Label lblRecipeName;
        private Panel panel4;
        private Panel panel5;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonEasy;
        private ComboBox comboBoxCategory;
        private PictureBox pictureBoxRecipeImage;
        private TextBox textBoxInstruction;
        private NumericUpDown numericUpDownTime;
        private ListBox listBoxIngredients;
        private Panel panel6;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label12;
        private Label label13;
        private Panel panel3;
        private Label label14;
        private TextBox textBoxCount;
        private ListBox listBoxRecipes;
        private Label label15;
        private SplitContainer splitContainer2;
        private ListBox listBoxModerationRecipes;
        private Panel panel7;
        private TextBox txtModerationComment;
        private TextBox txtModerationDescription;
        private TextBox lblModerationTitle;
        private Label label17;
        private Label label16;
        private TextBox txtModerationInstruction;
        private Label label20;
        private Label label19;
        private Label label18;
        private PictureBox pictureBox2;
        private Label label22;
        private Label label21;
        private Label label23;
        private Panel panel8;
        private TextBox textBoxIngredientName;
        private Label label26;
        private Label label24;
        private Label label27;
        private ComboBox comboBoxSortIngredient;
        private ListBox listBoxIngredientsAdmin;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton4;
        private RoundedButton btnReject;
        private RoundedButton btnApprove;
        private RoundedButton roundedButton8;
        private PictureBox pictureBox3;
        private ComboBox comboBoxTag;
        private ListBox listBoxModerationIngredients;
        private Label label28;
        private TextBox textBoxSearchIngredient;
        private RoundedButton roundedButton5;
        private Label label4;
        private TextBox lblModerationCategory;
        private TextBox lblModerationTags;
        private RadioButton radioModerationHard;
        private RadioButton radioModerationMedium;
        private RadioButton radioModerationEasy;
        private NumericUpDown numericModerationTime;
        private RoundedButton roundedButtonDelete;
    }
}