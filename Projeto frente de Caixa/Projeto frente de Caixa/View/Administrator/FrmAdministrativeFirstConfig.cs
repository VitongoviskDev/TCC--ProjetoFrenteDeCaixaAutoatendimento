using Projeto_frente_de_Caixa.View.Administrator.Configuration;
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
    public partial class FrmAdministrativeFirstConfig : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        public FrmAdministrativeFirstConfig(FrmAdministrativeMain parente)
        {
            InitializeComponent();

            frmAdministrativeMain = parente;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeConfig(frmAdministrativeMain));
        }
    }
}
