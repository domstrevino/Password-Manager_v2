using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccountRepository
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        private static bool userExists = false;

        private void ShowText_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowText.Checked)
            {
                NewPasswordTextBox.PasswordChar = '\0';
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                NewPasswordTextBox.PasswordChar = '*';
                ConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool newUser = true;
            while (newUser)
            {
                using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                try
                {
                    CheckUser(NewUsernameTextBox.Text);

                    if (NewUsernameTextBox.Text == "" || NewPasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "")
                    {
                        MessageBox.Show("Each enter a value for each field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();

                        newUser = false;
                    }
                    else if (userExists == true)
                    {
                        MessageBox.Show("This username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();

                        newUser = false;
                    }
                    else if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();

                        newUser = false;
                    }
                    else
                    {
                        SqlCommand sqlCommand = new("INSERT INTO Login_Info (Username, Password) VALUES (@NewUsername, @NewPassword)", connection);
                        SqlDataAdapter sqlAdapter = new();

                        SqlParameter[] sqlParameter = new SqlParameter[2];
                        sqlParameter[0] = new("@NewUsername", NewUsernameTextBox.Text);
                        sqlParameter[1] = new("@NewPassword", NewPasswordTextBox.Text);
                        sqlCommand.Parameters.Add(sqlParameter[0]);
                        sqlCommand.Parameters.Add(sqlParameter[1]);

                        connection.Open();
                        sqlCommand.Connection = connection;

                        sqlAdapter.InsertCommand = sqlCommand;

                        int success = sqlCommand.ExecuteNonQuery();
                        if (success == 0)
                        {
                            MessageBox.Show("Your records were unable to be added in our database. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Reset();

                            newUser = false;
                        }
                        else
                        {
                            MessageBox.Show("You have successfully created an account! Please return to the Login page to begin", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            connection.Close();
                            this.Close();
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error. Please try again.");
                    newUser = false;

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
        }
        void Reset()
        {
            NewUsernameTextBox.Clear();
            NewPasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();

            NewUsernameTextBox.Focus();
        }

        static bool CheckUser(string newUsernameTextBox)
        {
            string username = newUsernameTextBox;
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlCommand sqlCommand = new("SELECT * FROM Login_Info WHERE Username = @Username", connection);
            SqlDataReader dataReader;

            SqlParameter sqlParameter = new();
            sqlParameter = new("@Username", username);
            sqlCommand.Parameters.Add(sqlParameter);

            connection.Open();
            sqlCommand.Connection = connection;

            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                return userExists = true;
            }
            else
            {
                return userExists = false;
            }
        }
    }
}
