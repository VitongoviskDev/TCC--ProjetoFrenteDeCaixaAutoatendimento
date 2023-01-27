namespace Projeto_frente_de_Caixa.View.Administrator
{
    partial class FrmAdministrativeFirstConfig
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
            this.btnAddUser = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.BorderRadius = 40;
            this.btnAddUser.BorderSize = 3;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(157, 469);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(773, 150);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Vamos lá!";
            this.btnAddUser.TextColor = System.Drawing.Color.Black;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 217);
            this.label1.TabIndex = 2;
            this.label1.Text = "2º passo.\r\n\r\nAgora vamos fazer as configurações finais do sistema para que ele fu" +
    "ncione perfeitamente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAdministrativeFirstConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeFirstConfig";
            this.Text = "Configurações finais";
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnAddUser;
        private System.Windows.Forms.Label label1;
    }
}