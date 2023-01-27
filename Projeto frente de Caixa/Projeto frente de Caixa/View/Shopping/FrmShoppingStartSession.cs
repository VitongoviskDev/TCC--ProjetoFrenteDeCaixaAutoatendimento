using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping {
    public partial class FrmShoppingStartSession : Form {
        FrmModes frmModes;
        public FrmShoppingStartSession(FrmModes parent) {
            InitializeComponent();

            frmModes = parent;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            pnCPF.Visible = true;
            pnStart.Visible = false;
        }

        private void btnYes_Click(object sender, EventArgs e) {
            FrmShoppingGetCPF frmShoppinGetCPF = new FrmShoppingGetCPF(frmModes);
            frmShoppinGetCPF.Show();
            this.Close();
        }
        
        private void btnNo_Click(object sender, EventArgs e) {
            FrmShoppingMain frmShoppingMain = new FrmShoppingMain(frmModes, null);
            frmShoppingMain.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            pnCPF.Visible = false;
            pnStart.Visible = true;
        }
    }
}
