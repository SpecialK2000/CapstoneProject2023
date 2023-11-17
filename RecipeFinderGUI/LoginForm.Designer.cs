namespace RecipeFinderGUI
{
    partial class LoginForm
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
            usernameLabel1 = new Label();
            passwordLabel1 = new Label();
            FormTitle = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LoginButton = new Button();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel1
            // 
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new Point(422, 129);
            usernameLabel1.Name = "usernameLabel1";
            usernameLabel1.Size = new Size(75, 20);
            usernameLabel1.TabIndex = 1;
            usernameLabel1.Text = "Username";
            usernameLabel1.Click += usernameLabel1_Click;
            // 
            // passwordLabel1
            // 
            passwordLabel1.AutoSize = true;
            passwordLabel1.Location = new Point(427, 193);
            passwordLabel1.Name = "passwordLabel1";
            passwordLabel1.Size = new Size(70, 20);
            passwordLabel1.TabIndex = 2;
            passwordLabel1.Text = "Password";
            passwordLabel1.Click += passwordLabel1_Click;
            // 
            // FormTitle
            // 
            FormTitle.AutoSize = true;
            FormTitle.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormTitle.ForeColor = Color.FromArgb(128, 128, 255);
            FormTitle.Location = new Point(276, 22);
            FormTitle.Name = "FormTitle";
            FormTitle.Size = new Size(196, 37);
            FormTitle.TabIndex = 3;
            FormTitle.Text = "Recipe Finder";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(235, 126);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(125, 27);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(235, 190);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(192, 192, 255);
            LoginButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(313, 279);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 29);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LogIn_SignUp_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(192, 192, 255);
            SignUpButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpButton.Location = new Point(313, 328);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(125, 29);
            SignUpButton.TabIndex = 7;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(FormTitle);
            Controls.Add(passwordLabel1);
            Controls.Add(usernameLabel1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label usernameLabel1;
        private Label passwordLabel1;
        private Label FormTitle;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button LoginButton;
        private Button SignUpButton;
    }
}