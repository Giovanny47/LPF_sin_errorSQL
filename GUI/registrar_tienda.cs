using System;
using Entidades;
using Logica;
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
    public partial class registrar_tienda : Form
    {

        BarrioService ServicioBarrio;
        ClienteService ServicioCliente;
        TenderoService ServicioTendero;

        public registrar_tienda()
        {

            ServicioBarrio = new BarrioService();
            ServicioCliente = new ClienteService();
            ServicioTendero = new TenderoService();

            InitializeComponent();
            var ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "registro_tienda.png");
            fondoutil.colocarFondo(this, ruta);


            var placeholders = new Dictionary<TextBox, string>
            {
                // Datos del dueño

                { txt_nombre_dueño, "NOMBRE" },
                { txt_apellido_dueño, "APELLIDO" },
                { txt_correo_dueño, "CORREO ELECTRONICO" },
                { txt_telefono_dueño, "TELEFONO" },
                { txt_contra_dueño, "CREAR CONTRASEÑA" },
                

                // Datos de la tienda
                { txt_telefo_tienda, "TELEFONO" },
                { txt_name_tienda, "NOMBRE DE LA TIENDA" },
                { txt_direcc_tienda, "DIRECCION DE LA TIENDA" },
                { txt_barrio_tienda, "BARRIO DE LA TIENDA" }
            };

            PlaceholderUtil.AplicarPlaceholders(placeholders);

            //this.FormClosing += registrar_tienda_FormClosing;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnVenta.Visible = false;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            BaseForm.Minimizar(this);
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnVenta.Visible = true;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            BaseForm.Salir();
        }


        private void panelsalidas_MouseMove(object sender, MouseEventArgs e)
        {
            BaseForm.ArrastrarVentana(this);
        }


        //private void registrar_tienda_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}


        private void btn_cancelar_registro_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea cancelar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                inicio_sesion inicio = new inicio_sesion();
                inicio.Show();
                this.Close();
            }
        }


        private Barrio GuardarBarrio(string nombre_barrio)
        {

            if (ServicioBarrio.BuscarPorNombre(nombre_barrio) != null)
            {
                // Si el barrio ya existe, lo retornamos
                return ServicioBarrio.BuscarPorNombre(nombre_barrio);
            }

            Barrio barrio = new Barrio();

            barrio.Id = 1;
            barrio.Nombre = nombre_barrio.ToLower();

            ServicioBarrio.Guardar(barrio);

            return barrio;

        }


        private Tienda GuardarTienda(Barrio barrio)
        {
            Tienda tienda = new Tienda();

            tienda.Id = 1;
            tienda.Nombre = txt_name_tienda.Text;
            tienda.Direccion = txt_direcc_tienda.Text;
            tienda.barrio = barrio;
            tienda.ListaProductos = new List<Producto>();

            return tienda;

        }


        private Tendero GuardarTendero(Tienda tienda)
        {

            Tendero tendero = new Tendero();

            tendero.Nombre = txt_nombre_dueño.Text;
            tendero.Apellido = txt_apellido_dueño.Text;
            tendero.Email = txt_correo_dueño.Text;
            tendero.Telefono = txt_telefono_dueño.Text;
            tendero.Password = txt_contra_dueño.Text;

            return tendero;

        }


        private Boolean ComprobarCampos()
        {

            if (string.IsNullOrWhiteSpace(txt_nombre_dueño.Text) ||
                string.IsNullOrWhiteSpace(txt_apellido_dueño.Text) ||
                string.IsNullOrWhiteSpace(txt_correo_dueño.Text) ||
                string.IsNullOrWhiteSpace(txt_telefono_dueño.Text) ||
                string.IsNullOrWhiteSpace(txt_contra_dueño.Text) ||
                string.IsNullOrWhiteSpace(txt_name_tienda.Text) ||
                string.IsNullOrWhiteSpace(txt_direcc_tienda.Text) ||
                string.IsNullOrWhiteSpace(txt_barrio_tienda.Text) ||
                string.IsNullOrWhiteSpace(txt_telefo_tienda.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;

        }



        private Boolean Verificar_Correo(string Email)
        {

            if ((ServicioCliente.BuscarCliente(txt_correo_dueño.Text) != null) || (ServicioTendero.BuscarTendero(txt_correo_dueño.Text) != null))
            {
                MessageBox.Show("El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }


        private void AbrirTienda(Tendero tendero)
        {

            gestion_tienda tienda = new gestion_tienda(tendero);
            tienda.Show();
            this.Hide();

        }


        private void btn_registrartienda_Click(object sender, EventArgs e)
        {

            if((ComprobarCampos() == false) || (Verificar_Correo(txt_correo_dueño.Text) == false))
            {

                Barrio barrio = new Barrio();
                Tienda tienda = new Tienda();
                Tendero tendero = new Tendero();

                barrio = GuardarBarrio(txt_barrio_tienda.Text);
                tienda = GuardarTienda(barrio);
                tendero = GuardarTendero(tienda);

                AbrirTienda(tendero);

            }

        }

    }
}
