using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Test : Form
    {

        public Test()
        {
            InitializeComponent();
            this.cargarTabla();
        }

        public void cargarTabla(){
            //DataTable dt = empleadoControlador.getDatos();
            //MetodosGenerales.cargarTabla(dataGridView1, dt);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow row = dt.Rows[i];
            //    // val = Convert.ToInt32(row[0].ToString());
            //    Console.WriteLine("dt: " + row[3]);
            //}
        }
    }
}
