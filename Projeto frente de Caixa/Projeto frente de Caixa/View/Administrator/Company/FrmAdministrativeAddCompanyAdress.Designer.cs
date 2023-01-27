namespace Projeto_frente_de_Caixa.View.Administrator.Company
{
    partial class FrmAdministrativeAddCompanyAdress
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
            this.btnFinish = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.txtDistrict = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtState = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtZipCode = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtCity = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtAdress = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtNumber = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtComplement = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFinish.BorderColor = System.Drawing.Color.Black;
            this.btnFinish.BorderRadius = 60;
            this.btnFinish.BorderSize = 2;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.Black;
            this.btnFinish.Location = new System.Drawing.Point(290, 600);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(500, 60);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Concluir";
            this.btnFinish.TextColor = System.Drawing.Color.Black;
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDistrict.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDistrict.BorderColor = System.Drawing.Color.Black;
            this.txtDistrict.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtDistrict.BorderRadius = 0;
            this.txtDistrict.BorderSize = 2;
            this.txtDistrict.BottomBorderOnly = true;
            this.txtDistrict.CursorIndex = 0;
            this.txtDistrict.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.ForeColor = System.Drawing.Color.Black;
            this.txtDistrict.Location = new System.Drawing.Point(290, 279);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrict.MaxLength = 32767;
            this.txtDistrict.Multiline = false;
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDistrict.PasswordChar = '\0';
            this.txtDistrict.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDistrict.PlaceHolderText = "Bairro";
            this.txtDistrict.Size = new System.Drawing.Size(500, 40);
            this.txtDistrict.TabIndex = 4;
            this.txtDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDistrict.Texts = "";
            this.txtDistrict._TextChanged += new System.EventHandler(this.txtDistrict__TextChanged);
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtState.BorderColor = System.Drawing.Color.Black;
            this.txtState.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtState.BorderRadius = 0;
            this.txtState.BorderSize = 2;
            this.txtState.BottomBorderOnly = true;
            this.txtState.CursorIndex = 0;
            this.txtState.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.Black;
            this.txtState.Location = new System.Drawing.Point(290, 425);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.MaxLength = 32767;
            this.txtState.Multiline = false;
            this.txtState.Name = "txtState";
            this.txtState.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtState.PasswordChar = '\0';
            this.txtState.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtState.PlaceHolderText = "Estado";
            this.txtState.Size = new System.Drawing.Size(500, 40);
            this.txtState.TabIndex = 6;
            this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtState.Texts = "";
            this.txtState._TextChanged += new System.EventHandler(this.txtState__TextChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtZipCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtZipCode.BorderColor = System.Drawing.Color.Black;
            this.txtZipCode.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtZipCode.BorderRadius = 0;
            this.txtZipCode.BorderSize = 2;
            this.txtZipCode.BottomBorderOnly = true;
            this.txtZipCode.CursorIndex = 0;
            this.txtZipCode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.ForeColor = System.Drawing.Color.Black;
            this.txtZipCode.Location = new System.Drawing.Point(290, 133);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtZipCode.MaxLength = 32767;
            this.txtZipCode.Multiline = false;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtZipCode.PasswordChar = '\0';
            this.txtZipCode.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtZipCode.PlaceHolderText = "CEP";
            this.txtZipCode.Size = new System.Drawing.Size(240, 40);
            this.txtZipCode.TabIndex = 1;
            this.txtZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtZipCode.Texts = "";
            this.txtZipCode._TextChanged += new System.EventHandler(this.txtZipCode__TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCity.BorderColor = System.Drawing.Color.Black;
            this.txtCity.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtCity.BorderRadius = 0;
            this.txtCity.BorderSize = 2;
            this.txtCity.BottomBorderOnly = true;
            this.txtCity.CursorIndex = 0;
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(290, 352);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCity.PlaceHolderText = "Cidade";
            this.txtCity.Size = new System.Drawing.Size(500, 40);
            this.txtCity.TabIndex = 5;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCity.Texts = "";
            this.txtCity._TextChanged += new System.EventHandler(this.txtCity__TextChanged);
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdress.BorderColor = System.Drawing.Color.Black;
            this.txtAdress.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtAdress.BorderRadius = 0;
            this.txtAdress.BorderSize = 2;
            this.txtAdress.BottomBorderOnly = true;
            this.txtAdress.CursorIndex = 0;
            this.txtAdress.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.ForeColor = System.Drawing.Color.Black;
            this.txtAdress.Location = new System.Drawing.Point(290, 60);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.MaxLength = 32767;
            this.txtAdress.Multiline = false;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAdress.PasswordChar = '\0';
            this.txtAdress.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAdress.PlaceHolderText = "Endereco";
            this.txtAdress.Size = new System.Drawing.Size(500, 40);
            this.txtAdress.TabIndex = 0;
            this.txtAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdress.Texts = "";
            this.txtAdress._TextChanged += new System.EventHandler(this.txtAdress__TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumber.BorderColor = System.Drawing.Color.Black;
            this.txtNumber.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtNumber.BorderRadius = 0;
            this.txtNumber.BorderSize = 2;
            this.txtNumber.BottomBorderOnly = true;
            this.txtNumber.CursorIndex = 0;
            this.txtNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.Location = new System.Drawing.Point(550, 133);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceHolderText = "Número";
            this.txtNumber.Size = new System.Drawing.Size(240, 40);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumber.Texts = "";
            this.txtNumber._TextChanged += new System.EventHandler(this.txtNumber__TextChanged);
            // 
            // txtComplement
            // 
            this.txtComplement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtComplement.BorderColor = System.Drawing.Color.Black;
            this.txtComplement.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtComplement.BorderRadius = 0;
            this.txtComplement.BorderSize = 2;
            this.txtComplement.BottomBorderOnly = true;
            this.txtComplement.CursorIndex = 0;
            this.txtComplement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplement.ForeColor = System.Drawing.Color.Black;
            this.txtComplement.Location = new System.Drawing.Point(290, 206);
            this.txtComplement.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplement.MaxLength = 32767;
            this.txtComplement.Multiline = false;
            this.txtComplement.Name = "txtComplement";
            this.txtComplement.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComplement.PasswordChar = '\0';
            this.txtComplement.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtComplement.PlaceHolderText = "Complemento";
            this.txtComplement.Size = new System.Drawing.Size(500, 40);
            this.txtComplement.TabIndex = 3;
            this.txtComplement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComplement.Texts = "";
            this.txtComplement._TextChanged += new System.EventHandler(this.txtComplement__TextChanged);
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
            // FrmAdministrativeAddCompanyAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtComplement);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeAddCompanyAdress";
            this.Text = "Editar empresa";
            this.Load += new System.EventHandler(this.FrmAdministrativeAddCompanyAdress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnFinish;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtDistrict;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtState;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtZipCode;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtCity;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtAdress;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtNumber;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtComplement;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
    }
}