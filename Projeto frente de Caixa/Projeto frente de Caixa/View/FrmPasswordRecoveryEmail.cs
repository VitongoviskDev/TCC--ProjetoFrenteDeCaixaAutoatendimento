using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_frente_de_Caixa.View
{
    public partial class FrmPasswordRecoveryEmail : Form
    {
        FrmLogin frmLogin;
        FrmPasswordRecoveryCode frmPasswordRecoveryCode;

        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;

        public FrmPasswordRecoveryEmail(FrmLogin parent, bool isFirstAccess)
        {
            frmLogin = parent;

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            txtFocus.Focus();

            if (isFirstAccess)
                lblTitle.Text = "Definir Senha";
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Close();
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            txtEmail.BorderColor = normal_border_color;
            lblWrongEmail.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UserControll userControll = new UserControll();
            int id = userControll.GetUserIdByEmail(new UserModel() { Email = txtEmail.Texts});
            if (id > 0)
            {
                string code = UserControll.GenerateCode(5);

                EmailSender.SendVerificationCodeEmail(txtEmail.Texts, code);

                FrmPasswordRecoveryCode frmPasswordRecoveryCode = new FrmPasswordRecoveryCode(frmLogin, txtEmail.Texts, code, this, id);
                frmPasswordRecoveryCode.Show();
                this.Hide();
            }
            else
            {
                txtEmail.BorderColor = wrong_border_color;
                lblWrongEmail.Visible = true;
            }
        }


        
    }
}
