namespace RecipeFinderGUI
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DashboardTitle = new Label();
            SearchForRecipesButton = new Button();
            pictureBox1 = new PictureBox();
            adminAddRecipeButton = new Button();
            adminDeleteRecipeButton = new Button();
            logOutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DashboardTitle
            // 
            DashboardTitle.AutoSize = true;
            DashboardTitle.Font = new Font("Constantia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            DashboardTitle.ForeColor = Color.FromArgb(128, 128, 255);
            DashboardTitle.Location = new Point(275, 29);
            DashboardTitle.Name = "DashboardTitle";
            DashboardTitle.Size = new Size(220, 41);
            DashboardTitle.TabIndex = 0;
            DashboardTitle.Text = "Recipe Finder";
            // 
            // SearchForRecipesButton
            // 
            SearchForRecipesButton.BackColor = Color.FromArgb(192, 192, 255);
            SearchForRecipesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchForRecipesButton.Location = new Point(222, 91);
            SearchForRecipesButton.Name = "SearchForRecipesButton";
            SearchForRecipesButton.Size = new Size(323, 38);
            SearchForRecipesButton.TabIndex = 1;
            SearchForRecipesButton.Text = "Search For Recipes";
            SearchForRecipesButton.UseVisualStyleBackColor = false;
            SearchForRecipesButton.Click += SearchForRecipesButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(222, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 158);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // adminAddRecipeButton
            // 
            adminAddRecipeButton.BackColor = Color.Honeydew;
            adminAddRecipeButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminAddRecipeButton.Location = new Point(222, 148);
            adminAddRecipeButton.Name = "adminAddRecipeButton";
            adminAddRecipeButton.Size = new Size(94, 29);
            adminAddRecipeButton.TabIndex = 3;
            adminAddRecipeButton.Text = "Add Recipe";
            adminAddRecipeButton.UseVisualStyleBackColor = false;
            adminAddRecipeButton.Click += button1_Click;
            // 
            // adminDeleteRecipeButton
            // 
            adminDeleteRecipeButton.BackColor = Color.LavenderBlush;
            adminDeleteRecipeButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminDeleteRecipeButton.Location = new Point(416, 148);
            adminDeleteRecipeButton.Name = "adminDeleteRecipeButton";
            adminDeleteRecipeButton.Size = new Size(129, 29);
            adminDeleteRecipeButton.TabIndex = 4;
            adminDeleteRecipeButton.Text = "Delete Recipe";
            adminDeleteRecipeButton.UseVisualStyleBackColor = false;
            adminDeleteRecipeButton.Click += button2_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(192, 192, 255);
            logOutButton.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.Location = new Point(682, 12);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 5;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Controls.Add(adminDeleteRecipeButton);
            Controls.Add(adminAddRecipeButton);
            Controls.Add(pictureBox1);
            Controls.Add(SearchForRecipesButton);
            Controls.Add(DashboardTitle);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DashboardTitle;
        private Button SearchForRecipesButton;
        private PictureBox pictureBox1;
        private Button adminAddRecipeButton;
        private Button adminDeleteRecipeButton;
        private Button logOutButton;
    }
}