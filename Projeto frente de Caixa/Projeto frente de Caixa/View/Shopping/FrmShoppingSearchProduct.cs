using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping {
    public partial class FrmShoppingSearchProduct : Form {

        FrmShoppingMain frmShoppingMain;
        DataGridViewRow selectedRow;
        Dictionary<int, ItemModel> itemByIndex;
        ItemModel selectedItem = null;

        List<ItemModel> allItems = new List<ItemModel>();

        FrmShoppingKeyboard frmShoppingKeyboard;
        public FrmShoppingSearchProduct(FrmShoppingMain parent) {
            InitializeComponent();
            frmShoppingMain = parent;
        }
        
        private void FrmSearchProduct_Load(object sender, EventArgs e) {
            Width = frmShoppingMain.Width - 80;
            Height = frmShoppingMain.Height - 80;
            Location = new Point(40, 40);

            ItemControll itemControll = new ItemControll();
            allItems = itemControll.GetAllItems();
            if(allItems.Count > 0)
            {
                lblNoProducts.Visible = false;
                UpdateDataGridView(allItems);
            }
            else
                lblNoProducts.Visible = true;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            frmShoppingMain.Enabled = true;
            if (frmShoppingKeyboard != null)
                frmShoppingKeyboard.Close();
            this.Close();
        }
        private void UpdateDataGridView(List<ItemModel> items)
        {
            int counter = 1;
            dgvProductsList.Rows.Clear();

            ItemControll itemControll = new ItemControll();
            ProductControll productControll = new ProductControll();
            itemByIndex = new Dictionary<int, ItemModel>();
            foreach (ItemModel item in items)
            {
                int id = productControll.GetProductIdByBarCode(item.Product);
                ProductModel product = productControll.GetProductById(new ProductModel() { Id = id });

                int itemsAmount = itemControll.GetItemAmonut(frmShoppingMain.allItems, item);

                if (item.Amount > itemsAmount && product.Status)
                {
                    itemByIndex.Add(counter, item);
                    dgvProductsList.Rows.Add(counter, item.Product.Description, item.Product.Price, item.Product.BarCode);
                    counter++;
                }
            }
        }

        private void dgvProductsList_SizeChanged(object sender, EventArgs e) {

            int dgvWidthUnity = dgvProductsList.Width / 100;

            clmProduto.Width = dgvWidthUnity * 50;
            clmId.Width = dgvWidthUnity * 2;
            clmValUnit.Width = dgvWidthUnity * 18;
            clmBarCode.Width = dgvWidthUnity * 30;
        }

        private void dgvProductsList_SelectionChanged(object sender, EventArgs e) {
            if (dgvProductsList.SelectedCells.Count > 0) {
                selectedRow = dgvProductsList.Rows[dgvProductsList.SelectedCells[0].RowIndex];

                if (dgvProductsList.SelectedCells[0].Value.ToString() == "Deletar") {
                    dgvProductsList.SelectedCells[0].Selected = false;
                    return;
                }

                selectedRow.Selected = true;
                selectedItem = itemByIndex[(int)selectedRow.Cells[0].Value];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            frmShoppingMain.AddItemToList(selectedItem);
            frmShoppingMain.Enabled = true;
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (frmShoppingKeyboard != null) frmShoppingKeyboard.Close();

            frmShoppingKeyboard = new FrmShoppingKeyboard(txtSearch);
            frmShoppingKeyboard.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<ItemModel> filteredItems = new List<ItemModel>();
            foreach (ItemModel item in allItems)
            {
                if (item.Product.BarCode.ToLower().Contains(txtSearch.Text.Trim().ToLower()) ||
                    item.Product.Description.ToLower().Contains(txtSearch.Text.Trim().ToLower()))
                {
                    filteredItems.Add(item);
                }
            }
            if(filteredItems.Count > 0)
                UpdateDataGridView(filteredItems);
        }
    }
}
