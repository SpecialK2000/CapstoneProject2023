namespace RecipeFinderGUI
{
    partial class AddRecipeForm
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
            addRecipeToDatabaseButton = new Button();
            recipeNameLabel = new Label();
            recipeNameTextbox = new TextBox();
            ingredientsLabel = new Label();
            dietaryRestrictionLabel = new Label();
            cookingTimeLabel = new Label();
            instructionsLabel = new Label();
            costLabel = new Label();
            descriptionLabel = new Label();
            ingredientsTextbox = new TextBox();
            dietaryRestrictionTextbox = new TextBox();
            cookingTimeTextbox = new TextBox();
            instructionsTextbox = new TextBox();
            costTextbox = new TextBox();
            descriptionTextbox = new TextBox();
            returnToDashboardFromAddFormButton = new Button();
            SuspendLayout();
            // 
            // addRecipeToDatabaseButton
            // 
            addRecipeToDatabaseButton.BackColor = Color.FromArgb(192, 192, 255);
            addRecipeToDatabaseButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addRecipeToDatabaseButton.Location = new Point(476, 319);
            addRecipeToDatabaseButton.Name = "addRecipeToDatabaseButton";
            addRecipeToDatabaseButton.Size = new Size(205, 29);
            addRecipeToDatabaseButton.TabIndex = 0;
            addRecipeToDatabaseButton.Text = "Add Recipe To Database";
            addRecipeToDatabaseButton.UseVisualStyleBackColor = false;
            addRecipeToDatabaseButton.Click += button1_Click;
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            recipeNameLabel.ForeColor = Color.Black;
            recipeNameLabel.Location = new Point(32, 35);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(108, 21);
            recipeNameLabel.TabIndex = 1;
            recipeNameLabel.Text = "Recipe Name";
            // 
            // recipeNameTextbox
            // 
            recipeNameTextbox.Location = new Point(213, 29);
            recipeNameTextbox.Name = "recipeNameTextbox";
            recipeNameTextbox.Size = new Size(125, 27);
            recipeNameTextbox.TabIndex = 2;
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ingredientsLabel.Location = new Point(32, 91);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(96, 21);
            ingredientsLabel.TabIndex = 3;
            ingredientsLabel.Text = "Ingredients";
            // 
            // dietaryRestrictionLabel
            // 
            dietaryRestrictionLabel.AutoSize = true;
            dietaryRestrictionLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dietaryRestrictionLabel.Location = new Point(32, 145);
            dietaryRestrictionLabel.Name = "dietaryRestrictionLabel";
            dietaryRestrictionLabel.Size = new Size(151, 21);
            dietaryRestrictionLabel.TabIndex = 4;
            dietaryRestrictionLabel.Text = "Dietary Restriction";
            // 
            // cookingTimeLabel
            // 
            cookingTimeLabel.AutoSize = true;
            cookingTimeLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cookingTimeLabel.Location = new Point(32, 205);
            cookingTimeLabel.Name = "cookingTimeLabel";
            cookingTimeLabel.Size = new Size(114, 21);
            cookingTimeLabel.TabIndex = 5;
            cookingTimeLabel.Text = "Cooking Time";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsLabel.Location = new Point(32, 260);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(101, 21);
            instructionsLabel.TabIndex = 6;
            instructionsLabel.Text = "Instructions";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            costLabel.Location = new Point(32, 328);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(80, 21);
            costLabel.TabIndex = 7;
            costLabel.Text = "Cost (int)";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(32, 379);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(98, 21);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "Description";
            // 
            // ingredientsTextbox
            // 
            ingredientsTextbox.Location = new Point(213, 88);
            ingredientsTextbox.Name = "ingredientsTextbox";
            ingredientsTextbox.Size = new Size(125, 27);
            ingredientsTextbox.TabIndex = 9;
            // 
            // dietaryRestrictionTextbox
            // 
            dietaryRestrictionTextbox.Location = new Point(213, 139);
            dietaryRestrictionTextbox.Name = "dietaryRestrictionTextbox";
            dietaryRestrictionTextbox.Size = new Size(125, 27);
            dietaryRestrictionTextbox.TabIndex = 10;
            // 
            // cookingTimeTextbox
            // 
            cookingTimeTextbox.Location = new Point(213, 199);
            cookingTimeTextbox.Name = "cookingTimeTextbox";
            cookingTimeTextbox.Size = new Size(125, 27);
            cookingTimeTextbox.TabIndex = 11;
            // 
            // instructionsTextbox
            // 
            instructionsTextbox.Location = new Point(213, 257);
            instructionsTextbox.Name = "instructionsTextbox";
            instructionsTextbox.Size = new Size(125, 27);
            instructionsTextbox.TabIndex = 12;
            // 
            // costTextbox
            // 
            costTextbox.Location = new Point(213, 319);
            costTextbox.Name = "costTextbox";
            costTextbox.Size = new Size(125, 27);
            costTextbox.TabIndex = 13;
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(213, 376);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(125, 27);
            descriptionTextbox.TabIndex = 14;
            // 
            // returnToDashboardFromAddFormButton
            // 
            returnToDashboardFromAddFormButton.BackColor = Color.FromArgb(192, 192, 255);
            returnToDashboardFromAddFormButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            returnToDashboardFromAddFormButton.Location = new Point(476, 370);
            returnToDashboardFromAddFormButton.Name = "returnToDashboardFromAddFormButton";
            returnToDashboardFromAddFormButton.Size = new Size(205, 29);
            returnToDashboardFromAddFormButton.TabIndex = 15;
            returnToDashboardFromAddFormButton.Text = "Return To Dashboard";
            returnToDashboardFromAddFormButton.UseVisualStyleBackColor = false;
            returnToDashboardFromAddFormButton.Click += returnToDashboardButton_Click;
            // 
            // AddRecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(returnToDashboardFromAddFormButton);
            Controls.Add(descriptionTextbox);
            Controls.Add(costTextbox);
            Controls.Add(instructionsTextbox);
            Controls.Add(cookingTimeTextbox);
            Controls.Add(dietaryRestrictionTextbox);
            Controls.Add(ingredientsTextbox);
            Controls.Add(descriptionLabel);
            Controls.Add(costLabel);
            Controls.Add(instructionsLabel);
            Controls.Add(cookingTimeLabel);
            Controls.Add(dietaryRestrictionLabel);
            Controls.Add(ingredientsLabel);
            Controls.Add(recipeNameTextbox);
            Controls.Add(recipeNameLabel);
            Controls.Add(addRecipeToDatabaseButton);
            Name = "AddRecipeForm";
            Text = "AddRecipe";
            Load += AddRecipeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addRecipeToDatabaseButton;
        private Label recipeNameLabel;
        private TextBox recipeNameTextbox;
        private Label ingredientsLabel;
        private Label dietaryRestrictionLabel;
        private Label cookingTimeLabel;
        private Label instructionsLabel;
        private Label costLabel;
        private Label descriptionLabel;
        private TextBox ingredientsTextbox;
        private TextBox dietaryRestrictionTextbox;
        private TextBox cookingTimeTextbox;
        private TextBox instructionsTextbox;
        private TextBox costTextbox;
        private TextBox descriptionTextbox;
        private Button returnToDashboardFromAddFormButton;
    }
}