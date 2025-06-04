using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BuscarTienda : Form
    {
        public BuscarTienda()
        {
            InitializeComponent();
            var ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "buscar_tienda.png");
            fondoutil.colocarFondo(this, ruta);
            //this.FormClosing += buscar_tienda_FormClosing;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnVenta.Visible = false;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnVenta.Visible = true;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            BaseForm.Minimizar(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            BaseForm.Salir();
        }
        //private void buscar_tienda_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void panelsalidas_MouseMove(object sender, MouseEventArgs e)
        {
            BaseForm.ArrastrarVentana(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea volver a ubicacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                ubicacion_cliente volver = new ubicacion_cliente();
                volver.Show();
                this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea entrar a buscar producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                busqueda_cliente busqueda = new busqueda_cliente();
                busqueda.Show();
                this.Close();
            }
           
        }

        private void btn_cancelar_registro_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cerrar sesion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                inicio_sesion volver = new inicio_sesion();
                volver.Show();
                this.Close();
            }
        }
    }
}
