using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccountRepository
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }
        
        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataAdapter dataAdapter = new();
            SqlCommand sqlCommand = new("DELETE FROM Account_Info WHERE Account = @Account", connection);
            sqlCommand.Connection = connection;

            SqlParameter sqlParameter = new("@Account", AccountListBox.SelectedItem);
            sqlCommand.Parameters.Add(sqlParameter);

            connection.Open();
            dataAdapter.DeleteCommand = sqlCommand;

            int success = sqlCommand.ExecuteNonQuery();
            if (success == 0)
            {
                MessageBox.Show("Unable to delete record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show($"You have sucessfully deleted the account: {AccountListBox.SelectedItem}!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                Update();
            }
        }
        new void Update()
        {
            if (AccountListBox.Items.Count > 0)
            {
                AccountListBox.Items.Clear();
            }
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataReader dataReader;
            SqlCommand sqlCommand = new("SELECT * FROM Account_Info", connection);

            connection.Open();
            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                AccountListBox.Items.Add(dataReader["Account"]);
            }
            dataReader.Close();
            connection.Close();
        }
    }
}
