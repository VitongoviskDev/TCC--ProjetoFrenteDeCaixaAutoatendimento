using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Projeto_frente_de_Caixa.Dao
{
    public class ActivityDao
    {
        private const string TABLE = "fc_Activity";
        private const string CL_ID = "id";
        private const string CL_ITEM = "item";
        private const string CL_DATE = "date";
        private const string CL_HOUR = "hour";
        private const string CL_USER = "userId";
        private const string CL_TYPE = "type";

        public int code = -1;
        public string message = string.Empty;

        public ActivityModel GetActivityById(ActivityModel activity)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where id = {activity.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                activity = null;
                while (dataReader.Read())
                {
                    activity = new ActivityModel();
                    activity.Id = int.Parse(dataReader[CL_ID].ToString());
                    activity.Item = dataReader[CL_ITEM].ToString();
                    activity.Date = DateTime.Parse(dataReader[CL_DATE].ToString());
                    activity.Hour = DateTime.Parse(dataReader[CL_HOUR].ToString());
                    int userId = int.Parse(dataReader[CL_USER].ToString());
                    UserControll userControl = new UserControll();
                    activity.User = userControl.GetUserById(new UserModel() { Id = userId});
                    activity.Type = (ActivityType)Enum.Parse(typeof(ActivityType), dataReader[CL_TYPE].ToString());

                }
                connection.Close();

                return activity;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public ActivityModel GetActivitySystemById(ActivityModel activity)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where id = {activity.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                activity = null;
                while (dataReader.Read())
                {
                    activity = new ActivityModel();
                    activity.Id = int.Parse(dataReader[CL_ID].ToString());
                    activity.Item = dataReader[CL_ITEM].ToString();
                    activity.Date = DateTime.Parse(dataReader[CL_DATE].ToString());
                    activity.Hour = DateTime.Parse(dataReader[CL_HOUR].ToString());
                    activity.Type = (ActivityType)Enum.Parse(typeof(ActivityType), dataReader[CL_TYPE].ToString());

                }
                connection.Close();

                return activity;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public int AddActivity(ActivityModel activity)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string date = activity.Date.ToString("yyyy-MM-dd");
                string hour = activity.Hour.ToString("HH:mm:ss");
                string query = $"INSERT INTO {TABLE} ({CL_ITEM},{CL_DATE}, {CL_HOUR}, {CL_USER},{CL_TYPE}) VALUES ('{activity.Item}','{date}','{hour}',{activity.User.Id}, '{activity.Type}'); SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int id = -1;
                while (dataReader.Read())
                {
                    id = int.Parse(dataReader["LAST_INSERT_ID()"].ToString());
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
        public int CreateSystemActivity(ActivityModel activity)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string date = activity.Date.ToString("yyyy-MM-dd");
                string hour = activity.Hour.ToString("HH:mm:ss");
                string query = $"INSERT INTO {TABLE} ({CL_ITEM},{CL_DATE}, {CL_HOUR},{CL_TYPE}) VALUES ('{activity.Item}','{date}','{hour}', '{activity.Type}'); SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int id = -1;
                while (dataReader.Read())
                {
                    id = int.Parse(dataReader["LAST_INSERT_ID()"].ToString());
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

        public void UpdateSystemActivity(ActivityModel activity)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string date = activity.Date.ToString("yyyy-MM-dd");
                string hour = activity.Hour.ToString("HH:mm:ss");
                string query = $"UPDATE {TABLE} SET {CL_ITEM} = '{activity.Item}',{CL_DATE} = '{date}', {CL_HOUR} = '{hour}',{CL_TYPE} = '{activity.Type}' WHERE {CL_ID} = {activity.Id}";

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
    }
}
