using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    public partial class FrmAdministrativeAddProduct : Form
    {
        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;
        private Color correct_border_color = Color.LimeGreen;

        ProductModel editProduct;
        List<ItemModel> editProductList;

        FrmAdministrativeMain frmAdministrativeMain;
        DocumentModel document;

        bool addMultiple = false;
        public FrmAdministrativeAddProduct(FrmAdministrativeMain parent, ProductModel product)
        {
            InitializeComponent();
            editProduct = product;
            frmAdministrativeMain = parent;
        }
        public FrmAdministrativeAddProduct(FrmAdministrativeMain parent, List<ItemModel> products, DocumentModel _document)
        {
            InitializeComponent();
            editProductList = products;
            document = _document;
            frmAdministrativeMain = parent;
            addMultiple = true;
        }

        private void FrmAdmUpdateProduct_Load(object sender, EventArgs e)
        {
            FillFields();
        }

        private void FrmAdmUpdateProduct_SizeChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewProducts(frmAdministrativeMain));
        }



        #region Text_Changed
        private void txtCode__TextChanged(object sender, EventArgs e)
        {
            txtCode.BorderColor = normal_border_color;
            lblWrongCode.Visible = false;
        }

        private void txtDescription__TextChanged(object sender, EventArgs e)
        {
            txtDescription.BorderColor = normal_border_color;
            lblWrongDescription.Visible = false;
        }

        private void txtPrice__TextChanged(object sender, EventArgs e)
        {
            txtPrice.BorderColor = normal_border_color;
        }
        private void txtStorageLevelAlert__TextChanged(object sender, EventArgs e)
        {
            txtStorageLevelAlert.BorderColor = normal_border_color;
        }
        #endregion

        #region Focus_Leave
        private void txtCode_Leave(object sender, EventArgs e)
        {
            ValidateCode();
        }
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            ValidateDescription();
        }
        private void txtPrice_Leave(object sender, EventArgs e)
        {
            ValidatePrice();
        }
        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            if (ValidateBarCode())
                SetBarCode();
        }
        #endregion

        #region Key_Press
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789,".Contains(e.KeyChar))
                e.Handled = true;

            if (txtPrice.Texts.Contains(','))
            {
                if (e.KeyChar == ',')
                    e.Handled = true;

                int index = txtPrice.Texts.IndexOf(',');

                if (txtPrice.CursorIndex > index && txtPrice.Texts.Length >= index + 3)
                    e.Handled = true;

                if (txtPrice.CursorIndex <= index && index == 5)
                    e.Handled = true;
            }
            else
            {
                if (txtPrice.Texts.Length == 5)
                {
                    e.Handled = true;
                    txtPrice.Texts += $",{e.KeyChar}";
                    txtPrice.CursorIndex = txtPrice.Texts.Length;
                }
            }
        }

        //Panel2

        private void txtHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }

        private void txtStand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }

        private void txtShelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }

        private void txtSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }

        private void txtStorageLevelAlert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }

        private void txtStorageAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region CustomMethods

        private void FillFields()
        {
            if (addMultiple)
                 editProduct = editProductList[0].Product;

            editProduct.Description = editProduct.Description;
            editProduct.BarCode = editProduct.BarCode;

            txtDescription.Focus();
            txtDescription.Texts = editProduct.Description;

            lblBarCode.Text = editProduct.BarCode;
            SetBarCode();

            txtCode.Focus();
            ProductControll productControll = new ProductControll();
            txtCode.Texts = (productControll.GetNextCode() + 1).ToString();

            if (addMultiple)
            {
                Text = "Adicionar produtos";
                return;
            }

            txtCode.Focus();
            txtCode.Texts = editProduct.Code.ToString();

            txtPrice.Focus();
            txtPrice.Texts = editProduct.Price.ToString();


            txtStorageLevelAlert.Focus();
            txtStorageLevelAlert.Texts = editProduct.StorageLevelAlert.ToString();
        }
        private void UpdateProduct() {

            editProduct.Code = int.Parse(txtCode.Texts);
            editProduct.Description = txtDescription.Texts.ToUpper();
            editProduct.Price = decimal.Parse(txtPrice.Texts);

            ActivityControll activityControll = new ActivityControll();
            ActivityModel activity = new ActivityModel();
            activity.Date = DateTime.Now;
            activity.Hour = DateTime.Now;
            activity.Item = $"{editProduct.Code} - {editProduct.Description}";
            activity.User = frmAdministrativeMain.logedUser;
            activity.Type = addMultiple ? ActivityType.Created : ActivityType.Updated;
            activity.Id = activityControll.AddActivity(activity);

            editProduct.LastUpdated = activity;

            editProduct.StorageLevelAlert = int.Parse(txtStorageLevelAlert.Texts);
            editProduct.Status = true;
            editProduct.Unity = "UN";
            editProduct.Id = editProduct.Id;

            ProductControll productControll = new ProductControll();
            if (addMultiple)
            {
                editProduct.Added = activity;
                productControll.AddProdcut(editProduct);
            }
            else
                productControll.UpdateProduct(editProduct);
        }

        #region VALIDATIONS
        //-----panel1-----//
        private bool ValidateFileds()
        {
            if (!ValidateCode())
                return false;

            if (!ValidateDescription())
                return false;

            if (!ValidateStorageAlert())
                return false;

            return true;
        }
        private bool ValidateCode()
        {
            bool valid = true;
            ProductControll productControll = new ProductControll();
            if (string.IsNullOrEmpty(txtCode.Texts))
                valid  = false;
            else
            {
                int id = productControll.GetProductIdByCode(new ProductModel() { Code = int.Parse(txtCode.Texts) });
                if (!productControll.ValidateCode(new ProductModel() { Code = int.Parse(txtCode.Texts) }))
                    valid = false;
                else if (id > -1 && ((addMultiple && id > 0) || (!addMultiple && id != editProduct.Id)))
                {
                    lblWrongCode.Text = "Este código já está sendo ultilizado";
                    lblWrongCode.Visible = true;
                    valid = false;
                }
            }
            if (!valid)
            {
                txtCode.BorderColor = wrong_border_color;
            }

            return valid;
        }
        private bool ValidateDescription()
        {
            ProductControll productControll = new ProductControll();
            int id = productControll.GetProductIdByDescription(new ProductModel() { Description = txtDescription.Texts });

            if (string.IsNullOrEmpty(txtDescription.Texts.Trim()))
            {
                txtDescription.BorderColor = wrong_border_color;
                return false;
            }
            else if(id > 0 && ((addMultiple && id > 0) || (!addMultiple && id != editProduct.Id)))
            {
                txtDescription.BorderColor = wrong_border_color;
                lblWrongDescription.Visible = true;
                return false;
            }

            return true;
        }
        private bool ValidatePrice()
        {
            if (string.IsNullOrEmpty(txtPrice.Texts))
            {
                txtPrice.BorderColor = wrong_border_color;
                return false;
            }
            return true;
        }
        private bool ValidateBarCode()
        {
            ProductControll productControll = new ProductControll();
            int id = productControll.GetProductIdByBarCode(new ProductModel() { BarCode = editProduct.BarCode });
            if (!productControll.ValidateBarCode(new ProductModel() { BarCode = editProduct.BarCode }))
            {
                lblWrongBarCode.ForeColor = wrong_border_color;
            }
            else if (id != editProduct.Id && id > 0)
            {
                lblWrongBarCode.Text = "Este código de barras já foi cadastrado";
                lblWrongBarCode.Visible = true;
                return false;
            }

            return true;
        }
        private bool ValidateStorageAlert()
        {
            ProductControll productControll = new ProductControll();
            string message = string.Empty;

            if (!productControll.ValidateStorageAlert(new ProductModel() { StorageLevelAlert = int.Parse(txtStorageLevelAlert.Texts)}, out message))
            {
                txtCode.BorderColor = wrong_border_color;
                if (message != ".")
                {
                    lblWrongStorageLevelAlert.Text = message;
                    lblWrongCode.Visible = true;
                    return false;
                }
            }

            return true;
        }
        #endregion

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e) {
            if (ValidateFileds()) {
                UpdateProduct();

                if (addMultiple)
                {
                    ItemControll itemControll = new ItemControll();
                    editProductList[0].Id = itemControll.AddItem(editProductList[0]);

                    ItemXDocumentControll itemXDocumentControll = new ItemXDocumentControll();
                    itemXDocumentControll.AddItem(editProductList[0], document);

                    editProductList.Remove(editProductList[0]);

                    if (editProductList.Count > 0)
                    {
                        frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddProduct(frmAdministrativeMain, editProductList, document));
                    }
                    else
                    {
                        frmAdministrativeMain.ValidateStorageLevelAlert();
                        frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewEntrys(frmAdministrativeMain));
                    }
                }
                else
                    frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewProducts(frmAdministrativeMain));
            }
        }
        private void SetBarCode()
        {
            ProductControll productControll = new ProductControll();
            Image barCodeImage = productControll.GenerateBarCodeImage(editProduct.BarCode, 3);
            pbBarCode.Image = barCodeImage;

            pbBarCode.Width = barCodeImage.Width;
            pbBarCode.Location = new Point((Width - pbBarCode.Width) / 2, pbBarCode.Location.Y);
            pbBarCode.Width = pbBarCode.Image.Width;


            pbBarCode.Visible = true;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnUpdate.PerformClick();
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789,".Contains(e.KeyChar))
                e.Handled = true;
        }

    }
}
