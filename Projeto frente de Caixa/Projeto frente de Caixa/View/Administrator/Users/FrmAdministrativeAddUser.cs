using Projeto_frente_de_Caixa.Control;
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

namespace Projeto_frente_de_Caixa.View.Administrator.Users
{
    public partial class FrmAdministrativeAddUser : Form
    {
        UserModel editUser;
        private bool editMode = false;
        FrmAdministrativeMain frmAdministrativeMain;

        private Color normal_border_color = Color.MidnightBlue;
        private Color wrong_border_color = Color.Crimson;
        private Color correct_border_color = Color.LimeGreen;

        public bool firstUser = false;

        public FrmAdministrativeAddUser(FrmAdministrativeMain parent, UserModel _user)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;
            editUser = _user;
            editMode = editUser != null;

            if (firstUser) AdminLayout();
            
            int code = editMode ? editUser.Code :  UserControll.GetNextCode();
            lblCode.Text = String.Format("{0:0000}", code);
        }

        private void rbtnAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdministrator.Checked)
            {
                lblAdmin.Visible = true;
                lblDefault.Visible = false;
            }
            else
            {
                lblAdmin.Visible = false;
                lblDefault.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                UserControll userControll = new UserControll();
                GetData();
                if (editMode)
                    userControll.UpdateUser(editUser);
                else
                    userControll.AddUser(editUser);


                if (editUser.Id == frmAdministrativeMain.logedUser.Id)
                    frmAdministrativeMain.Logout();
                else
                {
                    if (firstUser)
                    {
                        frmAdministrativeMain.OpenChildForm(new FrmResetPassword(frmAdministrativeMain, editUser));
                    }
                    else
                    {
                        frmAdministrativeMain.ShowMenu();
                        frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewUsers(frmAdministrativeMain));
                    }
                }

            }
        }
        private bool ValidateFields()
        {
            if (!ValidateName())
                return false;

            if (!ValidateLogin())
                return false;

            if (!ValidateEmail())
                return false;

            return true;
        }
        private bool ValidateName()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txtUsername.Texts))
            {
                txtUsername.BorderColor = normal_border_color;
                valid = false;
            }
            return valid;
        }
        private bool ValidateLogin()
        {
            bool valid = true;
            UserControll userControll = new UserControll();
            UserModel user = userControll.GetUserByLogin(new UserModel() { Login = txtLogin.Texts });

            if (string.IsNullOrEmpty(txtLogin.Texts))
                valid = false;
            else if ((user != null && editMode && user.Id != editUser.Id) || (user != null &&  !editMode))
            {
                lblWrongLogin.Visible = true;
                valid = false;
            }

            if (!valid)
                txtLogin.BorderColor = wrong_border_color;

            return valid;
        }
        private bool ValidateEmail()
        {
            bool valid = true;
            UserControll userControll = new UserControll();
            int id = userControll.GetUserIdByEmail(new UserModel() { Email = txtEmail.Texts});
            ConfigControll configControll = new ConfigControll();
            if (string.IsNullOrEmpty(txtEmail.Texts))
                valid = false;
            else if ((editMode && editUser.Id != id && id > 0) || (!editMode && id > 0))
            {
                lblWrongEmail.Text = "Este e-mail ja foi cadastrado!";
                lblWrongEmail.Visible = true;
                valid = false;
            }
            else if (!userControll.ValidateEmail(new UserModel() { Email = txtEmail.Texts.Trim().ToLower() }))
            {
                lblWrongEmail.Text = "E-mail inválido!";
                lblWrongEmail.Visible = true;
                valid = false;
            } else if (configControll.GetConfig().Email.Trim().ToLower() == txtEmail.Texts.Trim().ToLower())
            {
                lblWrongEmail.Text = "E-mail inválido!";
                lblWrongEmail.Visible = true;
                valid = false;
            }


            if (!valid)
                txtEmail.BorderColor = wrong_border_color;

            return valid;
        }

        private void GetData()
        {
            if (editUser == null)
            {
                editUser = new UserModel();
            }

            editUser.Code = UserControll.GetNextCode();
            editUser.Name = txtUsername.Texts;
            editUser.Login = txtLogin.Texts;
            editUser.Email = txtEmail.Texts;
            editUser.Profile = rbtnAdministrator.Checked ? 0 : 1;
            editUser.IsFirstAccess = false;
            editUser.Status = editMode ? cbStatus.Checked : true;

            ActivityControll activityControll = new ActivityControll();

            if (editMode)
            {
                ActivityModel activity = new ActivityModel()
                {
                    Date = DateTime.Now,
                    Hour = DateTime.Now,
                    Item = editUser.Name,
                    Type = ActivityType.Updated,
                    User = frmAdministrativeMain.logedUser
                };

                int id = activityControll.AddActivity(activity);
                editUser.UpdatedId = id;
            }
            else
            {
                ActivityModel activity = new ActivityModel()
                {
                    Date = DateTime.Now,
                    Hour = DateTime.Now,
                    Item = editUser.Name,
                    Type = ActivityType.Created,
                    User = frmAdministrativeMain.logedUser
                };

                int id = activityControll.AddActivity(activity);
                editUser.AddedId = id;
                editUser.UpdatedId = id;
            }
        }

        private void txtUsername__TextChanged(object sender, EventArgs e)
        {
            txtUsername.BorderColor = normal_border_color;
        }

        private void txtLogin__TextChanged(object sender, EventArgs e)
        {
            txtLogin.BorderColor = normal_border_color;
            lblWrongLogin.Visible = false;
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            txtEmail.BorderColor = normal_border_color;
            lblWrongEmail.Visible = false;
        }

        private void FrmAdministrativeAddUser_Load(object sender, EventArgs e)
        {
            if (editUser != null)
                FillFields();
        }
        private void FillFields()
        {
            txtUsername.Focus();
            txtUsername.Texts = editUser.Name;

            txtLogin.Focus();
            txtLogin.Texts = editUser.Login;

            txtEmail.Focus();
            txtEmail.Texts = editUser.Email;

            if (editUser.Profile == 0)
                rbtnAdministrator.Checked = true;
            else
                rbtnDefault.Checked = true;

            if (editMode)
            {
                cbStatus.Visible = true;
                lblStatus.Visible = true;
                string status = cbStatus.Checked ? "ativo" : "inativo";
                cbStatus.Checked = editUser.Status;
            }

            if (editUser.Code == 0)
            {
                txtEmail.Enabled = false;
                rbtnAdministrator.Visible = false;
                rbtnDefault.Visible = false;
                lblAdmin.Visible = false;
                lblDefault.Visible = false;
            }
        }
        private void AdminLayout()
        {
            rbtnAdministrator.Enabled = false;
            rbtnAdministrator.Checked = true;
            rbtnDefault.Enabled = false;
            lblDefault.Visible = false;
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeViewUsers(frmAdministrativeMain));
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            string status = cbStatus.Checked ? "ativo" : "inativo";
            lblStatus.Text = $"Status ({status})";
        }
    }
}
