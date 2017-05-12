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

        private void frmLocacao_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LocacaoDAL lDAL = new LocacaoDAL();
           // ClienteDAL cDAL = new ClienteDAL();
            Locacao l = new Locacao();
            Cliente c = new Cliente();
            l = lDAL.SelecionarLocacaoPeloCodigo(Convert.ToInt32(txtCodFunc.Text));
            /********************
             *Busca do Cliente  *
             *                  *
             *                  *
             *                  *
             ********************/
            txtCodLocacao.Text = l.cdLocacao.ToString();
            txtCodFunc.Text = l.cdFunc.ToString();
            txtCPF.Text = c.CPF.ToString();
            txtNomeCli.Text = c.Nome.ToString();
            dtpAtual.Text = l.dtRetirada.ToString();






        }
    }
}
