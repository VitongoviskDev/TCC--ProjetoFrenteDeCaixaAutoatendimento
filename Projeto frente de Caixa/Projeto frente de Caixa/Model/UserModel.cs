using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class UserModel
    {
        private int id;
        private int code;
        private string name;
        private string email;
        private int profile;
        private bool status;
        private string login;
        private string passwordHash;
        private string passwordHashAdder;
        private bool isFirstAccess;
        private int addedId;
        private int updatedId;

        public int Id { get => id; set => id = value; }
        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public int Profile { get => profile; set => profile = value; }
        public bool Status { get => status; set => status = value; }
        public string Login { get => login; set => login = value; }
        public string PasswordHash { get => passwordHash; set => passwordHash = value; }
        public string PasswordHashAdder { get => passwordHashAdder; set => passwordHashAdder = value; }
        public bool IsFirstAccess { get => isFirstAccess; set => isFirstAccess = value; }
        public int AddedId { get => addedId; set => addedId = value; }
        public int UpdatedId { get => updatedId; set => updatedId = value; }
    }
}
