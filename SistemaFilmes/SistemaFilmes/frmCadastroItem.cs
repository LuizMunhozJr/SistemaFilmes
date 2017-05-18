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
    public partial class frmCadastroItem : Form
    {
        public frmCadastroItem()
        {
            InitializeComponent();
        }

        public Item SelectItem()
        {
            Item objItem = new Item();
            objItem.Codigo =Convert.ToInt32(txtCod.Text);
            objItem.CodigoDeBarras = txtCodBar.Text;
          //objItem.g
            objItem.Preco = Convert.ToDecimal(txtPreco.Text);

            //return
        }
       
    }
}
