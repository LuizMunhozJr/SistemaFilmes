namespace SistemaFilmes
{
    partial class frmRelatorioArt
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
            this.dgvArtistas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtistas
            // 
            this.dgvArtistas.AllowUserToAddRows = false;
            this.dgvArtistas.AllowUserToResizeRows = false;
            this.dgvArtistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArtistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtistas.Location = new System.Drawing.Point(12, 59);
            this.dgvArtistas.Name = "dgvArtistas";
            this.dgvArtistas.ReadOnly = true;
            this.dgvArtistas.Size = new System.Drawing.Size(1213, 519);
            this.dgvArtistas.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Relatório de Artistas";
            // 
            // frmRelatorioArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArtistas);
            this.Name = "frmRelatorioArt";
            this.Text = "frmRelatorioArt";
            this.Load += new System.EventHandler(this.frmRelatorioArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtistas;
        private System.Windows.Forms.Label label1;
    }
}