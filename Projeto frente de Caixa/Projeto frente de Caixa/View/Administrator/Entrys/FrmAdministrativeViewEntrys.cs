using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Entrys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    public partial class FrmAdministrativeViewEntrys : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;

        List<DocumentModel> allDocuments = new List<DocumentModel>();

        Dictionary<string, int> documentIdByIndex = new Dictionary<string, int>();
        Dictionary<string, int> itemIdByIndex = new Dictionary<string, int>();

        DataGridViewRow documentSelectedRow;
        DataGridViewRow itemSelectedRow;

        DocumentModel selectedDocument;
        ItemModel selectedItem;

        public FrmAdministrativeViewEntrys(FrmAdministrativeMain parent)
        {
            InitializeComponent();
            frmAdministrativeMain = parent;

            if (frmAdministrativeMain.logedUser.Profile != 0)
            {
                SetToolBarLayout();
            }
        }

        private void FrmAdministrativeViewEntrys_Load(object sender, EventArgs e)
        {
            allDocuments = FetchDocuments(); 
            if(allDocuments.Count > 0)
            {
                DocumentControll documentControll = new DocumentControll();
                dtpFrom.MinDate = documentControll.GetLowestDocumentDate(allDocuments);
                dtpFrom.Value = dtpFrom.MinDate;
                dtpTo.MaxDate = documentControll.GetHighestDocumentDate(allDocuments);
                dtpTo.Value = dtpTo.MaxDate;
                UpdateDocumentDatagridView(allDocuments);
            }
            else
            {
                lblFetchDocuments.Text = "Nenhum Documento de entrada encontrado";
                lblFetchItems.Text = "Nenhum item encontrado";
            }
        }

        #region Value Changed
        private void FrmAdministrativeViewEntrys_SizeChanged(object sender, EventArgs e)
        {
            pnDtpFrom.Width = pnDtpTo.Location.X - pnDtpFrom.Location.X - 55;
            pnDtpTo.Width = pnDtpFrom.Width;

            dtpTo.Invalidate();
            dtpFrom.Invalidate();

            int heightUnity = pnDgvsHolder.Height / 100;

            pnDgvDocuments.Height = heightUnity * 60;
            pnDgvItems.Height = heightUnity * 40;

            int unit = dgvDocuments.Width / 100;

            clmDocIndex.Width = unit * 5; //5
            clmNumber.Width = unit * 15; //20
            clmSerial.Width = unit * 10; //35
            clmCompany.Width = unit * 10; //45
            clmDate.Width = unit * 30; //75
            clmQtdItems.Width = unit * 15; //90
            clmDocTotalValue.Width = unit * 15; //100

            clmItemIndex.Width = unit * 5; //5
            clmBarCode.Width = unit * 20; //25
            clmItem.Width = unit * 30; //55
            clmPrice.Width = unit * 15; //70
            clmAmount.Width = unit * 10; //80
            clmUnity.Width = unit * 10; //90
            clmItemTotalValue.Width = unit * 10; //100
        }
        private void dgvDocuments_SelectionChanged(object sender, EventArgs e)
        {
            lblFetchItems.Visible = true;
            if (dgvDocuments.SelectedCells.Count > 0)
            {
                documentSelectedRow = dgvDocuments.Rows[dgvDocuments.SelectedCells[0].RowIndex];

                DocumentControll documentControll = new DocumentControll();
                selectedDocument = documentControll.GetDocumentById(new DocumentModel() { Id = documentIdByIndex[documentSelectedRow.Cells[0].Value.ToString()] });

                documentSelectedRow.Selected = true;
                ItemXDocumentControll itemXDocumentControll = new ItemXDocumentControll();
                selectedDocument.Items = itemXDocumentControll.GetItemsByDocumentId(new DocumentModel() { Id = selectedDocument.Id });

                UpdateItemDatagridView(selectedDocument.Items);
            }
        }
        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedCells.Count > 0)
            {
                itemSelectedRow = dgvItems.Rows[dgvItems.SelectedCells[0].RowIndex];

                ItemControll itemControll = new ItemControll();
                selectedItem = itemControll.GetItemById(new ItemModel() { Id = itemIdByIndex[itemSelectedRow.Cells[0].Value.ToString()] });

                itemSelectedRow.Selected = true;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;

            UpdateDocumentDatagridView(GetDocumentByDate());
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dtpFrom.MaxDate = dtpTo.Value;

            UpdateDocumentDatagridView(GetDocumentByDate());
        }
        #endregion

        #region CLick

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddEntry(frmAdministrativeMain, null));
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddEntry(frmAdministrativeMain, selectedDocument));

        }
        #endregion

        #region Custom methods
        private void SetToolBarLayout()
        {
            btnAdd.Visible = false;

            pnToolBar.Width = Width - 100;
            pnToolBar.Location = new Point(50, pnToolBar.Location.Y);
        }
        private List<DocumentModel> GetDocumentByDate()
        {
            DocumentControll documentControll = new DocumentControll();
            return documentControll.GetDocumentsByDate(dtpFrom.Value, dtpTo.Value, allDocuments);
        }
        private void UpdateDocumentDatagridView(List<DocumentModel> documents)
        {
            dgvDocuments.Rows.Clear();
            if (documents.Count == 0)
            {
                return;
            }
            int counter = 1;
            documentIdByIndex = new Dictionary<string, int>();
            foreach (DocumentModel document in documents)
            {
                documentIdByIndex.Add(counter.ToString(), document.Id);
                dgvDocuments.Rows.Add(counter, document.Number, document.Serial, document.Company.SocialReason, document.Registration.Date.ToString("dd/MM/yyyy"), document.ItemsAmount, String.Format("{0:C}", document.TotalValue));
                counter++;
            }
            lblFetchDocuments.Visible = false;
        }
        private void UpdateItemDatagridView(List<ItemModel> items)
        {
            dgvItems.Rows.Clear();
            if (items.Count == 0)
            {
                return;
            }
            int counter = 1;
            itemIdByIndex = new Dictionary<string, int>();
            foreach (ItemModel item in items)
            {
                itemIdByIndex.Add(counter.ToString(), item.Id);

                ItemXDocumentControll itemXDocumentControll = new ItemXDocumentControll();
                item.Amount = itemXDocumentControll.GetItemAmountByIdAndDocumentId(item, selectedDocument);

                dgvItems.Rows.Add(counter, item.Product.BarCode, item.Product.Description, String.Format("{0:C}", item.Product.Price), item.Amount, item.Product.Unity, item.TotalValue); ;
                counter++;
            }
            lblFetchItems.Visible = false;
        }
        private List<DocumentModel> FetchDocuments()
        {
            DocumentControll documentControll = new DocumentControll();
            List<DocumentModel> documents = documentControll.GetAllEntryDocuments();

            return documents;
        }
        #endregion

        private void FrmAdministrativeViewEntrys_Shown(object sender, EventArgs e)
        {

        }
    }
}
