using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping
{
    public partial class FrmShoppingSaleDocument : Form
    {
        DocumentModel docuemnt;
        CardModel card;
        FrmModes frmModes;
        public FrmShoppingSaleDocument(FrmModes parent, DocumentModel _document, CardModel _card)
        {
            InitializeComponent();
            docuemnt = _document;
            card = _card;
            frmModes = parent;
        }

        private void frmShoppingSaleDocument_Load(object sender, EventArgs e)
        {
            lblFantasyName.Text = docuemnt.Company.FantasyName;
            lblCnpj.Text += docuemnt.Company.Cnpj;
            lblStateRegistration.Text += docuemnt.Company.StateRegistration;
            lblDate.Text = docuemnt.EmissionDate.ToString("dd/MM/yyyy");

            if (!string.IsNullOrEmpty(docuemnt.Cpf))
            {
                lblCpf.Visible = true;
                lblCpf.Text += Convert.ToUInt64(docuemnt.Cpf).ToString(@"000\.000\.000\-00");
            }


            FillDataGridView(docuemnt.Items);

            lblTotalValue.Text = docuemnt.TotalValue.ToString();
            lblPaymentType.Text = card.Type == 'c' ? "crédito" : "débito";
            lblPaymentTypeTotalValue.Text = docuemnt.TotalValue.ToString();
        }

        private void FillDataGridView(List<ItemModel> items)
        {
            int counter = 1;
            foreach(ItemModel item in items)
            {
                dgvItems.Rows.Add(counter, item.Product.Code, item.Amount, item.Product.Unity, item.Product.Price, item.St, item.TotalValue);
                if (counter * 30 + 22 > dgvItems.MinimumSize.Height)
                {
                    pnDocument.Height += 30;
                    dgvItems.Height += 30;
                }
                counter++;
            }
        }

        int timerCounter = 10; //seconds
        private void tmTimer_Tick(object sender, EventArgs e)
        {
            if (timerCounter == 0)
            {
                FrmShoppingStartSession frmShoppingStartSession = new FrmShoppingStartSession(frmModes);
                frmShoppingStartSession.Show();
                this.Close();
                tmTimer.Stop();
            }
            timerCounter--;
        }
    }
}
