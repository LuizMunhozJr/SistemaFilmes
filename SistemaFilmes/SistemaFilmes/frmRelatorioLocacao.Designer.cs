namespace SistemaFilmes
{
    partial class frmRelatorioLocacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRelLocacoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelLocacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Relatório de Locações";
            // 
            // dgvRelLocacoes
            // 
            this.dgvRelLocacoes.AllowUserToAddRows = false;
            this.dgvRelLocacoes.AllowUserToResizeRows = false;
            this.dgvRelLocacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelLocacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelLocacoes.Location = new System.Drawing.Point(14, 49);
            this.dgvRelLocacoes.Name = "dgvRelLocacoes";
            this.dgvRelLocacoes.ReadOnly = true;
            this.dgvRelLocacoes.Size = new System.Drawing.Size(1237, 428);
            this.dgvRelLocacoes.TabIndex = 57;
            // 
            // frmRelatorioLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRelLocacoes);
            this.Name = "frmRelatorioLocacao";
            this.Text = "frmRelatorioLocacao";
            this.Load += new System.EventHandler(this.frmRelatorioLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelLocacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRelLocacoes;
    }
}