using System.Data.SqlClient;
using System.Configuration;

namespace AccountRepository
{
    public partial class ViewAccount : Form
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataReader dataReader;
            SqlCommand sqlCommand = new("SELECT * FROM Account_Info", connection);
            connection.Open();

            sqlCommand.Connection = connection;
            dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader.IsDBNull(0))
                {
                    ViewListBox.Text = string.Empty;
                }
                else
                {
                    ViewListBox.Items.Add(dataReader["Account"]);
                    ViewListBox.SelectedIndex = 0;
                }
            }
            connection.Close();
        }

        private void ViewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection connection = new(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            SqlDataReader dataReader;
            SqlCommand sqlCommand = new("SELECT Account, Username, Password FROM Account_Info WHERE Account = @Account", connection);
            SqlParameter sqlParameter = new("@Account", ViewListBox.SelectedItem);
            sqlCommand.Parameters.Add(sqlParameter);
            connection.Open();

            sqlCommand.Connection = connection;
            dataReader = sqlCommand.ExecuteReader();
            
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    nameAccount.Text = (string)dataReader["Account"];
                    nameUsername.Text = (string)dataReader["Username"];
                    namePassword.Text = (string)dataReader["Password"];
                }
            }
            dataReader.Close();
            connection.Close();
        }
    }
}
