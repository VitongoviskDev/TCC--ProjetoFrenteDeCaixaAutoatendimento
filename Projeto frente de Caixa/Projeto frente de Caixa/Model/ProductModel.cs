using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Model
{
    public class ProductModel
    {
        private int id;
        private int code;
        private ActivityModel added;
        private string description;
        private bool status;
        private decimal price;
        private string barCode;
        private ActivityModel updated;
        private string unity;
        private int storageLevelAlert;

        public int Id { get => id; set => id = value; }
        public int Code { get => code; set => code = value; }
        public ActivityModel Added { get => added; set => added = value; }
        public string Description { get => description; set => description = value; }
        public bool Status { get => status; set => status = value; }
        public decimal Price { get => price; set => price = value; }
        public string BarCode { get => barCode; set => barCode = value; }
        public ActivityModel LastUpdated { get => updated; set => updated = value; }
        public string Unity { get => unity; set => unity = value; }
        public int StorageLevelAlert { get => storageLevelAlert; set => storageLevelAlert = value; }
    }
}
