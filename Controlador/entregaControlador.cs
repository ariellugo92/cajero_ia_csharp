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
    public class entregaControlador: Controlador<Entrega>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(Entrega t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "tipoMoneda", "created_at", "id_empleado" };
            String[] ents = { "" + t.tipo_moneda + "", "'" + t.fecha + "'", "'" + t.id_empleado+ "'" };
            return sql.guardar("entrega", campos, ents);
        }

        public bool modificar(Entrega t)
        {
            return false;
        }

        public List<Entrega> getRecursos()
        {
            List<Entrega> devolver = new List<Entrega>();
            String[] campos = { "id", "tipoMoneda", "created_at", "id_empleado" };
            DataTable dt = sql.getDatos("entrega", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Entrega es = new Entrega();
                es.id = Convert.ToInt32(row[0]);
                es.tipo_moneda = Convert.ToBoolean(row[1]);
                es.fecha = Convert.ToDateTime(row[2]);
                es.id_empleado = Convert.ToInt32(row[3]);

                devolver.Add(es);
            }

            return devolver;
        }

        public Entrega buscarPorID(int id)
        {
            Entrega devolver = new Entrega();
            foreach (var entreg in getRecursos())
            {
                if (entreg.id == id)
                {
                    devolver = entreg;
                    break;
                }
            }

            return devolver;
        }
    }
}
