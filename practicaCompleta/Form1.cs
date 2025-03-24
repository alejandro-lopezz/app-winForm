using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaCompleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;

            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;                                                      
            }
            
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }

            txtMultilinea.Text += "Apellido y Nombre: " + apellido + "" + nombre + Environment.NewLine;
            txtMultilinea.Text += "Edad: " + edad + Environment.NewLine;
            txtMultilinea.Text += "Dirección: " + direccion + Environment.NewLine;

        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
