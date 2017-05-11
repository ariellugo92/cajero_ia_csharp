using Pocos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class empleadoControlador: Controlador<Empleado>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(Empleado t)
        {
            if (t == null)
            {
                return -1;
            }

            String[] campos = { "nombres", "apellidos", "usuario", "contrasenia", "estado" };
            String[] emps = { "'" + t.nombres + "'", "'" + t.apellidos + "'", "'" + t.usuario + "'", "'" + t.contrasenia + "'" };
            return sql.guardar("empleados", campos, emps);
        }

        public bool modificar(Empleado t)
        {
            return false;
        }

        public List<Empleado> getRecursos()
        {
            List<Empleado> devolver = new List<Empleado>();
            String[] campos = { "id", "nombres", "apellidos", "usuario", "contrasenia" };
            DataTable dt = sql.getDatos("empleados", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Empleado es = new Empleado();
                es.id = Convert.ToInt32(row[0]);
                es.nombres = row[1].ToString();
                es.apellidos = row[2].ToString();
                es.usuario = row[3].ToString();
                es.contrasenia = row[4].ToString();

                devolver.Add(es);
            }

            return devolver;
        }

        public Empleado buscarPorID(int id)
        {
            foreach (var emps in getRecursos())
            {
                if (emps.id == id)
                {
                    return emps;
                }
            }

            return null;
        }
    }
}
