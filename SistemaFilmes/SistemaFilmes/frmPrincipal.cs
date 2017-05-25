using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaFilmes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFunc objtela = new frmCadastroFunc();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroItem objtela = new frmCadastroItem();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCli objtela = new frmCadastroCli();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroArtista objtela = new frmCadastroArtista();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero objtela = new frmGenero();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void lOCAÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocacao objtela = new frmLocacao();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucao objtela = new frmDevolucao();
            objtela.MdiParent = this;
            objtela.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioCli objTela = new frmRelatorioCli();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void artistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioFunc objTela = new frmRelatorioFunc();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void artistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioArt objTela = new frmRelatorioArt();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void itensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatorioItem objTela = new frmRelatorioItem();
            objTela.MdiParent = this;
            objTela.Show();
        }

        private void locaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioLocacao objTela = new frmRelatorioLocacao();
            objTela.MdiParent = this;
            objTela.Show();
        }
    }
}
