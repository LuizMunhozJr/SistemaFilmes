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
        private void LimparTela()
        {
            foreach (var gpBox in this.Controls.OfType<GroupBox>())
            {
                foreach (var txtBox in gpBox.Controls.OfType<TextBox>())
                {
                    txtBox.Text =string.Empty;
                }
            }

            txtCodLocacao.Text = null;
            cbStatusPagamento.Text = null;
            cbFuncionarios.Text = null;
            dgvItens.Rows.Clear();
            
        }

        private void CBcarregarItens()
        {
            itemDAL iDAL = new itemDAL();
            cbItens.DataSource = iDAL.ListarItens();
            cbItens.DisplayMember = "Descricao";
            cbItens.ValueMember ="Codigo";
        }

        private void CBcarregarFuncionarios()
        {
            funcionarioDAL fDAL = new funcionarioDAL();
            cbFuncionarios.DataSource = fDAL.ListarFuncionarios();
            cbFuncionarios.DisplayMember = "Nome";
            cbFuncionarios.ValueMember = "Codigo"; 
        }
        private void frmLocacao_Load(object sender, EventArgs e)
        {
            CBcarregarItens();
            CBcarregarFuncionarios();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {           

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            locacaoDAL lDAL = new locacaoDAL();

           loc = lDAL.SelecionarLocacaoPeloCodigo(Convert.ToInt32(txtCodLocacao.Text));
            txtCodLocacao.Text = loc.cdLocacao.ToString();
            cbStatusPagamento.SelectedIndex = Convert.ToInt32(loc.situItem);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            itemDAL iDAL = new itemDAL();
            Item objItem = new Item();

            objItem = iDAL.BuscarItemCodigo(Convert.ToInt32(cbItens.SelectedValue));

            dgvItens.Rows.Add(objItem.Codigo, objItem.CodigoDeBarras, objItem.Descricao, objItem.Preco);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}
