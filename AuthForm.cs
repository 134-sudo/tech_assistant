using Npgsql;

namespace tech_assistant
{
    public partial class AuthForm : Form
    {
        NpgsqlConnection connection;
        NpgsqlCommand command;
        public static bool authSuccessful = false;

        public AuthForm()
        {
            InitializeComponent();

            try
            {
                connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=tech_assistant;Username=postgres;Password=1111;");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
                this.Close();
            }
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            string username = loginInput.Text;
            string password = passInput.Text;

            
                if (UserExists(username, password))
                {
                    connection.Close();
                    MessageBox.Show("Добро пожаловать, " + username + "!");
                    authSuccessful = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Допущена ошибка в данных пользователя.");
                }
            
        }

        private bool UserExists(string username, string password)
        {
            try
            {
                command = new NpgsqlCommand("select count(*) from сотрудники where логин = @Username AND пароль = @Password", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки пользователя: {ex.Message}");
                return false;
            }
            finally
            {
                command?.Dispose();
                command?.Cancel();
            }
        }
    }
}