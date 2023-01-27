using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using Projeto_frente_de_Caixa.View.Shopping;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_frente_de_Caixa.Control
{
    public class ItemControll
    {
        public ItemModel GetItemByProductBarCode(ItemModel item)
        {
            ItemDao itemDao = new ItemDao();
            return itemDao.GetItemByProductBarCode(item);
        }
        public ItemModel GetItemById(ItemModel item)
        {
            ItemDao itemDao = new ItemDao();
            return itemDao.GetItemById(item);
        }
        public int AddItem(ItemModel item)
        {
            ItemModel m_item = GetItemByProductBarCode(item);
            if (m_item != null)
            {
                AddAmount(m_item, item);
                return m_item.Id;
            }
            else
                return AddNewItem(item);
        }

        public bool RemoveItemAmount(ItemModel item)
        {
            ItemDao itemDao = new ItemDao();
            ItemModel m_item = GetItemByProductBarCode(item);
            m_item.Amount -= item.Amount;
            if (m_item.Amount >= 0)
            {

                ProductControll productControll = new ProductControll();
                int id = productControll.GetProductIdByBarCode(item.Product);
                ProductModel product = productControll.GetProductById(new ProductModel() { Id = id});

                bool send = true;
                if (!VerifyItemStorageLevelAlert(new ItemModel() { Amount = m_item.Amount + item.Amount, Product = new ProductModel() { BarCode = item.Product.BarCode } }))
                    send = false;

                itemDao.UpdateItemById(m_item);

                if (!VerifyItemStorageLevelAlert(item) && send)
                {
                    EmailSender.SendStorageLevelAlertEmail(product);
                }else if(m_item.Amount == 0)
                {
                    ConfigControll configControll = new ConfigControll();
                    if (configControll.GetConfig().SendItemSoldOutEmail)
                        EmailSender.SendStorageLevelZeroEmail(product);
                }

            }
            else
                return false;

            return true;
        }
        public bool VerifyItemStorageLevelAlert(ItemModel item)
        {

            ItemModel m_item = GetItemByProductBarCode(item);

            ProductControll productControll = new ProductControll();
            int id = productControll.GetProductIdByBarCode(item.Product);
            ProductModel product = productControll.GetProductById(new ProductModel() { Id = id });
            
            if (m_item.Amount <= product.StorageLevelAlert)
            {
                return false;
            }

            return true;
        }
        public int VerifyAllItemsStorageLevelAlert()
        {
            ItemDao itemDao = new ItemDao();
            int counter = 0;
            List<ItemModel> items = itemDao.GetAllItems();
            foreach (ItemModel item in items)
                if (!VerifyItemStorageLevelAlert(item))
                    counter ++;

            return counter;
        }
        public List<ItemModel> GetAllItems()
        {
            ItemDao itemDao = new ItemDao();
            return itemDao.GetAllItems();
        }
        public int GetItemAmonut(List<ItemModel> items, ItemModel item)
        {
            List<ItemModel> currentItem = new List<ItemModel>();
            foreach (ItemModel i in items)
            {
                if (i.Id == item.Id)
                    currentItem.Add(i);
            }

            int itemsAmount = 0;
            foreach (ItemModel i in currentItem)
            {
                itemsAmount += i.Amount;
            }

            return itemsAmount;
        }
        //PRIVADOS
        private int AddNewItem(ItemModel item)
        {
            ItemDao itemDao = new ItemDao();
            return itemDao.AddItem(item);
        }
        private void AddAmount(ItemModel item, ItemModel newitem)
        {
            ItemDao itemDao = new ItemDao();
            item.Amount += newitem.Amount;
            item.TotalValue = item.Amount * item.Product.Price;

            itemDao.UpdateItemById(item);
        }
    }
}
