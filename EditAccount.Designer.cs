namespace AccountRepository
{
    partial class EditAccount
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EditAccountListBox = new System.Windows.Forms.ListBox();
            this.AccountName = new System.Windows.Forms.RadioButton();
            this.AccountUsername = new System.Windows.Forms.RadioButton();
            this.AccountPassword = new System.Windows.Forms.RadioButton();
            this.CurrentAccount = new System.Windows.Forms.Label();
            this.CurrentUsername = new System.Windows.Forms.Label();
            this.CurrentPassword = new System.Windows.Forms.Label();
            this.NewAttribute = new System.Windows.Forms.TextBox();
            this.ChangeToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(153, 353);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(86, 31);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(117, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(179, 37);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Edit Account";
            // 
            // EditAccountListBox
            // 
            this.EditAccountListBox.FormattingEnabled = true;
            this.EditAccountListBox.ItemHeight = 20;
            this.EditAccountListBox.Location = new System.Drawing.Point(14, 56);
            this.EditAccountListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditAccountListBox.Name = "EditAccountListBox";
            this.EditAccountListBox.Size = new System.Drawing.Size(371, 44);
            this.EditAccountListBox.TabIndex = 2;
            this.EditAccountListBox.SelectedIndexChanged += new System.EventHandler(this.EditAccountListBox_SelectedIndexChanged);
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountName.Location = new System.Drawing.Point(14, 109);
            this.AccountName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(162, 32);
            this.AccountName.TabIndex = 3;
            this.AccountName.TabStop = true;
            this.AccountName.Text = "Account Name";
            this.AccountName.UseVisualStyleBackColor = true;
            // 
            // AccountUsername
            // 
            this.AccountUsername.AutoSize = true;
            this.AccountUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountUsername.Location = new System.Drawing.Point(14, 151);
            this.AccountUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountUsername.Name = "AccountUsername";
            this.AccountUsername.Size = new System.Drawing.Size(175, 32);
            this.AccountUsername.TabIndex = 4;
            this.AccountUsername.TabStop = true;
            this.AccountUsername.Text = "Username/Email";
            this.AccountUsername.UseVisualStyleBackColor = true;
            // 
            // AccountPassword
            // 
            this.AccountPassword.AutoSize = true;
            this.AccountPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountPassword.Location = new System.Drawing.Point(14, 192);
            this.AccountPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountPassword.Name = "AccountPassword";
            this.AccountPassword.Size = new System.Drawing.Size(114, 32);
            this.AccountPassword.TabIndex = 5;
            this.AccountPassword.TabStop = true;
            this.AccountPassword.Text = "Password";
            this.AccountPassword.UseVisualStyleBackColor = true;
            // 
            // CurrentAccount
            // 
            this.CurrentAccount.AutoSize = true;
            this.CurrentAccount.Location = new System.Drawing.Point(199, 119);
            this.CurrentAccount.Name = "CurrentAccount";
            this.CurrentAccount.Size = new System.Drawing.Size(60, 20);
            this.CurrentAccount.TabIndex = 6;
            this.CurrentAccount.Text = "Current:";
            // 
            // CurrentUsername
            // 
            this.CurrentUsername.AutoSize = true;
            this.CurrentUsername.Location = new System.Drawing.Point(199, 160);
            this.CurrentUsername.Name = "CurrentUsername";
            this.CurrentUsername.Size = new System.Drawing.Size(60, 20);
            this.CurrentUsername.TabIndex = 7;
            this.CurrentUsername.Text = "Current:";
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.AutoSize = true;
            this.CurrentPassword.Location = new System.Drawing.Point(199, 201);
            this.CurrentPassword.Name = "CurrentPassword";
            this.CurrentPassword.Size = new System.Drawing.Size(60, 20);
            this.CurrentPassword.TabIndex = 8;
            this.CurrentPassword.Text = "Current:";
            // 
            // NewAttribute
            // 
            this.NewAttribute.Location = new System.Drawing.Point(128, 292);
            this.NewAttribute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewAttribute.Name = "NewAttribute";
            this.NewAttribute.Size = new System.Drawing.Size(257, 27);
            this.NewAttribute.TabIndex = 9;
            // 
            // ChangeToLabel
            // 
            this.ChangeToLabel.AutoSize = true;
            this.ChangeToLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeToLabel.Location = new System.Drawing.Point(18, 291);
            this.ChangeToLabel.Name = "ChangeToLabel";
            this.ChangeToLabel.Size = new System.Drawing.Size(104, 25);
            this.ChangeToLabel.TabIndex = 10;
            this.ChangeToLabel.Text = "New value:";
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(399, 400);
            this.Controls.Add(this.ChangeToLabel);
            this.Controls.Add(this.NewAttribute);
            this.Controls.Add(this.CurrentPassword);
            this.Controls.Add(this.CurrentUsername);
            this.Controls.Add(this.CurrentAccount);
            this.Controls.Add(this.AccountPassword);
            this.Controls.Add(this.AccountUsername);
            this.Controls.Add(this.AccountName);
            this.Controls.Add(this.EditAccountListBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository - Edit Account";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditBtn;
        private Label TitleLabel;
        private ListBox EditAccountListBox;
        private RadioButton AccountName;
        private RadioButton AccountUsername;
        private RadioButton AccountPassword;
        private Label CurrentAccount;
        private Label CurrentUsername;
        private Label CurrentPassword;
        private TextBox NewAttribute;
        private Label ChangeToLabel;
    }
}