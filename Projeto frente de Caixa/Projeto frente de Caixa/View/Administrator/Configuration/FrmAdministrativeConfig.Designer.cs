namespace Projeto_frente_de_Caixa.View.Administrator.Configuration
{
    partial class FrmAdministrativeConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrativeConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtEmail = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.cbSendPasswordChanged = new kfcCustomControls.KFCCustomControls.KFCToggleButton();
            this.lblSendPasswordNotification = new System.Windows.Forms.Label();
            this.cbSendItemSoldOut = new kfcCustomControls.KFCCustomControls.KFCToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnEmailInfo = new System.Windows.Forms.Panel();
            this.btnUpdate = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblWrongEmail = new System.Windows.Forms.Label();
            this.txtPassword = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.pnVerificatioCode = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.lblChangeEmail = new System.Windows.Forms.Label();
            this.btnVerify = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.txtCode = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.lblEmailSend = new System.Windows.Forms.Label();
            this.cbShowPass = new kfcCustomControls.KFCCustomControls.KFCToggleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnVerificatioCode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(342, 118);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(404, 50);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Este e-mail será ultilizado para enviar e receber e-mails";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Visible = false;
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
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(346, 78);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtEmail.PlaceHolderText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(400, 36);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // cbSendPasswordChanged
            // 
            this.cbSendPasswordChanged.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSendPasswordChanged.AutoSize = true;
            this.cbSendPasswordChanged.Location = new System.Drawing.Point(350, 531);
            this.cbSendPasswordChanged.MinimumSize = new System.Drawing.Size(44, 22);
            this.cbSendPasswordChanged.Name = "cbSendPasswordChanged";
            this.cbSendPasswordChanged.OffBackColor = System.Drawing.Color.Gray;
            this.cbSendPasswordChanged.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cbSendPasswordChanged.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.cbSendPasswordChanged.OnToggleColor = System.Drawing.Color.White;
            this.cbSendPasswordChanged.Size = new System.Drawing.Size(44, 22);
            this.cbSendPasswordChanged.TabIndex = 3;
            this.cbSendPasswordChanged.UseVisualStyleBackColor = true;
            // 
            // lblSendPasswordNotification
            // 
            this.lblSendPasswordNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSendPasswordNotification.AutoSize = true;
            this.lblSendPasswordNotification.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendPasswordNotification.Location = new System.Drawing.Point(400, 532);
            this.lblSendPasswordNotification.Name = "lblSendPasswordNotification";
            this.lblSendPasswordNotification.Size = new System.Drawing.Size(324, 21);
            this.lblSendPasswordNotification.TabIndex = 4;
            this.lblSendPasswordNotification.Text = "Enviar e-mail quando senha for alterada";
            // 
            // cbSendItemSoldOut
            // 
            this.cbSendItemSoldOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSendItemSoldOut.AutoSize = true;
            this.cbSendItemSoldOut.Location = new System.Drawing.Point(350, 583);
            this.cbSendItemSoldOut.MinimumSize = new System.Drawing.Size(44, 22);
            this.cbSendItemSoldOut.Name = "cbSendItemSoldOut";
            this.cbSendItemSoldOut.OffBackColor = System.Drawing.Color.Gray;
            this.cbSendItemSoldOut.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cbSendItemSoldOut.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.cbSendItemSoldOut.OnToggleColor = System.Drawing.Color.White;
            this.cbSendItemSoldOut.Size = new System.Drawing.Size(44, 22);
            this.cbSendItemSoldOut.TabIndex = 4;
            this.cbSendItemSoldOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enviar e-mail quando produto esgotar";
            // 
            // pnEmailInfo
            // 
            this.pnEmailInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnEmailInfo.BackgroundImage = global::Projeto_frente_de_Caixa.Properties.Resources.infoDark;
            this.pnEmailInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnEmailInfo.Location = new System.Drawing.Point(753, 78);
            this.pnEmailInfo.Name = "pnEmailInfo";
            this.pnEmailInfo.Size = new System.Drawing.Size(32, 32);
            this.pnEmailInfo.TabIndex = 2;
            this.pnEmailInfo.MouseEnter += new System.EventHandler(this.pnEmailInfo_MouseEnter);
            this.pnEmailInfo.MouseLeave += new System.EventHandler(this.pnEmailInfo_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderRadius = 60;
            this.btnUpdate.BorderSize = 3;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(307, 648);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(439, 60);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWrongEmail
            // 
            this.lblWrongEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongEmail.AutoSize = true;
            this.lblWrongEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongEmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongEmail.Location = new System.Drawing.Point(342, 118);
            this.lblWrongEmail.Name = "lblWrongEmail";
            this.lblWrongEmail.Size = new System.Drawing.Size(121, 21);
            this.lblWrongEmail.TabIndex = 6;
            this.lblWrongEmail.Text = "E-mail inválido";
            this.lblWrongEmail.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.BottomBorderOnly = true;
            this.txtPassword.CursorIndex = 0;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(346, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceHolderText = "Senha";
            this.txtPassword.Size = new System.Drawing.Size(400, 36);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Texts = "";
            this.txtPassword._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lblTutorial
            // 
            this.lblTutorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTutorial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.Location = new System.Drawing.Point(165, 260);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(750, 249);
            this.lblTutorial.TabIndex = 0;
            this.lblTutorial.Text = resources.GetString("lblTutorial.Text");
            this.lblTutorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTutorial.Visible = false;
            // 
            // pnVerificatioCode
            // 
            this.pnVerificatioCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnVerificatioCode.BackColor = System.Drawing.Color.Black;
            this.pnVerificatioCode.Controls.Add(this.panel2);
            this.pnVerificatioCode.Location = new System.Drawing.Point(160, 60);
            this.pnVerificatioCode.Name = "pnVerificatioCode";
            this.pnVerificatioCode.Padding = new System.Windows.Forms.Padding(5);
            this.pnVerificatioCode.Size = new System.Drawing.Size(800, 600);
            this.pnVerificatioCode.TabIndex = 7;
            this.pnVerificatioCode.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblWrongCode);
            this.panel2.Controls.Add(this.lblChangeEmail);
            this.panel2.Controls.Add(this.btnVerify);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.lblEmailSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 590);
            this.panel2.TabIndex = 7;
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCode.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongCode.Location = new System.Drawing.Point(202, 334);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(140, 21);
            this.lblWrongCode.TabIndex = 7;
            this.lblWrongCode.Text = "Usar outro e-mail";
            this.lblWrongCode.Visible = false;
            this.lblWrongCode.Click += new System.EventHandler(this.lblChangeEmail_Click);
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEmail.Location = new System.Drawing.Point(258, 518);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(235, 33);
            this.lblChangeEmail.TabIndex = 7;
            this.lblChangeEmail.Text = "Usar outro e-mail";
            this.lblChangeEmail.Click += new System.EventHandler(this.lblChangeEmail_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVerify.BorderColor = System.Drawing.Color.Black;
            this.btnVerify.BorderRadius = 60;
            this.btnVerify.BorderSize = 3;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(156, 455);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(439, 60);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.Text = "VERIFICAR";
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
            this.txtCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.Black;
            this.txtCode.Location = new System.Drawing.Point(195, 290);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtCode.PlaceHolderText = "Código de verificação";
            this.txtCode.Size = new System.Drawing.Size(400, 40);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.Texts = "";
            this.txtCode._TextChanged += new System.EventHandler(this.txtCode__TextChanged);
            // 
            // lblEmailSend
            // 
            this.lblEmailSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmailSend.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSend.Location = new System.Drawing.Point(0, 0);
            this.lblEmailSend.Name = "lblEmailSend";
            this.lblEmailSend.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lblEmailSend.Size = new System.Drawing.Size(790, 174);
            this.lblEmailSend.TabIndex = 0;
            this.lblEmailSend.Text = "Digite o código de verificação enviado para";
            this.lblEmailSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbShowPass
            // 
            this.cbShowPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(702, 218);
            this.cbShowPass.MinimumSize = new System.Drawing.Size(44, 22);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.OffBackColor = System.Drawing.Color.Gray;
            this.cbShowPass.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cbShowPass.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.cbShowPass.OnToggleColor = System.Drawing.Color.White;
            this.cbShowPass.Size = new System.Drawing.Size(44, 22);
            this.cbShowPass.TabIndex = 3;
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mostrar senha";
            // 
            // FrmAdministrativeConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnVerificatioCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWrongEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSendPasswordNotification);
            this.Controls.Add(this.cbSendItemSoldOut);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.cbSendPasswordChanged);
            this.Controls.Add(this.pnEmailInfo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeConfig";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pnVerificatioCode.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtEmail;
        private System.Windows.Forms.Panel pnEmailInfo;
        private kfcCustomControls.KFCCustomControls.KFCToggleButton cbSendPasswordChanged;
        private System.Windows.Forms.Label lblSendPasswordNotification;
        private kfcCustomControls.KFCCustomControls.KFCToggleButton cbSendItemSoldOut;
        private System.Windows.Forms.Label label2;
        private kfcCustomControls.KFCCustomControls.kFCButton btnUpdate;
        private System.Windows.Forms.Label lblWrongEmail;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtPassword;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Panel pnVerificatioCode;
        private System.Windows.Forms.Panel panel2;
        private kfcCustomControls.KFCCustomControls.kFCButton btnVerify;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtCode;
        private System.Windows.Forms.Label lblEmailSend;
        private System.Windows.Forms.Label lblChangeEmail;
        private System.Windows.Forms.Label lblWrongCode;
        private kfcCustomControls.KFCCustomControls.KFCToggleButton cbShowPass;
        private System.Windows.Forms.Label label3;
    }
}