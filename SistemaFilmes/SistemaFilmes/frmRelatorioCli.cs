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
    public partial class frmRelatorioCli : Form
    {
        public frmRelatorioCli()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            clienteDAL cDAL = new clienteDAL();
            dgvClientes.DataSource = cDAL.ListarClientes();
        }

        private void frmRelatorioCli_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void frmRelatorioCli_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshGrid();
        }
    }
}
