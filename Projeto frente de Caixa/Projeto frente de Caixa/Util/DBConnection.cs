using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.Util {
    public class DBConnection {
        private const string SERVER = "localhost";
        private const string DATABASE = "frenteCaixa";
        private const string UID = "root";
        private const string PASSWORD = "";

        private static string message;
        private static int code;

        public static string Message { get => message; private set => message = value; }
        public static int Code { get => code; private set => code = value; }

        public static MySqlConnection Connection()
        {
            try
            {
                string connectionString = "SERVER=" + SERVER + ";" + "DATABASE=" + DATABASE + ";" + "UID=" + UID + ";" + "PASSWORD=" + PASSWORD + ";";
                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                Message = ex.Message;
                Code = (int)ex.Code;
                return null;
            }
        }

    }
}
