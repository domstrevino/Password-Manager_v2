namespace AccountRepository
{
    partial class DeleteAccount
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(135, 265);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(88, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(163, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Delete Account";
            // 
            // AccountListBox
            // 
            this.AccountListBox.FormattingEnabled = true;
            this.AccountListBox.ItemHeight = 15;
            this.AccountListBox.Location = new System.Drawing.Point(12, 58);
            this.AccountListBox.Name = "AccountListBox";
            this.AccountListBox.Size = new System.Drawing.Size(325, 184);
            this.AccountListBox.TabIndex = 2;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(349, 300);
            this.Controls.Add(this.AccountListBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DeleteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository - Delete Account";
            this.Load += new System.EventHandler(this.DeleteAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteBtn;
        private Label TitleLabel;
        private ListBox AccountListBox;
    }
}