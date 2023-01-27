namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    partial class FrmAdministrativeAddProduct
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
            this.lblWrongStorageLevelAlert = new System.Windows.Forms.Label();
            this.txtStorageLevelAlert = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.txtCode = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtPrice = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtDescription = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.lblWrongCode = new System.Windows.Forms.Label();
            this.pbBarCode = new System.Windows.Forms.PictureBox();
            this.lblWrongBarCode = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblWrongDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWrongStorageLevelAlert
            // 
            this.lblWrongStorageLevelAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongStorageLevelAlert.AutoSize = true;
            this.lblWrongStorageLevelAlert.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongStorageLevelAlert.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongStorageLevelAlert.Location = new System.Drawing.Point(288, 275);
            this.lblWrongStorageLevelAlert.Name = "lblWrongStorageLevelAlert";
            this.lblWrongStorageLevelAlert.Size = new System.Drawing.Size(278, 22);
            this.lblWrongStorageLevelAlert.TabIndex = 79;
            this.lblWrongStorageLevelAlert.Text = "O valor deve ser maior que 0";
            this.lblWrongStorageLevelAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongStorageLevelAlert.Visible = false;
            // 
            // txtStorageLevelAlert
            // 
            this.txtStorageLevelAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStorageLevelAlert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStorageLevelAlert.BorderColor = System.Drawing.Color.Black;
            this.txtStorageLevelAlert.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtStorageLevelAlert.BorderRadius = 0;
            this.txtStorageLevelAlert.BorderSize = 2;
            this.txtStorageLevelAlert.BottomBorderOnly = true;
            this.txtStorageLevelAlert.CursorIndex = 0;
            this.txtStorageLevelAlert.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStorageLevelAlert.ForeColor = System.Drawing.Color.Black;
            this.txtStorageLevelAlert.Location = new System.Drawing.Point(290, 233);
            this.txtStorageLevelAlert.Margin = new System.Windows.Forms.Padding(4);
            this.txtStorageLevelAlert.MaxLength = 4;
            this.txtStorageLevelAlert.Multiline = false;
            this.txtStorageLevelAlert.Name = "txtStorageLevelAlert";
            this.txtStorageLevelAlert.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStorageLevelAlert.PasswordChar = '\0';
            this.txtStorageLevelAlert.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtStorageLevelAlert.PlaceHolderText = "Alerta de estoque";
            this.txtStorageLevelAlert.Size = new System.Drawing.Size(221, 40);
            this.txtStorageLevelAlert.TabIndex = 78;
            this.txtStorageLevelAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStorageLevelAlert.Texts = "";
            this.txtStorageLevelAlert._TextChanged += new System.EventHandler(this.txtStorageLevelAlert__TextChanged);
            this.txtStorageLevelAlert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorageLevelAlert_KeyPress);
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
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(556, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "R$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderRadius = 60;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(290, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(500, 60);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Concluir";
            this.btnUpdate.TextColor = System.Drawing.Color.Black;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.txtCode.Location = new System.Drawing.Point(290, 57);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.MaxLength = 5;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtCode.PlaceHolderText = "Código";
            this.txtCode.Size = new System.Drawing.Size(500, 40);
            this.txtCode.TabIndex = 62;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.Texts = "";
            this.txtCode._TextChanged += new System.EventHandler(this.txtCode__TextChanged);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtPrice.BorderRadius = 0;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.BottomBorderOnly = true;
            this.txtPrice.CursorIndex = 0;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(590, 233);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceHolderText = "Preço";
            this.txtPrice.Size = new System.Drawing.Size(200, 40);
            this.txtPrice.TabIndex = 63;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.Texts = "";
            this.txtPrice._TextChanged += new System.EventHandler(this.txtPrice__TextChanged);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.BottomBorderOnly = true;
            this.txtDescription.CursorIndex = 0;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.Location = new System.Drawing.Point(290, 146);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceHolderText = "Description";
            this.txtDescription.Size = new System.Drawing.Size(500, 40);
            this.txtDescription.TabIndex = 64;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.Texts = "";
            this.txtDescription._TextChanged += new System.EventHandler(this.txtDescription__TextChanged);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblWrongCode
            // 
            this.lblWrongCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongCode.AutoSize = true;
            this.lblWrongCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongCode.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongCode.Location = new System.Drawing.Point(300, 101);
            this.lblWrongCode.Name = "lblWrongCode";
            this.lblWrongCode.Size = new System.Drawing.Size(250, 22);
            this.lblWrongCode.TabIndex = 66;
            this.lblWrongCode.Text = "Adicionar nova categoria";
            this.lblWrongCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongCode.Visible = false;
            // 
            // pbBarCode
            // 
            this.pbBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBarCode.Location = new System.Drawing.Point(290, 360);
            this.pbBarCode.Name = "pbBarCode";
            this.pbBarCode.Size = new System.Drawing.Size(500, 83);
            this.pbBarCode.TabIndex = 81;
            this.pbBarCode.TabStop = false;
            // 
            // lblWrongBarCode
            // 
            this.lblWrongBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongBarCode.AutoSize = true;
            this.lblWrongBarCode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongBarCode.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongBarCode.Location = new System.Drawing.Point(285, 360);
            this.lblWrongBarCode.Name = "lblWrongBarCode";
            this.lblWrongBarCode.Size = new System.Drawing.Size(278, 22);
            this.lblWrongBarCode.TabIndex = 82;
            this.lblWrongBarCode.Text = "O valor deve ser maior que 0";
            this.lblWrongBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongBarCode.Visible = false;
            // 
            // lblBarCode
            // 
            this.lblBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarCode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarCode.Location = new System.Drawing.Point(284, 318);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(506, 42);
            this.lblBarCode.TabIndex = 83;
            this.lblBarCode.Text = "0000000000000";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblWrongDescription
            // 
            this.lblWrongDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongDescription.AutoSize = true;
            this.lblWrongDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongDescription.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongDescription.Location = new System.Drawing.Point(300, 190);
            this.lblWrongDescription.Name = "lblWrongDescription";
            this.lblWrongDescription.Size = new System.Drawing.Size(351, 22);
            this.lblWrongDescription.TabIndex = 66;
            this.lblWrongDescription.Text = "Esta descrição já está sendo ultilizada";
            this.lblWrongDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWrongDescription.Visible = false;
            // 
            // FrmAdministrativeAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.lblWrongBarCode);
            this.Controls.Add(this.pbBarCode);
            this.Controls.Add(this.lblWrongStorageLevelAlert);
            this.Controls.Add(this.txtStorageLevelAlert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblWrongDescription);
            this.Controls.Add(this.lblWrongCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeAddProduct";
            this.Text = "Atualizar produto";
            this.Load += new System.EventHandler(this.FrmAdmUpdateProduct_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAdmUpdateProduct_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWrongStorageLevelAlert;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtStorageLevelAlert;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private System.Windows.Forms.Label label2;
        private kfcCustomControls.KFCCustomControls.kFCButton btnUpdate;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtCode;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtPrice;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtDescription;
        private System.Windows.Forms.Label lblWrongCode;
        private System.Windows.Forms.PictureBox pbBarCode;
        private System.Windows.Forms.Label lblWrongBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblWrongDescription;
    }
}