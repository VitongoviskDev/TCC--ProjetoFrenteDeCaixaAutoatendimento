using Projeto_frente_de_Caixa.Control;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Util;
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
using Ubiety.Dns.Core.Records.NotUsed;

namespace Projeto_frente_de_Caixa.View {
    public partial class FrmPasswordRecoveryNewPassword : Form {
        private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";
        private const string SPECIAL_CHARACTERS = "!@#$%&*_-";

        private Color normal_color = Color.Black;
        private Color wrong_color = Color.Crimson;


        private bool uppercase = false;
        private bool lowercase = false;
        private bool number = false;
        private bool special = false;

        FrmLogin frmLogin;
        int userId;
        public FrmPasswordRecoveryNewPassword(FrmLogin parent, int id) {
            InitializeComponent();

            frmLogin = parent;
            userId = id;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e) {
            if (ValidatePassword() && ValidateConfirmPassword()) {
                UserControll userControll = new UserControll();
                UserModel user = userControll.GetUserById(new UserModel() { Id = userId });
                userControll.UpdatePassword(txtPassword.Texts, user);
                user.IsFirstAccess = false;

                ActivityModel activity = new ActivityModel()
                {
                    Date = DateTime.Now,
                    Hour = DateTime.Now,
                    Item = user.Name,
                    Type = ActivityType.Updated,
                    User = user
                };

                ActivityControll activityControll = new ActivityControll();
                activity.Id = activityControll.AddActivity(activity);

                user.UpdatedId = activity.Id;
                
                userControll.UpdateUser(user);

                ConfigControll configControll = new ConfigControll();
                if (configControll.GetConfig().SendPassworChangedEmail)
                    EmailSender.SendPasswordChangedEmail(user.Email);

                this.Close();
                frmLogin.Show();
            }
        }
        private bool ValidateConfirmPassword() {
            bool valid = true;
            if(txtConfirmPassword.Texts != txtPassword.Texts) {
                txtConfirmPassword.BorderColor = wrong_color;
                lblWrongPassword.Visible = true;
                valid = false;
            }
            return valid;
        }
        private void txtPassword__TextChanged(object sender, EventArgs e) {
            txtPassword.BorderColor = normal_color;
            uppercase = false;
            lowercase = false;
            number = false;
            special = false;

            foreach (char letter in txtPassword.Texts) {
                if (ALPHABET.ToUpper().Contains(letter)) {
                    uppercase = true;
                }
                else if (ALPHABET.Contains(letter)) {
                    lowercase = true;
                }
                else if (NUMBERS.Contains(letter)) {
                    number = true;
                }
                else if (SPECIAL_CHARACTERS.Contains(letter)) {
                    special = true;
                }

            }
            

        }

        private bool ValidatePassword() {
            bool valid = true;
            if (!uppercase) {
                txtPassword.BorderColor = wrong_color;
                lblCaps.ForeColor = wrong_color;
                valid = false;
            }
            if (!lowercase) {
                txtPassword.BorderColor = wrong_color;
                lblCaps.ForeColor = wrong_color;
                valid = false;
            }
            if (!number) {
                txtPassword.BorderColor = wrong_color;
                lblNumber.ForeColor = wrong_color;
                valid = false;
            }
            if (!special) {
                txtPassword.BorderColor = wrong_color;
                lblSpecial.ForeColor = wrong_color;
                valid = false;
            }
            txtPassword.BorderColor = valid ? normal_color : wrong_color;
            return valid;
        }

        private void txtConfirmPassword__TextChanged(object sender, EventArgs e) {
            txtConfirmPassword.BorderColor = normal_color;
            lblWrongPassword.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e) {
            ValidatePassword();
        }
    }
}
