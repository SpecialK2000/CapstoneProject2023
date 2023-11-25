namespace RecipeFinderGUI
{
    partial class DeleteRecipe
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
            deleteRecipeButton = new Button();
            returnToDashboardButton = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.BackColor = Color.FromArgb(192, 192, 255);
            deleteRecipeButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteRecipeButton.Location = new Point(478, 192);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(94, 29);
            deleteRecipeButton.TabIndex = 2;
            deleteRecipeButton.Text = "Delete Recipe";
            deleteRecipeButton.UseVisualStyleBackColor = false;
            deleteRecipeButton.Click += deleteRecipeButton_Click;
            // 
            // returnToDashboardButton
            // 
            returnToDashboardButton.BackColor = Color.FromArgb(192, 192, 255);
            returnToDashboardButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            returnToDashboardButton.Location = new Point(559, 367);
            returnToDashboardButton.Name = "returnToDashboardButton";
            returnToDashboardButton.Size = new Size(172, 29);
            returnToDashboardButton.TabIndex = 3;
            returnToDashboardButton.Text = "Return To Dashboard";
            returnToDashboardButton.UseVisualStyleBackColor = false;
            returnToDashboardButton.Click += returnToDashboardButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gluten-Free", "Ketogenic", "Lactose-Free", "Vegan", "Vegetarian", "Dairy_free" });
            comboBox1.Location = new Point(245, 81);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(314, 29);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 90);
            label1.Name = "label1";
            label1.Size = new Size(129, 18);
            label1.TabIndex = 12;
            label1.Text = "Dietary Restriction";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Gluten-Free", "Ketogenic", "Lactose-Free", "Vegan", "Vegetarian", "Dairy_free" });
            comboBox2.Location = new Point(245, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(314, 29);
            comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 139);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 14;
            label2.Text = "Recipe";
            // 
            // DeleteRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(returnToDashboardButton);
            Controls.Add(deleteRecipeButton);
            Name = "DeleteRecipe";
            Text = "DeleteRecipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteRecipeButton;
        private Button returnToDashboardButton;
        private ComboBox DietaryRestrictionComboBox;
        private Label dietaryRestrictionLabel;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
    }
}