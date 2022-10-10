namespace AccountRepository
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.IntroductionLabel = new System.Windows.Forms.Label();
            this.AvailableFeaturesLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.NewAccountButton = new System.Windows.Forms.RadioButton();
            this.EditAccountButton = new System.Windows.Forms.RadioButton();
            this.ViewAccountButton = new System.Windows.Forms.RadioButton();
            this.DeleteAccountButton = new System.Windows.Forms.RadioButton();
            this.FutureFeaturesLabel = new System.Windows.Forms.Label();
            this.GeneratePasswordLabel = new System.Windows.Forms.Label();
            this.GroupAccountsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroductionLabel
            // 
            this.IntroductionLabel.AutoSize = true;
            this.IntroductionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IntroductionLabel.Location = new System.Drawing.Point(12, 9);
            this.IntroductionLabel.Name = "IntroductionLabel";
            this.IntroductionLabel.Size = new System.Drawing.Size(361, 102);
            this.IntroductionLabel.TabIndex = 0;
            this.IntroductionLabel.Text = resources.GetString("IntroductionLabel.Text");
            // 
            // AvailableFeaturesLabel
            // 
            this.AvailableFeaturesLabel.AutoSize = true;
            this.AvailableFeaturesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.AvailableFeaturesLabel.Location = new System.Drawing.Point(12, 155);
            this.AvailableFeaturesLabel.Name = "AvailableFeaturesLabel";
            this.AvailableFeaturesLabel.Size = new System.Drawing.Size(165, 25);
            this.AvailableFeaturesLabel.TabIndex = 1;
            this.AvailableFeaturesLabel.Text = "Available Features";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(189, 310);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.AutoSize = true;
            this.NewAccountButton.Location = new System.Drawing.Point(12, 221);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(97, 19);
            this.NewAccountButton.TabIndex = 4;
            this.NewAccountButton.TabStop = true;
            this.NewAccountButton.Text = "New Account";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.AutoSize = true;
            this.EditAccountButton.Location = new System.Drawing.Point(12, 246);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(93, 19);
            this.EditAccountButton.TabIndex = 5;
            this.EditAccountButton.TabStop = true;
            this.EditAccountButton.Text = "Edit Account";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            // 
            // ViewAccountButton
            // 
            this.ViewAccountButton.AutoSize = true;
            this.ViewAccountButton.Location = new System.Drawing.Point(12, 196);
            this.ViewAccountButton.Name = "ViewAccountButton";
            this.ViewAccountButton.Size = new System.Drawing.Size(98, 19);
            this.ViewAccountButton.TabIndex = 6;
            this.ViewAccountButton.TabStop = true;
            this.ViewAccountButton.Text = "View Account";
            this.ViewAccountButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.AutoSize = true;
            this.DeleteAccountButton.Location = new System.Drawing.Point(12, 271);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(106, 19);
            this.DeleteAccountButton.TabIndex = 7;
            this.DeleteAccountButton.TabStop = true;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            // 
            // FutureFeaturesLabel
            // 
            this.FutureFeaturesLabel.AutoSize = true;
            this.FutureFeaturesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FutureFeaturesLabel.Location = new System.Drawing.Point(330, 155);
            this.FutureFeaturesLabel.Name = "FutureFeaturesLabel";
            this.FutureFeaturesLabel.Size = new System.Drawing.Size(142, 25);
            this.FutureFeaturesLabel.TabIndex = 8;
            this.FutureFeaturesLabel.Text = "Future Features";
            // 
            // GeneratePasswordLabel
            // 
            this.GeneratePasswordLabel.AutoSize = true;
            this.GeneratePasswordLabel.Location = new System.Drawing.Point(330, 198);
            this.GeneratePasswordLabel.Name = "GeneratePasswordLabel";
            this.GeneratePasswordLabel.Size = new System.Drawing.Size(112, 15);
            this.GeneratePasswordLabel.TabIndex = 9;
            this.GeneratePasswordLabel.Text = "-Generate Password";
            // 
            // GroupAccountsLabel
            // 
            this.GroupAccountsLabel.AutoSize = true;
            this.GroupAccountsLabel.Location = new System.Drawing.Point(330, 223);
            this.GroupAccountsLabel.Name = "GroupAccountsLabel";
            this.GroupAccountsLabel.Size = new System.Drawing.Size(98, 15);
            this.GroupAccountsLabel.TabIndex = 10;
            this.GroupAccountsLabel.Text = "-Group Accounts";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.GroupAccountsLabel);
            this.Controls.Add(this.GeneratePasswordLabel);
            this.Controls.Add(this.FutureFeaturesLabel);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.ViewAccountButton);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.AvailableFeaturesLabel);
            this.Controls.Add(this.IntroductionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IntroductionLabel;
        private Label AvailableFeaturesLabel;
        private Button GoButton;
        private RadioButton NewAccountButton;
        private RadioButton EditAccountButton;
        private RadioButton ViewAccountButton;
        private RadioButton DeleteAccountButton;
        private Label FutureFeaturesLabel;
        private Label GeneratePasswordLabel;
        private Label GroupAccountsLabel;
    }
}