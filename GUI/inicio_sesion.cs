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
using System.Runtime.InteropServices;
using Logica;


namespace GUI
{

    public partial class inicio_sesion : Form
    {

        ClienteService ServicioCliente;
        TenderoService ServicioTendero;

        public inicio_sesion()
        {

            ServicioCliente = new ClienteService();
            ServicioTendero = new TenderoService();

            InitializeComponent();
            var placeholders = new Dictionary<TextBox, string>
        {
            { txtUser, "USUARIO/CORREO ELECTRONICO" },
            { txtContra, "CONTRASEÑA" }
        };

            PlaceholderUtil.AplicarPlaceholders(placeholders);

        }

        //metodo para arrastrar la ventana y no se que mas

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelsalidas_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnVenta.Visible = true;


        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnVenta.Visible = false;
        }

        private void btnRegis_client_Click(object sender, EventArgs e)
        {
            registrar_cliente cliente = new registrar_cliente();
            cliente.Show();
            this.Hide();
        }

        private void btn_Regis_tienda_Click(object sender, EventArgs e)
        {
            registrar_tienda Tienda = new registrar_tienda();
            Tienda.Show();
            this.Hide();
        }



        private Cliente InicioSesionCliente(string Email, string password)
        {
            var cliente = ServicioCliente.BuscarCliente(Email);
            if (cliente != null)
            {
                if (cliente.Password == password)
                    return cliente;
                MessageBox.Show("Contraseña incorrecta", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private Tendero InicioSesionTendero(string Email, string password)
        {
            var tendero = ServicioTendero.BuscarTendero(Email);
            if (tendero != null)
            {
                if (tendero.Password == password)
                    return tendero;
                MessageBox.Show("Contraseña incorrecta", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void IniciarSesion(string Email, string password)
        {
            var cliente = InicioSesionCliente(Email, password);
            if (cliente != null)
            {
                var ubicacionCliente = new ubicacion_cliente(cliente);
                ubicacionCliente.Show();
                this.Hide();
                return;
            }

            var tendero = InicioSesionTendero(Email, password);
            if (tendero != null)
            {
                var gestionTienda = new gestion_tienda(tendero);
                gestionTienda.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Usuario no encontrado. De no tener una cuenta, por favor registrarse.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }                   

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
                    // Solo el correo en minúsculas, la contraseña se respeta tal cual
                    IniciarSesion(txtUser.Text.ToLower(), txtContra.Text);
        }
    }
}
