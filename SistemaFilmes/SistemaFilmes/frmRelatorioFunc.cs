using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace SistemaFilmes
{
    public partial class frmRelatorioFunc : Form
    {
        public frmRelatorioFunc()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            funcionarioDAL fDAL = new funcionarioDAL();
            dgvFuncionarios.DataSource = fDAL.ListarFuncionarios();

        }
        private void frmRelatorioFunc_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void frmRelatorioFunc_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
