using System;
using Controlador;
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
    public partial class pnlGestion : Form
    {
        public pnlGestion()
        {
            InitializeComponent();
        }

        private void pnlGestion_Load(object sender, EventArgs e)
        {
            denominacionCordobaControlador dcc = new denominacionCordobaControlador();
            double cant_cordobas = dcc.getCantidadDineroCordoba();
            this.lblSaldo.Text = "El saldo en cordobas disponible es: " + cant_cordobas;
        }
    }
}
