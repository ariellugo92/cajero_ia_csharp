using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    class MetodosGenerales
    {

        public static void agregarPnl(Panel pnl_padre, object pnl_hijo_agregar)
        {
            if (pnl_padre.Controls.Count > 0)
            {
                pnl_padre.Controls.RemoveAt(0);
            }

            Form pc = pnl_hijo_agregar as Form;
            pc.TopLevel = false;
            pc.FormBorderStyle = FormBorderStyle.None;
            pc.Dock = DockStyle.Fill;
            pnl_padre.Controls.Add(pc);
            pnl_padre.Tag = pc;
            pc.Show();
        }

        public static void cargarTabla(System.Windows.Forms.DataGridView tbl, DataTable dt)
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            tbl.DataSource = bSource;
        }

    }
}
