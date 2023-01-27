using Projeto_frente_de_Caixa.View.Administrator.Users;
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
    public partial class FrmAdministrativeCreateNewAdminUser : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        public FrmAdministrativeCreateNewAdminUser(FrmAdministrativeMain parent)
        {
            InitializeComponent();
            frmAdministrativeMain = parent;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddUser(frmAdministrativeMain, null) { firstUser = true });
        }
    }
}
