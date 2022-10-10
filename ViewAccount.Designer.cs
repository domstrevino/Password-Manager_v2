namespace AccountRepository
{
    partial class ViewAccount
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountName = new System.Windows.Forms.Label();
            this.AccountUsername = new System.Windows.Forms.Label();
            this.AccountPassword = new System.Windows.Forms.Label();
            this.nameAccount = new System.Windows.Forms.Label();
            this.nameUsername = new System.Windows.Forms.Label();
            this.namePassword = new System.Windows.Forms.Label();
            this.ViewListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(95, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(149, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "View Account";
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountName.Location = new System.Drawing.Point(34, 99);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(115, 21);
            this.AccountName.TabIndex = 2;
            this.AccountName.Text = "Account Name:";
            // 
            // AccountUsername
            // 
            this.AccountUsername.AutoSize = true;
            this.AccountUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountUsername.Location = new System.Drawing.Point(21, 145);
            this.AccountUsername.Name = "AccountUsername";
            this.AccountUsername.Size = new System.Drawing.Size(128, 21);
            this.AccountUsername.TabIndex = 3;
            this.AccountUsername.Text = "Username/Email:";
            // 
            // AccountPassword
            // 
            this.AccountPassword.AutoSize = true;
            this.AccountPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountPassword.Location = new System.Drawing.Point(70, 191);
            this.AccountPassword.Name = "AccountPassword";
            this.AccountPassword.Size = new System.Drawing.Size(79, 21);
            this.AccountPassword.TabIndex = 4;
            this.AccountPassword.Text = "Password:";
            // 
            // nameAccount
            // 
            this.nameAccount.AutoSize = true;
            this.nameAccount.Location = new System.Drawing.Point(184, 105);
            this.nameAccount.Name = "nameAccount";
            this.nameAccount.Size = new System.Drawing.Size(0, 15);
            this.nameAccount.TabIndex = 5;
            // 
            // nameUsername
            // 
            this.nameUsername.AutoSize = true;
            this.nameUsername.Location = new System.Drawing.Point(184, 150);
            this.nameUsername.Name = "nameUsername";
            this.nameUsername.Size = new System.Drawing.Size(0, 15);
            this.nameUsername.TabIndex = 6;
            // 
            // namePassword
            // 
            this.namePassword.AutoSize = true;
            this.namePassword.Location = new System.Drawing.Point(184, 196);
            this.namePassword.Name = "namePassword";
            this.namePassword.Size = new System.Drawing.Size(0, 15);
            this.namePassword.TabIndex = 7;
            // 
            // ViewListBox
            // 
            this.ViewListBox.BackColor = System.Drawing.Color.White;
            this.ViewListBox.FormattingEnabled = true;
            this.ViewListBox.ItemHeight = 15;
            this.ViewListBox.Location = new System.Drawing.Point(12, 54);
            this.ViewListBox.Name = "ViewListBox";
            this.ViewListBox.Size = new System.Drawing.Size(325, 34);
            this.ViewListBox.TabIndex = 8;
            this.ViewListBox.SelectedIndexChanged += new System.EventHandler(this.ViewListBox_SelectedIndexChanged);
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(349, 300);
            this.Controls.Add(this.ViewListBox);
            this.Controls.Add(this.namePassword);
            this.Controls.Add(this.nameUsername);
            this.Controls.Add(this.nameAccount);
            this.Controls.Add(this.AccountPassword);
            this.Controls.Add(this.AccountUsername);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository - View Account";
            this.Load += new System.EventHandler(this.ViewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TitleLabel;
        private Label AccountName;
        private Label AccountUsername;
        private Label AccountPassword;
        private Label nameAccount;
        private Label nameUsername;
        private Label namePassword;
        private ListBox ViewListBox;
    }
}