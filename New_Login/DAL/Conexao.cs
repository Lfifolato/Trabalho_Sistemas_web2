using MySql.Data.MySqlClient;

namespace New_Login
{
    public class Conexao
    {
        #region Parâmetros de Conexão
        private static string Server = "sistema-web.mysql.uhserver.com";
        private static string Database = "sistema_web";
        private static string User = "lfifolato";
        private static string Password = "{Dalri1010}";

        

        private static string connectionString = $@"Server={Server};Database={Database};
                                                    Uid={User};Pwd={Password};SslMode=none;
                                                    Charset=utf8;";
        #endregion

        public static MySqlConnection Connection = new MySqlConnection(connectionString);

        #region Conectar
        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        #endregion

        #region Desconectar
        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        #endregion
    }
}