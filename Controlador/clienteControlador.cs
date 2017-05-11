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
    public class clienteControlador: Controlador<Cliente>
    {

        MetodosSql sql = new MetodosSql();

        public int guardar(Cliente t)
        {
            if (t == null)
            {
                return -1;
            }

            String[] campos = { "nombre", "apellido", "numTDC", "numPIN", "limiteTDC", "saldo" };
            String[] clients = { "'" + t.nombres + "'", "'" + t.apellidos + "'", "'" + t.numTDC + "'", "'" + t.numPIN + "'", t.limiteTDC.ToString(), t.saldo.ToString()};
            return sql.guardar("cliente", campos, clients);
        }

        public bool modificar(Cliente t)
        {
            return false;
        }

        public List<Cliente> getRecursos()
        {
            List<Cliente> devolver = new List<Cliente>();
            String[] campos = { "id", "nombres", "apellidos", "numTDC", "numPIN", "limiteTDC", "saldo", "estado" };
            DataTable dt = sql.getDatos("cliente", campos);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                Cliente cs = new Cliente();
                cs.id = Convert.ToInt32(row[0]);
                cs.nombres = row[1].ToString();
                cs.apellidos = row[2].ToString();
                cs.numTDC = row[3].ToString();
                cs.numPIN = row[4].ToString();
                cs.limiteTDC = Convert.ToDouble(row[5]);
                cs.saldo = Convert.ToDouble(row[6]);

                devolver.Add(cs);
            }

            return devolver;
        }

        public Cliente buscarPorID(int id)
        {
            Cliente devolver = new Cliente();
            foreach (var clients in getRecursos())
            {
                if (clients.id == id)
                {
                    devolver = clients;
                    break;
                }
            }

            return devolver;
        }
    }
}
