using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Ingresos.Paneles;

namespace Vista
{
    public partial class frmLoginEmpleados : Form
    {
        public frmLoginEmpleados()
        {
            InitializeComponent();
            this.pnlInicial();
        }

        // metodo para iniciar con el panel del login
        public void pnlInicial()
        {
            lblErrores.Text = "";
            pnlLogin login = new pnlLogin();
            login.frmPadre = this;
            MetodosGenerales.agregarPnl(this.pnlCentro, login);
        }

        // metodo para saber si el login fue correcto (pnlLogin)
        public void setFlagLogin(bool flag)
        {
            if (flag)
            {
                pnlOpciones pnl_opc = new pnlOpciones();
                pnl_opc.frmPadre = this;
                MetodosGenerales.agregarPnl(this.pnlCentro, pnl_opc);
                return;
            }

            // si llega aqui es porque lo datos son incorrectos
            lblErrores.Text = "El contraseña o usuario que introdujiste son incorrectas. Por favor ingresalas nuevamente";
        }

        // metodo para saber que opcion presiono
        public void setOpcSeleccionada(string opc)
        {
            if (opc.Equals("ingresar"))
            {
                pnlTipoMoneda tipoMon = new pnlTipoMoneda();
                MetodosGenerales.agregarPnl(this.pnlCentro, tipoMon);
            }

            if (opc.Equals("transaccion"))
            {
                pnlGestion tipoMon = new pnlGestion();
                MetodosGenerales.agregarPnl(this.pnlCentro, tipoMon);
            }
        }

        // metodo para saber que tipo de moneda eligio (pnlTipoMoneda)
        public void setOpcTipoMoneda(String opc)
        {
            switch (opc)
            {
                case "cordoba":
                    // mandar a llamar al panel de cordobas

                    break;

                case "dolar":
                    // mandar a llamar al panel de dolares

                    break;

                case "salir":
                    // volver al menu inicial

                    break;
            }
        }

        private void frmLoginEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Visible = true;
        }
    }
}
