using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a  C#");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento de Click" , "Atención");
            //this.BackColor = Color.Blue;
            if (txtEjercicio.Text == "")
            {
                txtEjercicio.BackColor = Color.Red;
            } else
            {
                txtEjercicio.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el botón izquierdo", "Atención");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presiono el botón derecho", "Atención");
            }
            if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presiono el botón de en medio", "Atención");
            }
        }

        private void lblEvento_MouseMove(object sender, MouseEventArgs e)
        {
            lblEvento.BackColor = Color.Cyan;
            lblEvento.Cursor = Cursors.Hand;
        }

        private void lblEvento_MouseLeave(object sender, EventArgs e)
        {
            lblEvento.BackColor = System.Drawing.SystemColors.Control;
            lblEvento.Cursor = Cursors.Arrow;
        }

        private void txtEjercicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtejercicio2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtejercicio2.Text.Length + " caracteres.");
        }

    }
}
