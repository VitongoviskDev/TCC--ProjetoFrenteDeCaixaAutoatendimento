namespace Projeto_frente_de_Caixa.View.Administrator
{
    partial class FrmResetPassword
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
            this.btnResetPassword = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.BorderColor = System.Drawing.Color.Black;
            this.btnResetPassword.BorderRadius = 40;
            this.btnResetPassword.BorderSize = 3;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.Black;
            this.btnResetPassword.Location = new System.Drawing.Point(157, 469);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(773, 150);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "Vamos lá!";
            this.btnResetPassword.TextColor = System.Drawing.Color.Black;
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 217);
            this.label1.TabIndex = 2;
            this.label1.Text = "E para finalizar as configurações.\r\n\r\nVocê precisa alterar a senha do novo usuári" +
    "o.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResetPassword";
            this.Text = "Configurações finais";
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnResetPassword;
        private System.Windows.Forms.Label label1;
    }
}