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
    public partial class frmCadastroCli : Form
    {
        public frmCadastroCli()
        {
            InitializeComponent();
        }

        public void LimparTela()
        {
            foreach (var groups in this.Controls.OfType<GroupBox>())
            {
                foreach (var txt in groups.Controls.OfType<TextBox>())
                    txt.Text = null;

                foreach (var cb in groups.Controls.OfType<ComboBox>())
                    cb.Text = null;
            }

            dtpDtNascimento.Value = DateTime.Today;
            cbStatus.Checked = false;
        }

        //Retorna um objeto do tipo Cliente Apartir dos campos do Form
        public Cliente SelecCli()
        {
            Cliente objCli = new Cliente();

            if (txtCod.Text != string.Empty)
                objCli.Codigo = Convert.ToInt32(txtCod.Text);
                objCli.CEL = txtCel.Text;
                objCli.CEP = txtCEP.Text;
                objCli.Cidade = txtCidade.Text;
                objCli.CPF = txtCPF.Text;
                objCli.DtNascto = dtpDtNascimento.Value;
                objCli.Email = txtEmail.Text;
                objCli.Endereco = txtEnd.Text;
                objCli.EstadoCivil = cbEC.Text;
                objCli.Nome = txtNome.Text;
                objCli.RG = txtRG.Text;
                objCli.Sexo = cbSexo.Text;
                objCli.Status = cbStatus.Checked;
                objCli.TEL = txtTel.Text;
                objCli.UF = cbUF.Text;

            return objCli;
        }
               
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente objCli = SelecCli();
            clienteDAL cliDAL = new clienteDAL();

            cliDAL.InserirCliente(objCli);
            LimparTela();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente objCli = SelecCli();
            clienteDAL cliDAL = new clienteDAL();
            cliDAL.AlterarCliente(objCli);
            MessageBox.Show("Alterado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clienteDAL cliDAL = new clienteDAL();
            Cliente objCli = cliDAL.BuscarCliente(Convert.ToInt32(txtCod.Text));

            //LimparTela();
            if (objCli == null)
            {
                MessageBox.Show("Funcionário não encontrado !");
            }
            else
            {
                txtCel.Text = objCli.CEL;
                txtCEP.Text = objCli.CEP;
                txtCidade.Text = objCli.Cidade;
                txtCPF.Text = objCli.CPF;
                txtEmail.Text = objCli.Email;
                txtEnd.Text = objCli.Endereco;
                txtNome.Text = objCli.Nome;
                txtRG.Text = objCli.RG;
                txtTel.Text = objCli.TEL;
                cbEC.Text = objCli.EstadoCivil;
                cbSexo.Text = objCli.Sexo;
                cbStatus.Checked = Convert.ToBoolean(objCli.Status);
                cbUF.Text = objCli.UF;
                dtpDtNascimento.Value = objCli.DtNascto;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            clienteDAL cliDAL = new clienteDAL();
            cliDAL.ExcluirCliente(Convert.ToInt32(txtCod.Text));
            LimparTela();
            MessageBox.Show("Exluido");
        }
    }
}
