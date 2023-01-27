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

namespace Projeto_frente_de_Caixa.View.Administrator
{
    public partial class FrmResetPassword : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        UserModel user;
        public FrmResetPassword(FrmAdministrativeMain parent, UserModel _user)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;

            user = _user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.Logout();
            frmAdministrativeMain.frmLogin.ChangePassword(user);
        }
    }
}
