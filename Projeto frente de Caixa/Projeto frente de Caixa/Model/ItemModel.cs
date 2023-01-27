using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class ItemModel
    {
        private int id;
        private ProductModel product;
        private int amount;
        private decimal totalValue;
        private string st;
        private char documentType;

        public int Id { get => id; set => id = value; }
        public ProductModel Product { get => product; set => product = value; }
        public int Amount { get => amount; set => amount = value; }
        public string St { get => st; set => st = value; }
        public decimal TotalValue { get => totalValue; set => totalValue = value; }
        public char DocumentType { get => documentType; set => documentType = value; }
    }
}
