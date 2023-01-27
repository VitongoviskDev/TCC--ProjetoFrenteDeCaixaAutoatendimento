using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_frente_de_Caixa.Util;
using System.Runtime.InteropServices;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Projeto_frente_de_Caixa.Dao
{
    public class ConfigDao
    {

        private const string TABLE = "fc_config";
        private const string CL_EMAIL = "email";
        private const string CL_PASSWORD = "password";
        private const string CL_PASSWORD_CHANGED = "passwordChanged";
        private const string CL_ITEM_SOLD_OUT = "itemSoldOut";

        public int code;
        public string message;

        public void AddConfiguration(ConfigModel config)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_EMAIL} ,{CL_PASSWORD}, {CL_PASSWORD_CHANGED}, {CL_ITEM_SOLD_OUT}) VALUES ('{config.Email}', '{config.Password}',  {config.SendPassworChangedEmail}, {config.SendItemSoldOutEmail})";

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
        public void UpdateConfiguration(ConfigModel config)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_EMAIL}= '{config.Email}',{CL_PASSWORD} = '{config.Password}', {CL_PASSWORD_CHANGED}= {config.SendPassworChangedEmail}, {CL_ITEM_SOLD_OUT}= {config.SendItemSoldOutEmail}";

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
        public ConfigModel GetConfig()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                ConfigModel config = null;
                while (dataReader.Read())
                {
                    config = new ConfigModel();

                    config.Email = dataReader[CL_EMAIL].ToString();
                    config.Password = dataReader[CL_PASSWORD].ToString();
                    config.SendPassworChangedEmail = bool.Parse(dataReader[CL_PASSWORD_CHANGED].ToString());
                    config.SendItemSoldOutEmail = bool.Parse(dataReader[CL_ITEM_SOLD_OUT].ToString());

                }
                connection.Close();

                return config;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
    }
}
