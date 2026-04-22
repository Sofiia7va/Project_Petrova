namespace RecipeApp
{
    partial class RecipeForm
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
            numericCookingTime = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericDifficulty = new NumericUpDown();
            label4 = new Label();
            dateTimePickerCreated = new DateTimePicker();
            checkBoxVegetarian = new CheckBox();
            buttonOK = new Button();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericCookingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDifficulty).BeginInit();
            SuspendLayout();
            // 
            // numericCookingTime
            // 
            numericCookingTime.Location = new Point(179, 77);
            numericCookingTime.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericCookingTime.Name = "numericCookingTime";
            numericCookingTime.Size = new Size(150, 27);
            numericCookingTime.TabIndex = 0;
            numericCookingTime.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 79);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Cooking Time:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 130);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Difficulty:";
            label3.Click += label3_Click;
            // 
            // numericDifficulty
            // 
            numericDifficulty.DecimalPlaces = 1;
            numericDifficulty.Location = new Point(179, 128);
            numericDifficulty.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericDifficulty.Name = "numericDifficulty";
            numericDifficulty.Size = new Size(150, 27);
            numericDifficulty.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 180);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "Created At:";
            // 
            // dateTimePickerCreated
            // 
            dateTimePickerCreated.Location = new Point(179, 175);
            dateTimePickerCreated.Name = "dateTimePickerCreated";
            dateTimePickerCreated.Size = new Size(250, 27);
            dateTimePickerCreated.TabIndex = 6;
            // 
            // checkBoxVegetarian
            // 
            checkBoxVegetarian.AutoSize = true;
            checkBoxVegetarian.Location = new Point(48, 226);
            checkBoxVegetarian.Name = "checkBoxVegetarian";
            checkBoxVegetarian.Size = new Size(116, 24);
            checkBoxVegetarian.TabIndex = 7;
            checkBoxVegetarian.Text = "Is Vegetarian";
            checkBoxVegetarian.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(48, 280);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 8;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click_1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(179, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 9;
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxName);
            Controls.Add(buttonOK);
            Controls.Add(checkBoxVegetarian);
            Controls.Add(dateTimePickerCreated);
            Controls.Add(label4);
            Controls.Add(numericDifficulty);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericCookingTime);
            Name = "RecipeForm";
            Text = "RecipeForm";
            ((System.ComponentModel.ISupportInitialize)numericCookingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDifficulty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericCookingTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericDifficulty;
        private Label label4;
        private DateTimePicker dateTimePickerCreated;
        private CheckBox checkBoxVegetarian;
        private Button buttonOK;
        private TextBox textBoxName;
    }
}