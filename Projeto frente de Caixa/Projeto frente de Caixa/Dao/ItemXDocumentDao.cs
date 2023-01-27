using MySql.Data.MySqlClient;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Dao
{
    public class ItemXDocumentDao
    {
        private const string TABLE = "fc_itemsXdocuments";
        private const string CL_ITEM_ID = "itemId";
        private const string CL_DOCUMENT_ID = "documentId";
        private const string CL_DOCUMENT_TYPE = "documentType";
        private const string CL_AMOUNT = "amount";
        private const string CL_TOTAL_VALUE = "totalValue";

        public int code = -1;
        public string message = string.Empty;
        public List<int> GetItemsIDsByDocumentId(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ITEM_ID} from {TABLE} Where {CL_DOCUMENT_ID} = {document.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<int> ids = new List<int>();
                while (dataReader.Read())
                {
                    ids.Add(dataReader.GetInt32(CL_ITEM_ID));
                }
                connection.Close();

                return ids;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public void AddItem(ItemModel item, DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_ITEM_ID}, {CL_DOCUMENT_ID}, {CL_DOCUMENT_TYPE}, {CL_AMOUNT}, {CL_TOTAL_VALUE}) VALUES ({item.Id}, {document.Id}, '{document.Type}', {item.Amount}, '{item.TotalValue.ToString().Replace(',','.')}')";

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
        public List<int> GetItemsIDsByDocumentType(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ITEM_ID} from {TABLE} Where {CL_DOCUMENT_TYPE} = {document.Type}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<int> ids = new List<int>();
                while (dataReader.Read())
                {
                    ids.Add(dataReader.GetInt32(CL_ITEM_ID));
                }
                connection.Close();

                return ids;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }

        public int GetItemAmountByIdAndDocumentId(ItemModel item, DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_AMOUNT} from {TABLE} Where {CL_DOCUMENT_ID} = {document.Id} AND {CL_ITEM_ID} = {item.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int amount = -1;
                while (dataReader.Read())
                {
                    amount = dataReader.GetInt32(CL_AMOUNT);
                }
                connection.Close();

                return amount;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
        }
        public decimal GetItemTotalValueByIdAndDocumentId(ItemModel item, DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_TOTAL_VALUE} from {TABLE} Where {CL_DOCUMENT_ID} = {document.Id} AND {CL_ITEM_ID} = {item.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                decimal totalValue = -1;
                while (dataReader.Read())
                {
                    totalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                }
                connection.Close();

                return totalValue;
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
