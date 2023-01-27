using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    public partial class FrmProductDetails : Form
    {
        ProductModel product;
        Form parentForm;
        public FrmProductDetails(ProductModel prod, Form form)
        {
            InitializeComponent();
            product = prod;
            parentForm = form;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductDetails_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            //Tittle
            lblProductName.Text = product.Code + " - " + product.Description;
            lblProductName.Location = new Point((Width - lblProductName.Width) / 2, lblProductName.Location.Y);

            //Added
            lblUserAdded.Text = product.Added.User.Name;
            lblUserAdded.Location = new Point(30, lblUserAdded.Location.Y);
            pnUserAdded.Width = 30 + lblUserAdded.Width;
            pnUserAdded.Location = new Point((pnAddded.Width - pnUserAdded.Width) / 2, pnUserAdded.Location.Y);

            lblDateAdded.Text = product.Added.Date.ToString("dd/MM/yyyy");
            lblDateAdded.Location = new Point(30, lblDateAdded.Location.Y);
            pnDateAdded.Width = 30 + lblDateAdded.Width;
            pnDateAdded.Location = new Point(pnUserAdded.Location.X, pnDateAdded.Location.Y);

            lblHourAdded.Text = product.Added.Hour.ToString("HH:mm");
            lblHourAdded.Location = new Point(30, lblHourAdded.Location.Y);
            pnHourAdded.Width = 30 + lblHourAdded.Width;
            pnHourAdded.Location = new Point(pnUserAdded.Location.X, pnHourAdded.Location.Y);

            //Update
            if(product.LastUpdated != null)
            {
                lblUserUpdated.Text = product.LastUpdated.User.Name;

                lblDateUpdated.Text = product.LastUpdated.Date.ToString("dd/MM/yyyy");

                lblHourUpdated.Text = product.LastUpdated.Hour.ToString("HH:mm");

                lblDescriptionUpdated.Text = ActivityControll.GetDescription(product.LastUpdated);

            }

            //Data

            ItemControll itemControll = new ItemControll();
            ItemModel item = itemControll.GetItemByProductBarCode(new ItemModel() { Product = product });

            lblCode.Text = String.Format("{0:00000}", product.Code);
            lblPrice.Text = "R$" + product.Price.ToString("#.00");
            lblStatus.Text = product.Status ? "ativo" : "inativo";
            lblStorageLevelAlert.Text = product.StorageLevelAlert.ToString();
            lblStorageAmount.Text = item.Amount.ToString();
            lblBarCode.Text = product.BarCode;

        }

        private void FrmProductDetails_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            parentForm.Enabled = true;
        }
    }
}
