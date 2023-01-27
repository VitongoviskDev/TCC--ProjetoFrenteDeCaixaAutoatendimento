namespace Projeto_frente_de_Caixa.View
{
    partial class FrmPasswordRecoveryEmail
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.btnSend = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblWrongEmail = new System.Windows.Forms.Label();
            this.txtFocus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(349, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Redefinir senha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(743, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o E-mail definido para recuperação \r\nde senha, e enviaremos um código de v" +
    "erificação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.BottomBorderOnly = true;
            this.txtEmail.CursorIndex = 0;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(240, 367);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtEmail.PlaceHolderText = "email@exemplo.com";
            this.txtEmail.Size = new System.Drawing.Size(600, 48);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.Texts = "";
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSend.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSend.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.BorderRadius = 40;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSend.Location = new System.Drawing.Point(390, 500);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(300, 80);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.TextColor = System.Drawing.Color.Gainsboro;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCancel.AutoSize = true;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Crimson;
            this.lblCancel.Location = new System.Drawing.Point(451, 596);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(178, 42);
            this.lblCancel.TabIndex = 8;
            this.lblCancel.Text = "Cancelar";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblWrongEmail
            // 
            this.lblWrongEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongEmail.AutoSize = true;
            this.lblWrongEmail.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongEmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongEmail.Location = new System.Drawing.Point(400, 430);
            this.lblWrongEmail.Name = "lblWrongEmail";
            this.lblWrongEmail.Size = new System.Drawing.Size(280, 30);
            this.lblWrongEmail.TabIndex = 0;
            this.lblWrongEmail.Text = "Email não encontrado";
            this.lblWrongEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrongEmail.Visible = false;
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(-50, -50);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Size = new System.Drawing.Size(100, 20);
            this.txtFocus.TabIndex = 9;
            // 
            // FrmPasswordRecoveryEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.txtFocus);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblWrongEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordRecoveryEmail";
            this.Text = "Recuperação de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtEmail;
        private kfcCustomControls.KFCCustomControls.kFCButton btnSend;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblWrongEmail;
        private System.Windows.Forms.TextBox txtFocus;
    }
}