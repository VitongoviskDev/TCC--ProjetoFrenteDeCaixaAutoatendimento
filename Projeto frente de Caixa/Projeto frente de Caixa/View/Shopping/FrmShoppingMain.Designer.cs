namespace Projeto_frente_de_Caixa.View.Shopping {
    partial class FrmShoppingMain {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchProduct = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.dgvShoppingList = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPayment = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnSelectedtem = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.lblUnitaryValue = new System.Windows.Forms.Label();
            this.lblProductBarCode = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.pnDetails = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmptyList = new System.Windows.Forms.Label();
            this.pnEmptyList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBarCode = new System.Windows.Forms.Panel();
            this.pnTotalValue = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblNotFoundProduct = new System.Windows.Forms.Label();
            this.tmNotFoundProductLabel = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingList)).BeginInit();
            this.pnSelectedtem.SuspendLayout();
            this.pnDetails.SuspendLayout();
            this.pnEmptyList.SuspendLayout();
            this.pnTotalValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchProduct.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchProduct.BorderColor = System.Drawing.Color.Black;
            this.btnSearchProduct.BorderRadius = 50;
            this.btnSearchProduct.BorderSize = 0;
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.LightGray;
            this.btnSearchProduct.Location = new System.Drawing.Point(12, 12);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(1056, 50);
            this.btnSearchProduct.TabIndex = 0;
            this.btnSearchProduct.Text = "PROCURAR PRODUTO";
            this.btnSearchProduct.TextColor = System.Drawing.Color.LightGray;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // dgvShoppingList
            // 
            this.dgvShoppingList.AllowUserToAddRows = false;
            this.dgvShoppingList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SkyBlue;
            this.dgvShoppingList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShoppingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShoppingList.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvShoppingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShoppingList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShoppingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoppingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShoppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoppingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmProduto,
            this.clmValUnit,
            this.clmDelete});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShoppingList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvShoppingList.EnableHeadersVisualStyles = false;
            this.dgvShoppingList.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvShoppingList.Location = new System.Drawing.Point(12, 68);
            this.dgvShoppingList.MultiSelect = false;
            this.dgvShoppingList.Name = "dgvShoppingList";
            this.dgvShoppingList.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoppingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvShoppingList.RowHeadersVisible = false;
            this.dgvShoppingList.RowTemplate.Height = 40;
            this.dgvShoppingList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShoppingList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShoppingList.Size = new System.Drawing.Size(693, 560);
            this.dgvShoppingList.TabIndex = 1;
            this.dgvShoppingList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShoppingList_CellContentClick);
            this.dgvShoppingList.SelectionChanged += new System.EventHandler(this.dgvShoppingList_SelectionChanged);
            this.dgvShoppingList.SizeChanged += new System.EventHandler(this.dgvShoppingList_SizeChanged);
            // 
            // clmId
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmId.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmProduto
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmProduto.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmProduto.HeaderText = "Produto";
            this.clmProduto.Name = "clmProduto";
            this.clmProduto.ReadOnly = true;
            this.clmProduto.Width = 68;
            // 
            // clmValUnit
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmValUnit.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmValUnit.HeaderText = "Val. unit.";
            this.clmValUnit.Name = "clmValUnit";
            this.clmValUnit.ReadOnly = true;
            this.clmValUnit.Width = 67;
            // 
            // clmDelete
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.clmDelete.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmDelete.HeaderText = "Remover";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Text = "Remover";
            this.clmDelete.Width = 46;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPayment.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnPayment.BorderColor = System.Drawing.Color.Black;
            this.btnPayment.BorderRadius = 50;
            this.btnPayment.BorderSize = 0;
            this.btnPayment.Enabled = false;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.LightGray;
            this.btnPayment.Location = new System.Drawing.Point(718, 658);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(350, 50);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "FINALIZAR";
            this.btnPayment.TextColor = System.Drawing.Color.LightGray;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnSelectedtem
            // 
            this.pnSelectedtem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSelectedtem.BackColor = System.Drawing.Color.White;
            this.pnSelectedtem.BorderRadius = 60;
            this.pnSelectedtem.Color1 = System.Drawing.Color.MidnightBlue;
            this.pnSelectedtem.Color2 = System.Drawing.Color.MidnightBlue;
            this.pnSelectedtem.Controls.Add(this.lblUnitaryValue);
            this.pnSelectedtem.Controls.Add(this.lblProductBarCode);
            this.pnSelectedtem.Controls.Add(this.lblProductDescription);
            this.pnSelectedtem.ForeColor = System.Drawing.Color.Black;
            this.pnSelectedtem.GradientAngle = 0F;
            this.pnSelectedtem.Location = new System.Drawing.Point(718, 68);
            this.pnSelectedtem.Name = "pnSelectedtem";
            this.pnSelectedtem.Size = new System.Drawing.Size(350, 523);
            this.pnSelectedtem.TabIndex = 4;
            this.pnSelectedtem.Visible = false;
            // 
            // lblUnitaryValue
            // 
            this.lblUnitaryValue.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitaryValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUnitaryValue.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitaryValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblUnitaryValue.Location = new System.Drawing.Point(0, 448);
            this.lblUnitaryValue.Name = "lblUnitaryValue";
            this.lblUnitaryValue.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblUnitaryValue.Size = new System.Drawing.Size(350, 75);
            this.lblUnitaryValue.TabIndex = 1;
            this.lblUnitaryValue.Text = "R$ 50,00";
            this.lblUnitaryValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProductBarCode
            // 
            this.lblProductBarCode.BackColor = System.Drawing.Color.Transparent;
            this.lblProductBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductBarCode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductBarCode.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblProductBarCode.Location = new System.Drawing.Point(0, 250);
            this.lblProductBarCode.Name = "lblProductBarCode";
            this.lblProductBarCode.Size = new System.Drawing.Size(350, 33);
            this.lblProductBarCode.TabIndex = 6;
            this.lblProductBarCode.Text = "789 1237 12373";
            this.lblProductBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblProductDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblProductDescription.Location = new System.Drawing.Point(0, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.lblProductDescription.Size = new System.Drawing.Size(350, 250);
            this.lblProductDescription.TabIndex = 6;
            this.lblProductDescription.Text = "Nome do produto";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnDetails
            // 
            this.pnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetails.BackColor = System.Drawing.Color.White;
            this.pnDetails.BorderRadius = 60;
            this.pnDetails.Color1 = System.Drawing.Color.MidnightBlue;
            this.pnDetails.Color2 = System.Drawing.Color.MidnightBlue;
            this.pnDetails.Controls.Add(this.label1);
            this.pnDetails.ForeColor = System.Drawing.Color.Black;
            this.pnDetails.GradientAngle = 0F;
            this.pnDetails.Location = new System.Drawing.Point(718, 68);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(350, 523);
            this.pnDetails.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(56, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nenhum item \r\nselecionado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyList
            // 
            this.lblEmptyList.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyList.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmptyList.Location = new System.Drawing.Point(0, 17);
            this.lblEmptyList.Name = "lblEmptyList";
            this.lblEmptyList.Size = new System.Drawing.Size(693, 39);
            this.lblEmptyList.TabIndex = 0;
            this.lblEmptyList.Text = "Escaneie o código de barras do produto";
            this.lblEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnEmptyList
            // 
            this.pnEmptyList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnEmptyList.Controls.Add(this.label2);
            this.pnEmptyList.Controls.Add(this.lblEmptyList);
            this.pnEmptyList.Controls.Add(this.pnBarCode);
            this.pnEmptyList.Location = new System.Drawing.Point(12, 200);
            this.pnEmptyList.Name = "pnEmptyList";
            this.pnEmptyList.Size = new System.Drawing.Size(693, 221);
            this.pnEmptyList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(0, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(693, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "usando o leitor abaxio de tela\r\nv    V    v";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBarCode
            // 
            this.pnBarCode.BackgroundImage = global::Projeto_frente_de_Caixa.Properties.Resources.BarCode1;
            this.pnBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBarCode.Location = new System.Drawing.Point(46, 59);
            this.pnBarCode.Name = "pnBarCode";
            this.pnBarCode.Size = new System.Drawing.Size(600, 59);
            this.pnBarCode.TabIndex = 1;
            // 
            // pnTotalValue
            // 
            this.pnTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTotalValue.BackColor = System.Drawing.Color.White;
            this.pnTotalValue.BorderRadius = 80;
            this.pnTotalValue.Color1 = System.Drawing.Color.MidnightBlue;
            this.pnTotalValue.Color2 = System.Drawing.Color.MidnightBlue;
            this.pnTotalValue.Controls.Add(this.lblTotalValue);
            this.pnTotalValue.Controls.Add(this.label3);
            this.pnTotalValue.ForeColor = System.Drawing.Color.Black;
            this.pnTotalValue.GradientAngle = 0F;
            this.pnTotalValue.Location = new System.Drawing.Point(12, 628);
            this.pnTotalValue.Name = "pnTotalValue";
            this.pnTotalValue.Size = new System.Drawing.Size(693, 80);
            this.pnTotalValue.TabIndex = 10;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalValue.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalValue.Location = new System.Drawing.Point(138, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalValue.Size = new System.Drawing.Size(555, 80);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "R$ 0,00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(138, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOTAL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(-50, -50);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(288, 20);
            this.txtBarCode.TabIndex = 11;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            this.txtBarCode.Leave += new System.EventHandler(this.txtBarCode_Leave);
            // 
            // lblNotFoundProduct
            // 
            this.lblNotFoundProduct.AutoSize = true;
            this.lblNotFoundProduct.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFoundProduct.ForeColor = System.Drawing.Color.Crimson;
            this.lblNotFoundProduct.Location = new System.Drawing.Point(156, 587);
            this.lblNotFoundProduct.Name = "lblNotFoundProduct";
            this.lblNotFoundProduct.Size = new System.Drawing.Size(430, 41);
            this.lblNotFoundProduct.TabIndex = 12;
            this.lblNotFoundProduct.Text = "Produto não encontrado";
            this.lblNotFoundProduct.Visible = false;
            // 
            // tmNotFoundProductLabel
            // 
            this.tmNotFoundProductLabel.Interval = 1000;
            this.tmNotFoundProductLabel.Tick += new System.EventHandler(this.tmNotFoundProductLabel_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 50;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(718, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(350, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextColor = System.Drawing.Color.LightGray;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmShoppingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblNotFoundProduct);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.pnTotalValue);
            this.Controls.Add(this.pnEmptyList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dgvShoppingList);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.pnSelectedtem);
            this.Controls.Add(this.pnDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingMain";
            this.Text = "FrmShoppingMain";
            this.Load += new System.EventHandler(this.FrmShoppingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoppingList)).EndInit();
            this.pnSelectedtem.ResumeLayout(false);
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.pnEmptyList.ResumeLayout(false);
            this.pnTotalValue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.kFCButton btnSearchProduct;
        private System.Windows.Forms.DataGridView dgvShoppingList;
        private kfcCustomControls.KFCCustomControls.kFCButton btnPayment;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnSelectedtem;
        private System.Windows.Forms.Label lblUnitaryValue;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductBarCode;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmptyList;
        private System.Windows.Forms.Panel pnEmptyList;
        private System.Windows.Forms.Panel pnBarCode;
        private System.Windows.Forms.Label label2;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnTotalValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValUnit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.Label lblNotFoundProduct;
        private System.Windows.Forms.Timer tmNotFoundProductLabel;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
    }
}