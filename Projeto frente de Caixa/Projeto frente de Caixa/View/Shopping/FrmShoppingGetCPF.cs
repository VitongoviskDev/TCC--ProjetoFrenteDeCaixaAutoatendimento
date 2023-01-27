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
using Ubiety.Dns.Core.Records.NotUsed;

namespace Projeto_frente_de_Caixa.View.Shopping {
    public partial class FrmShoppingGetCPF : Form {
        FrmModes frmModes;
        public FrmShoppingGetCPF(FrmModes modes) {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            frmModes = modes;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (ValidateCPF()) {
                FrmShoppingMain frmShoppingMain = new FrmShoppingMain(frmModes, new DocumentModel() { Cpf = txtCpf.Texts });
                frmShoppingMain.Show();
                this.Close();
            }
        }
        private bool ValidateCPF() {
            bool valid = true;
            if (string.IsNullOrEmpty(txtCpf.Texts))
                valid = false;
            else if(!DocumentControll.ValidaCPF(txtCpf.Texts.Trim()))
                valid = false;

            if (!valid)
            {
                MessageBox.Show("O CPF informado não é válido, por favor digite novamente");
                txtCpf.Focus();
                txtCpf.Texts = "";
                btnAdd.Focus();
            }

            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            FrmShoppingMain frmShoppingMain = new FrmShoppingMain(frmModes, null);
            frmShoppingMain.Show();
            this.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Addchar('0');
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Addchar('1');
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Addchar('2');
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Addchar('3');
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Addchar('4');
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Addchar('5');
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Addchar('6');
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Addchar('7');
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Addchar('8');
        }
        private void btn9_Click(object sender, EventArgs e) {
            Addchar('9');
        }


        private void btnClear_Click(object sender, EventArgs e) {
            if(txtCpf.Texts.Length > 0)
                txtCpf.Texts = txtCpf.Texts.Remove(txtCpf.Texts.Length - 1);
        }
        private void Addchar(char c)
        {
            txtCpf.Focus();
            if (txtCpf.Texts.Length < 11)
                txtCpf.Texts += c;
            txtCpf.CursorIndex = txtCpf.Texts.Length;
        }

    }
}
