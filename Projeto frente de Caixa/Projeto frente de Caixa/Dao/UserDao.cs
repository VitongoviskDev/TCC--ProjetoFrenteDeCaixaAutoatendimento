using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_frente_de_Caixa.Dao
{
    public class UserDao
    {
        private const string TABLE = "fc_users";
        private const string CL_ID = "id";
        private const string CL_CODE = "code";
        private const string CL_NAME = "username";
        private const string CL_EMAIL = "email";
        private const string CL_LOGIN = "login";
        private const string CL_PASSWORD_HASH = "passwordHash";
        private const string CL_PASSWORD_HASH_ADDER = "passwordHashAdder";
        private const string CL_PROFILE = "profile";
        private const string CL_STATUS = "status";
        private const string CL_IS_FIRST_ACCESS = "isFirstAccess";
        private const string CL_ADDED = "activityAddedId";
        private const string CL_UPDATED = "activityLastUpdatedId";

        public int code = -1;
        public string message = string.Empty;

        public UserModel GetUserByLogin(UserModel user)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_LOGIN} = '{user.Login}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                user = null;
                while (dataReader.Read())
                {
                    user = new UserModel();

                    user.Id = int.Parse(dataReader[CL_ID].ToString());
                    user.Code = int.Parse(dataReader[CL_CODE].ToString());
                    user.Name = dataReader[CL_NAME].ToString();
                    user.Email = dataReader[CL_EMAIL].ToString();
                    user.Login = dataReader[CL_LOGIN].ToString().ToLower();
                    user.PasswordHash = dataReader[CL_PASSWORD_HASH].ToString();
                    user.PasswordHashAdder = dataReader[CL_PASSWORD_HASH_ADDER].ToString();
                    user.Profile = int.Parse(dataReader[CL_PROFILE].ToString());
                    user.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                    user.IsFirstAccess = bool.Parse(dataReader[CL_IS_FIRST_ACCESS].ToString());
                    user.AddedId = int.Parse(dataReader[CL_ADDED].ToString());
                    user.UpdatedId = int.Parse(dataReader[CL_UPDATED].ToString());

                }
                connection.Close();

                return user;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public List<UserModel> GetAllUsers()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<UserModel> users = new List<UserModel>();
                while (dataReader.Read())
                {
                    UserModel user = new UserModel();

                    user.Id = int.Parse(dataReader[CL_ID].ToString());
                    user.Code = int.Parse(dataReader[CL_CODE].ToString());
                    user.Name = dataReader[CL_NAME].ToString();
                    user.Email = dataReader[CL_EMAIL].ToString();
                    user.Login = dataReader[CL_LOGIN].ToString().ToLower();
                    user.PasswordHash = dataReader[CL_PASSWORD_HASH].ToString();
                    user.PasswordHashAdder = dataReader[CL_PASSWORD_HASH_ADDER].ToString();
                    user.Profile = int.Parse(dataReader[CL_PROFILE].ToString());
                    user.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                    user.IsFirstAccess = bool.Parse(dataReader[CL_IS_FIRST_ACCESS].ToString());
                    user.AddedId = int.Parse(dataReader[CL_ADDED].ToString());
                    user.UpdatedId = int.Parse(dataReader[CL_UPDATED].ToString());

                    users.Add(user);
                }
                connection.Close();

                return users;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public UserModel GetUserById(UserModel user)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_ID} = {user.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                user = null;
                while (dataReader.Read())
                {
                    user = new UserModel();

                    user.Id = int.Parse(dataReader[CL_ID].ToString());
                    user.Code = int.Parse(dataReader[CL_CODE].ToString());
                    user.Name = dataReader[CL_NAME].ToString();
                    user.Email = dataReader[CL_EMAIL].ToString();
                    user.Login = dataReader[CL_LOGIN].ToString().ToLower();
                    user.PasswordHash = dataReader[CL_PASSWORD_HASH].ToString();
                    user.PasswordHashAdder = dataReader[CL_PASSWORD_HASH_ADDER].ToString();
                    user.Profile = int.Parse(dataReader[CL_PROFILE].ToString());
                    user.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                    user.IsFirstAccess = bool.Parse(dataReader[CL_IS_FIRST_ACCESS].ToString());
                    user.AddedId = int.Parse(dataReader[CL_ADDED].ToString());
                    user.UpdatedId = int.Parse(dataReader[CL_UPDATED].ToString());
                }
                connection.Close();

                return user;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public UserModel GetUserByCode(UserModel user)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_CODE} = {user.Code}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                user = null;
                while (dataReader.Read())
                {
                    user = new UserModel();

                    user.Id = int.Parse(dataReader[CL_ID].ToString());
                    user.Code = int.Parse(dataReader[CL_CODE].ToString());
                    user.Name = dataReader[CL_NAME].ToString();
                    user.Email = dataReader[CL_EMAIL].ToString();
                    user.Login = dataReader[CL_LOGIN].ToString().ToLower();
                    user.PasswordHash = dataReader[CL_PASSWORD_HASH].ToString();
                    user.PasswordHashAdder = dataReader[CL_PASSWORD_HASH_ADDER].ToString();
                    user.Profile = int.Parse(dataReader[CL_PROFILE].ToString());
                    user.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                    user.IsFirstAccess = bool.Parse(dataReader[CL_IS_FIRST_ACCESS].ToString());
                    user.AddedId = int.Parse(dataReader[CL_ADDED].ToString());
                    user.UpdatedId = int.Parse(dataReader[CL_UPDATED].ToString());
                }
                connection.Close();

                return user;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public int GetUserIdByEmail(UserModel user)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ID} from {TABLE} Where {CL_EMAIL} = '{user.Email}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int id = -1;
                while (dataReader.Read())
                {
                    id = int.Parse(dataReader[CL_ID].ToString());
                }
                connection.Close();

                return id;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
        }
        public void UpdateUser(UserModel user) {
            try {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_CODE} = {user.Code}, {CL_NAME}= '{user.Name}',{CL_EMAIL}= '{user.Email}', {CL_LOGIN}= '{user.Login}',{CL_PASSWORD_HASH} = '{user.PasswordHash}',{CL_PASSWORD_HASH_ADDER}= '{user.PasswordHashAdder}', {CL_PROFILE}= {user.Profile},{CL_STATUS}= {user.Status},{CL_IS_FIRST_ACCESS}= {user.IsFirstAccess}, {CL_ADDED} = {user.AddedId}, {CL_UPDATED} = {user.UpdatedId} WHERE {CL_ID} = {user.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                connection.Close();

            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
            }
        }
        public void AddUser(UserModel user) {
            try {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE}  ({CL_CODE}, {CL_NAME}, {CL_EMAIL}, {CL_LOGIN}, {CL_PASSWORD_HASH},{CL_PASSWORD_HASH_ADDER} , {CL_PROFILE} ,{CL_STATUS} ,{CL_IS_FIRST_ACCESS}, {CL_ADDED}, {CL_UPDATED}) VALUES ({user.Code}, '{user.Name}', '{user.Email}', '{user.Login}', '{user.PasswordHash}', '{user.PasswordHashAdder}', {user.Profile}, {user.Status}, {user.IsFirstAccess}, {user.AddedId}, {user.UpdatedId})";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                connection.Close();

            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
            }
        }
        public int GetLastCode()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string greatest = "greatest";
                string query = $"Select MAX({CL_CODE}) as {greatest} from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int code = -1;
                while (dataReader.Read())
                {
                    code = int.Parse(dataReader[greatest].ToString());
                }

                return code;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
        }
    }
}
