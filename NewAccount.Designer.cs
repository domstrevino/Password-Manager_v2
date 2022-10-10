namespace AccountRepository
{
    partial class NewAccount
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.Label();
            this.AccountPassword = new System.Windows.Forms.Label();
            this.AccountUsername = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(131, 237);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(99, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(146, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "New Account";
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountName.Location = new System.Drawing.Point(25, 62);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(115, 21);
            this.AccountName.TabIndex = 2;
            this.AccountName.Text = "Account Name:";
            // 
            // AccountPassword
            // 
            this.AccountPassword.AutoSize = true;
            this.AccountPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountPassword.Location = new System.Drawing.Point(61, 166);
            this.AccountPassword.Name = "AccountPassword";
            this.AccountPassword.Size = new System.Drawing.Size(79, 21);
            this.AccountPassword.TabIndex = 3;
            this.AccountPassword.Text = "Password:";
            // 
            // AccountUsername
            // 
            this.AccountUsername.AutoSize = true;
            this.AccountUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountUsername.Location = new System.Drawing.Point(12, 115);
            this.AccountUsername.Name = "AccountUsername";
            this.AccountUsername.Size = new System.Drawing.Size(128, 21);
            this.AccountUsername.TabIndex = 4;
            this.AccountUsername.Text = "Username/Email:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(176, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 23);
            this.nameTextBox.TabIndex = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(176, 113);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(148, 23);
            this.userTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(176, 164);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 23);
            this.passwordTextBox.TabIndex = 7;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(349, 300);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.AccountUsername);
            this.Controls.Add(this.AccountPassword);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CreateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository - New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateBtn;
        private Label TitleLabel;
        private Label AccountName;
        private Label AccountPassword;
        private Label AccountUsername;
        private TextBox nameTextBox;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
    }
}