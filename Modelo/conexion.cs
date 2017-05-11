using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class conexion
    {
        // cadena de conexion
        public static string Cn = "server=localhost;port=3306;user id=root; password=1234; " +
            "database=cajero_ia; pooling=false; Allow Zero Datetime=False;Convert Zero Datetime=True";
    }
}
