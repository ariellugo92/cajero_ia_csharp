using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Ingresos.Paneles
{
    public partial class pnlTipoMoneda : Form
    {

        private frmLoginEmpleados frmPadre;
        public void setFrmPadre(frmLoginEmpleados frm)
        {
            this.frmPadre = frm;
        }

        public pnlTipoMoneda()
        {
            InitializeComponent();
        }

        // metodo para calcular el total en cordobas
        public void totalCordobas()
        {
            // total de billetes
            int mil = Convert.ToInt32(spinerCordMil.Value);
            int quiniento = Convert.ToInt32(spinerCordQuiniento.Value);
            int dociento = Convert.ToInt32(spinerCordDocientos.Value);
            int cien = Convert.ToInt32(spinerCordCien.Value);
            // valor por billetes
            int cant_mil = mil * 1000;
            int cant_quin = quiniento * 500;
            int cant_doc = dociento * 200;
            int cant_cien = cien * 100;
            // total
            int suma_total = cant_mil + cant_quin + cant_doc + cant_cien;
            lblTotalCordobas.Text = "" + suma_total;
        }

        // metodo para calcular el total en dolares
        public void totalDolares()
        {
            // total billetes
            int cien = Convert.ToInt32(spinerDolarCien.Value);
            int cincuenta = Convert.ToInt32(spinerDolarCincuenta.Value);
            int veinte = Convert.ToInt32(spinerDolarVeinte.Value);
            // valor por billetes
            int cant_cien = cien * 100;
            int cant_cincuenta = cincuenta * 50;
            int cant_veinte = veinte * 20;
            // total
            int suma_total = cant_cien + cant_cincuenta + cant_veinte;
            lblTotalDolares.Text = "" + suma_total;
        }

        private void spinerCordMil_ValueChanged(object sender, EventArgs e)
        {
            totalCordobas();
        }

        private void spinerCordQuiniento_ValueChanged(object sender, EventArgs e)
        {
            totalCordobas();
        }

        private void spinerCordDocientos_ValueChanged(object sender, EventArgs e)
        {
            totalCordobas();
        }

        private void spinerCordCien_ValueChanged(object sender, EventArgs e)
        {
            totalCordobas();
        }

        private void spinerDolarCien_ValueChanged(object sender, EventArgs e)
        {
            totalDolares();
        }

        private void spinerDolarCincuenta_ValueChanged(object sender, EventArgs e)
        {
            totalDolares();
        }

        private void spinerDolarVeinte_ValueChanged(object sender, EventArgs e)
        {
            totalDolares();
        }
    }
}
