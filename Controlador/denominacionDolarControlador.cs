using Pocos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controlador
{
    public class denominacionDolarControlador: Controlador<DenominacionDolar>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(DenominacionDolar t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "nombre", "cantidad", "valor" };
            String[] den_dolars = { "'" + t.nombre + "'", "" + t.cantidad + "", "" + t.valor + "" };
            return sql.guardar("denominacion_dolar", campos, den_dolars);
        }

        public bool modificar(DenominacionDolar t)
        {
            return false;
        }

        public List<DenominacionDolar> getRecursos()
        {
            List<DenominacionDolar> devolver = new List<DenominacionDolar>();
            String[] campos = { "id", "nombre", "cantidad", "valor", "estado" };
            DataTable dt = sql.getDatos("denominacion_dolar", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                DenominacionDolar dc = new DenominacionDolar();
                dc.id = Convert.ToInt32(row[0]);
                dc.nombre = row[1].ToString();
                dc.cantidad = Convert.ToInt32(row[2]);
                dc.valor = Convert.ToInt32(row[3]);

                devolver.Add(dc);
            }

            return devolver;
        }

        public DenominacionDolar buscarPorID(int id)
        {
            DenominacionDolar devolver = new DenominacionDolar();
            foreach (var den_dolar in getRecursos())
            {
                if (den_dolar.id == id)
                {
                    devolver = den_dolar;
                    break;
                }
            }

            return devolver;
        }
    }
}
