namespace SistemaFilmes
{
    partial class frmCadastroItem
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
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.btnInserirIMG = new System.Windows.Forms.Button();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoItem = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnAdicionarGen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVlCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.colunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pbItem);
            this.groupBox1.Controls.Add(this.cbGeneros);
            this.groupBox1.Controls.Add(this.btnInserirIMG);
            this.groupBox1.Controls.Add(this.dtpCompra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbTipoItem);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.btnAdicionarGen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCodBar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.txtDiretor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtVlCusto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 289);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Item";
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Location = new System.Drawing.Point(144, 91);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(147, 21);
            this.cbGeneros.TabIndex = 125;
            // 
            // btnInserirIMG
            // 
            this.btnInserirIMG.Location = new System.Drawing.Point(531, 178);
            this.btnInserirIMG.Name = "btnInserirIMG";
            this.btnInserirIMG.Size = new System.Drawing.Size(75, 23);
            this.btnInserirIMG.TabIndex = 123;
            this.btnInserirIMG.Text = "Inserir";
            this.btnInserirIMG.UseVisualStyleBackColor = true;
            this.btnInserirIMG.Click += new System.EventHandler(this.btnInserirIMG_Click);
            // 
            // dtpCompra
            // 
            this.dtpCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompra.Location = new System.Drawing.Point(144, 188);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(121, 20);
            this.dtpCompra.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Tipo: ";
            // 
            // cbTipoItem
            // 
            this.cbTipoItem.FormattingEnabled = true;
            this.cbTipoItem.Items.AddRange(new object[] {
            "Locado",
            "Livre"});
            this.cbTipoItem.Location = new System.Drawing.Point(144, 236);
            this.cbTipoItem.Name = "cbTipoItem";
            this.cbTipoItem.Size = new System.Drawing.Size(147, 21);
            this.cbTipoItem.TabIndex = 119;
            this.cbTipoItem.Text = "Livre";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(144, 164);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(121, 20);
            this.txtPreco.TabIndex = 118;
            this.txtPreco.Text = " ";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(144, 115);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(83, 20);
            this.txtAno.TabIndex = 117;
            this.txtAno.Text = " ";
            // 
            // btnAdicionarGen
            // 
            this.btnAdicionarGen.Location = new System.Drawing.Point(307, 89);
            this.btnAdicionarGen.Name = "btnAdicionarGen";
            this.btnAdicionarGen.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarGen.TabIndex = 116;
            this.btnAdicionarGen.Text = "Adicionar";
            this.btnAdicionarGen.UseVisualStyleBackColor = true;
            this.btnAdicionarGen.Click += new System.EventHandler(this.btnAdicionarGen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Gênero: ";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(144, 66);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(83, 20);
            this.txtCodBar.TabIndex = 112;
            this.txtCodBar.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Codigo de Barras: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(233, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 110;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(108, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 108;
            this.label14.Text = "Tipo: ";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DVD",
            "BLU RAY"});
            this.cbTipo.Location = new System.Drawing.Point(144, 139);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(147, 21);
            this.cbTipo.TabIndex = 107;
            this.cbTipo.Text = " ";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(144, 261);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(259, 20);
            this.txtDiretor.TabIndex = 99;
            this.txtDiretor.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Diretor: ";
            // 
            // txtVlCusto
            // 
            this.txtVlCusto.Location = new System.Drawing.Point(144, 212);
            this.txtVlCusto.Name = "txtVlCusto";
            this.txtVlCusto.Size = new System.Drawing.Size(121, 20);
            this.txtVlCusto.TabIndex = 97;
            this.txtVlCusto.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Valor de Custo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Data de Lancamento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Preço: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Ano Lancamento: ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(144, 42);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(259, 20);
            this.txtDescricao.TabIndex = 90;
            this.txtDescricao.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Descrição: ";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(144, 19);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(83, 20);
            this.txtCod.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Código: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGeneros);
            this.groupBox2.Location = new System.Drawing.Point(13, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 111);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gêneros: ";
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.AllowUserToAddRows = false;
            this.dgvGeneros.AllowUserToResizeColumns = false;
            this.dgvGeneros.AllowUserToResizeRows = false;
            this.dgvGeneros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaCodigo,
            this.colunaNome});
            this.dgvGeneros.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGeneros.Location = new System.Drawing.Point(142, 19);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.Size = new System.Drawing.Size(393, 82);
            this.dgvGeneros.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDevolucao);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.dtpRetirada);
            this.groupBox3.Controls.Add(this.txtTelCli);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNomeCli);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(13, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 145);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(112, 71);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(147, 20);
            this.dtpDevolucao.TabIndex = 131;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 130;
            this.label16.Text = "Devolução Prevista: ";
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetirada.Location = new System.Drawing.Point(112, 45);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(147, 20);
            this.dtpRetirada.TabIndex = 129;
            // 
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(112, 97);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(147, 20);
            this.txtTelCli.TabIndex = 126;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 125;
            this.label12.Text = "Telefone: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 124;
            this.label13.Text = "Data da Retirada: ";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(112, 19);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(402, 20);
            this.txtNomeCli.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 122;
            this.label15.Text = "Nome: ";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(24, 588);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 47;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(636, 588);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(228, 588);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(432, 588);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // colunaCodigo
            // 
            this.colunaCodigo.HeaderText = "Codigo";
            this.colunaCodigo.Name = "colunaCodigo";
            this.colunaCodigo.ReadOnly = true;
            this.colunaCodigo.Width = 150;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            this.colunaNome.Width = 200;
            // 
            // pbItem
            // 
            this.pbItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItem.Location = new System.Drawing.Point(500, 42);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(130, 130);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItem.TabIndex = 126;
            this.pbItem.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 127;
            this.label11.Text = "Imagem";
            // 
            // frmCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 634);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroItem";
            this.Text = "Cadastro de Itens";
            this.Load += new System.EventHandler(this.frmCadastroItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVlCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnAdicionarGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.TextBox txtTelCli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserirIMG;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label label11;
    }
}