using MySql.Data.MySqlClient;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.Dao
{
    public class DocumentDao
    {
        private const string TABLE = "fc_documents";
        private const string CL_ID = "id";
        private const string CL_NUMBER = "number";
        private const string CL_SERIAL = "serial";
        private const string CL_COMPANY_ID = "companyId";
        private const string CL_EMISSION_DATE = "emissionDate";
        private const string CL_REGISTRATION = "registration";
        private const string CL_TOTAL_VALUE = "totalValue";
        private const string CL_TYPE = "type";
        private const string CL_CPF = "cpf";
        private const string CL_ITEMS = "itemsAmount";

        public int code = -1;
        public string message = string.Empty;

        public int CreateEmptyDocument(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_NUMBER}, {CL_SERIAL}, {CL_COMPANY_ID}, {CL_EMISSION_DATE}, {CL_TYPE}, {CL_REGISTRATION}, {CL_CPF}) VALUES " +
                    $"('{document.Number}', '{document.Serial}', {document.Company.Id}, '{document.EmissionDate.ToString("yyyy-MM-dd")}', '{document.Type}', {document.Registration.Id}, '{document.Cpf}'); SELECT LAST_INSERT_ID()";

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
        public void DeleteDocumentById(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"DELETE FROM {TABLE} WHERE {CL_ID} = {document.Id}";

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
        public List<DocumentModel> GetAllDocuments()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT * FROM {TABLE}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<DocumentModel> documents = new List<DocumentModel>();
                while (dataReader.Read())
                {
                    DocumentModel document = new DocumentModel();
                    document.Id = int.Parse(dataReader[CL_ID].ToString());
                    document.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    document.Serial = int.Parse(dataReader[CL_SERIAL].ToString());
                    CompanyControll companyControll = new CompanyControll();
                    document.Company = companyControll.GetCompanyById(new CompanyModel() { Id = int.Parse(dataReader[CL_COMPANY_ID].ToString()) });
                    document.EmissionDate = DateTime.Parse(dataReader[CL_EMISSION_DATE].ToString());
                    int acitivityID = int.Parse(dataReader[CL_REGISTRATION].ToString());
                    ActivityControll activityControll = new ActivityControll();
                    document.Registration = activityControll.GetActivityById(new ActivityModel() { Id = acitivityID });
                    document.TotalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    document.Type = char.Parse(dataReader[CL_TYPE].ToString());
                    document.Cpf = dataReader[CL_CPF].ToString();
                    document.ItemsAmount = int.Parse(dataReader[CL_ITEMS].ToString());

                    documents.Add(document);
                }
                connection.Close();
                return documents;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public List<DocumentModel> GetDocumentByType(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT * FROM {TABLE} WHERE {CL_TYPE} = '{document.Type}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<DocumentModel> documents = new List<DocumentModel>();
                while (dataReader.Read())
                {
                    document = new DocumentModel();
                    document.TotalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    if (document.TotalValue <= 0)
                        continue;
                    document.Id = int.Parse(dataReader[CL_ID].ToString());
                    document.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    document.Serial = int.Parse(dataReader[CL_SERIAL].ToString());
                    CompanyControll companyControll = new CompanyControll();
                    document.Company = companyControll.GetCompanyById(new CompanyModel() { Id = int.Parse(dataReader[CL_COMPANY_ID].ToString()) });
                    document.EmissionDate = DateTime.Parse(dataReader[CL_EMISSION_DATE].ToString());
                    int acitivityID = int.Parse(dataReader[CL_REGISTRATION].ToString());
                    ActivityControll activityControll = new ActivityControll();
                    document.Registration = activityControll.GetActivitySystemById(new ActivityModel() { Id = acitivityID});
                    document.Type = char.Parse(dataReader[CL_TYPE].ToString());
                    document.Cpf = dataReader[CL_CPF].ToString();
                    document.ItemsAmount = int.Parse(dataReader[CL_ITEMS].ToString());

                    documents.Add(document);
                }
                connection.Close();
                return documents;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public int GetLastNumber()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT {CL_NUMBER} FROM {TABLE} ORDER BY {CL_NUMBER}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int number = 0;
                while (dataReader.Read())
                {
                    number = int.Parse(dataReader[CL_NUMBER].ToString());
                }
                connection.Close();
                return number;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
        }
        public int GetLastSerial()
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT {CL_SERIAL} FROM {TABLE} ORDER BY {CL_SERIAL}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int serial = 0;
                while (dataReader.Read())
                {
                    serial = int.Parse(dataReader[CL_SERIAL].ToString());
                }
                connection.Close();
                return serial;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return -1;
            }
        }

        public DocumentModel GetDocumentByNumberAndSerial(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT * FROM {TABLE} WHERE {CL_NUMBER} =  {document.Number} AND {CL_SERIAL} = {document.Serial}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                document = null;
                while (dataReader.Read())
                {
                    document = new DocumentModel();
                    document.Id = int.Parse(dataReader[CL_ID].ToString());
                    document.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    document.Serial = int.Parse(dataReader[CL_SERIAL].ToString());
                    CompanyControll companyControll = new CompanyControll();
                    document.Company = companyControll.GetCompanyById(new CompanyModel() { Id = int.Parse(dataReader[CL_COMPANY_ID].ToString()) });
                    document.EmissionDate = DateTime.Parse(dataReader[CL_EMISSION_DATE].ToString());
                    int acitivityID = int.Parse(dataReader[CL_REGISTRATION].ToString());
                    ActivityControll activityControll = new ActivityControll();
                    document.Registration = activityControll.GetActivityById(new ActivityModel() { Id = acitivityID });
                    document.TotalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    document.Type = char.Parse(dataReader[CL_TYPE].ToString());
                    document.Cpf = dataReader[CL_CPF].ToString();
                    document.ItemsAmount = int.Parse(dataReader[CL_ITEMS].ToString());
                }
                connection.Close();
                return document;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public DocumentModel GetDocumentById(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT * FROM {TABLE} WHERE {CL_ID} =  {document.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                document = null;
                while (dataReader.Read())
                {
                    document = new DocumentModel();
                    document.Id = int.Parse(dataReader[CL_ID].ToString());
                    document.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    document.Serial = int.Parse(dataReader[CL_SERIAL].ToString());
                    CompanyControll companyControll = new CompanyControll();
                    document.Company = companyControll.GetCompanyById(new CompanyModel() { Id = int.Parse(dataReader[CL_COMPANY_ID].ToString())});
                    document.EmissionDate = DateTime.Parse(dataReader[CL_EMISSION_DATE].ToString());
                    int acitivityID = int.Parse(dataReader[CL_REGISTRATION].ToString());
                    ActivityControll activityControll = new ActivityControll();
                    document.Registration = activityControll.GetActivityById(new ActivityModel() { Id = acitivityID });
                    document.TotalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    document.Type = char.Parse(dataReader[CL_TYPE].ToString());
                    document.Cpf = dataReader[CL_CPF].ToString();
                    document.ItemsAmount = int.Parse(dataReader[CL_ITEMS].ToString());
                }
                connection.Close();
                return document;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public DocumentModel GetSaleDocumentById(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();
                string query = $"SELECT * FROM {TABLE} WHERE {CL_ID} =  {document.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                document = null;
                while (dataReader.Read())
                {
                    document = new DocumentModel();
                    document.Id = int.Parse(dataReader[CL_ID].ToString());
                    document.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    document.Serial = int.Parse(dataReader[CL_SERIAL].ToString());
                    CompanyControll companyControll = new CompanyControll();
                    document.Company = companyControll.GetCompanyById(new CompanyModel() { Id = int.Parse(dataReader[CL_COMPANY_ID].ToString())});
                    document.EmissionDate = DateTime.Parse(dataReader[CL_EMISSION_DATE].ToString());
                    int acitivityID = int.Parse(dataReader[CL_REGISTRATION].ToString());
                    ActivityControll activityControll = new ActivityControll();
                    document.Registration = activityControll.GetActivitySystemById(new ActivityModel() { Id = acitivityID});
                    decimal var = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    document.TotalValue = decimal.Parse(dataReader[CL_TOTAL_VALUE].ToString());
                    document.Type = char.Parse(dataReader[CL_TYPE].ToString());
                    document.Cpf = dataReader[CL_CPF].ToString();
                    document.ItemsAmount = int.Parse(dataReader[CL_ITEMS].ToString());
                }
                connection.Close();
                return document;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }

        public int AddDocument(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_NUMBER}, {CL_SERIAL}, {CL_COMPANY_ID}, {CL_EMISSION_DATE}, {CL_REGISTRATION}, {CL_TOTAL_VALUE}, {CL_TYPE}, {CL_CPF}, {CL_ITEMS}) VALUES ({document.Number}, {document.Serial}, {document.Company.Id}, '{document.EmissionDate.ToString("yyyy-MM-dd")}', {document.Registration.Id}, {document.TotalValue.ToString().Replace(',','.')}, '{document.Type}', '{document.Cpf}', {document.ItemsAmount});" +
                    $"SELECT LAST_INSERT_ID()";

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
        public void UpdateDocumentById(DocumentModel document)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_NUMBER} = {document.Number}, {CL_SERIAL} = {document.Serial}, {CL_COMPANY_ID} = {document.Company.Id}, {CL_EMISSION_DATE} = '{document.EmissionDate.ToString("yyyy-MM-dd")}', {CL_REGISTRATION} = {document.Registration.Id}, {CL_TOTAL_VALUE} = {document.TotalValue.ToString().Replace(',', '.')}, {CL_TYPE} = '{document.Type}', {CL_CPF} = '{document.Cpf}', {CL_ITEMS} = {document.ItemsAmount} WHERE {CL_ID} = {document.Id}";

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
