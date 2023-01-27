namespace Projeto_frente_de_Caixa.View.Administrator.Entrys
{
    partial class FrmAdministrativeAddEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilePath = new Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox();
            this.btnFileDialog = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblSocialReason = new System.Windows.Forms.Label();
            this.pnFileData = new System.Windows.Forms.Panel();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitaryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.lblDocumentSerialNumber = new System.Windows.Forms.Label();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblComplement = new System.Windows.Forms.Label();
            this.lblAdress2 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblEmissionDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStateRegistration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFantasyName = new System.Windows.Forms.Label();
            this.btnOpen = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnFileData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFilePath.BorderColor = System.Drawing.Color.Black;
            this.txtFilePath.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtFilePath.BorderRadius = 0;
            this.txtFilePath.BorderSize = 2;
            this.txtFilePath.BottomBorderOnly = true;
            this.txtFilePath.CursorIndex = 0;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.ForeColor = System.Drawing.Color.Black;
            this.txtFilePath.Location = new System.Drawing.Point(45, 20);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Multiline = false;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceHolderColor = System.Drawing.Color.DimGray;
            this.txtFilePath.PlaceHolderText = "Local do aquivo";
            this.txtFilePath.Size = new System.Drawing.Size(937, 36);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilePath.Texts = "";
            this.txtFilePath.Click += new System.EventHandler(this.txtFilePath_Click);
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileDialog.BackColor = System.Drawing.Color.Transparent;
            this.btnFileDialog.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnFileDialog.BorderColor = System.Drawing.Color.Black;
            this.btnFileDialog.BorderRadius = 5;
            this.btnFileDialog.BorderSize = 2;
            this.btnFileDialog.FlatAppearance.BorderSize = 0;
            this.btnFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDialog.ForeColor = System.Drawing.Color.Black;
            this.btnFileDialog.Image = global::Projeto_frente_de_Caixa.Properties.Resources.folder;
            this.btnFileDialog.Location = new System.Drawing.Point(989, 10);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(46, 46);
            this.btnFileDialog.TabIndex = 1;
            this.btnFileDialog.TextColor = System.Drawing.Color.Black;
            this.btnFileDialog.UseVisualStyleBackColor = false;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // lblSocialReason
            // 
            this.lblSocialReason.AutoSize = true;
            this.lblSocialReason.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocialReason.Location = new System.Drawing.Point(36, 106);
            this.lblSocialReason.Name = "lblSocialReason";
            this.lblSocialReason.Size = new System.Drawing.Size(163, 30);
            this.lblSocialReason.TabIndex = 2;
            this.lblSocialReason.Text = "Razão social";
            // 
            // pnFileData
            // 
            this.pnFileData.Controls.Add(this.btnCancel);
            this.pnFileData.Controls.Add(this.dgvItems);
            this.pnFileData.Controls.Add(this.btnAdd);
            this.pnFileData.Controls.Add(this.lblDocumentSerialNumber);
            this.pnFileData.Controls.Add(this.lblDocumentNumber);
            this.pnFileData.Controls.Add(this.label3);
            this.pnFileData.Controls.Add(this.lblAdress1);
            this.pnFileData.Controls.Add(this.lblComplement);
            this.pnFileData.Controls.Add(this.lblAdress2);
            this.pnFileData.Controls.Add(this.lblTotalValue);
            this.pnFileData.Controls.Add(this.lblRegistration);
            this.pnFileData.Controls.Add(this.lblEmissionDate);
            this.pnFileData.Controls.Add(this.lblPhone);
            this.pnFileData.Controls.Add(this.label5);
            this.pnFileData.Controls.Add(this.Registration);
            this.pnFileData.Controls.Add(this.lblCnpj);
            this.pnFileData.Controls.Add(this.label4);
            this.pnFileData.Controls.Add(this.label1);
            this.pnFileData.Controls.Add(this.lblStateRegistration);
            this.pnFileData.Controls.Add(this.label2);
            this.pnFileData.Controls.Add(this.lblFantasyName);
            this.pnFileData.Controls.Add(this.lblSocialReason);
            this.pnFileData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFileData.Location = new System.Drawing.Point(0, 117);
            this.pnFileData.Name = "pnFileData";
            this.pnFileData.Size = new System.Drawing.Size(1080, 603);
            this.pnFileData.TabIndex = 3;
            this.pnFileData.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 50;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(29, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.clmIndex,
            this.clmBarCode,
            this.clmDescription,
            this.clmUnity,
            this.clmAmount,
            this.clmUnitaryValue,
            this.clmTotalValue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.Black;
            this.dgvItems.Location = new System.Drawing.Point(41, 327);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 40;
            this.dgvItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItems.Size = new System.Drawing.Size(994, 209);
            this.dgvItems.TabIndex = 11;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            this.dgvItems.SizeChanged += new System.EventHandler(this.dgvItems_SizeChanged);
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
            this.clmBarCode.HeaderText = "Cód. barras";
            this.clmBarCode.Name = "clmBarCode";
            this.clmBarCode.ReadOnly = true;
            // 
            // clmDescription
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDescription.HeaderText = "Descrição";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmUnity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmUnity.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmUnity.HeaderText = "Unidade";
            this.clmUnity.Name = "clmUnity";
            this.clmUnity.ReadOnly = true;
            // 
            // clmAmount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmAmount.HeaderText = "Qtd.";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmUnitaryValue
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmUnitaryValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmUnitaryValue.HeaderText = "Val. Unitário";
            this.clmUnitaryValue.Name = "clmUnitaryValue";
            this.clmUnitaryValue.ReadOnly = true;
            // 
            // clmTotalValue
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTotalValue.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmTotalValue.HeaderText = "Val. total";
            this.clmTotalValue.Name = "clmTotalValue";
            this.clmTotalValue.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.BackgroundColor = System.Drawing.Color.Black;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 40;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(45, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(990, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADICIONAR ESTOQUE";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDocumentSerialNumber
            // 
            this.lblDocumentSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentSerialNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentSerialNumber.Location = new System.Drawing.Point(879, 50);
            this.lblDocumentSerialNumber.Name = "lblDocumentSerialNumber";
            this.lblDocumentSerialNumber.Size = new System.Drawing.Size(140, 25);
            this.lblDocumentSerialNumber.TabIndex = 2;
            this.lblDocumentSerialNumber.Text = "Série. 000";
            this.lblDocumentSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(879, 25);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(140, 25);
            this.lblDocumentNumber.TabIndex = 2;
            this.lblDocumentNumber.Text = "Nº. 00000";
            this.lblDocumentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "IE:";
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress1.Location = new System.Drawing.Point(41, 232);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(55, 24);
            this.lblAdress1.TabIndex = 2;
            this.lblAdress1.Text = "CEP:";
            // 
            // lblComplement
            // 
            this.lblComplement.AutoSize = true;
            this.lblComplement.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplement.Location = new System.Drawing.Point(41, 293);
            this.lblComplement.Name = "lblComplement";
            this.lblComplement.Size = new System.Drawing.Size(169, 24);
            this.lblComplement.TabIndex = 2;
            this.lblComplement.Text = "Complemento:";
            // 
            // lblAdress2
            // 
            this.lblAdress2.AutoSize = true;
            this.lblAdress2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress2.Location = new System.Drawing.Point(41, 261);
            this.lblAdress2.Name = "lblAdress2";
            this.lblAdress2.Size = new System.Drawing.Size(70, 24);
            this.lblAdress2.TabIndex = 2;
            this.lblAdress2.Text = "Bairro:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(813, 293);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(191, 24);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "R$99.999,00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegistration
            // 
            this.lblRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(880, 178);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(124, 24);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "00/00/0000";
            this.lblRegistration.Visible = false;
            // 
            // lblEmissionDate
            // 
            this.lblEmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmissionDate.AutoSize = true;
            this.lblEmissionDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissionDate.Location = new System.Drawing.Point(880, 140);
            this.lblEmissionDate.Name = "lblEmissionDate";
            this.lblEmissionDate.Size = new System.Drawing.Size(124, 24);
            this.lblEmissionDate.TabIndex = 2;
            this.lblEmissionDate.Text = "00/00/0000";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(131, 189);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(211, 24);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "+55 (11) 97167-7642";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Registration
            // 
            this.Registration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration.Location = new System.Drawing.Point(787, 178);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(97, 25);
            this.Registration.TabIndex = 2;
            this.Registration.Text = "Entrada:";
            this.Registration.Visible = false;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(114, 153);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(204, 24);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "25.392.447/0001-84";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Emissão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contato:";
            // 
            // lblStateRegistration
            // 
            this.lblStateRegistration.AutoSize = true;
            this.lblStateRegistration.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRegistration.Location = new System.Drawing.Point(383, 153);
            this.lblStateRegistration.Name = "lblStateRegistration";
            this.lblStateRegistration.Size = new System.Drawing.Size(169, 24);
            this.lblStateRegistration.TabIndex = 2;
            this.lblStateRegistration.Text = "218.113.430.395";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ:";
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.AutoSize = true;
            this.lblFantasyName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasyName.Location = new System.Drawing.Point(34, 71);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(264, 41);
            this.lblFantasyName.TabIndex = 2;
            this.lblFantasyName.Text = "Nome fantasia";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.BackgroundColor = System.Drawing.Color.Black;
            this.btnOpen.BorderColor = System.Drawing.Color.Black;
            this.btnOpen.BorderRadius = 40;
            this.btnOpen.BorderSize = 2;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(45, 63);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(990, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "ABRIR";
            this.btnOpen.TextColor = System.Drawing.Color.White;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.txtFilePath);
            this.pnHeader.Controls.Add(this.btnOpen);
            this.pnHeader.Controls.Add(this.btnFileDialog);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1080, 117);
            this.pnHeader.TabIndex = 12;
            // 
            // FrmAdministrativeAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnFileData);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrativeAddEntry";
            this.Text = "Nova entrada";
            this.pnFileData.ResumeLayout(false);
            this.pnFileData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Projeto_Frente_de_Caixa.View.CustomControls.KFCTextBox txtFilePath;
        private kfcCustomControls.KFCCustomControls.kFCButton btnFileDialog;
        private System.Windows.Forms.Label lblSocialReason;
        private System.Windows.Forms.Panel pnFileData;
        private System.Windows.Forms.Label lblDocumentSerialNumber;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStateRegistration;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblAdress2;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.DataGridView dgvItems;
        private kfcCustomControls.KFCCustomControls.kFCButton btnOpen;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblComplement;
        private kfcCustomControls.KFCCustomControls.kFCButton btnAdd;
        private System.Windows.Forms.Label lblEmissionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitaryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalValue;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label lblFantasyName;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
    }
}