namespace Projeto_frente_de_Caixa.View.Shopping
{
    partial class FrmShoppingInvalidPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnChoosePayment = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(190, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(700, 67);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextColor = System.Drawing.Color.Crimson;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChoosePayment
            // 
            this.btnChoosePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoosePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnChoosePayment.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChoosePayment.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnChoosePayment.BorderRadius = 178;
            this.btnChoosePayment.BorderSize = 3;
            this.btnChoosePayment.FlatAppearance.BorderSize = 0;
            this.btnChoosePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePayment.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePayment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoosePayment.Location = new System.Drawing.Point(190, 374);
            this.btnChoosePayment.Name = "btnChoosePayment";
            this.btnChoosePayment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnChoosePayment.Size = new System.Drawing.Size(700, 178);
            this.btnChoosePayment.TabIndex = 0;
            this.btnChoosePayment.Text = "ESCOLHER OUTRA FORMA DE PAGAMENTO";
            this.btnChoosePayment.TextColor = System.Drawing.Color.MidnightBlue;
            this.btnChoosePayment.UseVisualStyleBackColor = false;
            this.btnChoosePayment.Click += new System.EventHandler(this.btnChoosePayment_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMessage.Location = new System.Drawing.Point(190, 62);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(700, 283);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmShoppingInvalidPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnChoosePayment);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingInvalidPayment";
            this.Text = "FrmShoppingInvalidPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private kfcCustomControls.KFCCustomControls.kFCButton btnChoosePayment;
        private System.Windows.Forms.Label lblMessage;
    }
}