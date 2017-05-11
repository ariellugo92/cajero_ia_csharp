using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class Entrega
    {
        public int id {get; set; }
        public bool tipo_moneda { get; set; }
        public int id_empleado { get; set; }
        public DateTime fecha { get; set; }

        public Entrega() { }
    }
}
