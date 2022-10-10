namespace AccountRepository
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (ViewAccountButton.Checked)
            {
                ViewAccount viewAccount = new();
                viewAccount.Show();
            }
            else if (NewAccountButton.Checked)
            {
                NewAccount newAccount = new();
                newAccount.Show();
            }
            else if (EditAccountButton.Checked) 
            {
                EditAccount editAccount = new();
                editAccount.Show();
            }
            else if (DeleteAccountButton.Checked)
            {
                DeleteAccount deleteAccount = new();
                deleteAccount.Show();
            }
        }
    }
}