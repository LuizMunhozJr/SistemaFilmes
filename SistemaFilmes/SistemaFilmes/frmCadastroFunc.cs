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
    public partial class frmCadastroFunc : Form
    {
        public frmCadastroFunc()
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

        //Retorna um objeto do tipo Funcionario Apartir dos campos do Form
        public Funcionario SelecFunc()
        {
            Funcionario objfunc = new Funcionario();
            objfunc.Codigo = Convert.ToInt32(txtCodFunc.Text);
            objfunc.CEL = txtCel.Text;
            objfunc.CEP = txtCEP.Text;
            objfunc.Cidade = txtCidade.Text;
            objfunc.CPF = txtCPF.Text;
            objfunc.DtNascto = dtpDtNascimento.Value;
            objfunc.Email = txtEmail.Text;
            objfunc.Endereco = txtEnd.Text;
            objfunc.EstadoCivil = cbEC.Text;
            objfunc.Nome = txtNome.Text;
            objfunc.RG = txtRG.Text;
            objfunc.Sexo = cbSexo.Text;
            objfunc.Status = cbStatus.Checked;
            objfunc.TEL = txtTel.Text;
            objfunc.UF = cbUF.Text;
            

            return objfunc;
        }       

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Funcionario objfunc = SelecFunc();         
            funcionarioDAL FuncDAL = new funcionarioDAL();

            FuncDAL.InserirFuncionario(objfunc);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            funcionarioDAL funcDAL = new funcionarioDAL();
            Funcionario objfunc = funcDAL.BuscarFuncionario(Convert.ToInt32(txtCodFunc.Text));

            txtCel.Text = objfunc.CEL;
            txtCEP.Text = objfunc.CEP;
            txtCidade.Text = objfunc.Cidade;
            txtCPF.Text = objfunc.CPF;
            txtEmail.Text = objfunc.Email;
            txtEnd.Text = objfunc.Endereco;
            txtNome.Text = objfunc.Nome;
            txtRG.Text = objfunc.RG;
            txtTel.Text = objfunc.TEL;
            cbEC.Text = objfunc.EstadoCivil;
            cbSexo.Text = objfunc.Sexo;
            cbStatus.Checked =Convert.ToBoolean(objfunc.Status);
            cbUF.Text = objfunc.UF;
            dtpDtNascimento.Value = objfunc.DtNascto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario objfunc = SelecFunc();
            funcionarioDAL funcDAL = new funcionarioDAL();
            funcDAL.AlteraFuncionario(objfunc);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            funcionarioDAL funcDAL = new funcionarioDAL();
            funcDAL.ExcluirFuncionario(Convert.ToInt32(txtCodFunc.Text));
            LimparTela();
        }
    }
}
