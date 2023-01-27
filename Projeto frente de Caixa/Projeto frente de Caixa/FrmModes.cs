using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
using Projeto_frente_de_Caixa.View;
using Projeto_frente_de_Caixa.View.Shopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Projeto_frente_de_Caixa {
    public partial class FrmModes : Form {
        
        int counter = 10; //seconds
        public FrmModes() {
            InitializeComponent();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCaixa_Click(object sender, EventArgs e) {
            FrmShoppingStartSession frmShoppingStartSession = new FrmShoppingStartSession(this);
            frmShoppingStartSession.Show();
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnAdministrador_Click(object sender, EventArgs e) {
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.Show();
            Hide();
        }

        private void FrmModes_Shown(object sender, EventArgs e)
        {
        }

        private void FrmModes_Load(object sender, EventArgs e)
        {
            StartingValidations();
        }
        private bool TestConnection()
        {
            bool connected = false;
            MySqlConnection connection;
            for (int i = 0; i < 4; i++)
            {
                lblWarning.Text = $"Tentando conectar ao banco de dados \n\ntentativa: {i + 1}";
                connection = DBConnection.Connection();
                if (connection != null)
                {
                    pnConnection.Visible = false;
                    connected = true;
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        lblWarning.Text = "Não foi possivel conectar ao banco de dados. \n\nContate um administrador do sistema";
                        lblError.Visible = true;
                        lblError.Text = $"ERROR: {DBConnection.Code} - {DBConnection.Message}";
                        lblTimer.Text = $"Encerrando em {counter.ToString()}";
                        lblTimer.Visible = true;
                        tmTimer.Start();
                    }
                }
            }
            return connected;
        }
        public void StartingValidations()
        {
            if (TestConnection())
            {
                ConfigurateDatabase();
                ValidateCompany();
            }
        }
        private void ValidateCompany()
        {
            if (CompanyControll.GetMainCompany() == null)
            {
                btnCaixa.Enabled = false;
                lblCompanyWarning.Visible = true;
            }
            else
            {
                btnCaixa.Enabled = true;
                lblCompanyWarning.Visible = false;
            }
        }
        private void ConfigurateDatabase()
        {
            CreateTables();
            UserControll userControll = new UserControll();
            if (userControll.GetUserByCode(new UserModel() { Code = 0 }) == null)
                userControll.CreateAdminUser();
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = $"Encerrando em {counter.ToString()}";
            if (counter > 0)
                counter--;
            else
            {
                tmTimer.Stop();
                Application.Exit();
            }
        }

        private void FrmModes_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("salve");
        }
        private void CreateTables()
        {

        }
    }
}
