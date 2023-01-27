using System.Windows.Forms;

namespace Projeto_frente_de_Caixa {
    partial class FrmModes {
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
            this.components = new System.ComponentModel.Container();
            this.btnCaixa = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnAdministrador = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblCompanyWarning = new System.Windows.Forms.Label();
            this.btnClose = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.pnConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaixa
            // 
            this.btnCaixa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCaixa.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCaixa.BorderRadius = 80;
            this.btnCaixa.BorderSize = 3;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCaixa.Location = new System.Drawing.Point(215, 370);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(650, 150);
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.Text = "Autoatendimento";
            this.btnCaixa.TextColor = System.Drawing.Color.MidnightBlue;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrador.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdministrador.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAdministrador.BorderRadius = 80;
            this.btnAdministrador.BorderSize = 3;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdministrador.Location = new System.Drawing.Point(215, 200);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(650, 150);
            this.btnAdministrador.TabIndex = 0;
            this.btnAdministrador.Text = "Administrativo";
            this.btnAdministrador.TextColor = System.Drawing.Color.MidnightBlue;
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // pnConnection
            // 
            this.pnConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnConnection.Controls.Add(this.lblTimer);
            this.pnConnection.Controls.Add(this.lblError);
            this.pnConnection.Controls.Add(this.lblWarning);
            this.pnConnection.Location = new System.Drawing.Point(0, 0);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Size = new System.Drawing.Size(1080, 720);
            this.pnConnection.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(151, 570);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(780, 50);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "10";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimer.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(150, 150);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(780, 200);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Warning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyWarning
            // 
            this.lblCompanyWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompanyWarning.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold);
            this.lblCompanyWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblCompanyWarning.Location = new System.Drawing.Point(100, 370);
            this.lblCompanyWarning.Name = "lblCompanyWarning";
            this.lblCompanyWarning.Size = new System.Drawing.Size(880, 200);
            this.lblCompanyWarning.TabIndex = 3;
            this.lblCompanyWarning.Text = "Para acessar o modo Autoatendimento é necessário cadastrar os dados da empresa no" +
    " modo Administrativo";
            this.lblCompanyWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 50;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Location = new System.Drawing.Point(1018, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(151, 357);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(780, 200);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "ERRO";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // FrmModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnConnection);
            this.Controls.Add(this.lblCompanyWarning);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModes";
            this.Text = "FrmModels";
            this.Load += new System.EventHandler(this.FrmModes_Load);
            this.pnConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnCaixa;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdministrador;
        private System.Windows.Forms.Panel pnConnection;
        private kfcCustomControls.KFCCustomControls.kFCButton btnClose;
        private System.Windows.Forms.Label lblCompanyWarning;
        private Timer tmTimer;
        private Label lblWarning;
        private Label lblTimer;
        private Label lblError;
    }
}