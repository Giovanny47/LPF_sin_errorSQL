using Entidades;
using Logica;
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

    public partial class registrar_cliente : Form
    {

        ClienteService ServicioCliente;
        TenderoService ServicioTendero;

        public registrar_cliente()
        {

            ServicioCliente = new ClienteService();
            ServicioTendero = new TenderoService();

            InitializeComponent();
           
            var ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "registro_cliente.png");
            fondoutil.colocarFondo(this, ruta);

            var placeholders = new Dictionary<TextBox, string>
        {
            { txt_nombreclient, "NOMBRE" },
            { txt_apellidoclient, "APELLIDO" },
            { txt_contraclient, "CREAR CONTRASEÑA" },
            { txt_telefonoclient, "TELEFONO" },
            { txt_correoclient, "CORREO ELECTRONICO" }
        };

            PlaceholderUtil.AplicarPlaceholders(placeholders);
            //this.FormClosing += registrar_cliente_FormClosing;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            BaseForm.Salir();
        }
        //private void registrar_cliente_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

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

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnVenta.Visible = false;
        }
        private void panelsalidas_MouseMove(object sender, MouseEventArgs e)
        {
            BaseForm.ArrastrarVentana(this);
        }


        private void btn_cancelar_registro_Click(object sender, EventArgs e)
        {
            var resultados = MessageBox.Show("¿Desea cancelar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultados == DialogResult.Yes)
            {
                //mostramos el formulario de login y cerramos este
                inicio_sesion inicio = new inicio_sesion();
                inicio.Show();
                this.Close();


            }
        }


        private void btn_registrarclient_Click(object sender, EventArgs e)
        {
            if ((Comprobar_Campos() == false) && (Verificar_Correo(txt_correoclient.Text) == false))
            {
                Cliente cliente = Guardar_Cliente();
                string resultado = ServicioCliente.Guardar(cliente);

                MessageBox.Show(resultado, "Resultado del registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.Contains("correctamente"))
                {
                    ubicacion_cliente Ucliente = new ubicacion_cliente(cliente);
                    Ucliente.Show();
                    this.Hide();
                }
            }
        }


        private Boolean Verificar_Correo(string Email)
        {

            if ((ServicioCliente.BuscarCliente(txt_correoclient.Text) != null) || (ServicioTendero.BuscarTendero(txt_correoclient.Text) != null))
            {
                MessageBox.Show("El correo ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }



        private Cliente Guardar_Cliente()
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txt_nombreclient.Text;
            cliente.Apellido = txt_apellidoclient.Text;
            cliente.Email = txt_correoclient.Text;
            cliente.Telefono = txt_telefonoclient.Text;
            cliente.Password = txt_contraclient.Text;
            return cliente;
        }


        private Boolean Comprobar_Campos()
        {

            if (string.IsNullOrWhiteSpace(txt_nombreclient.Text) ||
               string.IsNullOrWhiteSpace(txt_apellidoclient.Text) ||
               string.IsNullOrWhiteSpace(txt_correoclient.Text) ||
               string.IsNullOrWhiteSpace(txt_telefonoclient.Text) ||
               string.IsNullOrWhiteSpace(txt_contraclient.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
    }
}
