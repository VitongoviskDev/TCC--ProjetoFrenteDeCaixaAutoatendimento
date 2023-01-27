using Microsoft.Win32.SafeHandles;
using Org.BouncyCastle.Bcpg;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using Projeto_frente_de_Caixa.View.Administrator.Products;
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
using Ubiety.Dns.Core.Records;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Projeto_frente_de_Caixa.View.Administrator.Configuration
{
    public partial class FrmAdministrativeConfig : Form
    {
        ConfigModel config;
        bool wrongEmailVisible = false;

        private bool editMode = false;

        string verificatioCode = string.Empty;
        bool TryAgain = false;
        bool verifyed = false;

        char passwordChar = '*';

        FrmAdministrativeMain frmAdministrativeMain;
        public FrmAdministrativeConfig(FrmAdministrativeMain parent)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;
            txtPassword.PasswordChar = passwordChar;
        }

        private void pnEmailInfo_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblWrongEmail.Visible = false;
        }

        private void pnEmailInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            if (wrongEmailVisible)
                lblWrongEmail.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) {
                if (verifyed || (config != null && config.Email.Trim().ToLower() == txtEmail.Texts.Trim().ToLower() && config.Password == txtPassword.Texts))
                {
                    config = GetData();
                    ConfigControll configControll = new ConfigControll();
                    if (editMode)
                        configControll.UpdateConfiguration(config);
                    else
                        configControll.AddConfiguration(config);
                    this.Close();
                    frmAdministrativeMain.ValidateUser();
                }
                else
                {
                    pnVerificatioCode.Visible = true;
                    txtCode.Focus();
                    lblEmailSend.Text = "Digite o código de verificação enviado para \n" + txtEmail.Texts.Trim();
                    SendEmail();
                }
            }
        }

        private ConfigModel GetData()
        {
            config = new ConfigModel();
            config.Email = txtEmail.Texts.Trim().ToLower();
            config.Password = txtPassword.Texts;
            config.SendItemSoldOutEmail = cbSendItemSoldOut.Checked;
            config.SendPassworChangedEmail = cbSendPasswordChanged.Checked;

            return config;
        }

        private bool ValidateFields()
        {
            bool valid = true;
            if (!ValidateEmail())
                valid = false;
            if (!ValidatePassword())
                valid = false;

            btnUpdate.Enabled = valid;
            return true;
        }

        private bool ValidatePassword()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtPassword.Texts))
                valid = false;

            if (!valid)
                txtPassword.BorderColor = Color.Crimson;

            return valid;
        }

        private bool ValidateEmail()
        {
            UserControll userControl = new UserControll();
            bool valid = true;
            if (string.IsNullOrEmpty(txtEmail.Texts.Trim()))
                valid = false;
            else if (!userControl.ValidateEmail(new UserModel() { Email = txtEmail.Texts.Trim().ToLower() }))
            {
                lblWrongEmail.Text = "E-mail inválido!";
                valid = false;
            }
            else if (userControl.GetUserIdByEmail(new UserModel() { Email = txtEmail.Texts.Trim().ToLower() }) > 0)
            {
                lblWrongEmail.Text = "Este e-mail já foi ultilizado por outro usuário e por \nmedidas de segurança não pode ser ultilizado novamente";
                valid = false;
            }
            else if (!userControl.ValidateGoogleEmail(new UserModel { Email = txtEmail.Texts.Trim().ToLower() }))
            {
                lblWrongEmail.Text = "O email deve conter \"@gmail.com\"";
                valid = false;
            }
            

            if (!valid)
            {
                txtEmail.BorderColor = Color.Crimson;
                lblWrongEmail.Visible = true;
                wrongEmailVisible = true;
            }
            else { btnUpdate.Enabled = true; }

            return valid;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmail.Texts.Contains('@') && e.KeyChar == '@') e.Handled = true;
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            lblWrongEmail.Visible = false;
            txtEmail.BorderColor = Color.Black;

        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            ConfigControll configControll = new ConfigControll();
            config = configControll.GetConfig();
            if (config != null)
            {
                editMode = true;
                FillFields();
            }
        }
        private void FillFields()
        {
            txtEmail.Focus();
            txtEmail.Texts = config.Email;
            txtPassword.Focus();
            txtPassword.Texts = config.Password;
            cbSendItemSoldOut.Checked = config.SendItemSoldOutEmail;
            cbSendPasswordChanged.Checked = config.SendPassworChangedEmail;
            cbSendItemSoldOut.Focus();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            lblWrongEmail.Visible = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (TryAgain)
            {
                SendEmail();
                TryAgain = false;
                btnVerify.Text = "VERIFICAR";
                txtCode.Focus();
                txtCode.Texts = "";
                btnVerify.Focus();
            }
            else if(ValidateCode()) {
                verifyed = true;
                pnVerificatioCode.Visible = false;
                btnUpdate.PerformClick();
            }
        }
        private bool ValidateCode()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtCode.Texts))
                valid = false;
            else if (txtCode.Texts.Trim() != verificatioCode)
            {
                lblWrongCode.Visible = true;
                lblWrongCode.Text = "Código inválido!";
                valid = false;
            }

            if (!valid)
            {
                btnVerify.Text = "Tentar novamente";
                TryAgain = true;
                txtCode.BorderColor = Color.Crimson;
            }

            return valid;
        }
        private void lblChangeEmail_Click(object sender, EventArgs e)
        {
            pnVerificatioCode.Visible = false;
        }

        private void txtCode__TextChanged(object sender, EventArgs e)
        {
            lblWrongCode.Visible = false;
            txtCode.BorderColor = Color.Black;
        }
        private void SendEmail()
        {
            verificatioCode = UserControll.GenerateCode(5);
            EmailSender.TestEmail(txtEmail.Texts.Trim(), txtPassword.Texts, verificatioCode);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            lblTutorial.Visible = true;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            lblTutorial.Visible = false;
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.Black;
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : passwordChar;
        }
    }

}
