namespace Projeto_frente_de_Caixa.View
{
    partial class FrmLogin
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
            this.pnLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShowPassword = new kfcCustomControls.KFCCustomControls.KFCToggleButton();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.txtPassword = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.txtLogin = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnLogin.BackColor = System.Drawing.Color.LightGray;
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.cbShowPassword);
            this.pnLogin.Controls.Add(this.lblForgotPassword);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.txtLogin);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Location = new System.Drawing.Point(340, 110);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(400, 500);
            this.pnLogin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mostrar senha";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(306, 311);
            this.cbShowPassword.MinimumSize = new System.Drawing.Size(44, 22);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.OffBackColor = System.Drawing.Color.DimGray;
            this.cbShowPassword.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cbShowPassword.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.cbShowPassword.OnToggleColor = System.Drawing.Color.PowderBlue;
            this.cbShowPassword.Size = new System.Drawing.Size(44, 22);
            this.cbShowPassword.TabIndex = 3;
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.Location = new System.Drawing.Point(152, 429);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(173, 21);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Esqueci minha senha";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderRadius = 50;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(75, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextColor = System.Drawing.Color.Black;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 3;
            this.txtPassword.BottomBorderOnly = true;
            this.txtPassword.CursorIndex = 0;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(50, 257);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(300, 38);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.Texts = "";
            this.txtPassword._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.LightGray;
            this.txtLogin.BorderColor = System.Drawing.Color.Black;
            this.txtLogin.BorderFocusColor = System.Drawing.Color.White;
            this.txtLogin.BorderRadius = 0;
            this.txtLogin.BorderSize = 3;
            this.txtLogin.BottomBorderOnly = true;
            this.txtLogin.CursorIndex = 0;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(50, 160);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtLogin.PlaceHolderText = "Login";
            this.txtLogin.Size = new System.Drawing.Size(300, 38);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogin.Texts = "";
            this.txtLogin._TextChanged += new System.EventHandler(this.txtLogin__TextChanged);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.BorderRadius = 50;
            this.btnBack.BorderSize = 2;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.TextColor = System.Drawing.Color.Black;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private kfcCustomControls.KFCCustomControls.kFCButton btnLogin;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtPassword;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label label3;
        private kfcCustomControls.KFCCustomControls.KFCToggleButton cbShowPassword;
        private kfcCustomControls.KFCCustomControls.kFCButton btnBack;
    }
}