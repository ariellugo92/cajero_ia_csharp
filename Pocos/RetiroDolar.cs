﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocos
{
    public class RetiroDolar
    {
        public int id { get; set; }
        public int id_retiro { get; set; }
        public int id_denominacion_dolar { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }

        public RetiroDolar() { }
    }
}
