using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Locacao
    {
        public int cdLocacao { get; set; }
        public int cdFunc { get; set; }
        public int cdFilme { get; set; }
        public int cdCli { get; set; }
        public DateTime dtRetirada { get; set; }
        public DateTime dtDevolucao { get; set; }
        public bool situItem { get; set; }
    }
}
