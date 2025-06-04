using Entidades;
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
    public partial class gestion_tienda : Form
    {
        public gestion_tienda(Tendero tendero)
        {

            InitializeComponent();
            var ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "fondo_tienda.png");
            fondoutil.colocarFondo(this, ruta);

            //this.FormClosing += gestion_tienda_FormClosing;
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

        private void paneltitulo_MouseMove(object sender, MouseEventArgs e)
        {
            BaseForm.ArrastrarVentana(this);
        }
        private void AbrirFormHija(object formhija)
        {
            //para dejar su tamaño original
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            // fh.Dock = DockStyle.Fill; // Elimina o comenta esta línea

            // Centrar el formulario dentro del panel
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.StartPosition = FormStartPosition.Manual;
            fh.Location = new Point(
                (panelcontenedor.Width - fh.Width) / 2,
                (panelcontenedor.Height - fh.Height) / 2
            );

            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        //private void AbrirFormHija(object formhija)
        //{
        //    //para colocarlo del tamaño del panel
        //    if (this.panelcontenedor.Controls.Count > 0)
        //        this.panelcontenedor.Controls.RemoveAt(0);

        //    Form fh = formhija as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelcontenedor.Controls.Add(fh);
        //    this.panelcontenedor.Tag = fh;
        //    fh.Show();
        //}

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new agregar_productos());
        }

        private void btn_verproduct_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new visualizar_productos());
        }

        private void btnSalirTienda_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cerrar sesion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                 inicio_sesion inicio = new inicio_sesion();
                inicio.Show();
                this.Close();
            }
        }

        //private void gestion_tienda_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

    }
}
