using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Retiros.Paneles;

namespace Vista.Retiros
{
    public partial class frmRetiroMain : Form
    {
        List<Int32> lista_numeros_main;
        public frmRetiroMain()
        {
            InitializeComponent();
            this.lista_numeros_main = new List<int>();
            this.opcionesIniciales();
            this.cambiandoLabels("", "", "", "SALIR", "", "", "", "INGRESAR");
        }

        private void opcionesIniciales()
        {
            this.lblTituloMensaje.Text = "Ingrese el numero PIN de su TDC";
            pnlDigitos digitos = new pnlDigitos();
            digitos.setFrmRetiroMain(this);
            MetodosGenerales.agregarPnl(this.pnlCentroContenido, digitos);
        }

        // metodo para llenar la lista de numeros
        public void actualizar_lista_nuemros(List<Int32> lista_num)
        {
            //this.lista_numeros_main.Clear();
            this.lista_numeros_main = lista_num;
        }

        // metodo para llenar los label que estan a la par de los botones
        public void cambiandoLabels(String text_lbl_izq_1, String text_lbl_izq_2, String text_lbl_izq_3, String text_lbl_izq_4, String text_lbl_der_1, String text_lbl_der_2, String text_lbl_der_3, String text_lbl_der_4)
        {
            // llenando los botones de lado izquierdo
            this.lblOpcIzq1.Text = text_lbl_izq_1;
            this.lblOpcIzq2.Text = text_lbl_izq_2;
            this.lblOpcIzq3.Text = text_lbl_izq_3;
            this.lblOpcIzq4.Text = text_lbl_izq_4;
            // llenando los botones del lado derecho
            this.lblOpcDer1.Text = text_lbl_der_1;
            this.lblOpcDer2.Text = text_lbl_der_2;
            this.lblOpcDer3.Text = text_lbl_der_3;
            this.lblOpcDer4.Text = text_lbl_der_4;
        }

        int contadorRegresar = 0;
        String tipoMoneda = "";
        // metodo para cuando toquen los botones de al lado
        public void realizarAccionBtn(String accion)
        {
            String accion_minuscula = accion.ToLower();
            switch (accion_minuscula)
            {
                case "ingresar":
                    this.validarPin();
                    break;

                case "retiro":
                    this.labelsTipoMoneda();
                    break;

                case "regresar":
                    if(this.contadorRegresar == 0){ this.labelsPinSuccess(); }
                    if (this.contadorRegresar == 1) { this.labelsTipoMoneda(); this.contadorRegresar = 0; }
                    break;

                case "dolar":
                    this.tipoMoneda = "dolar";
                    this.ingresarCantRetiro();
                    break;

                case "cordoba":
                    this.tipoMoneda = "cordoba";
                    this.ingresarCantRetiro();
                    break;

                case "retirar":
                    this.retirarDinero();
                    break;

                case "menu":
                    this.contadorRegresar = 0;
                    this.labelsPinSuccess();
                    pnlPublicidad pnlPub = new pnlPublicidad();
                    MetodosGenerales.agregarPnl(this.pnlCentroContenido, pnlPub);
                    break;
            }
        }

        int contadorPin = 0;
        // metodo para validar el pin
        private void validarPin()
        {
            String pin = "";
            foreach (var lista_numero in this.lista_numeros_main)
            {
                String num = Convert.ToString(lista_numero);
                pin += num;
            }

            if (pin == "1234")
            {
                pnlPublicidad pnlPub = new pnlPublicidad();
                MetodosGenerales.agregarPnl(this.pnlCentroContenido, pnlPub);
                this.labelsPinSuccess();
                return;
            }

            this.contadorPin++;
            if (this.contadorPin == 2)
            {
                lblTituloMensaje.ForeColor = Color.Red;
                lblTituloMensaje.Text = "Has Vuelto A Ingresar El PIN De Manera Incorrecta, Si El Proximo Intento Es Erroneo Se Bloqueara Su Tarjeta";
                return;
            }
            if (this.contadorPin == 3)
            {
                lblTituloMensaje.ForeColor = Color.Red;
                lblTituloMensaje.Text = "Su Tarjeta Ha Sido Bloqueada Por Motivos De Seguridad, Favor Contactarse Con La Institucion";
                return;
            }

            lblTituloMensaje.ForeColor = Color.Red;
            lblTituloMensaje.Text = "PIN Incorrecto";
        }

        // metodo para poner los labels cuando el pin es correcto
        public void labelsPinSuccess()
        {
            this.cambiandoLabels("Ver Saldo", "Abono", "Retiro", "Item 2", "Ver Mas", "Adelanto", "Reportar", "Salir");
            this.lblTituloMensaje.Text = "Por favor!, Seleccione Una Opcion";
        }

        // metodo para poner los labels para elijir al tipo de moneda
        public void labelsTipoMoneda()
        {
            this.cambiandoLabels("", "", "", "Regresar", "", "", "Dolar", "Cordoba");
            this.lblTituloMensaje.Text = "Seleccione El Tipo De Moneda";
            if (this.contadorRegresar == 1)
            {
                pnlPublicidad pnlPub = new pnlPublicidad();
                MetodosGenerales.agregarPnl(this.pnlCentroContenido, pnlPub);
            }
        }

        // metodo para ingresar la cantidad de dinero a retirar
        public void ingresarCantRetiro()
        {
            this.lista_numeros_main.Clear();
            this.contadorRegresar = 1;
            this.cambiandoLabels("", "", "", "Regresar", "", "", "", "Retirar");
            this.lblTituloMensaje.Text = "Ingrese La Cantidad A Retirar";
            pnlDigitos digitos = new pnlDigitos();
            digitos.setFrmRetiroMain(this);
            MetodosGenerales.agregarPnl(this.pnlCentroContenido, digitos);
        }

        // metodo para retirar el dinero
        public void retirarDinero()
        {
            String cant_ingresada = "";
            foreach (var lista_numero in this.lista_numeros_main)
            {
                String num = Convert.ToString(lista_numero);
                cant_ingresada += num;
            }

            // validar que la cantidad ingresada sea mayor que 100
            String moneda = this.tipoMoneda;
            if (Convert.ToDouble(cant_ingresada) < 100)
            {
                String simbolo = moneda == "cordoba" ? "C$" : "U$";
                lblTituloMensaje.ForeColor = Color.Red;
                this.lblTituloMensaje.Text = "La Cantidad Minima A Retirar Es De " + simbolo + "100";
                return;
            }

            // validar que la cantidad ingresada sea menor que ?
            // pendiente

            // validar que la cantidad concuerde con la denominacion de los billetes
            String ultimas_dos_cifras = cant_ingresada.Substring((cant_ingresada.Length - 2), 2);
            if (ultimas_dos_cifras != "00")
            {
                lblTituloMensaje.ForeColor = Color.Red;
                this.lblTituloMensaje.Text = "La Cantidad A Retirar Debe De Estar Compuesta Por Billetes de 100, 200, 500 o 1000 Cordobas";
                return;
            }

            // dando el dinero
            this.cambiandoLabels("", "", "", "Salir", "", "", "", "Menu");
            this.lblTituloMensaje.Text = "Su transaccion ha sido realizada correctamente, desea volver a menu?";
        }

        private void btnOpcDer4_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcDer4.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcIzq1_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcIzq1.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcIzq2_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcIzq2.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcIzq3_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcIzq3.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcIzq4_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcIzq4.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcDer1_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcDer1.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcDer2_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcDer2.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void btnOpcDer3_Click(object sender, EventArgs e)
        {
            String text_lbl_asociado = lblOpcDer3.Text;
            this.realizarAccionBtn(text_lbl_asociado);
        }

        private void frmRetiroMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Visible = true;
        }
    }
}
