namespace RecipeApp
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
            dataGridViewRecipes = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.AccessibleName = "";
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipes.Dock = DockStyle.Top;
            dataGridViewRecipes.Location = new Point(0, 0);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.Size = new Size(800, 368);
            dataGridViewRecipes.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(609, 383);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(79, 383);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(285, 383);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Зберегти  ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(385, 383);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(110, 29);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Завантажити";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewRecipes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRecipes;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonLoad;
    }
}
