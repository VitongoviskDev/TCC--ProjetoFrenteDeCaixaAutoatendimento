using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.X509;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.Dao
{
    public class ProductDao
    {
        private const string TABLE = "fc_products";
        private const string CL_ID = "id";
        private const string CL_CODE = "code";
        private const string CL_ADDED = "activityAddedId";
        private const string CL_DESCRIPTION = "description";
        private const string CL_STATUS = "status";
        private const string CL_PRICE = "price";
        private const string CL_BARCODE = "barcode";
        private const string CL_UNITY = "unity";
        private const string CL_UPDATED = "activityUpdatedId";
        private const string CL_STOAGE_LEVEL_ALERT = "storageLevelAlert";

        public int code = -1;
        public string message = string.Empty;
        public List<ProductModel> GetAllProductsForAdminView()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<ProductModel> products = new List<ProductModel>();
                while (dataReader.Read())
                {
                    ProductModel product = new ProductModel();

                    product.Id = int.Parse(dataReader[CL_ID].ToString());
                    product.Code = int.Parse(dataReader[CL_CODE].ToString());
                    if ( product.Code > 0)
                    {
                        product.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                        product.Description = dataReader[CL_DESCRIPTION].ToString();
                        product.Price = decimal.Parse(dataReader[CL_PRICE].ToString());
                        product.BarCode = dataReader[CL_BARCODE].ToString();
                        product.Unity = dataReader[CL_UNITY].ToString();
                        products.Add(product);
                    }

                }
                connection.Close();

                return products;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public List<ProductModel> GetActiveProducts()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} WHERE {CL_STATUS} = {true}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<ProductModel> products = new List<ProductModel>();
                while (dataReader.Read())
                {
                    ProductModel product = new ProductModel();

                    product.Id = int.Parse(dataReader[CL_ID].ToString());
                    product.Description = dataReader[CL_DESCRIPTION].ToString();
                    if (!string.IsNullOrEmpty(product.Description))
                    {
                        product.Price = decimal.Parse(dataReader[CL_PRICE].ToString());
                        product.BarCode = dataReader[CL_BARCODE].ToString();
                        product.Unity = dataReader[CL_UNITY].ToString();
                        products.Add(product);
                    }

                }
                connection.Close();

                return products;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public ProductModel GetProductById(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} Where {CL_ID} = {product.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();


                product = new ProductModel();
                while (dataReader.Read())
                {
                    product.Id = int.Parse(dataReader[CL_ID].ToString());
                    product.Code = int.Parse(dataReader[CL_CODE].ToString());
                    int activityAddedId = int.Parse(dataReader[CL_ADDED].ToString());
                    ActivityControll AddedActivityControll = new ActivityControll();
                    product.Added = AddedActivityControll.GetActivityById(new ActivityModel() { Id = activityAddedId });
                    product.Description = dataReader[CL_DESCRIPTION].ToString();
                    product.Status = bool.Parse(dataReader[CL_STATUS].ToString());
                    product.Price = decimal.Parse(dataReader[CL_PRICE].ToString());
                    product.BarCode = dataReader[CL_BARCODE].ToString();
                    product.Unity = dataReader[CL_UNITY].ToString();
                    int activityUpdatedId = int.Parse(dataReader[CL_UPDATED].ToString());
                    ActivityControll updatedActivityControll = new ActivityControll();
                    product.LastUpdated = updatedActivityControll.GetActivityById(new ActivityModel() { Id = activityAddedId });
                    product.StorageLevelAlert = int.Parse(dataReader[CL_STOAGE_LEVEL_ALERT].ToString());

                }
                connection.Close();

                return product;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public void UpdateProduct(ProductModel newProduct)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_CODE}='{newProduct.Code}',{CL_ADDED}={newProduct.Added.Id},{CL_DESCRIPTION}='{newProduct.Description}',{CL_STATUS}={newProduct.Status},{CL_PRICE}='{newProduct.Price.ToString().Replace(',','.')}', {CL_BARCODE}='{newProduct.BarCode}', {CL_UNITY}='{newProduct.Unity}',{CL_UPDATED}={newProduct.Added.Id},{CL_STOAGE_LEVEL_ALERT}={newProduct.StorageLevelAlert} WHERE {CL_ID} = {newProduct.Id}";

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
        public void AddProdcut(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE}  ({CL_CODE}, {CL_ADDED}, {CL_DESCRIPTION}, {CL_STATUS},{CL_PRICE}, {CL_BARCODE}, {CL_UNITY}, {CL_UPDATED}, {CL_STOAGE_LEVEL_ALERT}) VALUES " +
                    $"('{product.Code}', {product.Added.Id}, '{product.Description}', {product.Status}, '{product.Price.ToString().Replace(',', '.')}', '{product.BarCode}', '{product.Unity}', {product.Added.Id}, {product.StorageLevelAlert})";

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
        public int AddEmptyProdcut()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} () VALUES (); SELECT LAST_INSERT_ID()";

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
        public int GetProductIdByDescription(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ID} from {TABLE} WHERE {CL_DESCRIPTION} = '{product.Description}'";

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
        public int GetProductIdByBarCode(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ID} from {TABLE} WHERE {CL_BARCODE} = '{product.BarCode}'";

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
        public int GetProductIdByCode(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select {CL_ID} from {TABLE} WHERE {CL_CODE} = '{product.Code}'";

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
        public void DeleteProductById(ProductModel product)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"DELETE FROM {TABLE} WHERE {CL_ID} = {product.Id};";

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

                string greatestNumber = "Greatest";
                string query = $"Select MAX({CL_CODE}) AS {greatestNumber} from {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int code = 0;
                while (dataReader.Read())
                {
                    code = int.Parse(dataReader[greatestNumber].ToString());
                }
                connection.Close();
                return code;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
            catch(Exception ex)
            {
                message = ex.Message;
                return 0;
            }
        }
    }
}
