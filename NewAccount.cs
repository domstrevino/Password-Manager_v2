using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AccountRepository
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            try
            {
                SqlDataAdapter dataAdapter = new();
                SqlCommand sqlCommand = new("INSERT INTO Account_Info (Account, Username, Password) VALUES (@Account, @Username, @Password)", connection);
                sqlCommand.Connection = connection;

                SqlParameter[] sqlParameters = new SqlParameter[3];
                sqlParameters[0] = new SqlParameter("@Account", nameTextBox.Text);
                sqlParameters[1] = new SqlParameter("@Username", userTextBox.Text);
                sqlParameters[2] = new SqlParameter("@Password", passwordTextBox.Text);
                sqlCommand.Parameters.Add(sqlParameters[0]);
                sqlCommand.Parameters.Add(sqlParameters[1]);
                sqlCommand.Parameters.Add(sqlParameters[2]);

                connection.Open();
                dataAdapter.InsertCommand = sqlCommand;
                
                int success = sqlCommand.ExecuteNonQuery();
                if (success == 0)
                {
                    MessageBox.Show($"There seems to have been an error. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"You have sucessfully created the account: {nameTextBox.Text}!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error. Please try again.");
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
}
