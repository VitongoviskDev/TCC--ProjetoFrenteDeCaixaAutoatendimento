using Google.Protobuf.Reflection;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Dao;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Projeto_frente_de_Caixa.View.Administrator.Entrys
{
    public partial class FrmAdministrativeAddEntry : Form
    {
        FileInfo file;
        OpenFileDialog fileDialog;
        FrmAdministrativeMain frmAdministrativeMain;

        DocumentModel document = new DocumentModel();
        public FrmAdministrativeAddEntry(FrmAdministrativeMain parent, DocumentModel _document)
        {
            InitializeComponent();
            fileDialog = new OpenFileDialog()
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                InitialDirectory = @"C:\",
                Title = "Selecione o documento de entrada de produtos."
            };

            if(_document != null)
            {
                document = _document;
                FillFields();
                btnAdd.Visible = false;

                lblRegistration.Visible = true;
                Registration.Visible = true;

                lblRegistration.Text = document.Registration.Date.ToString("dd/MM/yyyy");

                dgvItems.Height += 40;

                btnCancel.Text = "Voltar";

                Text = "Visualizar documento de entrada";
            }

            frmAdministrativeMain = parent;
        }

        private void dgvItems_SizeChanged(object sender, EventArgs e)
        {
            int unity = dgvItems.Width / 100;

            clmIndex.Width = unity * 5;
            clmBarCode.Width = unity * 20;
            clmDescription.Width = unity * 35;
            clmUnity.Width = unity * 5;
            clmAmount.Width = unity * 5;
            clmUnitaryValue.Width = unity * 15;
            clmTotalValue.Width = unity * 15;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(ValidateFile()){
                DocumentControll documentControll = new DocumentControll();
                document = documentControll.ReadDocument(document);
                if(!documentControll.VerifyDocumentReaded(document))
                    FillFields();
                else
                    MessageBox.Show("Este documento já foi registrado e não pode ser ultilizado novamente","Gerenciado de docuemntos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Focus();
                file = new FileInfo(fileDialog.FileName);
                txtFilePath.Texts = file.FullName;
                document.File = new FileInfo(fileDialog.FileName);
            }
        }

        private bool ValidateFile()
        {
            DocumentControll documentControll = new DocumentControll();
            if (File.Exists(file.FullName))
                return true;

           return false;
        }

        private void FillFields()
        {
            pnFileData.Visible = true;
            pnHeader.Visible = false;

            lblFantasyName.Text = document.Company.FantasyName;
            lblSocialReason.Text = document.Company.SocialReason;
            lblCnpj.Text = document.Company.Cnpj;
            lblStateRegistration.Text = document.Company.StateRegistration;

            lblPhone.Text = $"{document.Company.Ddi} ({document.Company.Ddd}) {document.Company.PhoneNumber}";

            lblDocumentNumber.Text = "Nº " + document.Number.ToString();
            lblDocumentSerialNumber.Text = "Série " + document.Serial.ToString();

            lblEmissionDate.Text = document.EmissionDate.ToString("dd/MM/yyyy");

            lblAdress1.Text = document.Company.ZipCode + " - " + document.Company.Adress + ", " + document.Company.Number.ToString();
            lblAdress2.Text = document.Company.District + ", " + document.Company.City + ", " + document.Company.State;
            lblComplement.Text = document.Company.Complement;

            lblTotalValue.Text = String.Format("{0:C}", document.TotalValue);


            int couter = 1;
            foreach(ItemModel item in document.Items)
            {
                dgvItems.Rows.Add(couter,item.Product.BarCode, item.Product.Description, item.Product.Unity, item.Amount, String.Format("{0:C}", item.Product.Price), String.Format("{0:C}", item.TotalValue));
                couter++;
            }

        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Adicona o documento ao banco
            DocumentControll documentControll = new DocumentControll();
            ActivityModel registration = new ActivityModel();
            registration.Hour = DateTime.Now;
            registration.Date = DateTime.Now;
            registration.Type = ActivityType.Buy;
            registration.User = frmAdministrativeMain.logedUser;
            registration.Item = "Documento: " + document.File.Name;
            ActivityControll activeControl = new ActivityControll();
            document.Registration = registration;
            registration.Id = activeControl.AddActivity(registration);

            CompanyControll companyControll = new CompanyControll();
            CompanyModel company = companyControll.GetCompanyByCnpj(new CompanyModel() { Cnpj = document.Company.Cnpj });
            if (company == null)
                document.Company.Id = companyControll.AddCompany(document.Company);
            else
                document.Company.Id = company.Id;

            document.Id = documentControll.AddDocument(document);

            ItemControll itemControll = new ItemControll();

            List<ItemModel> toAdd = new List<ItemModel>();

            List<ItemModel> toRegister = new List<ItemModel>();
            string toRegisterString = string.Empty;

            int counter = 1;
            foreach(ItemModel item in document.Items)
            {
                item.DocumentType = document.Type;
                item.St = "F1";

                ProductControll productControll = new ProductControll();
                if (productControll.GetProductIdByBarCode(item.Product) > 0)
                {
                    item.Id = itemControll.AddItem(item);
                    toAdd.Add(item);
                }
                else {
                    toRegister.Add(item);
                    toRegisterString += $"{counter} - {item.Product.Description}\n";
                    counter++;
                }
            }

            ItemXDocumentControll itemXDocumentControll = new ItemXDocumentControll();


            itemXDocumentControll.AddItems(toAdd, document);

            if (toRegister.Count > 0)
            {
                MessageBox.Show($"Os items listados precisam ser registrados no sistema para que possam ser adicionados ao estoque \n\n{toRegisterString}", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddProduct(frmAdministrativeMain, toRegister, document));

            }
            else
            {
                frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewEntrys(frmAdministrativeMain));
                frmAdministrativeMain.ValidateStorageLevelAlert();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewEntrys(frmAdministrativeMain));
        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {
            btnFileDialog.PerformClick();
        }
    }
}
