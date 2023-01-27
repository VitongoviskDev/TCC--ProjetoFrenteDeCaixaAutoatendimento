using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.View.Administrator.Storage
{
    public partial class FrmAdministrativeViewStorage : Form
    {
        List<ItemModel> allItems;
        Dictionary<string, int> itemIdByIndex;
        DataGridViewRow selectedRow;
        public FrmAdministrativeViewStorage()
        {
            InitializeComponent();
        }

        private void FrmAdministrativeViewStorage_Load(object sender, EventArgs e)
        {
            allItems = FetchItems();
            UpdateDataGridView(allItems);
            lblEntryTotalValue.Text = String.Format("{0:C}", GetEntryTotalValue()) ;
            lblSaleTotalValue.Text = String.Format("{0:C}", GetSaleTotalValue()) ;
        }
        private decimal GetEntryTotalValue()
        {
            decimal totalValue = 0;
            foreach (ItemModel item in allItems)
                totalValue += item.TotalValue;

            return totalValue;
        }
        private decimal GetSaleTotalValue()
        {
            decimal totalValue = 0;
            ProductControll productControll = new ProductControll();
            foreach (ItemModel item in allItems)
            {
                int id = productControll.GetProductIdByBarCode(item.Product);
                totalValue += productControll.GetProductById(new ProductModel() { Id = id }).Price * item.Amount;
            }

            return totalValue;
        }
        private List<ItemModel> FetchItems()
        {
            ItemControll itemControll = new ItemControll();
            return itemControll.GetAllItems();
        }
        private void UpdateDataGridView(List<ItemModel> items)
        {
            dgvStorage.Rows.Clear();

            if (items.Count == 0)
            {
                lblFetchItems.Text = "Nenhum item encontrado no estoque";
                return;
            }

            int counter = 1;
            itemIdByIndex = new Dictionary<string, int>();
            ProductControll productControll = new ProductControll();
            foreach (ItemModel item in items)
            {
                int id = productControll.GetProductIdByBarCode(item.Product);
                ProductModel product = productControll.GetProductById(new ProductModel() { Id = id });

                itemIdByIndex.Add(counter.ToString(), item.Id); 
                dgvStorage.Rows.Add(counter,item.Product.BarCode, product.Description, String.Format("{0:C}", item.Product.Price), String.Format("{0:C}", product.Price), item.Amount, product.StorageLevelAlert);
                if (item.Amount <= product.StorageLevelAlert)
                    dgvStorage.Rows[dgvStorage.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Crimson;
                counter++;
            }
            lblFetchItems.Visible = false;
        }

        private void dgvStorage_SizeChanged(object sender, EventArgs e)
        {
            int unit = dgvStorage.Width / 100;

            clmIndex.Width = unit * 5;
            clmBarCode.Width = unit * 15;
            clmDescription.Width = unit * 40;
            clmEntryValue.Width = unit * 10;
            clmUnitaryValue.Width = unit * 10;
            clmAmount.Width = unit * 10;
            clmStorageLevelAlert.Width = unit * 10;
        }

        private void dgvStorage_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStorage.SelectedCells.Count > 0)
                dgvStorage.Rows[dgvStorage.SelectedCells[0].RowIndex].Selected = true;
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            List<ItemModel> filteredItems = new List<ItemModel>();
            foreach (ItemModel item in allItems)
            {
                if (item.Product.Code.ToString().ToLower().Contains(txtSearch.Texts.Trim().ToLower()) ||
                    item.Product.Description.ToLower().Contains(txtSearch.Texts.Trim().ToLower()) ||
                    item.Product.BarCode.ToLower().Contains(txtSearch.Texts.Trim().ToLower()))
                {
                    filteredItems.Add(item);
                }
            }
            UpdateDataGridView(filteredItems);
        }

        private void FrmAdministrativeViewStorage_SizeChanged(object sender, EventArgs e)
        {
            int width = (Width - 120) / 2;
            pnEntryTotalValue.Width = width;
            pnSaleTotalValue.Width = width;
            pnSaleTotalValue.Location = new Point(pnEntryTotalValue.Location.X + pnSaleTotalValue.Width + 20, pnSaleTotalValue.Location.Y);
        }
    }
}
