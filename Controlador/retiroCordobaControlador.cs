using Modelo;
using Pocos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class retiroCordobaControlador: Controlador<RetiroCordoba>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(RetiroCordoba t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "idRetiro", "idDenominacionCordoba", "cantidad", "created_at" };
            String[] rets = { "" + t.id_retiro + "", "'" + t.id_denominacion_cordoba + "'", "" + t.cantidad + "", "'" + t.fecha + "'" };
            return sql.guardar("retiro_cordoba", campos, rets);
        }

        public bool modificar(RetiroCordoba t)
        {
            return false;
        }

        public List<RetiroCordoba> getRecursos()
        {
            List<RetiroCordoba> devolver = new List<RetiroCordoba>();
            String[] campos = { "id", "idRetiro", "idDenominacionCordoba", "cantidad", "created_at" };
            DataTable dt = sql.getDatos("retiro_cordoba", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                RetiroCordoba es = new RetiroCordoba();
                es.id = Convert.ToInt32(row[0]);
                es.id_retiro = Convert.ToInt32(row[1]);
                es.id_denominacion_cordoba = Convert.ToInt32(row[2]);
                es.cantidad = Convert.ToInt32(row[3]);
                es.fecha = Convert.ToDateTime(row[4]);

                devolver.Add(es);
            }

            return devolver;
        }

        public RetiroCordoba buscarPorID(int id)
        {
            RetiroCordoba devolver = new RetiroCordoba();
            foreach (var retiro_cord in getRecursos())
            {
                if (retiro_cord.id == id)
                {
                    devolver = retiro_cord;
                    break;
                }
            }

            return devolver;
        }
    }
}
