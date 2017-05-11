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
    public class entregaCordobaControlador: Controlador<EntregaCordoba>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(EntregaCordoba t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "idEntrega", "idDenominacionCordoba", "cantidad", "created_at" };
            String[] en_cords = { "" + t.id_entrega + "", "" + t.id_denominacion_cordoba + "", "" + t.cantidad + "", "'" + t.fecha + "'" };
            return sql.guardar("entrega_cordoba", campos, en_cords);
        }

        public bool modificar(EntregaCordoba t)
        {
            return false;
        }

        public List<EntregaCordoba> getRecursos()
        {
            List<EntregaCordoba> devolver = new List<EntregaCordoba>();
            String[] campos = { "id", "idEntrega", "idDenominacionCordoba", "cantidad", "created_at" };
            DataTable dt = sql.getDatos("entrega_cordoba", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                EntregaCordoba ec = new EntregaCordoba();
                ec.id = Convert.ToInt32(row[0]);
                ec.id_entrega = Convert.ToInt32(row[1]);
                ec.id_denominacion_cordoba = Convert.ToInt32(row[2]);
                ec.cantidad = Convert.ToInt32(row[3]);
                ec.fecha = Convert.ToDateTime(row[4]);

                devolver.Add(ec);
            }

            return devolver;
        }

        public EntregaCordoba buscarPorID(int id)
        {
            EntregaCordoba devolver = new EntregaCordoba();
            foreach (var entreg_cord in getRecursos())
            {
                if (entreg_cord.id == id)
                {
                    devolver = entreg_cord;
                    break;
                }
            }

            return devolver;
        }
    }
}
