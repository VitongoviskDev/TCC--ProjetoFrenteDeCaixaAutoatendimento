using Projeto_Frente_de_Caixa.View.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_frente_de_Caixa.View.Shopping
{
    public partial class FrmShoppingKeyboard : Form
    {
        TextBox textBox = null;
        KFCTextBox kfcTextBox = null;


        public Point downPoint = Point.Empty;

        public FrmShoppingKeyboard(TextBox tb)
        {
            InitializeComponent();
            textBox = tb;
        }
        public FrmShoppingKeyboard(KFCTextBox kfctb)
        {
            InitializeComponent();
            kfcTextBox = kfctb;
        }

        private void GetButtonText(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;

            string text = button.Name;

            if (button.Name.Contains("button"))
                text = button.Name.Remove(0, 6);

            if (text == "_") text = "-";

            button.Text = text;
        }

        private void AddText(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string text = button.Name;

            if (button.Name.Contains("button"))
                text = button.Name.Remove(0, 6);

            else if (button.Name == SPACE.Name)
                text = " ";

            if (text == "_") text = "-";


            txtText.Text += text;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {   
            if(txtText.Text.Length > 0)
                txtText.Text = txtText.Text.Remove(txtText.Text.Length - 1, 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (kfcTextBox != null)
                kfcTextBox.Texts = txtText.Text;
            else
                textBox.Text = txtText.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
