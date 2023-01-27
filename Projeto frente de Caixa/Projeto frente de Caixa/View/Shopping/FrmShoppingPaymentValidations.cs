using Microsoft.Office.Interop.Excel;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.View.Shopping
{
    public partial class FrmShoppingPaymentValidations : Form
    {
        CardModel card;
        DocumentModel document;
        FrmModes frmModes;
        public FrmShoppingPaymentValidations(FrmModes modes, CardModel _card, DocumentModel _document)
        {
            InitializeComponent();
            frmModes = modes;
            card = _card;
            document = _document;
            FillFields();
        }
        private void FillFields()
        {
            lblOwner.Text = card.Owner;
            lblNumber.Text = card.Number;
            lblCvv.Text = card.Cvv.ToString();
            lblExpirationDate.Text = card.ExpirationDate.ToString("MM/yyyy");

            
            lblValue.Text = String.Format("{0:C}", card.Amount.ToString());
            lblType.Text = card.Type == 'c' ? "LIMITE DISPONÍVEL" : "SALDO";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (ValidatePayment())
            {
                //Baixar do estoque;
                CardControll cardControll = new CardControll();
                cardControll.RemoveAmount(card, document.TotalValue);

                document.Registration.Date = DateTime.Now;
                document.Registration.Hour = DateTime.Now;
                document.Registration.Item = "Documento de saída";
                document.Registration.Type = ActivityType.Sell;

                ActivityControll activityControll = new ActivityControll();
                activityControll.UpdateSystemActivity(document.Registration);

                ItemControll itemControll = new ItemControll();
                foreach(ItemModel item in document.Items)
                {
                    itemControll.RemoveItemAmount(item);
                }

                ItemXDocumentControll itemXDocumentControll = new ItemXDocumentControll();
                itemXDocumentControll.AddItems(document.Items, document);

                FrmShoppingSaleDocument frmShoppingSaleDocument = new FrmShoppingSaleDocument(frmModes,document, card);
                frmShoppingSaleDocument.Show();
                this.Close();
            }
            else
            {
                string message = "Não foi possivel concluir o pagamento da compra. \nPor favor escolha outra forma de pagamento para proseguir";
                FrmShoppingInvalidPayment frmShoppingInvalidPayment = new FrmShoppingInvalidPayment(frmModes, document, message);
                frmShoppingInvalidPayment.Show();
                this.Close();
            }

        }

        private bool ValidatePayment()
        {
            if (card.Amount < document.TotalValue)
                return false;

            return true;
        }
    }
}
