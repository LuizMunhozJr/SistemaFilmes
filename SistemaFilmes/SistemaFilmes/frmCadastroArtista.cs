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
using System.IO;

namespace SistemaFilmes
{
    public partial class frmCadastroArtista : Form
    {
        public frmCadastroArtista()
        {
            InitializeComponent();
        }

        private Artista SelectArtista()
        {
            var ms = new MemoryStream();
            Artista Art = new Artista();
            Art.Nome = txtNomeArt.Text;
            Art.DtNascto = Convert.ToDateTime(dtpNactoArtista.Text);
            Art.Naturalidade = txtPaisArt.Text;
            pbArtista.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Art.Imagem = ms.ToArray();

            return Art;
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbArtista.ImageLocation = file.FileName;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            artistaDAL aDAL = new artistaDAL();
            Artista Art = new Artista();

            Art =  aDAL.BuscarArtista(Convert.ToInt32(txtCodArt.Text));

            if (Art != null)
            {
                txtCodArt.Text = Art.Codigo.ToString();
                txtNomeArt.Text = Art.Nome.ToString();
                dtpNactoArtista.Text = Art.DtNascto.ToString();
                txtPaisArt.Text = Art.Naturalidade.ToString();
                pbArtista.Image = Image.FromStream(new MemoryStream(Art.Imagem));
                pbArtista.Refresh();
               // dgvItensArtista.DataSource = aDAL.SelecionarItensDoArtista(Art.Codigo);
               if(aDAL.ListarParticipacoes(Convert.ToInt32(txtCodArt.Text))!=null)
                dgvItensArtista.DataSource = aDAL.ListarParticipacoes(Convert.ToInt32(txtCodArt.Text));
            }
            else
                MessageBox.Show("Artista Não Encontrado");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            artistaDAL aDAL = new artistaDAL();

            if (pbArtista.Image != null)
            {
                Artista objArtista = SelectArtista();
                aDAL.InserirArtista(objArtista);
                MessageBox.Show("Inserido com Sucesso!");
                LimpaTelaArtista();
            }
            else
                MessageBox.Show("Imagem Requerida");


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var ms = new MemoryStream();
            artistaDAL aDAL = new artistaDAL();
            Artista Art = new Artista();
            Art.Nome = txtNomeArt.Text;
            Art.DtNascto = Convert.ToDateTime(dtpNactoArtista.Text);
            Art.Naturalidade = txtPaisArt.Text;
            pbArtista.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Art.Imagem = ms.ToArray();
            aDAL.AlteraArtista(Art);
            MessageBox.Show("Alterado com Sucesso!");
            LimpaTelaArtista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            artistaDAL aDAL = new artistaDAL();
            aDAL.ExcluirArtista(Convert.ToInt32(txtCodArt.Text));
        }
        public void LimpaTelaArtista()
        {
            txtCodArt.Text = string.Empty;
            txtNomeArt.Text = string.Empty;
            txtPaisArt.Text = string.Empty;
            dtpNactoArtista.Text = string.Empty;
            pbArtista.Image = null;
            dgvItensArtista = null;
        }

        private void frmCadastroArtista_Load(object sender, EventArgs e)
        {
            artistaDAL aDAL = new artistaDAL();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTelaArtista();
        }
    }


}
