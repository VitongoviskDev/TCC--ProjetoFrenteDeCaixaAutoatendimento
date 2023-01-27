namespace Projeto_frente_de_Caixa.View.Shopping
{
    partial class FrmShoppingSaleDocument
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDocument = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPaymentTypeTotalValue = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitaryValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDocumentNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStateRegistration = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblFantasyName = new System.Windows.Forms.Label();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnDocument.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.pnDocument);
            this.panel1.Location = new System.Drawing.Point(290, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 530);
            this.panel1.TabIndex = 1;
            // 
            // pnDocument
            // 
            this.pnDocument.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnDocument.Controls.Add(this.panel3);
            this.pnDocument.Controls.Add(this.dgvItems);
            this.pnDocument.Controls.Add(this.panel2);
            this.pnDocument.Location = new System.Drawing.Point(20, 0);
            this.pnDocument.Name = "pnDocument";
            this.pnDocument.Size = new System.Drawing.Size(462, 530);
            this.pnDocument.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblTotalValue);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblPaymentTypeTotalValue);
            this.panel3.Controls.Add(this.lblPaymentType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 125);
            this.panel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
    "";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(145, 21);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(317, 48);
            this.lblTotalValue.TabIndex = 23;
            this.lblTotalValue.Text = "150,00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 48);
            this.label5.TabIndex = 23;
            this.label5.Text = "TOTAL R$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Frente de Caixa Autoatendimento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentTypeTotalValue
            // 
            this.lblPaymentTypeTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentTypeTotalValue.AutoSize = true;
            this.lblPaymentTypeTotalValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTypeTotalValue.Location = new System.Drawing.Point(400, 69);
            this.lblPaymentTypeTotalValue.Name = "lblPaymentTypeTotalValue";
            this.lblPaymentTypeTotalValue.Size = new System.Drawing.Size(59, 21);
            this.lblPaymentTypeTotalValue.TabIndex = 19;
            this.lblPaymentTypeTotalValue.Text = "150,00";
            this.lblPaymentTypeTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(3, 69);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(62, 21);
            this.lblPaymentType.TabIndex = 19;
            this.lblPaymentType.Text = "débito";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItems
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvItems.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIndex,
            this.clmCode,
            this.clmAmount,
            this.clmUnity,
            this.clmUnitaryValue,
            this.clmSt,
            this.clmTotalValue});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvItems.GridColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvItems.Location = new System.Drawing.Point(0, 264);
            this.dgvItems.Name = "dgvItems";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.Size = new System.Drawing.Size(462, 141);
            this.dgvItems.TabIndex = 14;
            // 
            // clmIndex
            // 
            this.clmIndex.HeaderText = "Item";
            this.clmIndex.Name = "clmIndex";
            this.clmIndex.Width = 40;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "código";
            this.clmCode.Name = "clmCode";
            this.clmCode.Width = 60;
            // 
            // clmAmount
            // 
            this.clmAmount.HeaderText = "qtd.";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.Width = 40;
            // 
            // clmUnity
            // 
            this.clmUnity.HeaderText = "un.";
            this.clmUnity.Name = "clmUnity";
            this.clmUnity.Width = 50;
            // 
            // clmUnitaryValue
            // 
            this.clmUnitaryValue.HeaderText = "vl. unit R$";
            this.clmUnitaryValue.Name = "clmUnitaryValue";
            this.clmUnitaryValue.Width = 120;
            // 
            // clmSt
            // 
            this.clmSt.HeaderText = "st";
            this.clmSt.Name = "clmSt";
            this.clmSt.Width = 30;
            // 
            // clmTotalValue
            // 
            this.clmTotalValue.HeaderText = "vl. item R$";
            this.clmTotalValue.Name = "clmTotalValue";
            this.clmTotalValue.Width = 120;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.lblCpf);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblDocumentNumber);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblStateRegistration);
            this.panel2.Controls.Add(this.lblCnpj);
            this.panel2.Controls.Add(this.lblFantasyName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 264);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 48);
            this.label4.TabIndex = 23;
            this.label4.Text = "CUPOM FISCAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
    "";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDocumentNumber.AutoSize = true;
            this.lblDocumentNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentNumber.Location = new System.Drawing.Point(391, 162);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(72, 21);
            this.lblDocumentNumber.TabIndex = 16;
            this.lblDocumentNumber.Text = "13:43:23";
            this.lblDocumentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(0, 162);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 21);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "13/23/2013";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "IM: Isento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateRegistration
            // 
            this.lblStateRegistration.AutoSize = true;
            this.lblStateRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateRegistration.Location = new System.Drawing.Point(24, 94);
            this.lblStateRegistration.Name = "lblStateRegistration";
            this.lblStateRegistration.Size = new System.Drawing.Size(32, 21);
            this.lblStateRegistration.TabIndex = 21;
            this.lblStateRegistration.Text = "IE: ";
            this.lblStateRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(24, 68);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(60, 21);
            this.lblCnpj.TabIndex = 22;
            this.lblCnpj.Text = "CNPJ: ";
            this.lblCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFantasyName
            // 
            this.lblFantasyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFantasyName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasyName.Location = new System.Drawing.Point(0, 0);
            this.lblFantasyName.Name = "lblFantasyName";
            this.lblFantasyName.Size = new System.Drawing.Size(462, 63);
            this.lblFantasyName.TabIndex = 14;
            this.lblFantasyName.Text = "Nome da Empresa";
            this.lblFantasyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmTimer
            // 
            this.tmTimer.Enabled = true;
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagamento concluído com sucesso!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(1, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1080, 94);
            this.label7.TabIndex = 3;
            this.label7.Text = "Obrigado por comprar conosco ;)\r\nVolte sempre!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(3, 188);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(142, 21);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF consumidor: ";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCpf.UseWaitCursor = true;
            this.lblCpf.Visible = false;
            // 
            // FrmShoppingSaleDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingSaleDocument";
            this.Text = "FrmShoppingSaleDocument";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShoppingSaleDocument_Load);
            this.panel1.ResumeLayout(false);
            this.pnDocument.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDocument;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPaymentTypeTotalValue;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitaryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDocumentNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStateRegistration;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblFantasyName;
        private System.Windows.Forms.Timer tmTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCpf;
    }
}