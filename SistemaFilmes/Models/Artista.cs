using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Artista
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascto { get; set; }
        public string Naturalidade { get; set; }
        public Byte[] Imagem  { get; set; }
    }
}
