using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Control
{
    public class ItemXDocumentControll
    {
        public void AddItems(List<ItemModel> items, DocumentModel document)
        {
            foreach(ItemModel item in items)
                AddItem(item, document);
        }
        public void AddItem(ItemModel item, DocumentModel document)
        {
            ItemXDocumentDao itemXDocumentDao = new ItemXDocumentDao();
            itemXDocumentDao.AddItem(item, document);
        }
        public List<ItemModel> GetItemsByDocumentId(DocumentModel document)
        {
            ItemXDocumentDao itemXDocumentDao = new ItemXDocumentDao();
            ItemDao itemDao = new ItemDao();

            List<int> ids = itemXDocumentDao.GetItemsIDsByDocumentId(document);
            List<ItemModel> items = new List<ItemModel>();
            foreach (int id in ids)
            {
                ItemModel item = itemDao.GetItemById(new ItemModel() { Id = id});
                items.Add(item);
            }

            return items;
        }
        public List<ItemModel> GetSaleItemsByDocumentId(DocumentModel document)
        {
            ItemXDocumentDao itemXDocumentDao = new ItemXDocumentDao();
            ItemDao itemDao = new ItemDao();

            List<int> ids = itemXDocumentDao.GetItemsIDsByDocumentId(document);
            List<ItemModel> items = new List<ItemModel>();
            foreach (int id in ids)
            {
                ItemModel item = itemDao.GetItemById(new ItemModel() { Id = id});
                item.TotalValue = itemXDocumentDao.GetItemTotalValueByIdAndDocumentId(new ItemModel() { Id = id}, document);
                items.Add(item);
            }

            return items;
        }

        public List<ItemModel> GetAllEntryItems()
        {
            return GetItemsByDocumentType(new DocumentModel { Type = 'e' });
        }
        public List<ItemModel> GetAllSaleItems()
        {
            return GetItemsByDocumentType(new DocumentModel { Type = 's'});
        }

        private List<ItemModel> GetItemsByDocumentType(DocumentModel document)
        {
            ItemXDocumentDao itemXDocumentDao = new ItemXDocumentDao();
            ItemDao itemDao = new ItemDao();

            List<int> ids = itemXDocumentDao.GetItemsIDsByDocumentType(document);
            List<ItemModel> items = new List<ItemModel>();
            foreach (int id in ids)
            {
                ItemModel item = itemDao.GetItemById(new ItemModel() { Id = id });
                items.Add(item);
            }

            return items;
        }
        public int GetItemAmountByIdAndDocumentId(ItemModel item, DocumentModel document)
        {
            ItemXDocumentDao itemXDocumentDao = new ItemXDocumentDao();
            return itemXDocumentDao.GetItemAmountByIdAndDocumentId(item, document);
        }
    }
}
