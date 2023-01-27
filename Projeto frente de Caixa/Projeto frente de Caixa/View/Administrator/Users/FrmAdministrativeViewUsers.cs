using Org.BouncyCastle.Asn1.X509;
using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.View.Administrator.Products;
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
    public partial class FrmAdministrativeViewUsers : Form
    {
        FrmAdministrativeMain frmAdministrativeMain;
        List<UserModel> allUsers;
        Dictionary<int, int> userIdByIndex = new Dictionary<int, int>();

        UserModel selectedUser = null;
        DataGridViewRow selectedRow;

        FrmAdministrativeUserDetails frmAdministrativeUserDetails;

        public FrmAdministrativeViewUsers(FrmAdministrativeMain parent)
        {
            InitializeComponent();

            frmAdministrativeMain = parent;
            if(frmAdministrativeMain.logedUser.Profile != 0)
            {
                SetToolBarLayout();
            }
        }

        private void SetToolBarLayout()
        {
            btnAdduser.Visible = false;

            pnToolBar.Width = Width - 100;
            pnToolBar.Location = new Point(50, pnToolBar.Location.Y);

            btnEdit.Visible = false;

            pnSearchBar.Width = pnToolBar.Width - 10;
            pnSearchBar.Location = new Point(5, pnSearchBar.Location.Y);

        }

        private void FrmAdministrativeViewUsers_Load(object sender, EventArgs e)
        {
            allUsers = FetchUsers();
            UpdateDataGridView(allUsers);
        }
        private List<UserModel> FetchUsers()
        {
            UserControll userControll = new UserControll();
            return userControll.GetAllUsers();
        }
        private void UpdateDataGridView(List<UserModel> listedUsers)
        {
            dgvUsers.Rows.Clear();
            if (listedUsers.Count == 0)
            {
                lblFetchStatus.Text = "Nenhum produto encontrado";
                return;
            }
            userIdByIndex = new Dictionary<int, int>();
            foreach (UserModel user in listedUsers)
            {
                int code = user.Code;
                userIdByIndex.Add(code, user.Id);

                dgvUsers.Rows.Add(String.Format("{0:0000}", code), user.Name, user.Login, user.Profile == 0 ? "Admin" : "Padrão", user.Email, user.Status ? "ativo" : "inativo", Properties.Resources.infoDark);
                if (!user.Status)
                {
                    dgvUsers.Rows[dgvUsers.Rows.Count - 1].Cells[6].Style.ForeColor = Color.Crimson;
                }
            }
            lblFetchStatus.Visible = false;
        }

        private void dgvProducts_SizeChanged(object sender, EventArgs e)
        {
            int unit = dgvUsers.Width / 100;

            clmIndex.Width = unit * 5;
            clmName.Width = unit * 30;
            clmLogin.Width = unit * 20;
            clmEmail.Width = unit * 20;
            clmProfile.Width = unit * 10;
            clmStatus.Width = unit * 10;
            clmInfo.Width = unit * 5;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                selectedRow = dgvUsers.Rows[dgvUsers.SelectedCells[0].RowIndex];

                UserControll userControll = new UserControll();
                selectedUser = userControll.GetUserById(new UserModel() { Id = userIdByIndex[int.Parse(selectedRow.Cells[0].Value.ToString())]});

                selectedRow.Selected = true;

                if (selectedRow.Cells[6].Value.ToString().ToLower() != "ativo")
                    dgvUsers.Rows[dgvUsers.Rows.Count - 1].Cells[6].Style.ForeColor = Color.Crimson;

                btnEdit.Enabled = true;
                if (selectedUser.Code == 0 || selectedUser.Id == frmAdministrativeMain.logedUser.Id)
                {
                    btnEdit.Enabled = false;
                }

            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                UserControll userControll = new UserControll();
                UserModel user = userControll.GetUserById(new UserModel() { Id = selectedUser.Id });

                string chageTo = user.Status ? "desativar" : "ativar";
                string index = dgvUsers.Rows[selectedRow.Index].Cells[0].Value.ToString();

                if (user.Status)
                    userControll.DisabeUser(user);
                else
                    userControll.EnableUser(user);

                int selectedRowIndex = selectedRow.Index;
                UpdateDataGridView(FetchUsers());

                dgvUsers.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddUser(frmAdministrativeMain, null));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedUser != null)
                frmAdministrativeMain.OpenChildForm(new FrmAdministrativeAddUser(frmAdministrativeMain, selectedUser));
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string index = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                UserControll userControll = new UserControll();
                frmAdministrativeUserDetails = new FrmAdministrativeUserDetails(selectedUser, this);
                frmAdministrativeUserDetails.Show();

                this.Enabled = false;
            }
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            List<UserModel> filteredUsers = new List<UserModel>();
            foreach (UserModel user in allUsers)
            {
                if (user.Code.ToString().Contains(txtSearch.Texts.Trim().ToLower()) ||
                    user.Name.Contains(txtSearch.Texts.Trim().ToLower()) ||
                    user.Login.Contains(txtSearch.Texts.Trim()))
                {
                    filteredUsers.Add(user);
                }
            }
            UpdateDataGridView(filteredUsers);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (frmAdministrativeUserDetails != null)
                frmAdministrativeUserDetails.Close();
        }
    }
}
