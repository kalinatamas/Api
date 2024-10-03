using MySql.Data.MySqlClient;

namespace ProductApi
{
    public class Connect
    {
        public MySqlConnection Connection { get; set; }
        public string ConnectionString { get; set; }
        public string Host;
        public string Database;
        public string User;
        public string Password;

        public Connect() { 
            Host= "localhost";
            Database= "shop";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            Connection = new MySqlConnection(ConnectionString);

        }

    }
}
