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
    public class entregaDolarControlador: Controlador<EntregaDolar>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(EntregaDolar t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "idEntrega", "idDenominacionDolar", "cantidad", "created_at" };
            String[] en_dolars = { "" + t.id_entrega + "", "" + t.id_denominacion_dolar + "", "" + t.cantidad + "", "'" + t.fecha + "'" };
            return sql.guardar("entrega_dolar", campos, en_dolars);
        }

        public bool modificar(EntregaDolar t)
        {
            return false;
        }

        public List<EntregaDolar> getRecursos()
        {
            List<EntregaDolar> devolver = new List<EntregaDolar>();
            String[] campos = { "id", "idEntrega", "idDenominacionDolar", "cantidad", "created_at" };
            DataTable dt = sql.getDatos("entrega_dolar", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                EntregaDolar ed = new EntregaDolar();
                ed.id = Convert.ToInt32(row[0]);
                ed.id_entrega = Convert.ToInt32(row[1]);
                ed.id_denominacion_dolar = Convert.ToInt32(row[2]);
                ed.cantidad = Convert.ToInt32(row[3]);
                ed.fecha = Convert.ToDateTime(row[4]);

                devolver.Add(ed);
            }

            return devolver;
        }

        public EntregaDolar buscarPorID(int id)
        {
            EntregaDolar devolver = new EntregaDolar();
            foreach (var entreg_dolar in getRecursos())
            {
                if (entreg_dolar.id == id)
                {
                    devolver = entreg_dolar;
                    break;
                }
            }

            return devolver;
        }
    }
}
