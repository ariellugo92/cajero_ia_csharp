using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MetodosSql
    {
        MySqlConnection con;
        MySqlCommand Query;
        MySqlDataReader reader;

        public int guardar(String tabla, String[] campos, String[] valores)
        {
            int valor_devuelto = 0;

            // obteniendo los campos y valores concatenados
            String campos_new = getCampos(campos);
            String valores_new = getValores(valores);

            // consulta
            String consulta = "insert into " + tabla + "("+ campos_new +") values" + "("+ valores_new +");";
            Console.WriteLine("Consulta: " + consulta);
            // insetando en la db
            con = new MySqlConnection();
            try
            {
                con.ConnectionString = conexion.Cn;
                con.Open();
                Query = new MySqlCommand();
                Query.CommandText = consulta;
                Query.Connection = con;
                // si todo salio bien va a retornar 1
                valor_devuelto = Query.ExecuteNonQuery();
                Query.Connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                valor_devuelto = -1;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            return valor_devuelto;
        }

        // metodo para obtener los datos
        public DataTable getDatos(String tabla, String[] campos)
        {
            DataTable dt = null;
            Object[] row;

            // obteniendo los campos concatenados
            String campos_new = getCampos(campos);

            // consulta
            String consulta = "select " + campos_new + " from " +  tabla + ";";
            Console.WriteLine("Consulta: " + consulta);
            // trayendo los valores de la db
            try
            {
                con = new MySqlConnection(conexion.Cn);
                con.Open();
                Query = new MySqlCommand();
                Query.CommandText = consulta;
                Query.Connection = con;
                reader = Query.ExecuteReader();
                dt = new DataTable();
                int col = reader.GetSchemaTable().Rows.Count;
                for (int i = 0; i < col; i++)
                {
                    dt.Columns.Add(reader.GetName(i));
                }
                while (reader.Read())
                {
                    row = new Object[col];
                    for (int i = 0; i < col; i++)
                    {
                        row[i] = reader.GetValue(i);
                    }

                    dt.Rows.Add(row);
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                return null;
            }

            return dt;
        }

        // metodo para devolver los campos
        private String getCampos(String[] campos)
        {
            int cant_campos = campos.Length;
            String campos_concatenados = "";
            for (int i = 0; i < cant_campos; i++)
            {
                campos_concatenados += (campos[i] + ",");
            }
            Console.WriteLine("campos concact: " + campos_concatenados.Substring(0, (campos_concatenados.Length - 1)));
            // quitando las comas del final
            return campos_concatenados.Substring(0, (campos_concatenados.Length - 1));
        }

        // metodo para devolver los valores
        private String getValores(object [] valores)
        {
            int cant_valores = valores.Length;
            String valores_concatenados = "";
            for (int i = 0; i < cant_valores; i++)
            {
                valores_concatenados += (valores[i] + ",");
            }
            // quitando las comas del final
            return valores_concatenados.Substring(0, (valores_concatenados.Length - 1));
        }
    }
}
