using kfcCustomControls.KFCCustomControls;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Company;
using Projeto_frente_de_Caixa.View.Administrator.Configuration;
using Projeto_frente_de_Caixa.View.Administrator.Products;
using Projeto_frente_de_Caixa.View.Administrator.Sales;
using Projeto_frente_de_Caixa.View.Administrator.Storage;
using Projeto_frente_de_Caixa.View.Administrator.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator {
    public partial class FrmAdministrativeMain : Form
    {
        public FrmLogin frmLogin;

        Form currentForm = null;

        public UserModel logedUser;

        Button selectedButton = null;
        bool selectedButtonIsSubMenu = false;

        Color subMenuButtonNormalColor = Color.DarkGray;
        Color MenuButtonNormalColor = Color.FromArgb(180, 180, 180);

        Color MenuButtonSelectedColor = Color.WhiteSmoke;

        public FrmAdministrativeMain(FrmLogin parent, UserModel user)
        {
            InitializeComponent();

            frmLogin = parent;
            logedUser = user;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            lblUsername.Text = logedUser.Name;
            lblProfile.Text = logedUser.Profile == 0 ? "administrador" : "padrão";
        }

        private void FrmAdministrativeMain_SizeChanged(object sender, EventArgs e)
        {
            pnMenuHolder.Width = Width / 100 * 18;
        }

        private void pnHeaderBar_SizeChanged(object sender, EventArgs e)
        {
            btnRegistrationProducts.PerformClick();
        }
        public void OpenChildForm(Form form)
        {
            if (currentForm != null)
            {
                pnChildFormHolder.Controls.Remove(currentForm);
                currentForm.Close();
            }

            currentForm = form;
            currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            pnChildFormHolder.Controls.Add(currentForm);
            currentForm.Show();

            lblSoftwareName.Text = "King Of Frente de Caixa  - " + currentForm.Text;
            lblSoftwareName.Location = new Point((pnHeaderBar.Width - lblSoftwareName.Width) / 2, 5);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SelectButton(btnRegistrationProducts, true);
            OpenChildForm(new FrmAdministrativeViewProducts(this));
        }
        private void btnEntrys_Click(object sender, EventArgs e)
        {
            SelectButton(btnEntrys, true);
            OpenChildForm(new FrmAdministrativeViewEntrys(this));
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            SelectButton(btnSales, true);
            OpenChildForm(new FrmAdministrativeViewSales());
        }
        private void btnStorageProducts_Click(object sender, EventArgs e)
        {
            SelectButton(btnStorageProducts, true);
            OpenChildForm(new FrmAdministrativeViewStorage());
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            SelectButton(btnUsers, false);
            OpenChildForm(new FrmAdministrativeViewUsers(this));
        }
        private void btnCompany_Click(object sender, EventArgs e)
        {
            SelectButton(btnCompany, false);

            if (CompanyControll.GetMainCompany() == null)
                OpenChildForm(new FrmAdministrativeAddCompany(this, null));
            else
                OpenChildForm(new FrmAdminstrativeViewCompany(this));

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            SelectButton(btnConfig, false);
            OpenChildForm(new FrmAdministrativeConfig(this));
        }
        private void SelectButton(Button button, bool isSubMenuButton)
        {
            if (selectedButton != null)
                selectedButton.BackColor = selectedButtonIsSubMenu ? subMenuButtonNormalColor : MenuButtonNormalColor;

            selectedButton = button;
            selectedButtonIsSubMenu = isSubMenuButton;

            button.BackColor = MenuButtonSelectedColor;
        }

        private void btnRegisters_Click(object sender, EventArgs e)
        {
        }

        private void btnMovimentations_Click(object sender, EventArgs e)
        {
        }

        private void FrmAdministrativeMain_Shown(object sender, EventArgs e)
        {
        }
        public void ValidateUser()
        {
            UserControll userControl = new UserControll();
            if (userControl.GetAllUsers().Count == 1)
            {
                btnRegisters.PerformClick();
                SelectButton(btnUsers, false);
                OpenChildForm(new FrmAdministrativeCreateNewAdminUser(this));
            }
            else
            {
                ShowMenu();
            }
        }
        public void ValidateConfigurations()
        {
            ConfigControll configControll = new ConfigControll();
            if (configControll.GetConfig() == null)
            {
                btnConfig.PerformClick();
                SelectButton(btnConfig, false);
                OpenChildForm(new FrmAdministrativeFirstConfig(this));
            }
            else
            {
                ValidateUser();
            }
        }

        private void FrmAdministrativeMain_Load(object sender, EventArgs e)
        {
            if (logedUser.Profile > 0)
                btnConfig.Visible = false;

            HideMenu();
            if (CompanyControll.GetMainCompany() == null)
            {
                btnRegisters.PerformClick();
                SelectButton(btnCompany, false);

                OpenChildForm(new FrmAdministrativeRegisterCompany(this));

                btnCompany.Enabled = true;
            }
            else ValidateConfigurations();
            ValidateStorageLevelAlert();
            tmStorageVerification.Start();
        }
        public void ValidateStorageLevelAlert()
        {
            ItemControll itemControll = new ItemControll();
            int amount = itemControll.VerifyAllItemsStorageLevelAlert();
            pnStorageNotification.Visible = false;
            if (amount > 0)
            {
                pnStorageNotification.Visible = true;
                lblStorageNotificantion.Text = amount.ToString();
            }
        }

        public void ShowMenu()
        {
            pnMenuHolder.Visible = true;
        }
        public void HideMenu()
        {
            pnMenuHolder.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        public void Logout()
        {
            if(currentForm != null)
            {
                pnChildFormHolder.Controls.Remove(currentForm);
                currentForm.Close();
            }

            frmLogin.Logout();
            frmLogin.Show();
            this.Close();
        }

        private void tmStorageVerification_Tick(object sender, EventArgs e)
        {
            ValidateStorageLevelAlert();
        }
    }
}
