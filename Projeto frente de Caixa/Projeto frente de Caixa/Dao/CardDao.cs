using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Dao
{
    public class CardDao
    {
        private const string TABLE = "fc_Cards";
        private const string CL_ID = "id";
        private const string CL_OWNER = "owner";
        private const string CL_NUMBER = "number";
        private const string CL_CVV = "cvv";
        private const string CL_AMOUNT = "amount";
        private const string CL_DATE = "expirationDate";
        private const string CL_TYPE = "type";

        public int code = -1;
        public string message = string.Empty;

        public CardModel GetDebitCard()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_TYPE} = 'd'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                CardModel card = null;
                while (dataReader.Read())
                {
                    card = new CardModel();

                    card.Id = int.Parse(dataReader[CL_ID].ToString());
                    card.Owner = dataReader[CL_OWNER].ToString();
                    card.Number = dataReader[CL_NUMBER].ToString();
                    card.Cvv = int.Parse(dataReader[CL_CVV].ToString());
                    card.Amount = decimal.Parse(dataReader[CL_AMOUNT].ToString());
                    card.ExpirationDate = DateTime.Parse(dataReader[CL_DATE].ToString());
                    card.Type = char.Parse(dataReader[CL_TYPE].ToString());

                }
                connection.Close();

                return card;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public CardModel GetCreditCard()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_TYPE} = 'c'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                CardModel card = null;
                while (dataReader.Read())
                {
                    card = new CardModel();

                    card.Id = int.Parse(dataReader[CL_ID].ToString());
                    card.Owner = dataReader[CL_OWNER].ToString();
                    card.Number = dataReader[CL_NUMBER].ToString();
                    card.Cvv = int.Parse(dataReader[CL_CVV].ToString());
                    card.Amount = decimal.Parse(dataReader[CL_AMOUNT].ToString());
                    card.ExpirationDate = DateTime.Parse(dataReader[CL_DATE].ToString());
                    card.Type = char.Parse(dataReader[CL_TYPE].ToString());

                }
                connection.Close();

                return card;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public void UpdateAmount(CardModel card)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_AMOUNT}= {card.Amount.ToString().Replace(',', '.')} WHERE {CL_ID} = {card.Id}";

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
