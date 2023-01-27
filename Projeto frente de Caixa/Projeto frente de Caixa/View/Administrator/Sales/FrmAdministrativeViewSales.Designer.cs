namespace Projeto_frente_de_Caixa.View.Administrator.Sales
{
    partial class FrmAdministrativeViewSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnToolBar = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDtpTo = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.dtpTo = new kfcCustomControls.KFCCustomControls.KFCDatePicker();
            this.pnDtpFrom = new kfcCustomControls.KFCCustomControls.KFCGradientPanel();
            this.dtpFrom = new kfcCustomControls.KFCCustomControls.KFCDatePicker();
            this.pnDgvsHolder = new System.Windows.Forms.Panel();
            this.pnDgvItems = new System.Windows.Forms.Panel();
            this.lblFetchItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmItemIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDgvDocuments = new System.Windows.Forms.Panel();
            this.lblFetchDocuments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.clmDocIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtdItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnToolBar.SuspendLayout();
            this.pnDtpTo.SuspendLayout();
            this.pnDtpFrom.SuspendLayout();
            this.pnDgvsHolder.SuspendLayout();
            this.pnDgvItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnDgvDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
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
            this.pnToolBar.Controls.Add(this.label2);
            this.pnToolBar.Controls.Add(this.label1);
            this.pnToolBar.Controls.Add(this.pnDtpTo);
            this.pnToolBar.Controls.Add(this.pnDtpFrom);
            this.pnToolBar.ForeColor = System.Drawing.Color.Black;
            this.pnToolBar.GradientAngle = 0F;
            this.pnToolBar.Location = new System.Drawing.Point(50, 12);
            this.pnToolBar.Name = "pnToolBar";
            this.pnToolBar.Size = new System.Drawing.Size(980, 60);
            this.pnToolBar.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(520, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "De:";
            // 
            // pnDtpTo
            // 
            this.pnDtpTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnDtpTo.BackColor = System.Drawing.Color.White;
            this.pnDtpTo.BorderRadius = 50;
            this.pnDtpTo.Color1 = System.Drawing.Color.Black;
            this.pnDtpTo.Color2 = System.Drawing.Color.Black;
            this.pnDtpTo.Controls.Add(this.dtpTo);
            this.pnDtpTo.ForeColor = System.Drawing.Color.Black;
            this.pnDtpTo.GradientAngle = 0F;
            this.pnDtpTo.Location = new System.Drawing.Point(575, 5);
            this.pnDtpTo.Name = "pnDtpTo";
            this.pnDtpTo.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnDtpTo.Size = new System.Drawing.Size(400, 50);
            this.pnDtpTo.TabIndex = 12;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dtpTo.BorderSize = 0;
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(14, 7);
            this.dtpTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(372, 35);
            this.dtpTo.SkinColor = System.Drawing.Color.Black;
            this.dtpTo.TabIndex = 3;
            this.dtpTo.TextColor = System.Drawing.Color.White;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // pnDtpFrom
            // 
            this.pnDtpFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnDtpFrom.BackColor = System.Drawing.Color.White;
            this.pnDtpFrom.BorderRadius = 50;
            this.pnDtpFrom.Color1 = System.Drawing.Color.Black;
            this.pnDtpFrom.Color2 = System.Drawing.Color.Black;
            this.pnDtpFrom.Controls.Add(this.dtpFrom);
            this.pnDtpFrom.ForeColor = System.Drawing.Color.Black;
            this.pnDtpFrom.GradientAngle = 0F;
            this.pnDtpFrom.Location = new System.Drawing.Point(70, 5);
            this.pnDtpFrom.Name = "pnDtpFrom";
            this.pnDtpFrom.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnDtpFrom.Size = new System.Drawing.Size(400, 50);
            this.pnDtpFrom.TabIndex = 12;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dtpFrom.BorderSize = 0;
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(14, 7);
            this.dtpFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(372, 35);
            this.dtpFrom.SkinColor = System.Drawing.Color.Black;
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.TextColor = System.Drawing.Color.White;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // pnDgvsHolder
            // 
            this.pnDgvsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDgvsHolder.Controls.Add(this.pnDgvItems);
            this.pnDgvsHolder.Controls.Add(this.pnDgvDocuments);
            this.pnDgvsHolder.Location = new System.Drawing.Point(50, 106);
            this.pnDgvsHolder.Name = "pnDgvsHolder";
            this.pnDgvsHolder.Size = new System.Drawing.Size(980, 602);
            this.pnDgvsHolder.TabIndex = 16;
            // 
            // pnDgvItems
            // 
            this.pnDgvItems.Controls.Add(this.lblFetchItems);
            this.pnDgvItems.Controls.Add(this.label4);
            this.pnDgvItems.Controls.Add(this.dgvItems);
            this.pnDgvItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDgvItems.Location = new System.Drawing.Point(0, 311);
            this.pnDgvItems.Name = "pnDgvItems";
            this.pnDgvItems.Size = new System.Drawing.Size(980, 291);
            this.pnDgvItems.TabIndex = 14;
            // 
            // lblFetchItems
            // 
            this.lblFetchItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFetchItems.AutoSize = true;
            this.lblFetchItems.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchItems.ForeColor = System.Drawing.Color.Black;
            this.lblFetchItems.Location = new System.Drawing.Point(371, 156);
            this.lblFetchItems.Name = "lblFetchItems";
            this.lblFetchItems.Size = new System.Drawing.Size(196, 24);
            this.lblFetchItems.TabIndex = 11;
            this.lblFetchItems.Text = "Procurando itens...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Items";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemIndex,
            this.clmBarCode,
            this.clmItem,
            this.clmPrice,
            this.clmAmount,
            this.clmUnity,
            this.clmSt,
            this.clmItemTotalValue});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.Black;
            this.dgvItems.Location = new System.Drawing.Point(0, 27);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 40;
            this.dgvItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItems.Size = new System.Drawing.Size(980, 278);
            this.dgvItems.TabIndex = 10;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // clmItemIndex
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmItemIndex.HeaderText = "*";
            this.clmItemIndex.Name = "clmItemIndex";
            this.clmItemIndex.ReadOnly = true;
            // 
            // clmBarCode
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmBarCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmBarCode.HeaderText = "Cód. Barras";
            this.clmBarCode.Name = "clmBarCode";
            this.clmBarCode.ReadOnly = true;
            // 
            // clmItem
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmItem.HeaderText = "Item";
            this.clmItem.Name = "clmItem";
            this.clmItem.ReadOnly = true;
            // 
            // clmPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmPrice.HeaderText = "Valor unit.";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmAmount.HeaderText = "Qtd.";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmUnity
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmUnity.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmUnity.HeaderText = "Unidade";
            this.clmUnity.Name = "clmUnity";
            this.clmUnity.ReadOnly = true;
            // 
            // clmSt
            // 
            this.clmSt.HeaderText = "ST";
            this.clmSt.Name = "clmSt";
            this.clmSt.ReadOnly = true;
            // 
            // clmItemTotalValue
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmItemTotalValue.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmItemTotalValue.HeaderText = "Total";
            this.clmItemTotalValue.Name = "clmItemTotalValue";
            this.clmItemTotalValue.ReadOnly = true;
            // 
            // pnDgvDocuments
            // 
            this.pnDgvDocuments.Controls.Add(this.lblFetchDocuments);
            this.pnDgvDocuments.Controls.Add(this.label3);
            this.pnDgvDocuments.Controls.Add(this.dgvDocuments);
            this.pnDgvDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDgvDocuments.Location = new System.Drawing.Point(0, 0);
            this.pnDgvDocuments.Name = "pnDgvDocuments";
            this.pnDgvDocuments.Size = new System.Drawing.Size(980, 311);
            this.pnDgvDocuments.TabIndex = 13;
            // 
            // lblFetchDocuments
            // 
            this.lblFetchDocuments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFetchDocuments.AutoSize = true;
            this.lblFetchDocuments.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetchDocuments.ForeColor = System.Drawing.Color.Black;
            this.lblFetchDocuments.Location = new System.Drawing.Point(348, 173);
            this.lblFetchDocuments.Name = "lblFetchDocuments";
            this.lblFetchDocuments.Size = new System.Drawing.Size(283, 24);
            this.lblFetchDocuments.TabIndex = 11;
            this.lblFetchDocuments.Text = "Procurando documentos...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Documentos";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocuments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDocIndex,
            this.clmNumber,
            this.clmSerial,
            this.clmCpf,
            this.clmDate,
            this.clmQtdItems,
            this.clmDocTotalValue});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocuments.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDocuments.EnableHeadersVisualStyles = false;
            this.dgvDocuments.GridColor = System.Drawing.Color.Black;
            this.dgvDocuments.Location = new System.Drawing.Point(0, 27);
            this.dgvDocuments.MultiSelect = false;
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocuments.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.RowTemplate.Height = 40;
            this.dgvDocuments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocuments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDocuments.Size = new System.Drawing.Size(980, 281);
            this.dgvDocuments.TabIndex = 10;
            this.dgvDocuments.SelectionChanged += new System.EventHandler(this.dgvDocuments_SelectionChanged);
            // 
            // clmDocIndex
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDocIndex.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmDocIndex.HeaderText = "*";
            this.clmDocIndex.Name = "clmDocIndex";
            this.clmDocIndex.ReadOnly = true;
            // 
            // clmNumber
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmNumber.HeaderText = "Número";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmSerial
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSerial.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmSerial.HeaderText = "Série";
            this.clmSerial.Name = "clmSerial";
            this.clmSerial.ReadOnly = true;
            // 
            // clmCpf
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCpf.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmCpf.HeaderText = "CPF";
            this.clmCpf.Name = "clmCpf";
            this.clmCpf.ReadOnly = true;
            // 
            // clmDate
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDate.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmDate.HeaderText = "Data";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmQtdItems
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQtdItems.DefaultCellStyle = dataGridViewCellStyle17;
            this.clmQtdItems.HeaderText = "Qtd. items";
            this.clmQtdItems.Name = "clmQtdItems";
            this.clmQtdItems.ReadOnly = true;
            // 
            // clmDocTotalValue
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDocTotalValue.DefaultCellStyle = dataGridViewCellStyle18;
            this.clmDocTotalValue.HeaderText = "Total";
            this.clmDocTotalValue.Name = "clmDocTotalValue";
            this.clmDocTotalValue.ReadOnly = true;
            // 
            // FrmAdministrativeViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnToolBar);
            this.Controls.Add(this.pnDgvsHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeViewSales";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmAdministrativeViewSales_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAdministrativeViewSales_SizeChanged);
            this.pnToolBar.ResumeLayout(false);
            this.pnToolBar.PerformLayout();
            this.pnDtpTo.ResumeLayout(false);
            this.pnDtpFrom.ResumeLayout(false);
            this.pnDgvsHolder.ResumeLayout(false);
            this.pnDgvItems.ResumeLayout(false);
            this.pnDgvItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnDgvDocuments.ResumeLayout(false);
            this.pnDgvDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnToolBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnDtpTo;
        private kfcCustomControls.KFCCustomControls.KFCDatePicker dtpTo;
        private kfcCustomControls.KFCCustomControls.KFCGradientPanel pnDtpFrom;
        private kfcCustomControls.KFCCustomControls.KFCDatePicker dtpFrom;
        private System.Windows.Forms.Panel pnDgvsHolder;
        private System.Windows.Forms.Panel pnDgvItems;
        private System.Windows.Forms.Label lblFetchItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnDgvDocuments;
        private System.Windows.Forms.Label lblFetchDocuments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemTotalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtdItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocTotalValue;
    }
}