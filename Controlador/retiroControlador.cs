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
    public class retiroControlador: Controlador<Retiro>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(Retiro t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "idCliente", "tipoMoneda", "created_at" };
            String[] rets = { "" + t.id_cliente + "", "'" + t.tipoMoneda + "'", "'" + t.fecha + "'" };
            return sql.guardar("retiro", campos, rets);
        }

        public bool modificar(Retiro t)
        {
            return false;
        }

        public List<Retiro> getRecursos()
        {
            List<Retiro> devolver = new List<Retiro>();
            String[] campos = { "id", "idCliente", "tipoMoneda", "created_at" };
            DataTable dt = sql.getDatos("retiro", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Retiro es = new Retiro();
                es.id = Convert.ToInt32(row[0]);
                es.id_cliente = Convert.ToInt32(row[1]);
                es.tipoMoneda = Convert.ToBoolean(row[2]);
                es.fecha = Convert.ToDateTime(row[3]);

                devolver.Add(es);
            }

            return devolver;
        }

        public Retiro buscarPorID(int id)
        {
            Retiro devolver = new Retiro();
            foreach (var retiros in getRecursos())
            {
                if (retiros.id == id)
                {
                    devolver = retiros;
                    break;
                }
            }

            return devolver;
        }
    }
}
