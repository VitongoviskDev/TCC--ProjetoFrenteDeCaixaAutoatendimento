using MySqlX.XDevAPI.Relational;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping {
    public partial class FrmShoppingMain : Form {


        Dictionary<int, ItemModel> itemByIndex = new Dictionary<int, ItemModel>();
        ItemModel selectedItem = null;
        DataGridViewRow selectedRow;

        public List<ItemModel> allItems = new List<ItemModel>();

        DocumentModel document;
        FrmModes frmModes;

        const int PRODUCT_NOT_FOUND_LABEL_COUNTER = 3;
        int productNotFoundLabelTime = 3;

        public FrmShoppingMain(FrmModes modes, DocumentModel doc){
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            txtBarCode.Focus();

            frmModes = modes;

            string formattedMoneyValue = String.Format("{0:C}", CalculateTotalValue());
            lblTotalValue.Text = formattedMoneyValue;

            DocumentControll documentControll = new DocumentControll();
            document = documentControll.CreateNewSaleDocument(doc);

        }
        private void FrmShoppingMain_Load(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }

        #region Click
        private void btnSearchProduct_Click(object sender, EventArgs e) {
            FrmShoppingSearchProduct frmShoppingSearchProduct = new FrmShoppingSearchProduct(this);
            frmShoppingSearchProduct.Show();
            this.Enabled = false;

            txtBarCode.Focus();
        }
        #endregion

        #region DataGridView
        private void dgvShoppingList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvShoppingList.Columns[e.ColumnIndex].Name == clmDelete.Name && e.RowIndex > -1) {
                RemoveItemFromList(selectedItem);
            }
        }

        private void dgvShoppingList_SizeChanged(object sender, EventArgs e) {
            int dgvWidthUnity = dgvShoppingList.Width / 100;
            clmProduto.Width = dgvWidthUnity * 50;
            clmValUnit.Width = dgvWidthUnity * 20;
            clmDelete.Width = dgvWidthUnity * 20;
            clmId.Width = dgvWidthUnity * 10;
            clmDelete.UseColumnTextForButtonValue = true;
        }
        private void dgvShoppingList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShoppingList.SelectedCells.Count > 0) {
                pnSelectedtem.Visible = true;
                selectedRow = dgvShoppingList.Rows[dgvShoppingList.SelectedCells[0].RowIndex];

                if (dgvShoppingList.SelectedCells[0].Value.ToString() == "Deletar") {
                    dgvShoppingList.SelectedCells[0].Selected = false;
                    return;
                }

                selectedRow.Selected = true;


                ProductControll productControll = new ProductControll();
                selectedItem = allItems[(int)selectedRow.Cells[0].Value -1];



                lblProductDescription.Text = selectedItem.Product.Description;
                lblUnitaryValue.Text = String.Format("{0:C}", selectedItem.Product.Price);
                lblProductBarCode.Text = selectedItem.Product.BarCode;
            } else
                pnSelectedtem.Visible = false;

            if (dgvShoppingList.Rows.Count > 0) {
                pnEmptyList.Visible = false;
            }
        }
        #endregion

        #region txtBarCode
        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ItemControll itemControll = new ItemControll();
                ItemModel item = new ItemModel();

                item.Product = new ProductModel() { BarCode = txtBarCode.Text };
                item = itemControll.GetItemByProductBarCode(item);

                ProductControll productControll = new ProductControll();
                int id =  productControll.GetProductIdByBarCode(item.Product);
                ProductModel product = productControll.GetProductById(new ProductModel() { Id = id });

                if (item.Id > 0 && item.Amount > 0 && product.Status)
                {
                    AddItemToList(item);
                }
                else
                {
                    lblNotFoundProduct.Visible = true;
                    lblNotFoundProduct.Text = "Produto não encontrado";
                    tmNotFoundProductLabel.Start();
                }

                txtBarCode.Text = "";
            }
        }
        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }
        #endregion

        #region CustomMethods
        private decimal CalculateTotalValue()
        {
            decimal totalValue = 0;

            foreach (ItemModel item in allItems)
                totalValue += item.TotalValue;

            return totalValue;
        }
        public void AddItemToList(ItemModel item)
        {
            if (item == null)
                return;
            ItemControll itemControll = new ItemControll();
            int itemsAmount = itemControll.GetItemAmonut(allItems, item);

            if (itemsAmount >= item.Amount)
                return;

            item.TotalValue = item.Product.Price;
            item.Amount = 1;



            allItems.Add(item);
            UpdateDataGridView(allItems);

            int rows = dgvShoppingList.Rows.Count;
            if (rows > 0)
                dgvShoppingList.Rows[rows - 1].Selected = true;

            pnEmptyList.Visible = false;
            string formattedMoneyValue = String.Format("{0:C}", CalculateTotalValue());
            lblTotalValue.Text = formattedMoneyValue;

            btnPayment.Enabled = true;
        }
        public void RemoveItemFromList(ItemModel item)
        {
            if (item == null)
                return;

            allItems.Remove(item);
            UpdateDataGridView(allItems);
            int rows = dgvShoppingList.Rows.Count;
            if(rows > 0)
                dgvShoppingList.Rows[rows - 1].Selected = true;
            else
            {
                pnEmptyList.Visible = true;
                btnPayment.Enabled = false;
            }

            string formattedMoneyValue = String.Format("{0:C}", CalculateTotalValue());
            lblTotalValue.Text = formattedMoneyValue;
        }
        private void UpdateDataGridView(List<ItemModel> items)
        {
            dgvShoppingList.Rows.Clear();
            if (items.Count == 0) return;

            int counter = 1;
            itemByIndex = new Dictionary<int, ItemModel>();
            foreach (ItemModel item in items)
            {
                itemByIndex.Add(counter, item);
                dgvShoppingList.Rows.Add(counter, item.Product.Description, String.Format("{0:C}", item.Product.Price), "REMOVER");

                counter++;
            }
        }

        #endregion
        #region Overrided Methods
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (Enabled)
                txtBarCode.Focus();
        }
        #endregion

        private void btnPayment_Click(object sender, EventArgs e)
        {
            document.TotalValue = CalculateTotalValue();
            document.Items = allItems;
            document.ItemsAmount = allItems.Count;

            DocumentControll documentControll = new DocumentControll();
            documentControll.UpdateDocument(document);

            FrmShoppingPayment frmShoppingPayment = new FrmShoppingPayment(frmModes, document);
            frmShoppingPayment.WindowState = FormWindowState.Maximized;
            frmShoppingPayment.Show();
            this.Close();
        }
        
        private void tmNotFoundProductLabel_Tick(object sender, EventArgs e)
        {
            if (productNotFoundLabelTime > 0)
                productNotFoundLabelTime--;
            else
            {
                lblNotFoundProduct.Visible = false;
                tmNotFoundProductLabel.Stop();
                productNotFoundLabelTime = PRODUCT_NOT_FOUND_LABEL_COUNTER;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DocumentControll documentControll = new DocumentControll();
            documentControll.DeleteDocumentById(document);

            FrmShoppingStartSession frmShoppingStartSession = new FrmShoppingStartSession(frmModes);
            frmShoppingStartSession.Show();

            this.Close();
        }
    }
}
