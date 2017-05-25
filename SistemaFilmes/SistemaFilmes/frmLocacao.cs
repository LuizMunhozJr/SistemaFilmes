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
using System.Data.SqlClient;

namespace SistemaFilmes
{
    public partial class frmLocacao : Form
    {
        clienteDAL cDAL = new clienteDAL();
        Cliente Cli = new Cliente();
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
                    txtBox.Text = string.Empty;
                }
            }

            txtCodLocacao.Text = null;
            cbFuncionarios.Text = null;
            dgvItens.Rows.Clear();

        }

        private void CBcarregarItens()
        {
            itemDAL iDAL = new itemDAL();
            cbItens.DataSource = iDAL.ListarItens();
            cbItens.DisplayMember = "Descricao";
            cbItens.ValueMember = "Codigo";
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
            dtpAtual.Text = DateTime.Now.ToString(); ;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            ItemLocacao Iloc = new ItemLocacao();
            locacaoDAL lDAL = new locacaoDAL();
            loc.cdCli = Cli.Codigo;
            loc.cdFunc = cbFuncionarios.SelectedIndex;
            loc.dtRetirada = Convert.ToDateTime(dtpAtual.Text);
            lDAL.InserirLocacao(loc);
            Iloc.cdLocacao = lDAL.BuscarCodUltimaLocacao();
            for (int i=0; i <= dgvItens.TabIndex; i++)
            {
                Iloc.cdItem = (int)dgvItens.Rows[i].Cells[0].Value;
                Iloc.dtDevolucao = Convert.ToDateTime(dtpAtual.Text).AddDays(5);
                Iloc.statusPG = "Em Aberto";
                lDAL.InserirItensLocacao(Iloc);
            }
            MessageBox.Show("Inserido com Sucesso!!!");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            funcionarioDAL fDAL = new funcionarioDAL();
            locacaoDAL lDAL = new locacaoDAL();
            clienteDAL cDAL = new clienteDAL();
            Cliente Cli = new Cliente();

            loc = lDAL.SelecionarLocacaoPeloCodigo(Convert.ToInt32(txtCodLocacao.Text));
            cbFuncionarios.SelectedIndex = loc.cdFunc;
            txtCPF.Text = (Cli=cDAL.BuscarCliente(loc.cdCli)).CPF;
            txtNome.Text = Cli.Nome;
            dtpAtual.Text = loc.dtRetirada.ToString();
            dgvItens.DataSource = lDAL.SelecionarTodosItensNumeroPedido(loc.cdLocacao);
            txtCodLocacao.Text = loc.cdLocacao.ToString();
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

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {

            Cli = cDAL.BuscarClienteCPF(txtCPF.Text);
            txtCPF.Text = Cli.CPF.ToString();
            txtNome.Text = Cli.Nome.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            ItemLocacao Iloc = new ItemLocacao();
            locacaoDAL lDAL = new locacaoDAL();
            loc.cdCli = Cli.Codigo;
            loc.cdFunc = cbFuncionarios.SelectedIndex;
            loc.dtRetirada = Convert.ToDateTime(dtpAtual.Text);
            lDAL.AlteraLocacao(loc);
            Iloc.cdLocacao = loc.cdLocacao;
            for (int i = 0; i <= dgvItens.TabIndex; i++)
            {
                Iloc.cdItem = (int)dgvItens.Rows[i].Cells[0].Value;
                Iloc.dtDevolucao = Convert.ToDateTime(dtpAtual.Text).AddDays(5);
                Iloc.statusPG = "Em Aberto";
                lDAL.AlteraItensLocacao(Iloc);
            }
            MessageBox.Show("Alterado com Sucesso!!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            lDAL.ExcluirLocacao(Convert.ToInt32(txtCodLocacao.Text));
            lDAL.ExcluirItensLocacao(Convert.ToInt32(txtCodLocacao.Text));
            MessageBox.Show("Excluido com Sucesso!!!");

        }
    }
}
