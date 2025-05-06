using binary_database.Model;
using MySql.Data.MySqlClient;
using static binary_database.service.ConnectionFactory;

namespace binary_database.src.dao
{
    public class UserDAO
    {
        public static void Create(User user)
        {
            using (var connection = GetConnection())
            {
                string sql = "INSERT INTO usuarios (nome, digital_code) " +
                    "VALUES (@nome, @digital_code)";

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", user.Name);
                command.Parameters.AddWithValue("@digital_code", user.DigitalCode);

                command.ExecuteNonQuery();
            }
        }
    }
}