namespace RecipeFinderGUI
{
    partial class SearchForm
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
            SearchByLabel = new Label();
            budgetRadioButton = new RadioButton();
            dietaryRestrictionRadioButton = new RadioButton();
            bothRadioButton = new RadioButton();
            recipeDataGrid = new DataGridView();
            RecipeSearchButton = new Button();
            DietaryRestrictionComboBox = new ComboBox();
            dietaryRestrictionLabel = new Label();
            priceRangeFromLabel = new Label();
            priceRangeToLabel = new Label();
            priceRangeFromText = new TextBox();
            priceRangeToText = new TextBox();
            returnToDashboardFromSearchForm = new Button();
            ((System.ComponentModel.ISupportInitialize)recipeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // SearchByLabel
            // 
            SearchByLabel.AutoSize = true;
            SearchByLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchByLabel.ForeColor = Color.Blue;
            SearchByLabel.Location = new Point(102, 52);
            SearchByLabel.Name = "SearchByLabel";
            SearchByLabel.Size = new Size(114, 24);
            SearchByLabel.TabIndex = 0;
            SearchByLabel.Text = "Search By: ";
            // 
            // budgetRadioButton
            // 
            budgetRadioButton.AutoSize = true;
            budgetRadioButton.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            budgetRadioButton.ForeColor = Color.MediumSlateBlue;
            budgetRadioButton.Location = new Point(252, 54);
            budgetRadioButton.Name = "budgetRadioButton";
            budgetRadioButton.Size = new Size(89, 25);
            budgetRadioButton.TabIndex = 1;
            budgetRadioButton.TabStop = true;
            budgetRadioButton.Text = "Budget";
            budgetRadioButton.UseVisualStyleBackColor = true;
            budgetRadioButton.CheckedChanged += budgetRadioButton_CheckedChanged;
            // 
            // dietaryRestrictionRadioButton
            // 
            dietaryRestrictionRadioButton.AutoSize = true;
            dietaryRestrictionRadioButton.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dietaryRestrictionRadioButton.ForeColor = Color.MediumSlateBlue;
            dietaryRestrictionRadioButton.Location = new Point(365, 54);
            dietaryRestrictionRadioButton.Name = "dietaryRestrictionRadioButton";
            dietaryRestrictionRadioButton.Size = new Size(186, 25);
            dietaryRestrictionRadioButton.TabIndex = 2;
            dietaryRestrictionRadioButton.TabStop = true;
            dietaryRestrictionRadioButton.Text = "Dietary Restriction";
            dietaryRestrictionRadioButton.UseVisualStyleBackColor = true;
            dietaryRestrictionRadioButton.CheckedChanged += dietaryRestrictionRadioButton_CheckedChanged;
            // 
            // bothRadioButton
            // 
            bothRadioButton.AutoSize = true;
            bothRadioButton.Font = new Font("Constantia", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            bothRadioButton.ForeColor = Color.MediumSlateBlue;
            bothRadioButton.Location = new Point(576, 54);
            bothRadioButton.Name = "bothRadioButton";
            bothRadioButton.Size = new Size(70, 25);
            bothRadioButton.TabIndex = 3;
            bothRadioButton.TabStop = true;
            bothRadioButton.Text = "Both";
            bothRadioButton.UseVisualStyleBackColor = true;
            bothRadioButton.CheckedChanged += bothRadioButton_CheckedChanged;
            // 
            // recipeDataGrid
            // 
            recipeDataGrid.BackgroundColor = Color.OldLace;
            recipeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recipeDataGrid.Location = new Point(102, 194);
            recipeDataGrid.Name = "recipeDataGrid";
            recipeDataGrid.RowHeadersWidth = 51;
            recipeDataGrid.RowTemplate.Height = 29;
            recipeDataGrid.Size = new Size(674, 293);
            recipeDataGrid.TabIndex = 4;
            recipeDataGrid.CellContentClick += recipeDataGrid_CellContentClick;
            recipeDataGrid.CellDoubleClick += recipeDataGrid_CellDoubleClick;
            // 
            // RecipeSearchButton
            // 
            RecipeSearchButton.BackColor = Color.FromArgb(192, 192, 255);
            RecipeSearchButton.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            RecipeSearchButton.Location = new Point(685, 54);
            RecipeSearchButton.Name = "RecipeSearchButton";
            RecipeSearchButton.Size = new Size(103, 29);
            RecipeSearchButton.TabIndex = 5;
            RecipeSearchButton.Text = "Search";
            RecipeSearchButton.UseVisualStyleBackColor = false;
            RecipeSearchButton.Click += RecipeSearchButton_Click;
            // 
            // DietaryRestrictionComboBox
            // 
            DietaryRestrictionComboBox.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DietaryRestrictionComboBox.FormattingEnabled = true;
            DietaryRestrictionComboBox.Items.AddRange(new object[] { "Gluten-Free", "Ketogenic", "Lactose-Free", "Vegan", "Vegetarian", "Dairy_free" });
            DietaryRestrictionComboBox.Location = new Point(253, 138);
            DietaryRestrictionComboBox.Name = "DietaryRestrictionComboBox";
            DietaryRestrictionComboBox.Size = new Size(314, 29);
            DietaryRestrictionComboBox.TabIndex = 7;
            DietaryRestrictionComboBox.SelectedIndexChanged += DietaryRestrictionComboBox_SelectedIndexChanged;
            // 
            // dietaryRestrictionLabel
            // 
            dietaryRestrictionLabel.AutoSize = true;
            dietaryRestrictionLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dietaryRestrictionLabel.Location = new Point(102, 147);
            dietaryRestrictionLabel.Name = "dietaryRestrictionLabel";
            dietaryRestrictionLabel.Size = new Size(129, 18);
            dietaryRestrictionLabel.TabIndex = 8;
            dietaryRestrictionLabel.Text = "Dietary Restriction";
            // 
            // priceRangeFromLabel
            // 
            priceRangeFromLabel.AutoSize = true;
            priceRangeFromLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceRangeFromLabel.Location = new Point(102, 95);
            priceRangeFromLabel.Name = "priceRangeFromLabel";
            priceRangeFromLabel.Size = new Size(128, 18);
            priceRangeFromLabel.TabIndex = 9;
            priceRangeFromLabel.Text = "Price Range From:";
            priceRangeFromLabel.Visible = false;
            // 
            // priceRangeToLabel
            // 
            priceRangeToLabel.AutoSize = true;
            priceRangeToLabel.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceRangeToLabel.Location = new Point(456, 95);
            priceRangeToLabel.Name = "priceRangeToLabel";
            priceRangeToLabel.Size = new Size(109, 18);
            priceRangeToLabel.TabIndex = 11;
            priceRangeToLabel.Text = "Price Range To:";
            // 
            // priceRangeFromText
            // 
            priceRangeFromText.Location = new Point(253, 92);
            priceRangeFromText.Name = "priceRangeFromText";
            priceRangeFromText.Size = new Size(125, 27);
            priceRangeFromText.TabIndex = 12;
            priceRangeFromText.Visible = false;
            priceRangeFromText.TextChanged += priceRangeFromText_TextChanged;
            // 
            // priceRangeToText
            // 
            priceRangeToText.Location = new Point(574, 92);
            priceRangeToText.Name = "priceRangeToText";
            priceRangeToText.Size = new Size(125, 27);
            priceRangeToText.TabIndex = 13;
            priceRangeToText.Visible = false;
            // 
            // returnToDashboardFromSearchForm
            // 
            returnToDashboardFromSearchForm.BackColor = Color.FromArgb(192, 192, 255);
            returnToDashboardFromSearchForm.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            returnToDashboardFromSearchForm.Location = new Point(630, 12);
            returnToDashboardFromSearchForm.Name = "returnToDashboardFromSearchForm";
            returnToDashboardFromSearchForm.Size = new Size(158, 29);
            returnToDashboardFromSearchForm.TabIndex = 14;
            returnToDashboardFromSearchForm.Text = "Return To Dashboard";
            returnToDashboardFromSearchForm.UseVisualStyleBackColor = false;
            returnToDashboardFromSearchForm.Click += returnToDashboardFromSearchForm_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(803, 536);
            Controls.Add(returnToDashboardFromSearchForm);
            Controls.Add(DietaryRestrictionComboBox);
            Controls.Add(priceRangeToText);
            Controls.Add(priceRangeFromText);
            Controls.Add(priceRangeToLabel);
            Controls.Add(dietaryRestrictionLabel);
            Controls.Add(RecipeSearchButton);
            Controls.Add(recipeDataGrid);
            Controls.Add(bothRadioButton);
            Controls.Add(dietaryRestrictionRadioButton);
            Controls.Add(budgetRadioButton);
            Controls.Add(SearchByLabel);
            Controls.Add(priceRangeFromLabel);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)recipeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchByLabel;
        private RadioButton budgetRadioButton;
        private RadioButton dietaryRestrictionRadioButton;
        private RadioButton bothRadioButton;
        private DataGridView recipeDataGrid;
        private Button RecipeSearchButton;
        private ComboBox DietaryRestrictionComboBox;
        private Label dietaryRestrictionLabel;
        private Label priceRangeFromLabel;
        private Label priceRangeToLabel;
        private TextBox priceRangeFromText;
        private TextBox priceRangeToText;
        private Button returnToDashboardFromSearchForm;
    }
}