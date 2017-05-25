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
    public partial class frmRelatorioArt : Form
    {
        public frmRelatorioArt()
        {
            InitializeComponent();
        }
        private void RefreshGrid()
        {
            artistaDAL aDAL = new artistaDAL();
            dgvArtistas.DataSource = aDAL.ListarArtistas();
            dgvArtistas.Columns[4].Visible = false;

        }
        private void frmRelatorioArt_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
