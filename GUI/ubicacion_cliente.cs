using System;
using Entidades;
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
    public partial class ubicacion_cliente : Form
    {
        public ubicacion_cliente(Cliente cliente)
        {
            InitializeComponent();
            var ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "buscartienda.png");
            fondoutil.colocarFondo(this, ruta);
            //this.FormClosing += ubicacion_cliente_FormClosing;
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
        //private void ubicacion_cliente_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void panelsalidas_Paint(object sender, PaintEventArgs e)
        {
            BaseForm.ArrastrarVentana(this);
        }

        private void btn_cancelar_registro_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cerrar sesion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                inicio_sesion inicios = new inicio_sesion();
                inicios.Show();
                this.Close();
            }
        }


        private void Busqueda()
        {





        }




    }
}
