using Microsoft.SqlServer.Server;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Control
{
    public class UserControll
    {
        private const int HASH_ADDER_STRENGTH = 5;
        private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
        
        public bool ValidateUserPassword(string password, UserModel user)
        {
            string userPassword = user.PasswordHash;
            string typedPassword = GetPasswordHash(password + user.PasswordHashAdder);

            return userPassword == typedPassword ? true : false;
        }
        private string GetPasswordHash(string toConvert)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(toConvert));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private string GetRandomAdder()
        {
            string randomAdder = string.Empty;

            Random random = new Random();

            for(int i = 0;i < HASH_ADDER_STRENGTH; i++)
                randomAdder+= ALPHABET[random.Next(ALPHABET.Length)];

            return randomAdder;
        }
        public UserModel GetUserByLogin(UserModel user)
        {
            UserDao userDao = new UserDao();
            user.Login = user.Login.Trim().ToLower();
            return userDao.GetUserByLogin(user);
        }
        public UserModel GetUserById(UserModel user)
        {
            UserDao userDao = new UserDao();
            return userDao.GetUserById(user);
        }
        public UserModel GetUserByCode(UserModel user)
        {
            UserDao userDao = new UserDao();
            return userDao.GetUserByCode(user);
        }
        public List<UserModel> GetAllUsers()
        {
            UserDao userDao = new UserDao();
            return userDao.GetAllUsers();
        }
        public int GetUserIdByEmail(UserModel user)
        {
            UserDao userDao = new UserDao();
            user.Email = user.Email.Trim().ToLower();
            return userDao.GetUserIdByEmail(user);
        }
        public void UpdatePassword(string newPassword, UserModel user)
        {
            UserDao userDao = new UserDao();
            user.PasswordHash = GetPasswordHash(newPassword + user.PasswordHashAdder);
            userDao.UpdateUser(user);
        }
        public void UpdateUser(UserModel user)
        {
            UserDao userDao = new UserDao();
            userDao.UpdateUser(user);
        }

        public void DisabeUser(UserModel user)
        {
            UserDao userDao = new UserDao();
            user.Status = false;

            userDao.UpdateUser(user);
        }
        public void EnableUser(UserModel user)
        {
            UserDao userDao = new UserDao();
            user.Status = true;

            userDao.UpdateUser(user);
        }

        public void AddUser(UserModel user)
        {
            UserDao userDao = new UserDao();
            user.IsFirstAccess = user.Code > 0;
            userDao.AddUser(user);
        }

        public void CreateAdminUser()
        {
            string adder = GetRandomAdder();
            string pass = GetPasswordHash("admin" + adder);

            ConfigControll configControll = new ConfigControll();
            ConfigModel config = configControll.GetConfig();

            UserModel user = new UserModel()
            {
                Id = 0,
                Code = 0,
                Name = "administrador",
                Login = "administrador",
                PasswordHash = pass,
                PasswordHashAdder = adder,
                Profile = 0,
                Status = true,
                IsFirstAccess = false,
                AddedId = -1,
                UpdatedId = -1
            };

            AddUser(user);
        }

        public static int GetNextCode()
        {
            UserDao userDao = new UserDao();
            return userDao.GetLastCode() + 1;
        }

        public bool ValidateEmail(UserModel user)
        {
            if (user.Email.Contains('@'))
            {
                string[] splited = user.Email.Split('@');
                string after = splited[1];

                if (!after.Contains(".com"))
                    return false;
                else
                    return true;
            }
            else return false;
        }
        public bool ValidateGoogleEmail(UserModel user)
        {
            if (user.Email.Contains("@gmail.com"))
                return true;
            else return false;
        }

        public static string GenerateCode(int numberOfDigits)
        {
            string code = "";
            Random randomNumber = new Random();
            for (int i = 0; i < numberOfDigits; i++)
            {
                code += randomNumber.Next(0, 9 + 1);
            }

            return code;
        }
    }
}
