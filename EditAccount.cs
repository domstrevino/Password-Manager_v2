using System.Data.SqlClient;
using System.Configuration;

namespace AccountRepository
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void EditAccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataReader dataReader;
            SqlCommand sqlCommand = new("SELECT Account, Username, Password FROM Account_Info WHERE Account = @Account", connection);
            SqlParameter sqlParameter = new("@Account", EditAccountListBox.SelectedItem);
            sqlCommand.Parameters.Add(sqlParameter);

            connection.Open();

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                CurrentAccount.Text = "Current: " + (string)dataReader["Account"];
                CurrentUsername.Text = "Current: " + (string)dataReader["Username"];
                CurrentPassword.Text = "Current: " + (string)dataReader["Password"];
            }
            dataReader.Close();
            connection.Close();
            int position = EditAccountListBox.SelectedIndex;
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            int position = EditAccountListBox.SelectedIndex;

            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            string newAttribute = NewAttribute.Text;
            SqlDataAdapter dataAdapter = new();
            SqlCommand sqlCommand;
            SqlParameter sqlParameter = new();

            connection.Open();
            if (AccountName.Checked)
            {
                sqlCommand = new($"UPDATE Account_Info SET Account = @NewAttribute WHERE Account = '{EditAccountListBox.SelectedItem}'", connection);
                sqlParameter = new("@NewAttribute", newAttribute);
                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();
                CurrentAccount.Text = $"Current: {newAttribute}";
                Update();

                EditAccountListBox.SelectedIndex = position;
            }
            else if (AccountUsername.Checked)
            {
                sqlCommand = new($"UPDATE Account_Info SET Username = @NewAttribute WHERE Account = '{EditAccountListBox.SelectedItem}'", connection);
                sqlParameter = new("@NewAttribute", newAttribute);
                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();
                CurrentUsername.Text = $"Current: {newAttribute}";
                Update();

                EditAccountListBox.SelectedIndex = position;
            }
            else if (AccountPassword.Checked)
            {
                sqlCommand = new($"UPDATE Account_Info SET Password = @NewAttribute WHERE Account = '{EditAccountListBox.SelectedItem}'", connection);
                sqlParameter = new("@NewAttribute", newAttribute);
                sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();
                CurrentPassword.Text = $"Current: {newAttribute}";
                Update();

                EditAccountListBox.SelectedIndex = position;
            }
            else
            {
                MessageBox.Show("Please select the account name and the corresponding radio button to which attribute you would like to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        new void Update()
        {
            if (EditAccountListBox.Items.Count > 0)
            {
                EditAccountListBox.Items.Clear();
            }
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataReader dataReader;
            SqlCommand sqlCommand = new("SELECT * FROM Account_Info", connection);

            connection.Open();
            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                EditAccountListBox.Items.Add(dataReader["Account"]);
            }
            dataReader.Close();
            connection.Close();
        }
    }
}
