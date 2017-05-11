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
    public partial class pnlOpciones : Form
    {

        public frmLoginEmpleados frmPadre { get; set; }

        public pnlOpciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opc = "ingresar";
            this.frmPadre.setOpcSeleccionada(opc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string opc = "transaccion";
            this.frmPadre.setOpcSeleccionada(opc);
        }
    }
}
