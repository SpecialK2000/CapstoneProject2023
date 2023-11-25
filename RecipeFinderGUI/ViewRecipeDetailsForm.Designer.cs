namespace RecipeFinderGUI
{
    partial class ViewRecipeDetailsForm
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
            closeFormButton = new Button();
            nameLabel = new Label();
            cookingTimeLabel = new Label();
            dietaryRestrictionLabel = new Label();
            costLabel = new Label();
            ingredientsLabel = new Label();
            instructionsLabel = new Label();
            lblDisplayName = new Label();
            displayCookingTime = new Label();
            displayDietaryRestriction = new Label();
            displayCost = new Label();
            displayIngredients = new Label();
            displayInstructions = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // closeFormButton
            // 
            closeFormButton.BackColor = Color.FromArgb(192, 192, 255);
            closeFormButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeFormButton.Location = new Point(672, 409);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(94, 29);
            closeFormButton.TabIndex = 1;
            closeFormButton.Text = "Close";
            closeFormButton.UseVisualStyleBackColor = false;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(40, 26);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(105, 20);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Recipe Name:";
            // 
            // cookingTimeLabel
            // 
            cookingTimeLabel.AutoSize = true;
            cookingTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cookingTimeLabel.Location = new Point(44, 65);
            cookingTimeLabel.Name = "cookingTimeLabel";
            cookingTimeLabel.Size = new Size(106, 20);
            cookingTimeLabel.TabIndex = 9;
            cookingTimeLabel.Text = "Cooking time:";
            // 
            // dietaryRestrictionLabel
            // 
            dietaryRestrictionLabel.AutoSize = true;
            dietaryRestrictionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dietaryRestrictionLabel.Location = new Point(11, 105);
            dietaryRestrictionLabel.Name = "dietaryRestrictionLabel";
            dietaryRestrictionLabel.Size = new Size(145, 20);
            dietaryRestrictionLabel.TabIndex = 10;
            dietaryRestrictionLabel.Text = "Dietary Restriction:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            costLabel.Location = new Point(104, 144);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(44, 20);
            costLabel.TabIndex = 11;
            costLabel.Text = "Cost:";
            // 
            // ingredientsLabel
            // 
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ingredientsLabel.Location = new Point(59, 178);
            ingredientsLabel.Name = "ingredientsLabel";
            ingredientsLabel.Size = new Size(93, 20);
            ingredientsLabel.TabIndex = 12;
            ingredientsLabel.Text = "Ingredients:";
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            instructionsLabel.Location = new Point(53, 276);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(97, 20);
            instructionsLabel.TabIndex = 13;
            instructionsLabel.Text = "Instructions:";
            // 
            // lblDisplayName
            // 
            lblDisplayName.AutoSize = true;
            lblDisplayName.Location = new Point(179, 26);
            lblDisplayName.Name = "lblDisplayName";
            lblDisplayName.Size = new Size(101, 20);
            lblDisplayName.TabIndex = 14;
            lblDisplayName.Text = "Recipe Name:";
            lblDisplayName.Click += lblDisplayName_Click;
            // 
            // displayCookingTime
            // 
            displayCookingTime.AutoSize = true;
            displayCookingTime.Location = new Point(179, 67);
            displayCookingTime.Name = "displayCookingTime";
            displayCookingTime.Size = new Size(50, 20);
            displayCookingTime.TabIndex = 15;
            displayCookingTime.Text = "label2";
            // 
            // displayDietaryRestriction
            // 
            displayDietaryRestriction.AutoSize = true;
            displayDietaryRestriction.Location = new Point(179, 105);
            displayDietaryRestriction.Name = "displayDietaryRestriction";
            displayDietaryRestriction.Size = new Size(50, 20);
            displayDietaryRestriction.TabIndex = 16;
            displayDietaryRestriction.Text = "label3";
            // 
            // displayCost
            // 
            displayCost.AutoSize = true;
            displayCost.Location = new Point(190, 144);
            displayCost.Name = "displayCost";
            displayCost.Size = new Size(50, 20);
            displayCost.TabIndex = 17;
            displayCost.Text = "label4";
            // 
            // displayIngredients
            // 
            displayIngredients.Location = new Point(179, 178);
            displayIngredients.Name = "displayIngredients";
            displayIngredients.Size = new Size(587, 84);
            displayIngredients.TabIndex = 18;
            displayIngredients.Text = "label5";
            // 
            // displayInstructions
            // 
            displayInstructions.Location = new Point(179, 276);
            displayInstructions.Name = "displayInstructions";
            displayInstructions.Size = new Size(587, 130);
            displayInstructions.TabIndex = 19;
            displayInstructions.Text = "label6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 144);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 20;
            label1.Text = "$";
            // 
            // ViewRecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(displayInstructions);
            Controls.Add(displayIngredients);
            Controls.Add(displayCost);
            Controls.Add(displayDietaryRestriction);
            Controls.Add(displayCookingTime);
            Controls.Add(lblDisplayName);
            Controls.Add(instructionsLabel);
            Controls.Add(ingredientsLabel);
            Controls.Add(costLabel);
            Controls.Add(dietaryRestrictionLabel);
            Controls.Add(cookingTimeLabel);
            Controls.Add(nameLabel);
            Controls.Add(closeFormButton);
            Name = "ViewRecipeDetailsForm";
            Text = "ViewRecipeDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeFormButton;
        private ListBox ingredientsListbox;
        private ListBox instructionsListbox;
        private Label nameLabel;
        private TextBox cookingTimeTextbox;
        private TextBox dietaryRestrictionTextbox;
        private TextBox costTextbox;
        private Label cookingTimeLabel;
        private Label dietaryRestrictionLabel;
        private Label costLabel;
        private Label ingredientsLabel;
        private Label instructionsLabel;
        private Label lblDisplayName;
        private Label displayCookingTime;
        private Label displayDietaryRestriction;
        private Label displayCost;
        private Label displayIngredients;
        private Label displayInstructions;
        private Label label1;
    }
}