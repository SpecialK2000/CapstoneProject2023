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
            saveRecipeToLibraryButton = new Button();
            closeFormButton = new Button();
            SuspendLayout();
            // 
            // saveRecipeToLibraryButton
            // 
            saveRecipeToLibraryButton.BackColor = Color.FromArgb(192, 192, 255);
            saveRecipeToLibraryButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            saveRecipeToLibraryButton.Location = new Point(203, 368);
            saveRecipeToLibraryButton.Name = "saveRecipeToLibraryButton";
            saveRecipeToLibraryButton.Size = new Size(128, 29);
            saveRecipeToLibraryButton.TabIndex = 0;
            saveRecipeToLibraryButton.Text = "Save Recipe";
            saveRecipeToLibraryButton.UseVisualStyleBackColor = false;
            saveRecipeToLibraryButton.Click += saveRecipeToLibraryButton_Click;
            // 
            // closeFormButton
            // 
            closeFormButton.BackColor = Color.FromArgb(192, 192, 255);
            closeFormButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeFormButton.Location = new Point(492, 370);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(94, 29);
            closeFormButton.TabIndex = 1;
            closeFormButton.Text = "Close";
            closeFormButton.UseVisualStyleBackColor = false;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // ViewRecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(closeFormButton);
            Controls.Add(saveRecipeToLibraryButton);
            Name = "ViewRecipeDetailsForm";
            Text = "ViewRecipeDetailsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button saveRecipeToLibraryButton;
        private Button closeFormButton;
    }
}