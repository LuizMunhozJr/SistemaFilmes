namespace SistemaFilmes
{
    partial class frmDevolucao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddItens = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodBarItem = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigoLocacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCdLocacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblRS2 = new System.Windows.Forms.Label();
            this.lblTextoTroco = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.cdLocacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cddbarItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDevolucao);
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Item";
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdLocacao,
            this.cdItem,
            this.cddbarItem,
            this.dsItem,
            this.precoItem,
            this.statusPG,
            this.dtDevolucao});
            this.dgvDevolucao.Location = new System.Drawing.Point(7, 20);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(742, 225);
            this.dgvDevolucao.TabIndex = 0;
            this.dgvDevolucao.Validated += new System.EventHandler(this.dgvDevolucao_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddItens);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodBarItem);
            this.groupBox2.Controls.Add(this.btnBuscarCodigoLocacao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCdLocacao);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket para Devolução Total ou Codigo de Barras";
            // 
            // btnAddItens
            // 
            this.btnAddItens.Location = new System.Drawing.Point(292, 49);
            this.btnAddItens.Name = "btnAddItens";
            this.btnAddItens.Size = new System.Drawing.Size(75, 23);
            this.btnAddItens.TabIndex = 5;
            this.btnAddItens.Text = "Adicionar";
            this.btnAddItens.UseVisualStyleBackColor = true;
            this.btnAddItens.Click += new System.EventHandler(this.btnAddItens_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo de Barras: ";
            // 
            // txtCodBarItem
            // 
            this.txtCodBarItem.Location = new System.Drawing.Point(101, 51);
            this.txtCodBarItem.Name = "txtCodBarItem";
            this.txtCodBarItem.Size = new System.Drawing.Size(185, 20);
            this.txtCodBarItem.TabIndex = 3;
            // 
            // btnBuscarCodigoLocacao
            // 
            this.btnBuscarCodigoLocacao.Location = new System.Drawing.Point(292, 20);
            this.btnBuscarCodigoLocacao.Name = "btnBuscarCodigoLocacao";
            this.btnBuscarCodigoLocacao.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCodigoLocacao.TabIndex = 2;
            this.btnBuscarCodigoLocacao.Text = "Buscar";
            this.btnBuscarCodigoLocacao.UseVisualStyleBackColor = true;
            this.btnBuscarCodigoLocacao.Click += new System.EventHandler(this.btnBuscarCodigoLocacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket: ";
            // 
            // txtCdLocacao
            // 
            this.txtCdLocacao.Location = new System.Drawing.Point(101, 22);
            this.txtCdLocacao.Name = "txtCdLocacao";
            this.txtCdLocacao.Size = new System.Drawing.Size(185, 20);
            this.txtCdLocacao.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL A PAGAR";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.Location = new System.Drawing.Point(12, 372);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(71, 46);
            this.lblRS.TabIndex = 3;
            this.lblRS.Text = "R$";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(210, 372);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(193, 53);
            this.txtValorRecebido.TabIndex = 4;
            this.txtValorRecebido.Text = "0";
            this.txtValorRecebido.EnabledChanged += new System.EventHandler(this.txtValorRecebido_EnabledChanged);
            this.txtValorRecebido.Validated += new System.EventHandler(this.txtValorRecebido_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALOR RECEBIDO";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(651, 372);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(116, 53);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblRS2
            // 
            this.lblRS2.AutoSize = true;
            this.lblRS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS2.Location = new System.Drawing.Point(453, 372);
            this.lblRS2.Name = "lblRS2";
            this.lblRS2.Size = new System.Drawing.Size(71, 46);
            this.lblRS2.TabIndex = 8;
            this.lblRS2.Text = "R$";
            // 
            // lblTextoTroco
            // 
            this.lblTextoTroco.AutoSize = true;
            this.lblTextoTroco.Location = new System.Drawing.Point(505, 430);
            this.lblTextoTroco.Name = "lblTextoTroco";
            this.lblTextoTroco.Size = new System.Drawing.Size(45, 13);
            this.lblTextoTroco.TabIndex = 7;
            this.lblTextoTroco.Text = "TROCO";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(75, 372);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(97, 46);
            this.lblTotalAPagar.TabIndex = 9;
            this.lblTotalAPagar.Text = "0.00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(514, 372);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(97, 46);
            this.lblTroco.TabIndex = 10;
            this.lblTroco.Text = "0.00";
            // 
            // cdLocacao
            // 
            this.cdLocacao.HeaderText = "cdLocacao";
            this.cdLocacao.Name = "cdLocacao";
            // 
            // cdItem
            // 
            this.cdItem.HeaderText = "cdItem";
            this.cdItem.Name = "cdItem";
            // 
            // cddbarItem
            // 
            this.cddbarItem.HeaderText = "cddbarItem";
            this.cddbarItem.Name = "cddbarItem";
            // 
            // dsItem
            // 
            this.dsItem.HeaderText = "dsItem";
            this.dsItem.Name = "dsItem";
            // 
            // precoItem
            // 
            this.precoItem.HeaderText = "precoItem";
            this.precoItem.Name = "precoItem";
            // 
            // statusPG
            // 
            this.statusPG.HeaderText = "statusPG";
            this.statusPG.Name = "statusPG";
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.HeaderText = "dtDevolucao";
            this.dtDevolucao.Name = "dtDevolucao";
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 466);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.lblRS2);
            this.Controls.Add(this.lblTextoTroco);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorRecebido);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDevolucao";
            this.Text = "Devolução: ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodBarItem;
        private System.Windows.Forms.Button btnBuscarCodigoLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCdLocacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblRS2;
        private System.Windows.Forms.Label lblTextoTroco;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cddbarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtDevolucao;
    }
}