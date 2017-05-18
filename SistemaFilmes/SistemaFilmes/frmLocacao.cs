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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void CBcarregarItens()
        {
            itemDAL iDAL = new itemDAL();
            cbItens.DataSource = iDAL.ListarItens();
            cbItens.DisplayMember = "dsItem";
            cbItens.ValueMember = "cdItem";
        }
        private void frmLocacao_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {           

        }
    }
}
