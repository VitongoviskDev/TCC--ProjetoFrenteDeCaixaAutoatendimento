namespace Projeto_frente_de_Caixa.View {
    partial class FrmPasswordRecoveryNewPassword {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnUpdatePassword = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblWrongPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtPassword = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCaps = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdatePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdatePassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdatePassword.BorderColor = System.Drawing.Color.Black;
            this.btnUpdatePassword.BorderRadius = 60;
            this.btnUpdatePassword.BorderSize = 3;
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePassword.Location = new System.Drawing.Point(390, 519);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(300, 60);
            this.btnUpdatePassword.TabIndex = 7;
            this.btnUpdatePassword.Text = "Alterar senha";
            this.btnUpdatePassword.TextColor = System.Drawing.Color.Black;
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblWrongPassword
            // 
            this.lblWrongPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWrongPassword.AutoSize = true;
            this.lblWrongPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongPassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblWrongPassword.Location = new System.Drawing.Point(388, 369);
            this.lblWrongPassword.Name = "lblWrongPassword";
            this.lblWrongPassword.Size = new System.Drawing.Size(302, 21);
            this.lblWrongPassword.TabIndex = 3;
            this.lblWrongPassword.Text = "A confirmação de senha não confere";
            this.lblWrongPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrongPassword.Visible = false;
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
            this.label1.TabIndex = 5;
            this.label1.Text = "Redefinir senha";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtConfirmPassword.BorderRadius = 0;
            this.txtConfirmPassword.BorderSize = 3;
            this.txtConfirmPassword.BottomBorderOnly = true;
            this.txtConfirmPassword.CursorIndex = 0;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Location = new System.Drawing.Point(390, 327);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.PlaceHolderText = "Confirmar senha";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 38);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword._TextChanged += new System.EventHandler(this.txtConfirmPassword__TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.BottomBorderOnly = true;
            this.txtPassword.CursorIndex = 0;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(390, 184);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceHolderText = "Nova senha";
            this.txtPassword.Size = new System.Drawing.Size(300, 38);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Texts = "";
            this.txtPassword._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(402, 226);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(125, 17);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "• 6 - 12 caracteres";
            // 
            // lblCaps
            // 
            this.lblCaps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaps.AutoSize = true;
            this.lblCaps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaps.ForeColor = System.Drawing.Color.Black;
            this.lblCaps.Location = new System.Drawing.Point(402, 245);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(203, 17);
            this.lblCaps.TabIndex = 3;
            this.lblCaps.Text = "• Letra maiúscula e minúscula";
            // 
            // lblSpecial
            // 
            this.lblSpecial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.ForeColor = System.Drawing.Color.Black;
            this.lblSpecial.Location = new System.Drawing.Point(402, 264);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(220, 17);
            this.lblSpecial.TabIndex = 3;
            this.lblSpecial.Text = "• Ao menos 1 caractere especial";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(402, 283);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(150, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "• Ao menos 1 número";
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCancel.AutoSize = true;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Crimson;
            this.lblCancel.Location = new System.Drawing.Point(472, 582);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(150, 36);
            this.lblCancel.TabIndex = 10;
            this.lblCancel.Text = "Cancelar";
            // 
            // FrmPasswordRecoveryNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblWrongPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPasswordRecoveryNewPassword";
            this.Text = "Recuperação de senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnUpdatePassword;
        private System.Windows.Forms.Label lblWrongPassword;
        private System.Windows.Forms.Label label1;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtConfirmPassword;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtPassword;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCaps;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCancel;
    }
}