using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class EntregaCordoba
    {
        public int id { get; set; }
        public int id_entrega { get; set; }
        public int id_denominacion_cordoba { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }

        public EntregaCordoba() { }
    }
}
