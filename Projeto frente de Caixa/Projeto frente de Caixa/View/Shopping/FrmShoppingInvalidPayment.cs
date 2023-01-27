using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_frente_de_Caixa.View.Shopping
{
    public partial class FrmShoppingInvalidPayment : Form
    {
        DocumentModel document;

        FrmModes frmModes;
        public FrmShoppingInvalidPayment(FrmModes modes, DocumentModel _document,string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            frmModes = modes;
            document = _document;
        }

        private void btnChoosePayment_Click(object sender, EventArgs e)
        {
            FrmShoppingPayment frmShoppingPayment = new FrmShoppingPayment(frmModes, document);
            frmShoppingPayment.Show();
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
    }
}
