using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccountRepository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter your login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }

            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            try
            {
                SqlCommand sqlCommand = new("SELECT * FROM Login_Info WHERE Username = @Username AND Password = @Password", connection);
                SqlDataReader dataReader;

                SqlParameter[] sqlParameter = new SqlParameter[2];
                sqlParameter[0] = new("@Username", UsernameTextBox.Text);
                sqlParameter[1] = new("@Password", PasswordTextBox.Text);
                sqlCommand.Parameters.Add(sqlParameter[0]);
                sqlCommand.Parameters.Add(sqlParameter[1]);

                connection.Open();
                sqlCommand.Connection = connection;

                dataReader = sqlCommand.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    this.Hide();
                    Form2 form2 = new();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Error. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ShowText_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowText.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void NewAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount newAccount = new();
            newAccount.Show();
        }

        void Reset()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            UsernameTextBox.Focus();
        }
    }
}