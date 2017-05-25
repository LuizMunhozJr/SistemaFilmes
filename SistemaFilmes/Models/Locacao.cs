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
        //public string nmFunc { get; set; }
        public int cdCli { get; set; }
        //public string nmCli { get; set; }
        public DateTime dtRetirada { get; set; }
    }
}
