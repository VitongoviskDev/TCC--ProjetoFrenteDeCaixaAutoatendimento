using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator.Company
{
    public partial class FrmAdministrativeAddCompanyAdress : Form
    {
        CompanyModel company;

        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;
        private Color correct_border_color = Color.LimeGreen;

        FrmAdministrativeMain frmAdministrativeMain;

        public bool validateUser = false;

        public FrmAdministrativeAddCompanyAdress(FrmAdministrativeMain parent, CompanyModel _company)
        {
            InitializeComponent();
            frmAdministrativeMain = parent;

            company = _company;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                GetData();
                CompanyControll companyControll = new CompanyControll();
                if (CompanyControll.GetMainCompany() == null)
                    companyControll.AddMainCompany(company);
                else
                    companyControll.UpdateCompany(company);

                frmAdministrativeMain.OpenChildForm(new FrmAdminstrativeViewCompany(frmAdministrativeMain));
                frmAdministrativeMain.ValidateConfigurations();
            }
        }
        private void GetData()
        {
            company.Id = 1;
            company.Adress = txtAdress.Texts;
            company.ZipCode = txtZipCode.Texts;
            company.Number = int.Parse(txtNumber.Texts);
            company.Complement = txtComplement.Texts;
            company.District = txtDistrict.Texts;
            company.City = txtCity.Texts;
            company.State = txtState.Texts;
        }
        private bool ValidateFields()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txtAdress.Texts))
            {
                txtAdress.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtZipCode.Texts))
            {
                txtZipCode.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtNumber.Texts))
            {
                txtNumber.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtDistrict.Texts))
            {
                txtDistrict.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtCity.Texts))
            {
                txtCity.BorderColor = wrong_border_color;
                valid = false;
            }
            if (string.IsNullOrEmpty(txtState.Texts))
            {
                txtState.BorderColor = wrong_border_color;
                valid = false;
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza de que deseja cancelar o cadastro? \n Os dados atuais não serão salvos!", "Cadastro de empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmAdministrativeMain.OpenChildForm(new FrmAdminstrativeViewCompany(frmAdministrativeMain));
        }

        private void FrmAdministrativeAddCompanyAdress_Load(object sender, EventArgs e)
        {
            if (company != null)
                FillFields();

                CompanyControll companyControll = new CompanyControll();
            if (CompanyControll.GetMainCompany() == null)
            {
                btnCancel.Visible = false;
            }
        }
        private void FillFields()
        {
            txtAdress.Focus();
            txtAdress.Texts = company.Adress;

            txtZipCode.Focus();
            txtZipCode.Texts = company.ZipCode;

            txtNumber.Focus();
            txtNumber.Texts = company.Number.ToString();

            txtComplement.Focus();
            txtComplement.Texts = company.Complement;

            txtDistrict.Focus();
            txtDistrict.Texts = company.District;

            txtCity.Focus();
            txtCity.Texts = company.City;

            txtState.Focus();
            txtState.Texts = company.State;
        }

        private void txtAdress__TextChanged(object sender, EventArgs e)
        {
            txtAdress.BorderColor = normal_border_color;
        }

        private void txtZipCode__TextChanged(object sender, EventArgs e)
        {
            txtZipCode.BorderColor = normal_border_color;
        }

        private void txtNumber__TextChanged(object sender, EventArgs e)
        {
            txtNumber.BorderColor = normal_border_color;
        }

        private void txtComplement__TextChanged(object sender, EventArgs e)
        {
            txtComplement.BorderColor = normal_border_color;
        }

        private void txtDistrict__TextChanged(object sender, EventArgs e)
        {
            txtDistrict.BorderColor = normal_border_color;
        }

        private void txtCity__TextChanged(object sender, EventArgs e)
        {
            txtCity.BorderColor = normal_border_color;
        }

        private void txtState__TextChanged(object sender, EventArgs e)
        {
            txtState.BorderColor = normal_border_color;
        }
    }
}
