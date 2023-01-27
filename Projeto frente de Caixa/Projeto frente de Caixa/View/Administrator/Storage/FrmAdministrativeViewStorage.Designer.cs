namespace Projeto_frente_de_Caixa.View.Administrator.Storage
{
    partial class FrmAdministrativeViewStorage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStorage = new System.Windows.Forms.DataGridView();
            this.lblFetchItems = new System.Windows.Forms.Label();
            this.pnToolBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.pnSearchBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.txtSearch = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.pnEntryTotalValue = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.lblEntryTotalValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnSaleTotalValue = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.lblSaleTotalValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitaryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStorageLevelAlert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.pnToolBar.SuspendLayout();
            this.pnSearchBar.SuspendLayout();
            this.pnEntryTotalValue.SuspendLayout();
            this.pnSaleTotalValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStorage.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStorage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStorage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStorage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIndex,
            this.clmBarCode,
            this.clmDescription,
            this.clmEntryValue,
            this.clmUnitaryValue,
            this.clmAmount,
            this.clmStorageLevelAlert});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorage.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStorage.EnableHeadersVisualStyles = false;
            this.dgvStorage.GridColor = System.Drawing.Color.Black;
            this.dgvStorage.Location = new System.Drawing.Point(12, 87);
            this.dgvStorage.MultiSelect = false;
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorage.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStorage.RowHeadersVisible = false;
            this.dgvStorage.RowTemplate.Height = 40;
            this.dgvStorage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStorage.Size = new System.Drawing.Size(1056, 539);
            this.dgvStorage.TabIndex = 11;
            this.dgvStorage.SelectionChanged += new System.EventHandler(this.dgvStorage_SelectionChanged);
            this.dgvStorage.SizeChanged += new System.EventHandler(this.dgvStorage_SizeChanged);
            // 
            // lblFetchItems
            // 
            this.lblFetchItems.AutoSize = true;
            this.lblFetchItems.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblFetchItems.Location = new System.Drawing.Point(442, 368);
            this.lblFetchItems.Name = "lblFetchItems";
            this.lblFetchItems.Size = new System.Drawing.Size(196, 24);
            this.lblFetchItems.TabIndex = 12;
            this.lblFetchItems.Text = "Procurando itens...";
            // 
            // pnToolBar
            // 
            this.pnToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnToolBar.BackColor = System.Drawing.Color.Transparent;
            this.pnToolBar.BorderRadius = 60;
            this.pnToolBar.Color1 = System.Drawing.Color.Gray;
            this.pnToolBar.Color2 = System.Drawing.Color.Gray;
            this.pnToolBar.Controls.Add(this.pnSearchBar);
            this.pnToolBar.ForeColor = System.Drawing.Color.Black;
            this.pnToolBar.GradientAngle = 0F;
            this.pnToolBar.Location = new System.Drawing.Point(12, 12);
            this.pnToolBar.Name = "pnToolBar";
            this.pnToolBar.Size = new System.Drawing.Size(1056, 60);
            this.pnToolBar.TabIndex = 13;
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
            this.pnSearchBar.Size = new System.Drawing.Size(1047, 50);
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
            this.txtSearch.Size = new System.Drawing.Size(1009, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.Texts = "";
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // pnEntryTotalValue
            // 
            this.pnEntryTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnEntryTotalValue.BackColor = System.Drawing.Color.White;
            this.pnEntryTotalValue.BorderRadius = 60;
            this.pnEntryTotalValue.Color1 = System.Drawing.Color.Black;
            this.pnEntryTotalValue.Color2 = System.Drawing.Color.Black;
            this.pnEntryTotalValue.Controls.Add(this.lblEntryTotalValue);
            this.pnEntryTotalValue.Controls.Add(this.label3);
            this.pnEntryTotalValue.ForeColor = System.Drawing.Color.Black;
            this.pnEntryTotalValue.GradientAngle = 0F;
            this.pnEntryTotalValue.Location = new System.Drawing.Point(35, 650);
            this.pnEntryTotalValue.Name = "pnEntryTotalValue";
            this.pnEntryTotalValue.Size = new System.Drawing.Size(500, 59);
            this.pnEntryTotalValue.TabIndex = 14;
            // 
            // lblEntryTotalValue
            // 
            this.lblEntryTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblEntryTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryTotalValue.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTotalValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEntryTotalValue.Location = new System.Drawing.Point(260, 0);
            this.lblEntryTotalValue.Name = "lblEntryTotalValue";
            this.lblEntryTotalValue.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblEntryTotalValue.Size = new System.Drawing.Size(240, 59);
            this.lblEntryTotalValue.TabIndex = 1;
            this.lblEntryTotalValue.Text = "R$ 0,00";
            this.lblEntryTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(260, 59);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total entrada:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSaleTotalValue
            // 
            this.pnSaleTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSaleTotalValue.BackColor = System.Drawing.Color.White;
            this.pnSaleTotalValue.BorderRadius = 60;
            this.pnSaleTotalValue.Color1 = System.Drawing.Color.Black;
            this.pnSaleTotalValue.Color2 = System.Drawing.Color.Black;
            this.pnSaleTotalValue.Controls.Add(this.lblSaleTotalValue);
            this.pnSaleTotalValue.Controls.Add(this.label2);
            this.pnSaleTotalValue.ForeColor = System.Drawing.Color.Black;
            this.pnSaleTotalValue.GradientAngle = 0F;
            this.pnSaleTotalValue.Location = new System.Drawing.Point(544, 650);
            this.pnSaleTotalValue.Name = "pnSaleTotalValue";
            this.pnSaleTotalValue.Size = new System.Drawing.Size(500, 59);
            this.pnSaleTotalValue.TabIndex = 14;
            // 
            // lblSaleTotalValue
            // 
            this.lblSaleTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaleTotalValue.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotalValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaleTotalValue.Location = new System.Drawing.Point(233, 0);
            this.lblSaleTotalValue.Name = "lblSaleTotalValue";
            this.lblSaleTotalValue.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblSaleTotalValue.Size = new System.Drawing.Size(267, 59);
            this.lblSaleTotalValue.TabIndex = 1;
            this.lblSaleTotalValue.Text = "R$ 0,00";
            this.lblSaleTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(233, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total venda:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clmIndex
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmIndex.HeaderText = "*";
            this.clmIndex.Name = "clmIndex";
            this.clmIndex.ReadOnly = true;
            // 
            // clmBarCode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBarCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmBarCode.HeaderText = "Cód. Barrras";
            this.clmBarCode.Name = "clmBarCode";
            this.clmBarCode.ReadOnly = true;
            // 
            // clmDescription
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmDescription.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmDescription.HeaderText = "Item";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmEntryValue
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmEntryValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmEntryValue.HeaderText = "Valor entrada";
            this.clmEntryValue.Name = "clmEntryValue";
            this.clmEntryValue.ReadOnly = true;
            // 
            // clmUnitaryValue
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmUnitaryValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmUnitaryValue.HeaderText = "Valor venda";
            this.clmUnitaryValue.Name = "clmUnitaryValue";
            this.clmUnitaryValue.ReadOnly = true;
            // 
            // clmAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmAmount.HeaderText = "Qtd. estoque";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmStorageLevelAlert
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmStorageLevelAlert.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmStorageLevelAlert.HeaderText = "Alerta de Estoque";
            this.clmStorageLevelAlert.Name = "clmStorageLevelAlert";
            this.clmStorageLevelAlert.ReadOnly = true;
            // 
            // FrmAdministrativeViewStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnSaleTotalValue);
            this.Controls.Add(this.pnEntryTotalValue);
            this.Controls.Add(this.pnToolBar);
            this.Controls.Add(this.lblFetchItems);
            this.Controls.Add(this.dgvStorage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeViewStorage";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmAdministrativeViewStorage_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAdministrativeViewStorage_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.pnToolBar.ResumeLayout(false);
            this.pnSearchBar.ResumeLayout(false);
            this.pnEntryTotalValue.ResumeLayout(false);
            this.pnSaleTotalValue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStorage;
        private System.Windows.Forms.Label lblFetchItems;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnToolBar;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnSearchBar;
        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtSearch;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnEntryTotalValue;
        private System.Windows.Forms.Label lblEntryTotalValue;
        private System.Windows.Forms.Label label3;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnSaleTotalValue;
        private System.Windows.Forms.Label lblSaleTotalValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitaryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStorageLevelAlert;
    }
}