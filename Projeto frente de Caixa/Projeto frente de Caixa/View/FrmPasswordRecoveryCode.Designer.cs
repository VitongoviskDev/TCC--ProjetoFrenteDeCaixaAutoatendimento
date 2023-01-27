namespace Projeto_frente_de_Caixa.View
{
    partial class FrmPasswordRecoveryCode
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
            this.btnVerify = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.txtCode = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailFail = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.txtFocus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerify.BackColor = System.Drawing.Color.Silver;
            this.btnVerify.BackgroundColor = System.Drawing.Color.Silver;
            this.btnVerify.BorderColor = System.Drawing.Color.Black;
            this.btnVerify.BorderRadius = 80;
            this.btnVerify.BorderSize = 0;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(390, 488);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(300, 80);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.TextColor = System.Drawing.Color.Black;
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCode.BorderColor = System.Drawing.Color.Black;
            this.txtCode.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtCode.BorderRadius = 0;
            this.txtCode.BorderSize = 2;
            this.txtCode.BottomBorderOnly = true;
            this.txtCode.CursorIndex = 0;
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(320, 367);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceHolderColor = System.Drawing.Color.Gray;
            this.txtCode.PlaceHolderText = "Código de virificação";
            this.txtCode.Size = new System.Drawing.Size(446, 48);
            this.txtCode.TabIndex = 5;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(314, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o código enviado para ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Redefinir senha";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(314, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(314, 36);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "email@exemplo.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailFail
            // 
            this.lblEmailFail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailFail.AutoSize = true;
            this.lblEmailFail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFail.ForeColor = System.Drawing.Color.Black;
            this.lblEmailFail.Location = new System.Drawing.Point(558, 428);
            this.lblEmailFail.Name = "lblEmailFail";
            this.lblEmailFail.Size = new System.Drawing.Size(208, 24);
            this.lblEmailFail.TabIndex = 7;
            this.lblEmailFail.Text = "Não recebi o email";
            this.lblEmailFail.Click += new System.EventHandler(this.lblEmailFail_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCancel.AutoSize = true;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Crimson;
            this.lblCancel.Location = new System.Drawing.Point(465, 573);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(150, 36);
            this.lblCancel.TabIndex = 9;
            this.lblCancel.Text = "Cancelar";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // txtFocus
            // 
            this.txtFocus.Location = new System.Drawing.Point(-50, -50);
            this.txtFocus.Name = "txtFocus";
            this.txtFocus.Size = new System.Drawing.Size(100, 20);
            this.txtFocus.TabIndex = 10;
            // 
            // FrmPasswordRecoveryCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.txtFocus);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblEmailFail);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordRecoveryCode";
            this.Text = "Recuperação de senha";
            this.SizeChanged += new System.EventHandler(this.FrmPasswordRecoveryCode_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnVerify;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailFail;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.TextBox txtFocus;
    }
}