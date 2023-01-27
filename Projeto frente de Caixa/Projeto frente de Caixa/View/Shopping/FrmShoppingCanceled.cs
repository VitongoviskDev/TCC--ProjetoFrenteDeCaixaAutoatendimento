using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping
{
    public partial class FrmShoppingCanceled : Form
    {
        int counter = 10;
        FrmShoppingStartSession frmShoppingStartSession;
        public FrmShoppingCanceled(FrmShoppingStartSession parent)
        {
            InitializeComponent();
            frmShoppingStartSession = parent;
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            if(counter == 0)
            {
                frmShoppingStartSession.Show();
                this.Close();
                tmTimer.Stop();
            }
            counter--;
        }
    }
}
