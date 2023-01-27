using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class CardModel
    {
        private int id;
        private string owner;
        private string number;
        private int cvv;
        private DateTime expirationDate;
        private decimal amount;
        private char type;

        public int Id { get => id; set => id = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Number { get => number; set => number = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public char Type { get => type; set => type = value; }
    }
}
