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
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            txtCod.Text = null;
            txtNome.Text = null;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Genero objGen = new Genero();
            objGen.Nome = txtNome.Text;
            generoDAL gDAL = new generoDAL();
            gDAL.InserirGenero(objGen);
            LimparTela();
            MessageBox.Show("Inserido");            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            generoDAL gDAL = new generoDAL();
            Genero objGenero = gDAL.BuscarGenero(Convert.ToInt32(txtCod.Text));

            txtNome.Text = objGenero.Nome;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Genero objGen = new Genero();
            generoDAL gDAL = new generoDAL();
            objGen.Codigo = Convert.ToInt32(txtCod.Text);
            objGen.Nome = txtNome.Text;
            gDAL.AlterarGenero(objGen);
            LimparTela();
            MessageBox.Show("Alterado");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            generoDAL gDAL = new generoDAL();
            gDAL.ExcluirGenero(Convert.ToInt32(txtCod.Text));
            LimparTela();
            MessageBox.Show("Excluido");
        }
    }
}
