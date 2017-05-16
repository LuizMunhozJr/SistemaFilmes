using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascto { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string TEL { get; set; }
        public string CEL { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
