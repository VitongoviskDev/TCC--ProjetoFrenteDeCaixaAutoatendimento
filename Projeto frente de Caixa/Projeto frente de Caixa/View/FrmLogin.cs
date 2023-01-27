using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using Projeto_frente_de_Caixa.View.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View
{
    public partial class FrmLogin : Form
    {
        UserControll userController = new UserControll();
        FrmModes frmModes;

        UserModel currentuser;

        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;
        private Color correct_border_color = Color.LimeGreen;

        private char passwordChar = '*';
        public FrmLogin(FrmModes parent)
        {
            InitializeComponent();
            frmModes = parent;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            txtPassword.PasswordChar = passwordChar;
        }
        public void Logout() {
            txtLogin.Texts = "";
            txtPassword.Texts = "";
            ActivityControll activityControll = new ActivityControll();
            activityControll.AddLogoutActivity(currentuser);
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            if (ValidateLogin() && ValidateUser())
            {
                UserModel user = userController.GetUserByLogin(new UserModel() { Login = txtLogin.Texts });
                if (user.IsFirstAccess)
                {
                    FrmPasswordRecoveryEmail frmPasswordRecoveryEmail = new FrmPasswordRecoveryEmail(this, true);
                    frmPasswordRecoveryEmail.Show();
                    this.Hide();
                }
                else if (ValidatePassword() && userController.ValidateUserPassword(txtPassword.Texts, currentuser))
                {
                    ActivityControll activityControll = new ActivityControll();
                    activityControll.AddLoginActivity(currentuser);


                    FrmAdministrativeMain frmAdministrativeMain = new FrmAdministrativeMain(this, currentuser);
                    frmAdministrativeMain.Show();
                    this.Hide();
                }
                else
                    txtPassword.BorderColor = wrong_border_color;
            }
        }
        private bool ValidateLogin()
        {
            if (string.IsNullOrEmpty(txtLogin.Texts))
            {
                txtLogin.BorderColor = wrong_border_color;
                return false;
            }
            return true;
        }
        private bool ValidatePassword() {
            if (string.IsNullOrEmpty(txtPassword.Texts))
            {
                txtPassword.BorderColor = wrong_border_color;
                return false;
            }

            return true;
        }
        private bool ValidateUser()
        {
            currentuser = userController.GetUserByLogin(new UserModel() { Login = txtLogin.Texts });

            if (currentuser != null && currentuser.Status)
            {
                txtLogin.BorderColor = correct_border_color;
                return true;
            }
            txtLogin.BorderColor = wrong_border_color;
            return false;
        }

        private void txtLogin__TextChanged(object sender, EventArgs e) {
            txtLogin.BorderColor = normal_border_color;
        }

        private void txtLogin_Leave(object sender, EventArgs e) {
            ValidateUser();
        }

        private void txtPassword__TextChanged(object sender, EventArgs e){
            txtPassword.BorderColor = normal_border_color;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : passwordChar;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FrmPasswordRecoveryEmail frmPasswordRecoveryEmail = new FrmPasswordRecoveryEmail(this, false);
            frmPasswordRecoveryEmail.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            frmModes.StartingValidations();
            frmModes.Show();
            this.Hide();
        }
        public void ChangePassword(UserModel user)
        {
            FrmPasswordRecoveryEmail frmPasswordRecoveryEmail = new FrmPasswordRecoveryEmail(this, true);
            frmPasswordRecoveryEmail.Show();
            this.Hide();
        }
    }
}
