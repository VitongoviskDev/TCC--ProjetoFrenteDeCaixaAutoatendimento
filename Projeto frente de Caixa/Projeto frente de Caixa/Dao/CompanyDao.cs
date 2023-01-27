using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Projeto_frente_de_Caixa.Dao
{
    public class CompanyDao
    {
        private const int MAIN_COMPANY_ID = 1;
        private const string TABLE = "fc_company";
        private const string CL_ID = "id";
        private const string CL_FANTASY_NAME = "FantasyName";
        private const string CL_SOCIAL_REASON = "SocialReason";
        private const string CL_CNPJ = "Cnpj";
        private const string CL_STATE_REGISTRATION = "StateRegistration";
        private const string CL_OPENING_DATE = "OpeningDate";
        private const string CL_SITE = "Site";
        private const string CL_EMAIL = "Email";
        private const string CL_DDI = "ddi";
        private const string CL_DDD = "ddd";
        private const string CL_PHONE_NUMBER = "PhoneNumber";
        private const string CL_ADRESS = "Adress";
        private const string CL_ZIP_CODE = "ZipCode";
        private const string CL_NUMBER = "Number";
        private const string CL_COMPLEMENT = "Complement";
        private const string CL_DISTRICT = "District";
        private const string CL_CITY = "City";
        private const string CL_STATE = "State";

        public int code = -1;
        public string message = string.Empty;

        public CompanyModel GetCompanyByID(CompanyModel company)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} WHERE {CL_ID} = {company.Id}";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                company = null;
                while (dataReader.Read())
                {
                    company = new CompanyModel();
                    company.Id = int.Parse(dataReader[CL_ID].ToString());
                    company.FantasyName = dataReader[CL_FANTASY_NAME].ToString();
                    company.SocialReason = dataReader[CL_SOCIAL_REASON].ToString();
                    company.Cnpj = dataReader[CL_CNPJ].ToString();
                    company.StateRegistration = dataReader[CL_STATE_REGISTRATION].ToString();
                    company.OpeningDate = DateTime.Parse(dataReader[CL_OPENING_DATE].ToString());
                    company.Site = dataReader[CL_SITE].ToString();
                    company.Email = dataReader[CL_EMAIL].ToString();
                    company.Ddi = dataReader[CL_DDI].ToString();
                    company.Ddd = dataReader[CL_DDD].ToString();
                    company.PhoneNumber = dataReader[CL_PHONE_NUMBER].ToString();
                    company.Adress = dataReader[CL_ADRESS].ToString();
                    company.ZipCode = dataReader[CL_ZIP_CODE].ToString();
                    company.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    company.Complement = dataReader[CL_COMPLEMENT].ToString();
                    company.District = dataReader[CL_DISTRICT].ToString();
                    company.City = dataReader[CL_CITY].ToString();
                    company.State = dataReader[CL_STATE].ToString();
                }

                connection.Close();

                return company;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public CompanyModel GetCompanyByCnpj(CompanyModel company)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"Select * from {TABLE} WHERE {CL_CNPJ} = '{company.Cnpj}'";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                company = null;
                while (dataReader.Read())
                {
                    company = new CompanyModel();
                    company.Id = int.Parse(dataReader[CL_ID].ToString());
                    company.FantasyName = dataReader[CL_FANTASY_NAME].ToString();
                    company.SocialReason = dataReader[CL_SOCIAL_REASON].ToString();
                    company.Cnpj = dataReader[CL_CNPJ].ToString();
                    company.StateRegistration = dataReader[CL_STATE_REGISTRATION].ToString();
                    company.OpeningDate = DateTime.Parse(dataReader[CL_OPENING_DATE].ToString());
                    company.Site = dataReader[CL_SITE].ToString();
                    company.Email = dataReader[CL_EMAIL].ToString();
                    company.Ddi = dataReader[CL_DDI].ToString();
                    company.Ddd = dataReader[CL_DDD].ToString();
                    company.PhoneNumber = dataReader[CL_PHONE_NUMBER].ToString();
                    company.Adress = dataReader[CL_ADRESS].ToString();
                    company.ZipCode = dataReader[CL_ZIP_CODE].ToString();
                    company.Number = int.Parse(dataReader[CL_NUMBER].ToString());
                    company.Complement = dataReader[CL_COMPLEMENT].ToString();
                    company.District = dataReader[CL_DISTRICT].ToString();
                    company.City = dataReader[CL_CITY].ToString();
                    company.State = dataReader[CL_STATE].ToString();
                }
                connection.Close();

                return company;
            }
            catch (MySqlException ex)
            {
                code = (int)ex.Code;
                message = ex.Message;
                return null;
            }
        }
        public void UpdateCompany(CompanyModel company)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"UPDATE {TABLE} SET {CL_FANTASY_NAME} = '{company.FantasyName}', {CL_SOCIAL_REASON} = '{company.SocialReason}', " +
                    $"{CL_CNPJ} = '{company.Cnpj}', {CL_STATE_REGISTRATION} = '{company.StateRegistration}', {CL_OPENING_DATE} = '{company.OpeningDate}', " +
                    $"{CL_SITE} = '{company.Site}', {CL_EMAIL} = '{company.Email}', {CL_DDI} = '{company.Ddi}', " +
                    $"{CL_DDD} = '{company.Ddd}', {CL_PHONE_NUMBER} = '{company.PhoneNumber}', {CL_COMPLEMENT} = '{company.Complement}', {CL_ADRESS} = '{company.Adress}', " +
                    $"{CL_ZIP_CODE} = '{company.ZipCode}', {CL_NUMBER} = '{company.Number}', {CL_DISTRICT} = '{company.District}', " +
                    $"{CL_CITY} = '{company.City}', {CL_STATE} = '{company.State}' Where {CL_ID} = {company.Id}";

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
        public void AddMainCompany(CompanyModel company)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_ID}, {CL_FANTASY_NAME}, {CL_SOCIAL_REASON}, {CL_CNPJ}, {CL_STATE_REGISTRATION}, {CL_OPENING_DATE}, {CL_SITE}, {CL_EMAIL}, {CL_DDI}, {CL_DDD}, {CL_PHONE_NUMBER}, {CL_COMPLEMENT}, {CL_ADRESS}, {CL_ZIP_CODE}, {CL_NUMBER}, {CL_DISTRICT}, {CL_CITY}, {CL_STATE}) VALUES " +
                    $"({MAIN_COMPANY_ID}, '{company.FantasyName}', '{company.SocialReason}', '{company.Cnpj}', '{company.StateRegistration}', '{company.OpeningDate}', '{company.Site}', '{company.Email}', '{company.Ddi}', '{company.Ddd}', '{company.PhoneNumber}', '{company.Complement}', '{company.Adress}', '{company.ZipCode}', '{company.Number}', '{company.District}', '{company.City}','{company.State}')";

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
        public int AddCompany(CompanyModel company)
        {
            try
            {
                MySqlConnection connection = DBConnection.Connection();

                string query = $"INSERT INTO {TABLE} ({CL_FANTASY_NAME}, {CL_SOCIAL_REASON}, {CL_CNPJ}, {CL_STATE_REGISTRATION}, {CL_OPENING_DATE}, {CL_SITE}, {CL_EMAIL}, {CL_DDI}, {CL_DDD}, {CL_PHONE_NUMBER}, {CL_COMPLEMENT}, {CL_ADRESS}, {CL_ZIP_CODE}, {CL_NUMBER}, {CL_DISTRICT}, {CL_CITY}, {CL_STATE}) VALUES " +
                    $"('{company.FantasyName}', '{company.SocialReason}', '{company.Cnpj}', '{company.StateRegistration}', '{company.OpeningDate}', '{company.Site}', '{company.Email}', '{company.Ddi}', '{company.Ddd}', '{company.PhoneNumber}', '{company.Complement}', '{company.Adress}', '{company.ZipCode}', '{company.Number}', '{company.District}', '{company.City}','{company.State}');SELECT LAST_INSERT_ID()";

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
    }
}
