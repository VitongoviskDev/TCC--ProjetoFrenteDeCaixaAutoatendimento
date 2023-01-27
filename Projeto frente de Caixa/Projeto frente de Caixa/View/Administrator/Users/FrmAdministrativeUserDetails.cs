using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Administrator.Users
{
    public partial class FrmAdministrativeUserDetails : Form
    {
        UserModel user;
        Form parent;
        public FrmAdministrativeUserDetails(UserModel _user, Form form)
        {
            InitializeComponent();

            user = _user;
            parent = form;
            TopLevel = true;
        }

        private void FrmAdministrativeUserDetails_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            parent.Enabled = true;
        }

        private void FrmAdministrativeUserDetails_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            lblName.Text = user.Name;
            lblProfile.Text = user.Profile == 0 ? "administrador" : "padrão".ToUpper();

            lblCode.Text = user.Code.ToString();
            lblStatus.Text = user.Status ? "Ativo" : "Inativo";
            lblEmail.Text = user.Email;

            if(user.Profile != 0)
            {
                ActivityControll activityControll = new ActivityControll();
                ActivityModel activity = activityControll.GetActivityById(new ActivityModel() { Id = user.AddedId });

                lblUserAdded.Text = activity.User.Name;
                lblDateAdded.Text = activity.Date.ToString("dd/MM/yyyy");
                lblHourAdded.Text = activity.Hour.ToString("HH:mm");

                activity = activityControll.GetActivityById(new ActivityModel() { Id = user.UpdatedId });
                lblUserUpdated.Text = activity.User.Name;
                lblDateUpdated.Text = activity.Date.ToString("dd/MM/yyyy");
                lblHourUpdated.Text = activity.Hour.ToString("HH:mm");
                lblDescriptionUpdated.Text = ActivityControll.GetDescription(activity);
            }
            else
            {
                lblDescriptionUpdated.Text = "usuário criado na primeira primeira execução do sistema";
            }
        }
    }
}
