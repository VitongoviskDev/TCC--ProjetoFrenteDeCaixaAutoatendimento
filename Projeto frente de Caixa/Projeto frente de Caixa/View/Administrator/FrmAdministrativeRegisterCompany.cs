using Projeto_frente_de_Caixa.View.Administrator.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator
{
    public partial class FrmAdministrativeRegisterCompany : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        public FrmAdministrativeRegisterCompany(FrmAdministrativeMain parent)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddCompany(frmAdministrativeMain, null));
        }
    }
}
