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
            dgvDevolucao.DataSource = lDAL.SelecionarTodosItensNumeroPedido(Convert.ToInt32(txtCdLocacao.Text));
            
            
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
            decimal acrescimo, Soma = acrescimo = 0;
            if (dgvDevolucao.RowCount != 0)
            {
                for (int i = 0; i <= dgvDevolucao.RowCount; i++)
                {
                    acrescimo = Convert.ToInt32(DateTime.Now.Subtract(Convert.ToDateTime(dgvDevolucao.Rows[i].Cells[5])));
                    Soma += Convert.ToDecimal(dgvDevolucao.Rows[i].Cells[3].Value) + acrescimo;
                    lblTotalAPagar.Text = Soma.ToString();
                }
            }

        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            dgvDevolucao.Rows.Add(lDAL.SelecionarItemDevolucaoCodBar(txtCodBarItem.Text));
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            locacaoDAL lDAL = new locacaoDAL();
            if((Convert.ToDecimal(txtValorRecebido.Text))>=(Convert.ToDecimal(lblTotalAPagar.Text)))
            {
                for (int i = 0; i <= dgvDevolucao.RowCount; i++)
                {
                    lDAL.ConfirmaPagamento(Convert.ToInt32(dgvDevolucao.Rows[i].Cells[0].Value), Convert.ToInt32(dgvDevolucao.Rows[i].Cells[6].Value));
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
