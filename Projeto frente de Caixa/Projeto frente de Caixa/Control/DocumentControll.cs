using Microsoft.Office.Interop.Excel;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Projeto_frente_de_Caixa.Control
{
    public class DocumentControll
    {
        public DocumentModel CreateNewSaleDocument(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            if (document == null) document = new DocumentModel();

            document.Number = GetNextNumber();
            document.Serial = GetCurrentSerial();

            document.Company = CompanyControll.GetMainCompany();

            ActivityControll activityControll = new ActivityControll();
            document.Registration = new ActivityModel();
            document.Registration.Id = activityControll.CreateSystemActivity(document.Registration);

            document.EmissionDate = DateTime.Now;

            document.Type = 's';
            document.TotalValue = 0;
            document.ItemsAmount = 0;

            int id = documentDao.AddDocument(document);

            return GetSaleDocumentById(new DocumentModel() { Id =  id});
        }
        public void DeleteDocumentById(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            documentDao.DeleteDocumentById(document);
        }
        private int GetNextNumber()
        {
            DocumentDao documentDao = new DocumentDao();
            int number = documentDao.GetLastNumber() + 1;

            if (number > 100000)
                number = 1;

            return number;

        }
        private int GetCurrentSerial()
        {
            DocumentDao documentDao = new DocumentDao();
            int serial = documentDao.GetLastSerial();

            if(documentDao.GetLastNumber() == 99999)
                serial++;

            return serial;
        }
        public DocumentModel ReadDocument(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            _Application excel = new _Excel.Application();
            Workbook wb = excel.Workbooks.Open(document.File.FullName);
            Worksheet ws = excel.Worksheets[1];

            document.Items = new List<ItemModel>();
            int i= 1;
            bool cont = true;
            while(cont)
            {
                switch (i)
                {
                    case 1:
                        i++;
                        document.Company = new CompanyModel();
                        document.Company.SocialReason = ws.Cells[i, 1].Value;
                        document.Company.FantasyName = ws.Cells[i, 2].Value;
                        document.Company.Cnpj = ws.Cells[i,3].Value;
                        document.Company.StateRegistration = ws.Cells[i,4].Value.ToString();
                        document.Company.OpeningDate = ws.Cells[i, 5].Value;
                        document.Company.Site = ws.Cells[i,6].Value;
                        document.Company.Email = ws.Cells[i,7].Value;
                        document.Company.Ddi = ws.Cells[i,8].Value.ToString();
                        document.Company.Ddd = ws.Cells[i,9].Value.ToString();
                        document.Company.PhoneNumber = ws.Cells[i,10].Value.ToString();
                        document.Company.Adress = ws.Cells[i,11].Value;
                        document.Company.ZipCode = ws.Cells[i,12].Value.ToString();
                        document.Company.Number = (int)ws.Cells[i, 13].Value;
                        document.Company.Complement = ws.Cells[i,14].Value;
                        document.Company.District = ws.Cells[i,15].Value;
                        document.Company.City = ws.Cells[i,16].Value;
                        document.Company.State = ws.Cells[i, 17].Value;
                        i+=2;
                        break;
                    case 4:
                        document.Number = (int)ws.Cells[i, 1].Value;
                        document.Serial = (int)ws.Cells[i, 2].Value;
                        document.EmissionDate = ws.Cells[i,3].Value;
                        document.TotalValue = (decimal)ws.Cells[i, 4].Value;
                        document.Type = char.Parse(ws.Cells[i,5].Value);
                        i+= 2;
                        break;
                    default:
                        if (ws.Cells[i, 1].Value == null)
                        {
                            cont = false;
                            break;
                        }

                        ProductModel product = new ProductModel();
                        product.BarCode = ws.Cells[i, 1].Value;
                        product.Description = ws.Cells[i, 2].Value;
                        product.Unity = ws.Cells[i, 3].Value;
                        product.Price = (decimal)ws.Cells[i, 4].Value;

                        ItemModel item = new ItemModel();
                        item.Product = product;
                        item.Amount = (int)ws.Cells[i, 5].Value;
                        item.TotalValue = (decimal)ws.Cells[i, 6].Value;
                        document.Items.Add(item);
                        document.ItemsAmount = i - 2;
                        i++;
                        break;
                }
            }
            excel.Application.Quit();
            return document;
        }
        public bool VerifyDocumentReaded(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.GetDocumentByNumberAndSerial(document) != null ? true : false;
        }
        public int AddDocument(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.AddDocument(document);
        }
        public DocumentModel GetDocumentById(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.GetDocumentById(document);
        }
        public DocumentModel GetSaleDocumentById(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.GetSaleDocumentById(document);
        }
        public List<DocumentModel> GetAllEntryDocuments()
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.GetDocumentByType(new DocumentModel { Type = 'e'});
        }
        public List<DocumentModel> GetAllSaleDocuments()
        {
            DocumentDao documentDao = new DocumentDao();
            return documentDao.GetDocumentByType(new DocumentModel { Type = 's'});
        }
        public List<DocumentModel> GetDocumentsByDate(DateTime from, DateTime to, List<DocumentModel> documents)
        {
            List<DocumentModel> docs = new List<DocumentModel>();
            foreach(DocumentModel document in documents)
            {
                if (document.Registration.Date >= from && document.Registration.Date <= to)
                    docs.Add(document);
            }

            return docs;
        }
        public DateTime GetLowestDocumentDate(List<DocumentModel> documents)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach(DocumentModel document in documents)
                dates.Add(document.Registration.Date);

            dates.Sort();
            return dates[0];
        }
        public DateTime GetHighestDocumentDate(List<DocumentModel> documents)
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (DocumentModel document in documents)
                dates.Add(document.Registration.Date);

            dates.Sort();
            return dates[dates.Count - 1];
        }
        public void UpdateDocument(DocumentModel document)
        {
            DocumentDao documentDao = new DocumentDao();
            documentDao.UpdateDocumentById(document);
        }

        public static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)

                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }
    }
}
