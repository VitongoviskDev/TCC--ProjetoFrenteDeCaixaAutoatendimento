namespace Projeto_frente_de_Caixa.View.Administrator {
    partial class FrmAdministrativeMain {
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
            this.pnMenuHolder = new System.Windows.Forms.Panel();
            this.pnMovimentation = new System.Windows.Forms.Panel();
            this.pnStorageNotification = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.lblStorageNotificantion = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnEntrys = new System.Windows.Forms.Button();
            this.btnStorageProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pnRegistrations = new System.Windows.Forms.Panel();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnRegistrationProducts = new System.Windows.Forms.Button();
            this.btnRegisters = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnHeaderBar = new System.Windows.Forms.Panel();
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.pnChildFormHolder = new System.Windows.Forms.Panel();
            this.tmStorageVerification = new System.Windows.Forms.Timer(this.components);
            this.pnMenuHolder.SuspendLayout();
            this.pnMovimentation.SuspendLayout();
            this.pnStorageNotification.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnRegistrations.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnHeaderBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuHolder
            // 
            this.pnMenuHolder.BackColor = System.Drawing.Color.Silver;
            this.pnMenuHolder.Controls.Add(this.pnMovimentation);
            this.pnMenuHolder.Controls.Add(this.panel2);
            this.pnMenuHolder.Controls.Add(this.btnConfig);
            this.pnMenuHolder.Controls.Add(this.pnRegistrations);
            this.pnMenuHolder.Controls.Add(this.btnRegisters);
            this.pnMenuHolder.Controls.Add(this.panel1);
            this.pnMenuHolder.Controls.Add(this.btnLogout);
            this.pnMenuHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuHolder.Location = new System.Drawing.Point(0, 40);
            this.pnMenuHolder.Name = "pnMenuHolder";
            this.pnMenuHolder.Size = new System.Drawing.Size(216, 680);
            this.pnMenuHolder.TabIndex = 4;
            // 
            // pnMovimentation
            // 
            this.pnMovimentation.Controls.Add(this.pnStorageNotification);
            this.pnMovimentation.Controls.Add(this.btnSales);
            this.pnMovimentation.Controls.Add(this.btnEntrys);
            this.pnMovimentation.Controls.Add(this.btnStorageProducts);
            this.pnMovimentation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMovimentation.Location = new System.Drawing.Point(0, 349);
            this.pnMovimentation.Name = "pnMovimentation";
            this.pnMovimentation.Size = new System.Drawing.Size(216, 140);
            this.pnMovimentation.TabIndex = 11;
            // 
            // pnStorageNotification
            // 
            this.pnStorageNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStorageNotification.BackColor = System.Drawing.Color.Transparent;
            this.pnStorageNotification.BorderRadius = 25;
            this.pnStorageNotification.Color1 = System.Drawing.Color.Crimson;
            this.pnStorageNotification.Color2 = System.Drawing.Color.Crimson;
            this.pnStorageNotification.Controls.Add(this.lblStorageNotificantion);
            this.pnStorageNotification.ForeColor = System.Drawing.Color.Black;
            this.pnStorageNotification.GradientAngle = 0F;
            this.pnStorageNotification.Location = new System.Drawing.Point(180, 12);
            this.pnStorageNotification.Name = "pnStorageNotification";
            this.pnStorageNotification.Size = new System.Drawing.Size(25, 25);
            this.pnStorageNotification.TabIndex = 0;
            this.pnStorageNotification.Visible = false;
            // 
            // lblStorageNotificantion
            // 
            this.lblStorageNotificantion.BackColor = System.Drawing.Color.Crimson;
            this.lblStorageNotificantion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStorageNotificantion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageNotificantion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStorageNotificantion.Location = new System.Drawing.Point(0, 0);
            this.lblStorageNotificantion.Name = "lblStorageNotificantion";
            this.lblStorageNotificantion.Size = new System.Drawing.Size(25, 25);
            this.lblStorageNotificantion.TabIndex = 0;
            this.lblStorageNotificantion.Text = "20";
            this.lblStorageNotificantion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(0, 90);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(216, 45);
            this.btnSales.TabIndex = 12;
            this.btnSales.Text = "saídas";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnEntrys
            // 
            this.btnEntrys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnEntrys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntrys.FlatAppearance.BorderSize = 0;
            this.btnEntrys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrys.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrys.Location = new System.Drawing.Point(0, 45);
            this.btnEntrys.Name = "btnEntrys";
            this.btnEntrys.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEntrys.Size = new System.Drawing.Size(216, 45);
            this.btnEntrys.TabIndex = 8;
            this.btnEntrys.Text = "entradas";
            this.btnEntrys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrys.UseVisualStyleBackColor = false;
            this.btnEntrys.Click += new System.EventHandler(this.btnEntrys_Click);
            // 
            // btnStorageProducts
            // 
            this.btnStorageProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnStorageProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStorageProducts.FlatAppearance.BorderSize = 0;
            this.btnStorageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorageProducts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorageProducts.Location = new System.Drawing.Point(0, 0);
            this.btnStorageProducts.Name = "btnStorageProducts";
            this.btnStorageProducts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStorageProducts.Size = new System.Drawing.Size(216, 45);
            this.btnStorageProducts.TabIndex = 13;
            this.btnStorageProducts.Text = "produtos";
            this.btnStorageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorageProducts.UseVisualStyleBackColor = false;
            this.btnStorageProducts.Click += new System.EventHandler(this.btnStorageProducts_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 50);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTOQUE";
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Silver;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(0, 580);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(216, 50);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "CONFIGURAÇÕES";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pnRegistrations
            // 
            this.pnRegistrations.Controls.Add(this.btnCompany);
            this.pnRegistrations.Controls.Add(this.btnUsers);
            this.pnRegistrations.Controls.Add(this.btnRegistrationProducts);
            this.pnRegistrations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRegistrations.Location = new System.Drawing.Point(0, 159);
            this.pnRegistrations.Name = "pnRegistrations";
            this.pnRegistrations.Size = new System.Drawing.Size(216, 140);
            this.pnRegistrations.TabIndex = 7;
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompany.FlatAppearance.BorderSize = 0;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompany.Location = new System.Drawing.Point(0, 90);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCompany.Size = new System.Drawing.Size(216, 45);
            this.btnCompany.TabIndex = 13;
            this.btnCompany.Text = "empresa";
            this.btnCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(0, 45);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(216, 45);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "usuários";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRegistrationProducts
            // 
            this.btnRegistrationProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnRegistrationProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrationProducts.FlatAppearance.BorderSize = 0;
            this.btnRegistrationProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrationProducts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationProducts.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrationProducts.Name = "btnRegistrationProducts";
            this.btnRegistrationProducts.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRegistrationProducts.Size = new System.Drawing.Size(216, 45);
            this.btnRegistrationProducts.TabIndex = 8;
            this.btnRegistrationProducts.Text = "produtos";
            this.btnRegistrationProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrationProducts.UseVisualStyleBackColor = false;
            this.btnRegistrationProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnRegisters
            // 
            this.btnRegisters.BackColor = System.Drawing.Color.Silver;
            this.btnRegisters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisters.FlatAppearance.BorderSize = 0;
            this.btnRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisters.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisters.Location = new System.Drawing.Point(0, 109);
            this.btnRegisters.Name = "btnRegisters";
            this.btnRegisters.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegisters.Size = new System.Drawing.Size(216, 50);
            this.btnRegisters.TabIndex = 6;
            this.btnRegisters.Text = "CADASTROS";
            this.btnRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisters.UseVisualStyleBackColor = false;
            this.btnRegisters.Click += new System.EventHandler(this.btnRegisters_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblProfile);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 109);
            this.panel1.TabIndex = 5;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(145, 79);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 21);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Black;
            this.lblProfile.Location = new System.Drawing.Point(12, 33);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(142, 21);
            this.lblProfile.TabIndex = 5;
            this.lblProfile.Text = "Vitor Campos";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(5, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 24);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Vitor Campos";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 630);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(216, 50);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "SAIR";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnHeaderBar
            // 
            this.pnHeaderBar.BackColor = System.Drawing.Color.Gray;
            this.pnHeaderBar.Controls.Add(this.lblSoftwareName);
            this.pnHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderBar.ForeColor = System.Drawing.Color.Black;
            this.pnHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.pnHeaderBar.Name = "pnHeaderBar";
            this.pnHeaderBar.Size = new System.Drawing.Size(1080, 40);
            this.pnHeaderBar.TabIndex = 5;
            this.pnHeaderBar.SizeChanged += new System.EventHandler(this.pnHeaderBar_SizeChanged);
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftwareName.ForeColor = System.Drawing.Color.Black;
            this.lblSoftwareName.Location = new System.Drawing.Point(370, 9);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(271, 25);
            this.lblSoftwareName.TabIndex = 5;
            this.lblSoftwareName.Text = "King Of FrenteDeCaixa  - ";
            // 
            // pnChildFormHolder
            // 
            this.pnChildFormHolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnChildFormHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChildFormHolder.Location = new System.Drawing.Point(216, 40);
            this.pnChildFormHolder.Name = "pnChildFormHolder";
            this.pnChildFormHolder.Size = new System.Drawing.Size(864, 680);
            this.pnChildFormHolder.TabIndex = 6;
            // 
            // tmStorageVerification
            // 
            this.tmStorageVerification.Interval = 1800000;
            this.tmStorageVerification.Tick += new System.EventHandler(this.tmStorageVerification_Tick);
            // 
            // FrmAdministrativeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnChildFormHolder);
            this.Controls.Add(this.pnMenuHolder);
            this.Controls.Add(this.pnHeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeMain";
            this.Text = "FrmAdministrativeMain";
            this.Load += new System.EventHandler(this.FrmAdministrativeMain_Load);
            this.Shown += new System.EventHandler(this.FrmAdministrativeMain_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmAdministrativeMain_SizeChanged);
            this.pnMenuHolder.ResumeLayout(false);
            this.pnMovimentation.ResumeLayout(false);
            this.pnStorageNotification.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnRegistrations.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnHeaderBar.ResumeLayout(false);
            this.pnHeaderBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenuHolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnHeaderBar;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.Panel pnChildFormHolder;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel pnRegistrations;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRegisters;
        private System.Windows.Forms.Button btnRegistrationProducts;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Panel pnMovimentation;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnEntrys;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStorageProducts;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnStorageNotification;
        private System.Windows.Forms.Label lblStorageNotificantion;
        private System.Windows.Forms.Timer tmStorageVerification;
    }
}