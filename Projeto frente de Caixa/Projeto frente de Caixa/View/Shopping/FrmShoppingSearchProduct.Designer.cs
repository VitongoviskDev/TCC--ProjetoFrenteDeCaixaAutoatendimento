namespace Projeto_frente_de_Caixa.View.Shopping {
    partial class FrmShoppingSearchProduct {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHolder = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kfcGradientPanel1 = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.kfcGradientPanel2 = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblNoProducts = new System.Windows.Forms.Label();
            this.pnHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.panel3.SuspendLayout();
            this.kfcGradientPanel1.SuspendLayout();
            this.kfcGradientPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHolder
            // 
            this.pnHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHolder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnHolder.Controls.Add(this.lblNoProducts);
            this.pnHolder.Controls.Add(this.textBox1);
            this.pnHolder.Controls.Add(this.dgvProductsList);
            this.pnHolder.Controls.Add(this.panel3);
            this.pnHolder.Controls.Add(this.panel2);
            this.pnHolder.Location = new System.Drawing.Point(5, 5);
            this.pnHolder.Name = "pnHolder";
            this.pnHolder.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnHolder.Size = new System.Drawing.Size(870, 510);
            this.pnHolder.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-50, -50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AllowUserToAddRows = false;
            this.dgvProductsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvProductsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsList.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvProductsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmProduto,
            this.clmValUnit,
            this.clmBarCode});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductsList.EnableHeadersVisualStyles = false;
            this.dgvProductsList.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvProductsList.Location = new System.Drawing.Point(5, 74);
            this.dgvProductsList.MultiSelect = false;
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductsList.RowHeadersVisible = false;
            this.dgvProductsList.RowTemplate.Height = 40;
            this.dgvProductsList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductsList.Size = new System.Drawing.Size(860, 366);
            this.dgvProductsList.TabIndex = 7;
            this.dgvProductsList.SelectionChanged += new System.EventHandler(this.dgvProductsList_SelectionChanged);
            this.dgvProductsList.SizeChanged += new System.EventHandler(this.dgvProductsList_SizeChanged);
            // 
            // clmId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmId.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmProduto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.ReadOnly = true;
            this.clmProduto.Width = 68;
            // 
            // clmValUnit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmValUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmValUnit.HeaderText = "Valor";
            this.clmValUnit.Name = "clmValUnit";
            this.clmValUnit.ReadOnly = true;
            this.clmValUnit.Width = 67;
            // 
            // clmBarCode
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBarCode.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmBarCode.HeaderText = "Código";
            this.clmBarCode.Name = "clmBarCode";
            this.clmBarCode.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kfcGradientPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel3.Size = new System.Drawing.Size(860, 74);
            this.panel3.TabIndex = 11;
            // 
            // kfcGradientPanel1
            // 
            this.kfcGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.kfcGradientPanel1.BorderRadius = 50;
            this.kfcGradientPanel1.Color1 = System.Drawing.Color.MidnightBlue;
            this.kfcGradientPanel1.Color2 = System.Drawing.Color.MidnightBlue;
            this.kfcGradientPanel1.Controls.Add(this.kfcGradientPanel2);
            this.kfcGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kfcGradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.kfcGradientPanel1.GradientAngle = 0F;
            this.kfcGradientPanel1.Location = new System.Drawing.Point(0, 14);
            this.kfcGradientPanel1.Name = "kfcGradientPanel1";
            this.kfcGradientPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.kfcGradientPanel1.Size = new System.Drawing.Size(860, 50);
            this.kfcGradientPanel1.TabIndex = 0;
            // 
            // kfcGradientPanel2
            // 
            this.kfcGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.kfcGradientPanel2.BorderRadius = 46;
            this.kfcGradientPanel2.Color1 = System.Drawing.Color.LightSkyBlue;
            this.kfcGradientPanel2.Color2 = System.Drawing.Color.LightSkyBlue;
            this.kfcGradientPanel2.Controls.Add(this.txtSearch);
            this.kfcGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kfcGradientPanel2.ForeColor = System.Drawing.Color.Black;
            this.kfcGradientPanel2.GradientAngle = 0F;
            this.kfcGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.kfcGradientPanel2.Name = "kfcGradientPanel2";
            this.kfcGradientPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kfcGradientPanel2.Size = new System.Drawing.Size(854, 44);
            this.kfcGradientPanel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(834, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 70);
            this.panel2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 60;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd.Location = new System.Drawing.Point(453, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADICIONAR";
            this.btnAdd.TextColor = System.Drawing.Color.LightGray;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 60;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(83, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(300, 60);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextColor = System.Drawing.Color.LightGray;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNoProducts
            // 
            this.lblNoProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoProducts.AutoSize = true;
            this.lblNoProducts.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNoProducts.Location = new System.Drawing.Point(220, 225);
            this.lblNoProducts.Name = "lblNoProducts";
            this.lblNoProducts.Size = new System.Drawing.Size(420, 64);
            this.lblNoProducts.TabIndex = 13;
            this.lblNoProducts.Text = "Nenhum produto encontrado...\r\n(Chame um atendente)";
            this.lblNoProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmShoppingSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.Controls.Add(this.pnHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSearchProduct";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            this.pnHolder.ResumeLayout(false);
            this.pnHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.kfcGradientPanel1.ResumeLayout(false);
            this.kfcGradientPanel2.ResumeLayout(false);
            this.kfcGradientPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHolder;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdd;
        private System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarCode;
        private System.Windows.Forms.TextBox textBox1;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel kfcGradientPanel1;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel kfcGradientPanel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblNoProducts;
    }
}