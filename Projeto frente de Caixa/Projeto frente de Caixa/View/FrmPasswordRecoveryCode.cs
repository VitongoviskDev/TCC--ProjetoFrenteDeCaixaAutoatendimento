using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto_frente_de_Caixa.View
{
    public partial class FrmPasswordRecoveryCode : Form
    {
        FrmLogin frmLogin;
        FrmPasswordRecoveryEmail frmPasswordRecoverySendCode;
        string code;
        int userId;
        public FrmPasswordRecoveryCode(FrmLogin parent, string email, string _code, FrmPasswordRecoveryEmail previous, int id)
        {
            frmLogin = parent;
            frmPasswordRecoverySendCode = previous;
            code = _code;
            userId = id;

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            lblEmail.Text = email;
            txtFocus.Focus();
        }

        private void lblEmailFail_Click(object sender, EventArgs e)
        {
            frmPasswordRecoverySendCode.Show();
            this.Close();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
            frmPasswordRecoverySendCode.Close();
        }

        private void FrmPasswordRecoveryCode_SizeChanged(object sender, EventArgs e)
        {
            lblEmail.Location = new Point((Width - lblEmail.Width) / 2, lblEmail.Location.Y);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtCode.Texts == code)
            {
                UserControll userControll = new UserControll();
                FrmPasswordRecoveryNewPassword frmPasswordRecoveryNewPassword = new FrmPasswordRecoveryNewPassword(frmLogin, userId);
                frmPasswordRecoveryNewPassword.Show();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect");
        }
    }
}
