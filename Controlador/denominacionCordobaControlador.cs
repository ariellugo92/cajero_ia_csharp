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
    public class denominacionCordobaControlador: Controlador<DenominacionCordoba>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(DenominacionCordoba t)
        {
            if (t == null)
            {
                Console.WriteLine("Objeto vacio");
                return -1;
            }

            String[] campos = { "nombre", "cantidad", "valor" };
            String[] den_cords = { "'" + t.nombre + "'", "" + t.cantidad + "", "" + t.valor + "" };
            return sql.guardar("denominacion_cordoba", campos, den_cords);
        }

        public bool modificar(DenominacionCordoba t)
        {
            return false;
        }

        public List<DenominacionCordoba> getRecursos()
        {
            List<DenominacionCordoba> devolver = new List<DenominacionCordoba>();
            String[] campos = { "id", "nombre", "cantidad", "valor", "estado" };
            DataTable dt = sql.getDatos("denominacion_cordoba", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                DenominacionCordoba dc = new DenominacionCordoba();
                dc.id = Convert.ToInt32(row[0]);
                dc.nombre = row[1].ToString();
                dc.cantidad = Convert.ToInt32(row[2]);
                dc.valor = Convert.ToInt32(row[3]);

                devolver.Add(dc);
            }

            return devolver;
        }

        public DenominacionCordoba buscarPorID(int id)
        {
            DenominacionCordoba devolver = new DenominacionCordoba();
            foreach (var den_cord in getRecursos())
            {
                if (den_cord.id == id)
                {
                    devolver = den_cord;
                    break;
                }
            }

            return devolver;
        }

        public double getCantidadDineroCordoba()
        {
            double cantidad = 0;
            foreach (var dcs in getRecursos())
            {
                double valor = (dcs.cantidad * dcs.valor);
                cantidad += valor;
            }
            return cantidad;
        }
    }
}
