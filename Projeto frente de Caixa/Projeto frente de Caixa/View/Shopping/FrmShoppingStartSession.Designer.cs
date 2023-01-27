namespace Projeto_frente_de_Caixa.View.Shopping {
    partial class FrmShoppingStartSession {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnNo = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.btnCancel = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnCPF = new System.Windows.Forms.Panel();
            this.pnStart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new kfcCustomControls.KFCCustomControls.kFCButton();
            this.pnCPF.SuspendLayout();
            this.pnStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 173);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deseja incluir o CPF \r\nna Nota Fiscal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.BackColor = System.Drawing.Color.ForestGreen;
            this.btnYes.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnYes.BorderColor = System.Drawing.Color.Black;
            this.btnYes.BorderRadius = 40;
            this.btnYes.BorderSize = 0;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.LightGray;
            this.btnYes.Location = new System.Drawing.Point(0, 210);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(720, 90);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "SIM";
            this.btnYes.TextColor = System.Drawing.Color.LightGray;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNo.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnNo.BorderColor = System.Drawing.Color.Black;
            this.btnNo.BorderRadius = 40;
            this.btnNo.BorderSize = 0;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.LightGray;
            this.btnNo.Location = new System.Drawing.Point(0, 320);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(720, 90);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "CONTINUAR SEM CPF";
            this.btnNo.TextColor = System.Drawing.Color.LightGray;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderRadius = 40;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(0, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(720, 90);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.TextColor = System.Drawing.Color.LightGray;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnCPF
            // 
            this.pnCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCPF.Controls.Add(this.btnCancel);
            this.pnCPF.Controls.Add(this.btnNo);
            this.pnCPF.Controls.Add(this.btnYes);
            this.pnCPF.Controls.Add(this.label1);
            this.pnCPF.Location = new System.Drawing.Point(180, 70);
            this.pnCPF.Name = "pnCPF";
            this.pnCPF.Size = new System.Drawing.Size(720, 524);
            this.pnCPF.TabIndex = 6;
            this.pnCPF.Visible = false;
            // 
            // pnStart
            // 
            this.pnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnStart.Controls.Add(this.label2);
            this.pnStart.Controls.Add(this.btnStart);
            this.pnStart.Location = new System.Drawing.Point(180, 46);
            this.pnStart.Name = "pnStart";
            this.pnStart.Size = new System.Drawing.Size(720, 617);
            this.pnStart.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 108F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(720, 317);
            this.label2.TabIndex = 9;
            this.label2.Text = "CAIXA\r\nLIVRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.BorderRadius = 60;
            this.btnStart.BorderSize = 0;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LightGray;
            this.btnStart.Location = new System.Drawing.Point(0, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(720, 200);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "INICIAR SESSÃO";
            this.btnStart.TextColor = System.Drawing.Color.LightGray;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FrmShoppingStartSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnStart);
            this.Controls.Add(this.pnCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShoppingStartSession";
            this.Text = "FrmShoppingStartSession";
            this.pnCPF.ResumeLayout(false);
            this.pnStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private kfcCustomControls.KFCCustomControls.kFCButton btnYes;
        private kfcCustomControls.KFCCustomControls.kFCButton btnNo;
        private kfcCustomControls.KFCCustomControls.kFCButton btnCancel;
        private System.Windows.Forms.Panel pnCPF;
        private System.Windows.Forms.Panel pnStart;
        private kfcCustomControls.KFCCustomControls.kFCButton btnStart;
        private System.Windows.Forms.Label label2;
    }
}