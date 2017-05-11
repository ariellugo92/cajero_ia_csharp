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
    public partial class pnlLogin : Form
    {

        public frmLoginEmpleados frmPadre { get; set; }

        public pnlLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.validandoCredenciales();
        }

        // metodo para validar las credenciales
        public void validandoCredenciales()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingresa al usuario");
                return;
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("Por favor ingresa la contraseña");
                return;
            }

            String user = txtUsuario.Text;
            String pass = txtPass.Text;
            // validando
            if (user == "user" && pass == "1234")
            {
                // si los datos son correctos
                this.frmPadre.setFlagLogin(true);
                return;
            }

            // si los datos son incorrectos
            this.frmPadre.setFlagLogin(false);
        }
    }
}
