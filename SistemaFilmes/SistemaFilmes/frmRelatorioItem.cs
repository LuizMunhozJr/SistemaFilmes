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
    public partial class frmRelatorioItem : Form
    {
        public frmRelatorioItem()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            itemDAL iDAL = new itemDAL();
            dgvItens.DataSource = iDAL.ListarItens();
            dgvItens.Columns[10].Visible = false;

        }
        private void frmRelatorioItem_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
