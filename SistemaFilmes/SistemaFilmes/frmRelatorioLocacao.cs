using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Models;

namespace SistemaFilmes
{
    public partial class frmRelatorioLocacao : Form
    {
        public frmRelatorioLocacao()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            locacaoDAL lDAL = new locacaoDAL();
            dgvRelLocacoes.DataSource = lDAL.SelecionarLocacoes(); ;

        }

        private void frmRelatorioLocacao_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
