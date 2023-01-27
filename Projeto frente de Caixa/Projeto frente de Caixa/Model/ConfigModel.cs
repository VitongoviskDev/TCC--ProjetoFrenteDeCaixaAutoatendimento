using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class ConfigModel
    {
        private string email;
        private string password;
        private bool sendPassworChangedEmail;
        private bool sendItemSoldOutEmail;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool SendPassworChangedEmail { get => sendPassworChangedEmail; set => sendPassworChangedEmail = value; }
        public bool SendItemSoldOutEmail { get => sendItemSoldOutEmail; set => sendItemSoldOutEmail = value; }
    }
}
