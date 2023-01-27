using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Users;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_frente_de_Caixa.View.Administrator.Company
{
    public partial class FrmAdminstrativeViewCompany : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        CompanyModel company;
        public FrmAdminstrativeViewCompany(FrmAdministrativeMain parent)
        {
            InitializeComponent();
            frmAdministrativeMain = parent;
            company = CompanyControll.GetMainCompany();

            if (frmAdministrativeMain.logedUser.Profile != 0)
            {
                btnEdit.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddCompany(frmAdministrativeMain, company));
        }

        private void FrmAdminstrativeViewCompany_Load(object sender, EventArgs e)
        {
            FillFields();
        }
        private void FillFields()
        {
            lblFantasyName.Text = company.FantasyName;
            lblSocialReason.Text = company.SocialReason;
            lblCnpj.Text = company.Cnpj;
            lblStateRegistration.Text = company.StateRegistration;
            lblOpeningDate.Text = company.OpeningDate.ToString("dd/MM/yyyy");
            lblPhone.Text = $"{company.Ddi} ({company.Ddd}) {company.PhoneNumber}";
            lblSite.Text = company.Site;
            lblEmail.Text = company.Email;
            //Endereço
            lblCep.Text = $"{company.ZipCode} - {company.Adress}, nº{company.Number.ToString()}";

            lblDistrict.Text = $"{company.District}, {company.City}, {company.State}";

            lblComplement.Text = company.Complement;
        }
    }
}
