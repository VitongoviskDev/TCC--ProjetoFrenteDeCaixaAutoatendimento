using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator.Company
{
    public partial class FrmAdministrativeAddCompany : Form
    {
        CompanyModel company;
        FrmAdministrativeMain frmAdministrativeMain;

        private bool editMode;

        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;
        private Color correct_border_color = Color.LimeGreen;

        public bool validateUser = false;

        public FrmAdministrativeAddCompany(FrmAdministrativeMain parent, CompanyModel _company)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;
            if (_company != null)
            {
                company = _company;
                editMode = true;
            }
            else
            {
                company = new CompanyModel();
                editMode = false;
            }

            dpOpeningDate.MaxDate = DateTime.Now;
        }

        private void btnAdress_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                GetData();
                frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddCompanyAdress(frmAdministrativeMain, company) { validateUser = validateUser});
            }
        }
        private void FillFields()
        {
            txtFantasyName.Focus();
            txtFantasyName.Texts = company.FantasyName;
            txtSocialReason.Focus();
            txtSocialReason.Texts = company.SocialReason;
            txtCnpj.Focus();
            txtCnpj.Texts = company.Cnpj;
            txtStateRegistration.Focus();
            txtStateRegistration.Texts = company.StateRegistration;
            
            dpOpeningDate.Value = company.OpeningDate;
            txtSite.Focus();
            txtSite.Texts = company.Site;
            txtEmail.Focus();
            txtEmail.Texts = company.Email;
            cmbDDD.SelectedIndex = GetCbmDddIndex(company.Ddd) ;
            txtPhoneNumber.Focus();
            txtPhoneNumber.Texts = company.PhoneNumber;
        }
        private int GetCbmDddIndex(string ddd)
        {
            foreach(string item in cmbDDD.Items)
                if (item.Contains(ddd))
                {
                    return cmbDDD.Items.IndexOf(item);
                }

            return -1;
        }
        private bool ValidateFields()
        {
            bool valid = true;
            CompanyControll companyControll = new CompanyControll();

            if (string.IsNullOrEmpty(txtFantasyName.Texts)){
                txtFantasyName.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtSocialReason.Texts)){
                txtSocialReason.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtCnpj.Texts)){
                txtSocialReason.BorderColor = wrong_border_color;
                valid = false;
            }
            string cnpj = string.Empty;
            foreach(char letter in txtCnpj.Texts)
            {
                if ("0123456789".Contains(letter))
                    cnpj += letter;
            }
            if (!companyControll.ValidateCnpj(new CompanyModel() { Cnpj = cnpj })){
                txtCnpj.BorderColor = wrong_border_color;
                lblWrongCnpj.Text = "CNPJ Inválido!";
                lblWrongCnpj.Visible = true;
                valid = false; 
            }
            string stateRegistration = string.Empty;
            foreach (char letter in txtStateRegistration.Texts)
            {
                if ("0123456789".Contains(letter))
                    stateRegistration += letter;
            }
            if (companyControll.ValidateStateRegistration(new CompanyModel() { StateRegistration = stateRegistration })){
                txtStateRegistration.BorderColor = wrong_border_color;
                valid = false; 
            }
            if (string.IsNullOrEmpty(txtSite.Texts))
            {
                txtSite.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                txtEmail.BorderColor = wrong_border_color;
                valid = false;
            }
            if (cmbDDD.SelectedIndex == -1)
            {
                cmbDDD.BorderColor = wrong_border_color;
                cmbDDD.IconColor = wrong_border_color;
                cmbDDD.ForeColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Texts))
            {
                txtEmail.BorderColor = wrong_border_color;
                valid = false;
            }
            return valid;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (!"0123456789".Contains(e.KeyChar)) e.Handled = true;

            if (txtPhoneNumber.Texts.Count() > 0 && txtPhoneNumber.Texts[0] == '9')
            {
                txtPhoneNumber.MaxLength = 9;
            }
            else
            {
                txtPhoneNumber.MaxLength = 8;
            }
        }
        private void GetData()
        {
            company.Id = 0;
            company.FantasyName = txtFantasyName.Texts;
            company.SocialReason = txtSocialReason.Texts;
            company.Cnpj = txtCnpj.Texts;
            company.StateRegistration = txtStateRegistration.Texts;
            company.OpeningDate = dpOpeningDate.Value;
            company.Site = txtSite.Texts;
            company.Email = txtEmail.Texts;
            company.Ddi = "+55";
            company.Ddd = cmbDDD.Texts;
            company.PhoneNumber = txtPhoneNumber.Texts;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza de que deseja cancelar o cadastro? \n Os dados atuais não serão salvos!", "Cadastro de empresa", MessageBoxButtons.YesNo ,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes) 
                frmAdministrativeMain.OpenChildForm(new FrmAdminstrativeViewCompany(frmAdministrativeMain));
        }

        private void FrmAdministrativeAddCompany_Load(object sender, EventArgs e)
        {
            if(editMode)
                FillFields();

            if (CompanyControll.GetMainCompany() == null)
            {
                btnCancel.Visible = false;
            }
        }

        private void cmbDDD_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDDD.Texts = cmbDDD.SelectedItem.ToString().Remove(2, cmbDDD.SelectedItem.ToString().Length - 2);
            cmbDDD.BorderColor = normal_border_color;
            cmbDDD.IconColor = normal_border_color;
            cmbDDD.ForeColor = normal_border_color;

            lblWrongCnpj.Visible = false;
        }

        private void txtFantasyName__TextChanged(object sender, EventArgs e)
        {
            txtFantasyName.BorderColor = normal_border_color;
        }

        private void txtSocialReason__TextChanged(object sender, EventArgs e)
        {
            txtSocialReason.BorderColor = normal_border_color;
        }

        private void txtCnpj__TextChanged(object sender, EventArgs e)
        {
            txtCnpj.BorderColor = normal_border_color;
            lblWrongCnpj.Visible = false;
        }

        private void txtStateRegistration__TextChanged(object sender, EventArgs e)
        {
            txtStateRegistration.BorderColor = normal_border_color;
        }

        private void txtSite__TextChanged(object sender, EventArgs e)
        {
            txtSite.BorderColor = normal_border_color;
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            txtEmail.BorderColor = normal_border_color;
        }

        private void txtPhoneNumber__TextChanged(object sender, EventArgs e)
        {
            txtPhoneNumber.BorderColor = normal_border_color;


            if (txtPhoneNumber.Texts.Count() == 9 && txtPhoneNumber.Texts[0] != '9')
                txtPhoneNumber.Texts = txtPhoneNumber.Texts.Remove(8, 1);
        }
    }
}
