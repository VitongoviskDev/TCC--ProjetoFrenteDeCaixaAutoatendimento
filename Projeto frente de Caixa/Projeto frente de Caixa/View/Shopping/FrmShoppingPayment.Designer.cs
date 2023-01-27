namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    partial class FrmShoppingPayment
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
            this.btnCredit = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnDebit = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.SuspendLayout();
            // 
            // btnCredit
            // 
            this.btnCredit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCredit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCredit.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnCredit.BorderColor = System.Drawing.Color.Black;
            this.btnCredit.BorderRadius = 40;
            this.btnCredit.BorderSize = 0;
            this.btnCredit.FlatAppearance.BorderSize = 0;
            this.btnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredit.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnCredit.Location = new System.Drawing.Point(150, 423);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(300, 160);
            this.btnCredit.TabIndex = 0;
            this.btnCredit.Text = "CRÉDITO";
            this.btnCredit.TextColor = System.Drawing.Color.LightSkyBlue;
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnDebit
            // 
            this.btnDebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDebit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDebit.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnDebit.BorderColor = System.Drawing.Color.Black;
            this.btnDebit.BorderRadius = 40;
            this.btnDebit.BorderSize = 0;
            this.btnDebit.FlatAppearance.BorderSize = 0;
            this.btnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebit.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnDebit.Location = new System.Drawing.Point(630, 423);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(300, 160);
            this.btnDebit.TabIndex = 0;
            this.btnDebit.Text = "DÉBITO";
            this.btnDebit.TextColor = System.Drawing.Color.LightSkyBlue;
            this.btnDebit.UseVisualStyleBackColor = false;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 111);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total a pagar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalValue.Font = new System.Drawing.Font("Century Gothic", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalValue.Location = new System.Drawing.Point(150, 130);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(780, 122);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "R$99.999,99";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(150, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 129);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleciona a forma de pagamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(385, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(310, 60);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextColor = System.Drawing.Color.Crimson;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmShoppingPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.btnCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingPayment";
            this.Text = "FrmShoppingPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmShoppingPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnCredit;
        private kfcCustomControls.KFCCustomControls.kFCButton btnDebit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label3;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
    }
}