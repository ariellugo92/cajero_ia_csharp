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
    public class retiroDolarControlador: Controlador<RetiroDolar>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(RetiroDolar t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "idRetiro", "idDenominacionDolar", "cantidad", "created_at" };
            String[] rets = { "" + t.id_retiro + "", "'" + t.id_denominacion_dolar + "'", "" + t.cantidad + "", "'" + t.fecha + "'" };
            return sql.guardar("retiro_dolar", campos, rets);
        }

        public bool modificar(RetiroDolar t)
        {
            return false;
        }

        public List<RetiroDolar> getRecursos()
        {
            List<RetiroDolar> devolver = new List<RetiroDolar>();
            String[] campos = { "id", "idRetiro", "idDenominacionDolar", "cantidad", "created_at" };
            DataTable dt = sql.getDatos("retiro_dolar", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                RetiroDolar es = new RetiroDolar();
                es.id = Convert.ToInt32(row[0]);
                es.id_retiro = Convert.ToInt32(row[1]);
                es.id_denominacion_dolar = Convert.ToInt32(row[2]);
                es.cantidad = Convert.ToInt32(row[3]);
                es.fecha = Convert.ToDateTime(row[4]);

                devolver.Add(es);
            }

            return devolver;
        }

        public RetiroDolar buscarPorID(int id)
        {
            RetiroDolar devolver = new RetiroDolar();
            foreach (var retiro_dolar in getRecursos())
            {
                if (retiro_dolar.id == id)
                {
                    devolver = retiro_dolar;
                    break;
                }
            }

            return devolver;
        }
    }
}
