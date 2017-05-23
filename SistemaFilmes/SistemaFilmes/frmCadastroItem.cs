﻿using System;
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
    public partial class frmCadastroItem : Form
    {
        public frmCadastroItem()
        {
            InitializeComponent();
        }

        private void limparTela()
        {
            foreach (var GB in this.Controls.OfType<GroupBox>())
            {
                foreach (var txt in GB.Controls.OfType<TextBox>())                
                    txt.Text = null;
                

                foreach (var data in GB.Controls.OfType<DateTimePicker>())                
                    data.Value = DateTime.Now;

                foreach (var combobox in GB.Controls.OfType<ComboBox>())
                    combobox.Text = null;

            }
            pbItem.Image = null;
            pbItem.Refresh();
            dgvGeneros.Rows.Clear();

        }

        private Item SelectItem()
        {
            Item objItem = new Item();
            if (txtCod.Text!=string.Empty)
            objItem.Codigo =Convert.ToInt32(txtCod.Text);
            objItem.Descricao = txtDescricao.Text;
            objItem.CodigoDeBarras = txtCodBar.Text;
            objItem.Ano = Convert.ToInt32(txtAno.Text);
            objItem.Tipo = cbTipo.Text;
            objItem.Preco = Convert.ToDecimal(txtPreco.Text);
            objItem.DtCompra = dtpCompra.Value;
            objItem.VlCusto = Convert.ToDecimal(txtVlCusto.Text);
            objItem.Tipo = cbTipoItem.Text;
            objItem.Diretor = txtDiretor.Text;

            //Pegando a Imagem
            using (var ms = new MemoryStream())
            {
                pbItem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                objItem.Imagem = ms.ToArray();
            }
                       

            return objItem;
        }

        private void btnInserirIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pbItem.ImageLocation = file.FileName;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (pbItem.Image != null)
            {
                Item objItem = SelectItem();
                itemDAL iDAL = new itemDAL();
                generoDAL gDAL = new generoDAL();
                iDAL.InserirItem(objItem);

                foreach (DataGridViewRow linha in dgvGeneros.Rows)
                {
                    gDAL.InserirGeneroItem(iDAL.BuscarCodUltimoItem(), Convert.ToInt32(linha.Cells[0].Value));
                }

                limparTela();
                MessageBox.Show("Item inserido");
            }
            else
                MessageBox.Show("Imagem Requerida");
        }

        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Item objItem = SelectItem();
            itemDAL iDAL = new itemDAL();
            iDAL.AlteraItem(objItem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            itemDAL iDAL = new itemDAL();
            iDAL.ExcluirItem(Convert.ToInt32(txtCod.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {            
            itemDAL iDAL = new itemDAL();
            Item objitem= iDAL.BuscarItemCodigo(Convert.ToInt32(txtCod.Text));

            txtCod.Text=Convert.ToString(objitem.Codigo);
            txtDescricao.Text=objitem.Descricao;
            txtDiretor.Text=objitem.Diretor;
            dtpCompra.Value=objitem.DtCompra;
            txtPreco.Text= Convert.ToString(objitem.Preco);
            cbTipoItem.Text=objitem.Tipo;
            txtVlCusto.Text= Convert.ToString(objitem.VlCusto);
            pbItem.Image = Image.FromStream(new MemoryStream(objitem.Imagem));
            pbItem.Refresh();                  

            
        }

        private void frmCadastroItem_Load(object sender, EventArgs e)
        {
            generoDAL gDAL = new generoDAL();;
            cbGeneros.DataSource = gDAL.ListarGeneros();
            cbGeneros.DisplayMember = "Nome";
            cbGeneros.ValueMember = "Codigo";       
        }

        private void btnAdicionarGen_Click(object sender, EventArgs e)
        {
            Genero objGen = new Genero();
            objGen.Codigo = Convert.ToInt32(cbGeneros.SelectedValue);
            objGen.Nome = cbGeneros.Text;

            dgvGeneros.Rows.Add(objGen.Codigo,objGen.Nome);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTela();
        }
    }
}
