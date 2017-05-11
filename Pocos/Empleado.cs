using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class Empleado
    {
        public int id { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String usuario { get; set; }
        public String contrasenia { get; set; }

        public Empleado() { }
    }
}