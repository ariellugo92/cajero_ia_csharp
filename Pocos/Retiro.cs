﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class Retiro
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public bool tipoMoneda { get; set; }
        public DateTime fecha { get; set; }

        public Retiro() { }
    }
}
