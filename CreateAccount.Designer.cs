namespace AccountRepository
{
    partial class CreateAccount
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
            this.NewAccountMessage = new System.Windows.Forms.Label();
            this.NewUsername = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.NewUsernameTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewAccountMessage
            // 
            this.NewAccountMessage.AutoSize = true;
            this.NewAccountMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewAccountMessage.Location = new System.Drawing.Point(43, 9);
            this.NewAccountMessage.Name = "NewAccountMessage";
            this.NewAccountMessage.Size = new System.Drawing.Size(265, 20);
            this.NewAccountMessage.TabIndex = 0;
            this.NewAccountMessage.Text = "Please enter a username and password";
            // 
            // NewUsername
            // 
            this.NewUsername.AutoSize = true;
            this.NewUsername.Location = new System.Drawing.Point(96, 95);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(63, 15);
            this.NewUsername.TabIndex = 1;
            this.NewUsername.Text = "Username:";
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(99, 129);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(60, 15);
            this.NewPassword.TabIndex = 2;
            this.NewPassword.Text = "Password:";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(52, 164);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(107, 15);
            this.ConfirmPassword.TabIndex = 3;
            this.ConfirmPassword.Text = "Confirm Password:";
            // 
            // NewUsernameTextBox
            // 
            this.NewUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewUsernameTextBox.Location = new System.Drawing.Point(186, 92);
            this.NewUsernameTextBox.Name = "NewUsernameTextBox";
            this.NewUsernameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NewUsernameTextBox.TabIndex = 4;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(186, 126);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.NewPasswordTextBox.TabIndex = 5;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(186, 161);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.ConfirmPasswordTextBox.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(136, 231);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ShowText
            // 
            this.ShowText.AutoSize = true;
            this.ShowText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowText.Location = new System.Drawing.Point(186, 190);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(55, 17);
            this.ShowText.TabIndex = 8;
            this.ShowText.Text = "Show";
            this.ShowText.UseVisualStyleBackColor = true;
            this.ShowText.CheckedChanged += new System.EventHandler(this.ShowText_CheckedChanged);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(349, 300);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewUsernameTextBox);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.Controls.Add(this.NewAccountMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository - Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NewAccountMessage;
        private Label NewUsername;
        private Label NewPassword;
        private Label ConfirmPassword;
        private TextBox NewUsernameTextBox;
        private TextBox NewPasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private Button SubmitButton;
        private CheckBox ShowText;
    }
}