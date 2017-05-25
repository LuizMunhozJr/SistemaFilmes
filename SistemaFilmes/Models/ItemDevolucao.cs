using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ItemDevolucao
    {
        public int cdLocacao { get; set; }
        public int cdItem { get; set; }
        public string cddbarItem { get; set; }
        public string dsItem { get; set; }
        public decimal precoItem { get; set; }
        public string  statusPG { get; set; }
        public DateTime dtDevolucao { get; set; }
    }
}
