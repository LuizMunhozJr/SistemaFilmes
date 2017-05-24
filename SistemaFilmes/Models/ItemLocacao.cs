using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ItemLocacao
    {
        public int cdLocacao { get; set; }
        public int cdItem { get; set; }
        public string statusPG { get; set; }
        public DateTime dtDevolucao { get; set; }

    }
}
