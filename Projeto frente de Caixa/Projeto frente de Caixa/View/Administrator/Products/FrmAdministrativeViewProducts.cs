using Org.BouncyCastle.Utilities.Collections;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    public partial class FrmAdministrativeViewProducts : Form
    {
        DataGridViewRow selectedRow;
        List<ProductModel> AllProducts;
        ProductModel selectedProduct = null;
        Dictionary<string, int> productIdByIndex;

        FrmAdministrativeMain frmAdministrativeMain;
        FrmProductDetails frmProductDetails;
        public FrmAdministrativeViewProducts(FrmAdministrativeMain frmParent)
        {
            InitializeComponent();

            frmAdministrativeMain = frmParent;
        }

        private void SetToolBarLayout()
        {
            pnToolBar.Width = Width - 100;
            pnToolBar.Location = new Point(50, pnToolBar.Location.Y);

            btnEdit.Visible = false;
            btnChangeStatus.Visible = false;

            pnSearchBar.Width = pnToolBar.Width - 10;
            pnSearchBar.Location = new Point(5, pnSearchBar.Location.Y);

        }

        private void dgvShoppingList_SizeChanged(object sender, EventArgs e)
        {
            int unit = dgvProducts.Width / 100;

            clmIndex.Width = 5 * unit;
            clmCode.Width = 10 * unit; 
            clmDescription.Width =  40 * unit; 
            clmPrice.Width = 15 * unit;
            clmBarCode.Width = 20 * unit;
            clmStatus.Width = 5 * unit;
            clmInfo.Width = 5 * unit;
        }
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                string index = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                ProductControll productControll = new ProductControll();
                frmProductDetails = new FrmProductDetails(productControll.GetProductById(new ProductModel() { Id = productIdByIndex[index] }), this) ;
                frmProductDetails.Show();
                this.Enabled = false;
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedCells.Count > 0)
            {
                selectedRow = dgvProducts.Rows[dgvProducts.SelectedCells[0].RowIndex];

                ProductControll productControll = new ProductControll();
                selectedProduct = productControll.GetProductById(new ProductModel() { Id = productIdByIndex[selectedRow.Cells[0].Value.ToString()] });

                selectedRow.Selected = true;
                if (selectedRow.Cells[6].Value.ToString().ToLower() != "ativo")
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[6].Style.ForeColor = Color.Crimson;

            }
        }
        
        private List<ProductModel> FecthProducts() {
            lblFetchStatus.Visible = true;
            lblFetchStatus.Text = "Procurando produtos...";
            ProductControll productControll = new ProductControll();
            return productControll.GetAllProductsForAdmList();
        }
        private void UpdateDataGridView(List<ProductModel> ListedProducts) {
            dgvProducts.Rows.Clear();
            if (ListedProducts.Count == 0)
            {
                lblFetchStatus.Text = "Nenhum produto encontrado";
                return;
            }
            int counter = 1;
            productIdByIndex = new Dictionary<string, int>();
            foreach (ProductModel product in ListedProducts)
            {
                productIdByIndex.Add(counter.ToString(), product.Id);
                dgvProducts.Rows.Add(counter, String.Format("{0:00000}", product.Code), product.Description, "R$" + product.Price.ToString("#.00"), product.BarCode, product.Status ? "ativo" : "inativo",Properties.Resources.infoDark);
                counter++;
            }
            lblFetchStatus.Visible = false;
        }

        private void FrmAdministrativeViewProducts_Load(object sender, EventArgs e)
        {
            AllProducts = FecthProducts();
            UpdateDataGridView(AllProducts);

            if(frmAdministrativeMain.logedUser.Profile > 0)
            {
                SetToolBarLayout();
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                ProductControll productControll = new ProductControll();
                ProductModel product = productControll.GetProductById(new ProductModel() { Id = productIdByIndex[selectedRow.Cells[0].Value.ToString()] });

                string chageTo = product.Status ? "desativar" : "ativar";
                string index = dgvProducts.Rows[selectedRow.Index].Cells[0].Value.ToString();

                if(product.Status)
                    productControll.DisableProduct(product);
                else
                    productControll.EnableProduct(product);

                int selectedRowIndex = selectedRow.Index;
                UpdateDataGridView(FecthProducts());

                dgvProducts.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                int id = productIdByIndex[selectedRow.Cells[0].Value.ToString()];
                ProductControll productControll = new ProductControll();
                frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddProduct(frmAdministrativeMain, productControll.GetProductById(new ProductModel() { Id = id })));
            }
        }

        private void lblFetchStatus_Paint(object sender, PaintEventArgs e)
        {
            lblFetchStatus.Location = new Point(dgvProducts.Location.X + (dgvProducts.Width - lblFetchStatus.Width) / 2, lblFetchStatus.Location.Y);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e) {

            List<ProductModel> filteredProducts = new List<ProductModel>();
            foreach (ProductModel product in AllProducts)
            {
                if (product.Code.ToString().ToLower().Contains(txtSearch.Texts.Trim().ToLower()) ||
                    product.Description.ToLower().Contains(txtSearch.Texts.Trim().ToLower()) ||
                    product.BarCode.ToLower().Contains(txtSearch.Texts.Trim().ToLower()))
                {
                    filteredProducts.Add(product);
                }
            }
            UpdateDataGridView(filteredProducts);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (frmProductDetails != null)
                frmProductDetails.Close();
        }
    }
}
