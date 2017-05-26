namespace SistemaFilmes
{
    partial class frmLocacao
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
            this.btnBuscarCliCod = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.dtpAtual = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbItens = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCodLocacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDTentrega = new System.Windows.Forms.TextBox();
            this.itemCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdBarItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliCod);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnBuscarCli);
            this.groupBox1.Controls.Add(this.dtpAtual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // btnBuscarCliCod
            // 
            this.btnBuscarCliCod.Location = new System.Drawing.Point(208, 21);
            this.btnBuscarCliCod.Name = "btnBuscarCliCod";
            this.btnBuscarCliCod.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliCod.TabIndex = 107;
            this.btnBuscarCliCod.Text = "Buscar";
            this.btnBuscarCliCod.UseVisualStyleBackColor = true;
            this.btnBuscarCliCod.Click += new System.EventHandler(this.btnBuscarCliCod_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(62, 23);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(140, 20);
            this.txtCod.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Código: ";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(208, 47);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCli.TabIndex = 104;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // dtpAtual
            // 
            this.dtpAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtual.Location = new System.Drawing.Point(62, 101);
            this.dtpAtual.Name = "dtpAtual";
            this.dtpAtual.Size = new System.Drawing.Size(140, 20);
            this.dtpAtual.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(402, 20);
            this.txtNome.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nome: ";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(62, 49);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(140, 20);
            this.txtCPF.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "CPF: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvItens);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbItens);
            this.groupBox3.Location = new System.Drawing.Point(3, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodigo,
            this.cdBarItem,
            this.Descricao,
            this.Preco});
            this.dgvItens.Location = new System.Drawing.Point(16, 61);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(608, 150);
            this.dgvItens.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(549, 26);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Adicionar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Titulos: ";
            // 
            // cbItens
            // 
            this.cbItens.FormattingEnabled = true;
            this.cbItens.Location = new System.Drawing.Point(63, 28);
            this.cbItens.Name = "cbItens";
            this.cbItens.Size = new System.Drawing.Size(459, 21);
            this.cbItens.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(96, 473);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 31);
            this.btnInserir.TabIndex = 51;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 473);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(223, 473);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(81, 31);
            this.btnAlterar.TabIndex = 52;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(350, 473);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 31);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtCodLocacao
            // 
            this.txtCodLocacao.Location = new System.Drawing.Point(107, 23);
            this.txtCodLocacao.Name = "txtCodLocacao";
            this.txtCodLocacao.Size = new System.Drawing.Size(129, 20);
            this.txtCodLocacao.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Código Locação:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Location = new System.Drawing.Point(107, 67);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(129, 21);
            this.cbFuncionarios.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Funcionario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Total R$:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(539, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(106, 20);
            this.txtTotal.TabIndex = 100;
            this.txtTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Entrega Prevista:";
            // 
            // txtDTentrega
            // 
            this.txtDTentrega.Location = new System.Drawing.Point(539, 64);
            this.txtDTentrega.Name = "txtDTentrega";
            this.txtDTentrega.ReadOnly = true;
            this.txtDTentrega.Size = new System.Drawing.Size(106, 20);
            this.txtDTentrega.TabIndex = 103;
            this.txtDTentrega.Text = "0";
            // 
            // itemCodigo
            // 
            this.itemCodigo.HeaderText = "Código";
            this.itemCodigo.Name = "itemCodigo";
            this.itemCodigo.ReadOnly = true;
            // 
            // cdBarItem
            // 
            this.cdBarItem.HeaderText = "Cód de Barra";
            this.cdBarItem.Name = "cdBarItem";
            this.cdBarItem.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.txtDTentrega);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbFuncionarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodLocacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbItens;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCodLocacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDTentrega;
        private System.Windows.Forms.Button btnBuscarCliCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdBarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}