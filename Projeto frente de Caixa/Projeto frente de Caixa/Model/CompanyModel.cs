using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class CompanyModel
    {
        private int id;
        private string socialReason;
        private string fantasyName;
        private string cnpj;
        private string stateRegistration;
        private DateTime openingDate;
        private string site;
        private string email;
        private string ddi;
        private string ddd;
        private string phoneNumber;
        private string adress;
        private string zipCode;
        private int number;
        private string complement;
        private string district;
        private string city;
        private string state;

        public int Id { get => id; set => id = value; }
        public string SocialReason { get => socialReason; set => socialReason = value; }
        public string FantasyName { get => fantasyName; set => fantasyName = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string StateRegistration { get => stateRegistration; set => stateRegistration = value; }
        public DateTime OpeningDate { get => openingDate; set => openingDate = value; }
        public string Site { get => site; set => site = value; }
        public string Email { get => email; set => email = value; }
        public string Ddi { get => ddi; set => ddi = value; }
        public string Ddd { get => ddd; set => ddd = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Adress { get => adress; set => adress = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public int Number { get => number; set => number = value; }
        public string Complement { get => complement; set => complement = value; }
        public string District { get => district; set => district = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
    }
}
