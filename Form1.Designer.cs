namespace AccountRepository
{
    partial class Form1
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
            this.AppName = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NewAccountLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppName.Location = new System.Drawing.Point(136, 81);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(220, 32);
            this.AppName.TabIndex = 6;
            this.AppName.Text = "Account Repository";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(152, 158);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(63, 15);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(155, 187);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password:";
            // 
            // NewAccountLabel
            // 
            this.NewAccountLabel.AutoSize = true;
            this.NewAccountLabel.Location = new System.Drawing.Point(196, 337);
            this.NewAccountLabel.Name = "NewAccountLabel";
            this.NewAccountLabel.Size = new System.Drawing.Size(89, 15);
            this.NewAccountLabel.TabIndex = 4;
            this.NewAccountLabel.TabStop = true;
            this.NewAccountLabel.Text = "Create Account";
            this.NewAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewAccountLabel_LinkClicked);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(228, 184);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(228, 155);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 23);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(152, 254);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(253, 254);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowText
            // 
            this.ShowText.AutoSize = true;
            this.ShowText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowText.Location = new System.Drawing.Point(334, 190);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(55, 17);
            this.ShowText.TabIndex = 5;
            this.ShowText.Text = "Show";
            this.ShowText.UseVisualStyleBackColor = true;
            this.ShowText.CheckedChanged += new System.EventHandler(this.ShowText_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ShowText);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NewAccountLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.AppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppName;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private LinkLabel NewAccountLabel;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Button LoginButton;
        private Button ClearButton;
        private CheckBox ShowText;
    }
}