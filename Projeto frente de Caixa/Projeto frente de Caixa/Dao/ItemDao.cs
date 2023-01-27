using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.Dao
{
    public class ItemDao : DBConnection
    {

        private const string TABLE = "fc_items";
        private const string CL_ID = "itemId";
        private const string CL_CODE = "barcode";
        private const string CL_DESCRIPTION = "description";
        private const string CL_AMOUNT = "amount";
        private const string CL_UNITY = "unity";
        private const string CL_UNITARY_VALUE = "unitaryValue";
        private const string CL_ST = "st";
        private const string CL_ITEM_VALUE = "itemValue";
        private const string CL_DOCUMENT_TYPE = "documentType";

        public int code = -1;
        public string message = string.Empty;

        public ItemModel GetItemByProductBarCode(ItemModel item)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_CODE} = '{item.Product.BarCode}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                item = null;
                while (dataReader.Read())
                {
                    item = new ItemModel();

                    item.Id = int.Parse(dataReader[CL_ID].ToString());
                    item.Amount = int.Parse(dataReader[CL_AMOUNT].ToString());
                    item.St = dataReader[CL_ST].ToString();
                    item.TotalValue = decimal.Parse(dataReader[CL_ITEM_VALUE].ToString());
                    item.DocumentType = char.Parse(dataReader[CL_DOCUMENT_TYPE].ToString());

                    item.Product = new ProductModel()
                    {
                        BarCode = dataReader[CL_CODE].ToString(),
                        Description = dataReader[CL_DESCRIPTION].ToString(),
                        Unity = dataReader[CL_UNITY].ToString(),
                        Price = decimal.Parse(dataReader[CL_UNITARY_VALUE].ToString())
                    };
                }

                connection.Close();
                return item;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public int AddItem(ItemModel item)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_CODE}, {CL_DESCRIPTION}, {CL_AMOUNT}, {CL_UNITY}, {CL_UNITARY_VALUE}, {CL_ST}, {CL_ITEM_VALUE}, {CL_DOCUMENT_TYPE}) VALUES " +
                    $"('{item.Product.BarCode}', '{item.Product.Description}', {item.Amount}, '{item.Product.Unity}', {item.Product.Price.ToString().Replace(',','.')}, '{item.St}', {item.TotalValue.ToString().Replace(',', '.')}, '{item.DocumentType}'); Select LAST_INSERT_ID()";

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
        public void UpdateItemById(ItemModel item)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_CODE} = '{item.Product.BarCode}', {CL_DESCRIPTION} = '{item.Product.Description}', {CL_AMOUNT} = {item.Amount}, {CL_UNITY} = '{item.Product.Unity}', {CL_UNITARY_VALUE} = {item.Product.Price.ToString().Replace(',','.')}, " +
                $"{CL_ST} = '{item.St}', {CL_ITEM_VALUE} = {item.TotalValue.ToString().Replace(',', '.')}, {CL_DOCUMENT_TYPE} = '{item.DocumentType}' WHERE {CL_ID} = {item.Id};" ;
                 
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
        public ItemModel GetItemById(ItemModel item)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_ID} = {item.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                item = null;
                while (dataReader.Read())
                {
                    item = new ItemModel();

                    item.Id = int.Parse(dataReader[CL_ID].ToString());
                    item.Amount = int.Parse(dataReader[CL_AMOUNT].ToString());
                    item.St = dataReader[CL_ST].ToString();
                    item.TotalValue = decimal.Parse(dataReader[CL_ITEM_VALUE].ToString());
                    item.DocumentType = char.Parse(dataReader[CL_DOCUMENT_TYPE].ToString());

                    item.Product = new ProductModel()
                    {
                        BarCode = dataReader[CL_CODE].ToString(),
                        Description = dataReader[CL_DESCRIPTION].ToString(),
                        Unity = dataReader[CL_UNITY].ToString(),
                        Price = decimal.Parse(dataReader[CL_UNITARY_VALUE].ToString())
                    };

                }
                connection.Close();

                return item;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public List<ItemModel> GetAllItems()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<ItemModel> items = new List<ItemModel>();
                while (dataReader.Read())
                {
                    ItemModel item = new ItemModel();

                    item.Id = int.Parse(dataReader[CL_ID].ToString());
                    item.Amount = int.Parse(dataReader[CL_AMOUNT].ToString());
                    item.St = dataReader[CL_ST].ToString();
                    item.TotalValue = decimal.Parse(dataReader[CL_ITEM_VALUE].ToString());
                    item.DocumentType = char.Parse(dataReader[CL_DOCUMENT_TYPE].ToString());

                    item.Product = new ProductModel()
                    {
                        BarCode = dataReader[CL_CODE].ToString(),
                        Description = dataReader[CL_DESCRIPTION].ToString(),
                        Unity = dataReader[CL_UNITY].ToString(),
                        Price = decimal.Parse(dataReader[CL_UNITARY_VALUE].ToString())
                    };

                    items.Add(item);

                }
                connection.Close();

                return items;
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
