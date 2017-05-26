using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace SistemaFilmes
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigoLocacao_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            foreach (DataGridViewColumn coluna in dgvDevolucao.Columns)
            {
                coluna.Visible = false;
            }
            
            dgvDevolucao.DataSource = lDAL.SelecionarTodosItensNumeroPedido(Convert.ToInt32(txtCdLocacao.Text));
            decimal acrescimo, Soma = acrescimo = 0;
            if (dgvDevolucao.RowCount != 0)
            {
                for (int i = 0; i < dgvDevolucao.RowCount; i++)
                {
                    DateTime dtdevolucao;
                    dtdevolucao = Convert.ToDateTime(dgvDevolucao.Rows[i].Cells[13].Value);
                    acrescimo = (decimal)(DateTime.Now.Subtract(dtdevolucao).Days);
                    Soma += Convert.ToDecimal(dgvDevolucao.Rows[i].Cells[11].Value) + acrescimo;
                    lblTotalAPagar.Text = Soma.ToString();
                }
            }

        }

        private void txtValorRecebido_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void txtValorRecebido_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void txtValorRecebido_Validated(object sender, EventArgs e)
        {
            if (txtValorRecebido.Text != string.Empty)
            {
                lblTroco.Text = ((Convert.ToDecimal(txtValorRecebido.Text)) - (Convert.ToDecimal(lblTotalAPagar.Text))).ToString("N2");
            }
        }

        private void dgvDevolucao_Validated(object sender, EventArgs e)
        {
            

        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            
            dgvDevolucao.Rows.Add(lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).cdLocacao, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).cdItem, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).cddbarItem, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).dsItem, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).precoItem, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).statusPG, lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text).dtDevolucao);
            decimal acrescimo, Soma = acrescimo = 0;
            if (dgvDevolucao.RowCount != 0)
            {
                for (int i = 0; i < dgvDevolucao.RowCount-1; i++)
                {
                    DateTime dtdevolucao;
                    dtdevolucao = Convert.ToDateTime(dgvDevolucao.Rows[i].Cells[6].Value);
                    acrescimo = (decimal)(DateTime.Now.Subtract(dtdevolucao).Days);
                    Soma += Convert.ToDecimal(dgvDevolucao.Rows[i].Cells[4].Value) + acrescimo;
                    lblTotalAPagar.Text = Soma.ToString();
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            if((Convert.ToDecimal(txtValorRecebido.Text))>=(Convert.ToDecimal(lblTotalAPagar.Text)))
            {
                for (int i = 0; i < dgvDevolucao.RowCount; i++)
                {
                    lDAL.ConfirmaPagamento(Convert.ToInt32(dgvDevolucao.Rows[i].Cells[1].Value), Convert.ToInt32(dgvDevolucao.Rows[i].Cells[0].Value));
                }
                MessageBox.Show("PAGAMENTO EFETUADO COM SUCESSO!!!");
            }
            else
            {
                MessageBox.Show("Valor Insuficiente!");
            }
        }
    }
}
