namespace Projeto_frente_de_Caixa.View.Administrator.Users
{
    partial class FrmAdministrativeAddUser
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
            this.lblWrongLogin = new System.Windows.Forms.Label();
            this.txtLogin = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtUsername = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtEmail = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.rbtnAdministrator = new kfcCustomControls.KFCCustomControls.KFCRadioButton();
            this.rbtnDefault = new kfcCustomControls.KFCCustomControls.KFCRadioButton();
            this.btnAdd = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblWrongEmail = new System.Windows.Forms.Label();
            this.cbStatus = new kfcCustomControls.KFCCustomControls.KFCToggleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWrongLogin
            // 
            this.lblWrongLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWrongLogin.AutoSize = true;
            this.lblWrongLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongLogin.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongLogin.Location = new System.Drawing.Point(295, 219);
            this.lblWrongLogin.Name = "lblWrongLogin";
            this.lblWrongLogin.Size = new System.Drawing.Size(170, 22);
            this.lblWrongLogin.TabIndex = 93;
            this.lblWrongLogin.Text = "Login indisponível";
            this.lblWrongLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongLogin.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.BorderColor = System.Drawing.Color.Black;
            this.txtLogin.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtLogin.BorderRadius = 0;
            this.txtLogin.BorderSize = 2;
            this.txtLogin.BottomBorderOnly = true;
            this.txtLogin.CursorIndex = 0;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(290, 175);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 255;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtLogin.PlaceHolderText = "Login";
            this.txtLogin.Size = new System.Drawing.Size(500, 40);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogin.Texts = "";
            this.txtLogin._TextChanged += new System.EventHandler(this.txtLogin__TextChanged);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtUsername.BorderRadius = 6;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.BottomBorderOnly = true;
            this.txtUsername.CursorIndex = 0;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtUsername.Location = new System.Drawing.Point(290, 102);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 255;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceHolderText = "Nome";
            this.txtUsername.Size = new System.Drawing.Size(500, 40);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.Texts = "";
            this.txtUsername._TextChanged += new System.EventHandler(this.txtUsername__TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 98;
            this.label1.Text = "Código:";
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(419, 48);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(79, 36);
            this.lblCode.TabIndex = 98;
            this.lblCode.Text = "0283";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.BottomBorderOnly = true;
            this.txtEmail.CursorIndex = 0;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(290, 270);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceHolderText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(500, 40);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // rbtnAdministrator
            // 
            this.rbtnAdministrator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnAdministrator.AutoSize = true;
            this.rbtnAdministrator.CheckColor = System.Drawing.Color.RoyalBlue;
            this.rbtnAdministrator.Checked = true;
            this.rbtnAdministrator.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdministrator.Location = new System.Drawing.Point(366, 363);
            this.rbtnAdministrator.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnAdministrator.Name = "rbtnAdministrator";
            this.rbtnAdministrator.Size = new System.Drawing.Size(178, 28);
            this.rbtnAdministrator.TabIndex = 4;
            this.rbtnAdministrator.TabStop = true;
            this.rbtnAdministrator.Text = "Administrador";
            this.rbtnAdministrator.UncheckedColor = System.Drawing.Color.DimGray;
            this.rbtnAdministrator.UseVisualStyleBackColor = true;
            this.rbtnAdministrator.CheckedChanged += new System.EventHandler(this.rbtnAdministrator_CheckedChanged);
            // 
            // rbtnDefault
            // 
            this.rbtnDefault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnDefault.AutoSize = true;
            this.rbtnDefault.CheckColor = System.Drawing.Color.RoyalBlue;
            this.rbtnDefault.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDefault.Location = new System.Drawing.Point(600, 363);
            this.rbtnDefault.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnDefault.Name = "rbtnDefault";
            this.rbtnDefault.Size = new System.Drawing.Size(114, 28);
            this.rbtnDefault.TabIndex = 5;
            this.rbtnDefault.Text = "Padrão";
            this.rbtnDefault.UncheckedColor = System.Drawing.Color.DimGray;
            this.rbtnDefault.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 60;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(290, 620);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(500, 60);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Concluir";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 60;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 60);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(363, 394);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(225, 113);
            this.lblAdmin.TabIndex = 98;
            this.lblAdmin.Text = "•   Visualizar\r\n•   Adicionar\r\n•   Editar\r\n•   Excluir\r\n•   Registrar entradas no" +
    " estoque\r\n (todos os itens do sistema)";
            // 
            // lblDefault
            // 
            this.lblDefault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDefault.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefault.Location = new System.Drawing.Point(597, 394);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(129, 77);
            this.lblDefault.TabIndex = 98;
            this.lblDefault.Text = "•   Visualizar \r\n      x produtos\r\n      x categorias\r\n      x usuários\r\n";
            this.lblDefault.Visible = false;
            // 
            // lblWrongEmail
            // 
            this.lblWrongEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWrongEmail.AutoSize = true;
            this.lblWrongEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongEmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongEmail.Location = new System.Drawing.Point(295, 314);
            this.lblWrongEmail.Name = "lblWrongEmail";
            this.lblWrongEmail.Size = new System.Drawing.Size(249, 22);
            this.lblWrongEmail.TabIndex = 93;
            this.lblWrongEmail.Text = "Este e-mail já foi registrado";
            this.lblWrongEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongEmail.Visible = false;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(290, 524);
            this.cbStatus.MinimumSize = new System.Drawing.Size(44, 22);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.OffBackColor = System.Drawing.Color.Gray;
            this.cbStatus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cbStatus.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.cbStatus.OnToggleColor = System.Drawing.Color.White;
            this.cbStatus.Size = new System.Drawing.Size(44, 22);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.Visible = false;
            this.cbStatus.CheckedChanged += new System.EventHandler(this.cbStatus_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(340, 525);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(127, 21);
            this.lblStatus.TabIndex = 98;
            this.lblStatus.Text = "Status(Inativo)";
            this.lblStatus.Visible = false;
            // 
            // FrmAdministrativeAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbtnDefault);
            this.Controls.Add(this.rbtnAdministrator);
            this.Controls.Add(this.lblDefault);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWrongEmail);
            this.Controls.Add(this.lblWrongLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeAddUser";
            this.Text = "Adicionar usuários";
            this.Load += new System.EventHandler(this.FrmAdministrativeAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWrongLogin;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtLogin;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtEmail;
        private kfcCustomControls.KFCCustomControls.KFCRadioButton rbtnAdministrator;
        private kfcCustomControls.KFCCustomControls.KFCRadioButton rbtnDefault;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdd;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.Label lblWrongEmail;
        private kfcCustomControls.KFCCustomControls.KFCToggleButton cbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}