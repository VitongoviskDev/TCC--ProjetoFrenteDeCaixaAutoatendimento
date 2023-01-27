namespace Projeto_frente_de_Caixa.View.Administrator.Company
{
    partial class FrmAdministrativeAddCompany
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
            this.cmbDDD = new kfcCustomControls.KFCCustomControls.KFCComboBox();
            this.txtPhoneNumber = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdress = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpOpeningDate = new kfcCustomControls.KFCCustomControls.KFCDatePicker();
            this.lblWrongCnpj = new System.Windows.Forms.Label();
            this.txtStateRegistration = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtCnpj = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtEmail = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtSite = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtSocialReason = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtFantasyName = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDDD
            // 
            this.cmbDDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDDD.BorderColor = System.Drawing.Color.Black;
            this.cmbDDD.BorderSize = 2;
            this.cmbDDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDDD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDDD.ForeColor = System.Drawing.Color.Black;
            this.cmbDDD.IconColor = System.Drawing.Color.Black;
            this.cmbDDD.Items.AddRange(new object[] {
            "11 – São Paulo – SP",
            "12 – São José dos Campos – SP",
            "13 – Santos – SP",
            "14 – Bauru – SP",
            "15 – Sorocaba – SP",
            "16 – Ribeirão Preto – SP",
            "17 – São José do Rio Preto – SP",
            "18 – Presidente Prudente – SP",
            "19 – Campinas – SP",
            "21 – Rio de Janeiro – RJ",
            "22 – Campos dos Goytacazes – RJ",
            "24 – Volta Redonda – RJ",
            "27 – Vila Velha/Vitória – ES",
            "28 – Cachoeiro de Itapemirim – ES",
            "31 – Belo Horizonte – MG",
            "32 – Juiz de Fora – MG",
            "33 – Governador Valadares – MG",
            "34 – Uberlândia – MG",
            "35 – Poços de Caldas – MG",
            "37 – Divinópolis – MG",
            "38 – Montes Claros – MG",
            "41 – Curitiba – PR",
            "42 – Ponta Grossa – PR",
            "43 – Londrina – PR",
            "44 – Maringá – PR",
            "45 – Foz do Iguaçú – PR",
            "46 – Francisco Beltrão/Pato Branco – PR",
            "47 – Joinville – SC",
            "48 – Florianópolis – SC",
            "49 – Chapecó – SC",
            "51 – Porto Alegre – RS",
            "53 – Pelotas – RS",
            "54 – Caxias do Sul – RS",
            "55 – Santa Maria – RS",
            "61 – Brasília – DF",
            "62 – Goiânia – GO",
            "63 – Palmas – TO",
            "64 – Rio Verde – GO",
            "65 – Cuiabá – MT",
            "66 – Rondonópolis – MT",
            "67 – Campo Grande – MS",
            "68 – Rio Branco – AC",
            "69 – Porto Velho – RO",
            "71 – Salvador – BA",
            "73 – Ilhéus – BA",
            "74 – Juazeiro – BA",
            "75 – Feira de Santana – BA",
            "77 – Barreiras – BA",
            "79 – Aracaju – SE",
            "81 – Recife – PE",
            "82 – Maceió – AL",
            "83 – João Pessoa – PB",
            "84 – Natal – RN",
            "85 – Fortaleza – CE",
            "86 – Teresina – PI",
            "87 – Petrolina – PE",
            "88 – Juazeiro do Norte – CE",
            "89 – Picos – PI",
            "91 – Belém – PA",
            "92 – Manaus – AM",
            "93 – Santarém – PA",
            "94 – Marabá – PA",
            "95 – Boa Vista – RR",
            "96 – Macapá – AP",
            "97 – Coari – AM",
            "98 – São Luís – MA",
            "99 – Imperatriz – MA"});
            this.cmbDDD.ListBackColor = System.Drawing.Color.DimGray;
            this.cmbDDD.ListTextColor = System.Drawing.Color.White;
            this.cmbDDD.Location = new System.Drawing.Point(363, 508);
            this.cmbDDD.MinimumSize = new System.Drawing.Size(30, 30);
            this.cmbDDD.Name = "cmbDDD";
            this.cmbDDD.Padding = new System.Windows.Forms.Padding(2);
            this.cmbDDD.Size = new System.Drawing.Size(192, 40);
            this.cmbDDD.TabIndex = 6;
            this.cmbDDD.Texts = "DDD";
            this.cmbDDD.OnSelectedIndexChanged += new System.EventHandler(this.cmbDDD_OnSelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtPhoneNumber.BorderRadius = 0;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.BottomBorderOnly = true;
            this.txtPhoneNumber.CursorIndex = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(577, 508);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.MaxLength = 9;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceHolderText = "Tel/Cel";
            this.txtPhoneNumber.Size = new System.Drawing.Size(212, 40);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.Texts = "";
            this.txtPhoneNumber._TextChanged += new System.EventHandler(this.txtPhoneNumber__TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 77;
            this.label4.Text = "+55";
            // 
            // btnAdress
            // 
            this.btnAdress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdress.BackColor = System.Drawing.Color.Transparent;
            this.btnAdress.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdress.BorderColor = System.Drawing.Color.Black;
            this.btnAdress.BorderRadius = 60;
            this.btnAdress.BorderSize = 2;
            this.btnAdress.FlatAppearance.BorderSize = 0;
            this.btnAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdress.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdress.ForeColor = System.Drawing.Color.Black;
            this.btnAdress.Location = new System.Drawing.Point(289, 610);
            this.btnAdress.Name = "btnAdress";
            this.btnAdress.Size = new System.Drawing.Size(500, 60);
            this.btnAdress.TabIndex = 8;
            this.btnAdress.Text = "Cadastrar endereço";
            this.btnAdress.TextColor = System.Drawing.Color.Black;
            this.btnAdress.UseVisualStyleBackColor = false;
            this.btnAdress.Click += new System.EventHandler(this.btnAdress_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.dpOpeningDate);
            this.panel1.Location = new System.Drawing.Point(289, 285);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(500, 41);
            this.panel1.TabIndex = 74;
            // 
            // dpOpeningDate
            // 
            this.dpOpeningDate.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dpOpeningDate.BorderSize = 0;
            this.dpOpeningDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpOpeningDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpOpeningDate.Location = new System.Drawing.Point(4, 4);
            this.dpOpeningDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpOpeningDate.Name = "dpOpeningDate";
            this.dpOpeningDate.Size = new System.Drawing.Size(492, 35);
            this.dpOpeningDate.SkinColor = System.Drawing.Color.Black;
            this.dpOpeningDate.TabIndex = 0;
            this.dpOpeningDate.TextColor = System.Drawing.Color.White;
            // 
            // lblWrongCnpj
            // 
            this.lblWrongCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongCnpj.AutoSize = true;
            this.lblWrongCnpj.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCnpj.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongCnpj.Location = new System.Drawing.Point(285, 240);
            this.lblWrongCnpj.Name = "lblWrongCnpj";
            this.lblWrongCnpj.Size = new System.Drawing.Size(250, 22);
            this.lblWrongCnpj.TabIndex = 73;
            this.lblWrongCnpj.Text = "Adicionar nova categoria";
            this.lblWrongCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongCnpj.Visible = false;
            // 
            // txtStateRegistration
            // 
            this.txtStateRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStateRegistration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStateRegistration.BorderColor = System.Drawing.Color.Black;
            this.txtStateRegistration.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtStateRegistration.BorderRadius = 0;
            this.txtStateRegistration.BorderSize = 2;
            this.txtStateRegistration.BottomBorderOnly = true;
            this.txtStateRegistration.CursorIndex = 0;
            this.txtStateRegistration.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateRegistration.ForeColor = System.Drawing.Color.Black;
            this.txtStateRegistration.Location = new System.Drawing.Point(549, 196);
            this.txtStateRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.txtStateRegistration.MaxLength = 32767;
            this.txtStateRegistration.Multiline = false;
            this.txtStateRegistration.Name = "txtStateRegistration";
            this.txtStateRegistration.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStateRegistration.PasswordChar = '\0';
            this.txtStateRegistration.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtStateRegistration.PlaceHolderText = "Inscriçã estadual";
            this.txtStateRegistration.Size = new System.Drawing.Size(240, 40);
            this.txtStateRegistration.TabIndex = 3;
            this.txtStateRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStateRegistration.Texts = "";
            this.txtStateRegistration._TextChanged += new System.EventHandler(this.txtStateRegistration__TextChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCnpj.BorderColor = System.Drawing.Color.Black;
            this.txtCnpj.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtCnpj.BorderRadius = 0;
            this.txtCnpj.BorderSize = 2;
            this.txtCnpj.BottomBorderOnly = true;
            this.txtCnpj.CursorIndex = 0;
            this.txtCnpj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.ForeColor = System.Drawing.Color.Black;
            this.txtCnpj.Location = new System.Drawing.Point(289, 196);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.MaxLength = 32767;
            this.txtCnpj.Multiline = false;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCnpj.PasswordChar = '\0';
            this.txtCnpj.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCnpj.PlaceHolderText = "CNPJ";
            this.txtCnpj.Size = new System.Drawing.Size(240, 40);
            this.txtCnpj.TabIndex = 2;
            this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCnpj.Texts = "";
            this.txtCnpj._TextChanged += new System.EventHandler(this.txtCnpj__TextChanged);
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
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(289, 431);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceHolderText = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(500, 40);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Texts = "";
            this.txtEmail._TextChanged += new System.EventHandler(this.txtEmail__TextChanged);
            // 
            // txtSite
            // 
            this.txtSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSite.BorderColor = System.Drawing.Color.Black;
            this.txtSite.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtSite.BorderRadius = 0;
            this.txtSite.BorderSize = 2;
            this.txtSite.BottomBorderOnly = true;
            this.txtSite.CursorIndex = 0;
            this.txtSite.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.ForeColor = System.Drawing.Color.Black;
            this.txtSite.Location = new System.Drawing.Point(289, 358);
            this.txtSite.Margin = new System.Windows.Forms.Padding(4);
            this.txtSite.MaxLength = 32767;
            this.txtSite.Multiline = false;
            this.txtSite.Name = "txtSite";
            this.txtSite.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSite.PasswordChar = '\0';
            this.txtSite.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtSite.PlaceHolderText = "Site";
            this.txtSite.Size = new System.Drawing.Size(500, 40);
            this.txtSite.TabIndex = 4;
            this.txtSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSite.Texts = "";
            this.txtSite._TextChanged += new System.EventHandler(this.txtSite__TextChanged);
            // 
            // txtSocialReason
            // 
            this.txtSocialReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSocialReason.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSocialReason.BorderColor = System.Drawing.Color.Black;
            this.txtSocialReason.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtSocialReason.BorderRadius = 0;
            this.txtSocialReason.BorderSize = 2;
            this.txtSocialReason.BottomBorderOnly = true;
            this.txtSocialReason.CursorIndex = 0;
            this.txtSocialReason.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocialReason.ForeColor = System.Drawing.Color.Black;
            this.txtSocialReason.Location = new System.Drawing.Point(289, 123);
            this.txtSocialReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtSocialReason.MaxLength = 32767;
            this.txtSocialReason.Multiline = false;
            this.txtSocialReason.Name = "txtSocialReason";
            this.txtSocialReason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSocialReason.PasswordChar = '\0';
            this.txtSocialReason.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtSocialReason.PlaceHolderText = "Razão social";
            this.txtSocialReason.Size = new System.Drawing.Size(500, 40);
            this.txtSocialReason.TabIndex = 1;
            this.txtSocialReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSocialReason.Texts = "";
            this.txtSocialReason._TextChanged += new System.EventHandler(this.txtSocialReason__TextChanged);
            // 
            // txtFantasyName
            // 
            this.txtFantasyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFantasyName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFantasyName.BorderColor = System.Drawing.Color.Black;
            this.txtFantasyName.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtFantasyName.BorderRadius = 0;
            this.txtFantasyName.BorderSize = 2;
            this.txtFantasyName.BottomBorderOnly = true;
            this.txtFantasyName.CursorIndex = 0;
            this.txtFantasyName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasyName.ForeColor = System.Drawing.Color.Black;
            this.txtFantasyName.Location = new System.Drawing.Point(289, 50);
            this.txtFantasyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFantasyName.MaxLength = 32767;
            this.txtFantasyName.Multiline = false;
            this.txtFantasyName.Name = "txtFantasyName";
            this.txtFantasyName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFantasyName.PasswordChar = '\0';
            this.txtFantasyName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtFantasyName.PlaceHolderText = "Nome fantasia";
            this.txtFantasyName.Size = new System.Drawing.Size(500, 40);
            this.txtFantasyName.TabIndex = 0;
            this.txtFantasyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFantasyName.Texts = "";
            this.txtFantasyName._TextChanged += new System.EventHandler(this.txtFantasyName__TextChanged);
            // 
            // FrmAdministrativeAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.cmbDDD);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWrongCnpj);
            this.Controls.Add(this.txtStateRegistration);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtSocialReason);
            this.Controls.Add(this.txtFantasyName);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeAddCompany";
            this.Text = "Editar empresa";
            this.Load += new System.EventHandler(this.FrmAdministrativeAddCompany_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private kfcCustomControls.KFCCustomControls.KFCComboBox cmbDDD;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdress;
        private System.Windows.Forms.Panel panel1;
        private kfcCustomControls.KFCCustomControls.KFCDatePicker dpOpeningDate;
        private System.Windows.Forms.Label lblWrongCnpj;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtStateRegistration;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtCnpj;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtEmail;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtSite;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtSocialReason;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtFantasyName;
    }
}