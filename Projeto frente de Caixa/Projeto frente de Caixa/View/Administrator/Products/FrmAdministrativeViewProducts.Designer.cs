namespace Projeto_frente_de_Caixa.View.Administrator.Products
{
    partial class FrmAdministrativeViewProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnToolBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.btnEdit = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnChangeStatus = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnSearchBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.txtSearch = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblFetchStatus = new System.Windows.Forms.Label();
            this.pnToolBar.SuspendLayout();
            this.pnSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
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
            this.pnToolBar.Controls.Add(this.btnChangeStatus);
            this.pnToolBar.Controls.Add(this.pnSearchBar);
            this.pnToolBar.ForeColor = System.Drawing.Color.Black;
            this.pnToolBar.GradientAngle = 0F;
            this.pnToolBar.Location = new System.Drawing.Point(50, 12);
            this.pnToolBar.Name = "pnToolBar";
            this.pnToolBar.Size = new System.Drawing.Size(980, 60);
            this.pnToolBar.TabIndex = 0;
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
            this.btnEdit.Location = new System.Drawing.Point(664, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDITAR";
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChangeStatus.BackColor = System.Drawing.Color.Gray;
            this.btnChangeStatus.BackgroundColor = System.Drawing.Color.Gray;
            this.btnChangeStatus.BorderColor = System.Drawing.Color.Black;
            this.btnChangeStatus.BorderRadius = 40;
            this.btnChangeStatus.BorderSize = 0;
            this.btnChangeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.ForeColor = System.Drawing.Color.Black;
            this.btnChangeStatus.Location = new System.Drawing.Point(820, 10);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(150, 40);
            this.btnChangeStatus.TabIndex = 1;
            this.btnChangeStatus.Text = "DESATIVAR ";
            this.btnChangeStatus.TextColor = System.Drawing.Color.Black;
            this.btnChangeStatus.UseVisualStyleBackColor = false;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnDisable_Click);
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
            this.pnSearchBar.Size = new System.Drawing.Size(653, 50);
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
            this.txtSearch.Size = new System.Drawing.Size(615, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.Texts = "";
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIndex,
            this.clmCode,
            this.clmDescription,
            this.clmPrice,
            this.clmBarCode,
            this.clmStatus,
            this.clmInfo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.Black;
            this.dgvProducts.Location = new System.Drawing.Point(50, 86);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.Size = new System.Drawing.Size(980, 606);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            this.dgvProducts.SizeChanged += new System.EventHandler(this.dgvShoppingList_SizeChanged);
            // 
            // clmIndex
            // 
            this.clmIndex.HeaderText = "*";
            this.clmIndex.Name = "clmIndex";
            this.clmIndex.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmDescription
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDescription.HeaderText = "Descrição";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 68;
            // 
            // clmPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPrice.HeaderText = "Valor";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 67;
            // 
            // clmBarCode
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBarCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmBarCode.HeaderText = "Cód. barras";
            this.clmBarCode.Name = "clmBarCode";
            this.clmBarCode.ReadOnly = true;
            // 
            // clmStatus
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStatus.DefaultCellStyle = dataGridViewCellStyle5;
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
            // lblFetchStatus
            // 
            this.lblFetchStatus.AutoSize = true;
            this.lblFetchStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchStatus.ForeColor = System.Drawing.Color.Black;
            this.lblFetchStatus.Location = new System.Drawing.Point(419, 346);
            this.lblFetchStatus.Name = "lblFetchStatus";
            this.lblFetchStatus.Size = new System.Drawing.Size(241, 24);
            this.lblFetchStatus.TabIndex = 7;
            this.lblFetchStatus.Text = "Procurando produtos...";
            this.lblFetchStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.lblFetchStatus_Paint);
            // 
            // FrmAdministrativeViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblFetchStatus);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeViewProducts";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmAdministrativeViewProducts_Load);
            this.pnToolBar.ResumeLayout(false);
            this.pnSearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnToolBar;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtSearch;
        private kfcCustomControls.KFCCustomControls.kFCButton btnEdit;
        private kfcCustomControls.KFCCustomControls.kFCButton btnChangeStatus;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnSearchBar;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblFetchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmInfo;
    }
}