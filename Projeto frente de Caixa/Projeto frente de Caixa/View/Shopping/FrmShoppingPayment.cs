using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Shopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    public partial class FrmShoppingPayment : Form
    {

        CardControll cardControll;
        DocumentModel document;

        FrmModes frmModes;
        public FrmShoppingPayment(FrmModes modes, DocumentModel _document)
        {
            InitializeComponent();
            document = _document;
            frmModes = modes;
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            cardControll = new CardControll();
            CardModel creditCard = cardControll.GetCreditCard();

            OpenPaymentValidationForm(creditCard);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            cardControll = new CardControll();
            CardModel debitCard = cardControll.GetDebitCard();
            OpenPaymentValidationForm(debitCard);
        }
        private void OpenPaymentValidationForm(CardModel card)
        {
            FrmShoppingPaymentValidations frmShoppingPaymentValidations = new FrmShoppingPaymentValidations(frmModes, card, document);
            frmShoppingPaymentValidations.WindowState = FormWindowState.Maximized;
            frmShoppingPaymentValidations.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DocumentControll documentControll = new DocumentControll();
            documentControll.DeleteDocumentById(document);
            FrmShoppingStartSession frmShoppingStartSession = new FrmShoppingStartSession(frmModes);
            frmShoppingStartSession.Show();
            this.Close();
        }

        private void FrmShoppingPayment_Load(object sender, EventArgs e)
        {
            lblTotalValue.Text = String.Format("{0:C}", document.TotalValue);
        }
    }
}
