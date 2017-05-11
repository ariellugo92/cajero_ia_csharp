using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class Cliente
    {
        public int id { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String numTDC { get; set; }
        public String numPIN { get; set; }
        public double limiteTDC { get; set; }
        public double saldo { get; set; }
        public bool estado { get; set; }

        public Cliente() { }
    }
}
