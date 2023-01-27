using GenCode128;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ubiety.Dns.Core.Records.NotUsed;

namespace Projeto_frente_de_Caixa.Control
{
    public class ProductControll
    {
        public List<ProductModel> GetAllProductsForAdmList()
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetAllProductsForAdminView();
        }
        public ProductModel GetProductById(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetProductById(product);
        }
        public int GetProductIdByDescription(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            product.Description = product.Description.ToUpper();
            return productDao.GetProductIdByDescription(product);
        }
        public int GetProductIdByBarCode(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetProductIdByBarCode(product);
        }
        public int GetProductIdByCode(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetProductIdByCode(product);
        }
        public List<ProductModel> GetActiveProducts()
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetActiveProducts();
        }

        public void DisableProduct(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            product.Status = false;

            productDao.UpdateProduct(product);
        }
        public void EnableProduct(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            product.Status = true;

            productDao.UpdateProduct(product);
        }

        public void AddProdcut(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            productDao.AddProdcut(product);
        }
        public void UpdateProduct(ProductModel product)
        {
            ProductDao productDao = new ProductDao();
            productDao.UpdateProduct(product);
        }
        public bool ValidateBarCode(ProductModel product)
        {
            if (string.IsNullOrEmpty(product.BarCode))
                return false;
            return true;
        }

        public int GetNextCode()
        {
            ProductDao productDao = new ProductDao();
            return productDao.GetLastCode();
        }
        #region VALIDATIONS
        public bool ValidateDescription(ProductModel product)
        {
            if (string.IsNullOrEmpty(product.Description))
                return false;

            return true;
        }
        public bool ValidateCode(ProductModel product)
        {
            if (product.Code <= 0)
                return false;

            return true;
        }
        public bool ValidateStorageAlert(ProductModel product, out string message)
        {
            message = ".";
            if (product.StorageLevelAlert < 0)
            {
                message = "O valor deve ser maior que 0";
                return false;
            }
            if(product.StorageLevelAlert == 0)
            {

                message = "O alerta não será disparado se o valor for 0";
                return true;
            }

            return true;
        }

        public Image GenerateBarCodeImage(string barCode, int size)
        {
            return Code128Rendering.MakeBarcodeImage(barCode, size, true);
        }
        #endregion
    }
}
