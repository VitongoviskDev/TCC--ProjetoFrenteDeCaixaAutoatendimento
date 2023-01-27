using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class DocumentModel
    {
        private int id;
        private int number;
        private int serial;
        private CompanyModel company;
        private DateTime emissionDate;
        private List<ItemModel> items;
        private decimal totalValue;
        private char type;
        private string cpf;
        private FileInfo file;
        private ActivityModel registration;
        private int itemsAmount;

        public int Id { get => id; set => id = value; }
        public int Number { get => number; set => number = value; }
        public int Serial { get => serial; set => serial = value; }
        public CompanyModel Company { get => company; set => company = value; }
        public DateTime EmissionDate { get => emissionDate; set => emissionDate = value; }
        public List<ItemModel> Items { get => items; set => items = value; }
        public decimal TotalValue { get => totalValue; set => totalValue = value; }
        public char Type { get => type; set => type = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public FileInfo File { get => file; set => file = value; }
        public ActivityModel Registration { get => registration; set => registration = value; }
        public int ItemsAmount { get => itemsAmount; set => itemsAmount = value; }
    }
}
 