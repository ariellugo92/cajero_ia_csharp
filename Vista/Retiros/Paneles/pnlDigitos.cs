using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Retiros.Paneles
{
    public partial class pnlDigitos : Form
    {
        List<Int32> num_marcados;
        frmRetiroMain ret_main;
        public void setFrmRetiroMain(frmRetiroMain frm)
        {
            this.ret_main = frm;
        }

        public pnlDigitos()
        {
            InitializeComponent();
            num_marcados = new List<int>();
        }

        // metodo para poner cantidades en el tablero
        private void llenar_tablero()
        {
            String list_numeros = "";
            foreach (var numero in num_marcados)
            {
                String numero_string = Convert.ToString(numero);
                list_numeros += numero_string;
            }
            this.lblTableroDigitos.Text = list_numeros;
        }

        // metodo para llenar la lista segun el numero que toquen
        public void poniendoNumeros(Int32 num)
        {
            this.num_marcados.Add(num);
            this.llenar_tablero();
            this.ret_main.actualizar_lista_nuemros(this.num_marcados);
        }

        // metodo para borrar el ultimo numero ingresado
        public void borrarNumero()
        {
            String text_tablero = this.lblTableroDigitos.Text;
            if (text_tablero.Equals("0")) { return; }

            Int32 cant_numeros_actual = this.lblTableroDigitos.Text.Length;
            if (cant_numeros_actual == 1)
            {
                this.num_marcados.RemoveAt((num_marcados.Count - 1));
                this.lblTableroDigitos.Text = "0";
                this.ret_main.actualizar_lista_nuemros(this.num_marcados);
                return;
            }

            this.num_marcados.RemoveAt((num_marcados.Count - 1));
            this.llenar_tablero();
            this.ret_main.actualizar_lista_nuemros(this.num_marcados);
        }

        // metodo para limpiar la pantalla
        public void limpiarTablero()
        {
            this.num_marcados.Clear();
            this.lblTableroDigitos.Text = "0";
            this.ret_main.actualizar_lista_nuemros(this.num_marcados);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(9);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(6);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(3);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.poniendoNumeros(0);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.borrarNumero();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarTablero();
        }
    }
}
