using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Item
    {
        public int Codigo { get; set; }
        public int CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public Decimal  Preco { get; set; }
        public DateTime DataLancamento { get; set; }
        public Decimal VlCusto { get; set; }
        public bool Situacao { get; set; }
        public string  Diretor { get; set; }
        public byte Imagem { get; set; }
    }
}
