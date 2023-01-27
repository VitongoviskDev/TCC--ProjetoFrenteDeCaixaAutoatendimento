namespace Projeto_frente_de_Caixa.View.Administrator.Users
{
    partial class FrmAdministrativeViewUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFetchStatus = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdduser = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnToolBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.btnEdit = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnSearchBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.txtSearch = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnToolBar.SuspendLayout();
            this.pnSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFetchStatus
            // 
            this.lblFetchStatus.AutoSize = true;
            this.lblFetchStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchStatus.ForeColor = System.Drawing.Color.Black;
            this.lblFetchStatus.Location = new System.Drawing.Point(422, 381);
            this.lblFetchStatus.Name = "lblFetchStatus";
            this.lblFetchStatus.Size = new System.Drawing.Size(241, 24);
            this.lblFetchStatus.TabIndex = 11;
            this.lblFetchStatus.Text = "Procurando produtos...";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIndex,
            this.clmName,
            this.clmLogin,
            this.clmProfile,
            this.clmEmail,
            this.clmStatus,
            this.clmInfo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.Black;
            this.dgvUsers.Location = new System.Drawing.Point(50, 96);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 40;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsers.Size = new System.Drawing.Size(980, 612);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            this.dgvUsers.SizeChanged += new System.EventHandler(this.dgvProducts_SizeChanged);
            // 
            // clmIndex
            // 
            this.clmIndex.HeaderText = "*";
            this.clmIndex.Name = "clmIndex";
            this.clmIndex.ReadOnly = true;
            // 
            // clmName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmName.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmName.HeaderText = "Nome";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 68;
            // 
            // clmLogin
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmLogin.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmLogin.HeaderText = "Login";
            this.clmLogin.Name = "clmLogin";
            this.clmLogin.ReadOnly = true;
            // 
            // clmProfile
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmProfile.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmProfile.HeaderText = "Perfil";
            this.clmProfile.Name = "clmProfile";
            this.clmProfile.ReadOnly = true;
            // 
            // clmEmail
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmEmail.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmEmail.HeaderText = "E-mail";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            // 
            // clmStatus
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStatus.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmStatus.HeaderText = "Ativo";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmInfo
            // 
            this.clmInfo.HeaderText = "Info";
            this.clmInfo.Name = "clmInfo";
            this.clmInfo.ReadOnly = true;
            // 
            // btnAdduser
            // 
            this.btnAdduser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdduser.BackColor = System.Drawing.Color.Transparent;
            this.btnAdduser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdduser.BackgroundImage = global::Projeto_frente_de_Caixa.Properties.Resources.addDark;
            this.btnAdduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdduser.BorderColor = System.Drawing.Color.Black;
            this.btnAdduser.BorderRadius = 0;
            this.btnAdduser.BorderSize = 0;
            this.btnAdduser.FlatAppearance.BorderSize = 0;
            this.btnAdduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdduser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdduser.Location = new System.Drawing.Point(980, 17);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(50, 50);
            this.btnAdduser.TabIndex = 9;
            this.btnAdduser.TextColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdduser.UseVisualStyleBackColor = false;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // pnToolBar
            // 
            this.pnToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnToolBar.BackColor = System.Drawing.Color.Transparent;
            this.pnToolBar.BorderRadius = 60;
            this.pnToolBar.Color1 = System.Drawing.Color.Gray;
            this.pnToolBar.Color2 = System.Drawing.Color.Gray;
            this.pnToolBar.Controls.Add(this.btnEdit);
            this.pnToolBar.Controls.Add(this.pnSearchBar);
            this.pnToolBar.ForeColor = System.Drawing.Color.Black;
            this.pnToolBar.GradientAngle = 0F;
            this.pnToolBar.Location = new System.Drawing.Point(50, 12);
            this.pnToolBar.Name = "pnToolBar";
            this.pnToolBar.Size = new System.Drawing.Size(896, 60);
            this.pnToolBar.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Gray;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderRadius = 40;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(733, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDITAR";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnSearchBar
            // 
            this.pnSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearchBar.BackColor = System.Drawing.Color.Gray;
            this.pnSearchBar.BorderRadius = 50;
            this.pnSearchBar.Color1 = System.Drawing.Color.DarkGray;
            this.pnSearchBar.Color2 = System.Drawing.Color.DarkGray;
            this.pnSearchBar.Controls.Add(this.txtSearch);
            this.pnSearchBar.ForeColor = System.Drawing.Color.Black;
            this.pnSearchBar.GradientAngle = 0F;
            this.pnSearchBar.Location = new System.Drawing.Point(5, 5);
            this.pnSearchBar.Name = "pnSearchBar";
            this.pnSearchBar.Size = new System.Drawing.Size(722, 50);
            this.pnSearchBar.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.DarkGray;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.BottomBorderOnly = true;
            this.txtSearch.CursorIndex = 0;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(18, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceHolderText = "Pesquisar...";
            this.txtSearch.Size = new System.Drawing.Size(684, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.Texts = "";
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // FrmAdministrativeViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblFetchStatus);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.pnToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeViewUsers";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.FrmAdministrativeViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnToolBar.ResumeLayout(false);
            this.pnSearchBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFetchStatus;
        private System.Windows.Forms.DataGridView dgvUsers;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdduser;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnToolBar;
        private kfcCustomControls.KFCCustomControls.kFCButton btnEdit;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnSearchBar;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmInfo;
    }
}