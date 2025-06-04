using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace GUI
{
    public partial class agregar_productos : Form
    {
        private int? productoId = null;
        private Tienda tienda; // Guardamos la tienda actual

        public agregar_productos(Tienda tienda)
        {
            InitializeComponent();
            this.tienda = tienda;
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private void agregar_productos_Load(object sender, EventArgs e)
        {
            CargarProductosEnTabla();
        }

        // Llama a este método cuando selecciones un producto para editar/eliminar
        public void CargarProducto(Producto producto)
        {
            productoId = producto.Id;
            txtNombre.Text = producto.Nombre;
            txtprecio.Text = producto.Precio.ToString();
            cmbCategoria.SelectedItem = producto.categoria?.Nombre;
            txtcantidad.Text = producto.Stock.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtprecio.Text) ||
                cmbCategoria.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtcantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = Convert.ToDouble(precio),
                categoria = new Categoria { Nombre = cmbCategoria.SelectedItem.ToString() },
                Stock = cantidad,
                tienda = tienda // Asocia el producto a la tienda actual
            };

            var servicio = new ProductoService();
            string resultado = servicio.Guardar(producto);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarProductosEnTabla(); // <-- Recarga la tabla
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoId == null)
            {
                MessageBox.Show("Selecciona un producto para editar.");
                return;
            }

            var producto = new Producto
            {
                Id = productoId.Value,
                Nombre = txtNombre.Text,
                Precio = Convert.ToDouble(txtprecio.Text),
                categoria = new Categoria { Nombre = cmbCategoria.SelectedItem.ToString() },
                Stock = int.Parse(txtcantidad.Text),
                tienda = tienda
            };

            var servicio = new ProductoService();
            string resultado = servicio.Modificar(producto);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarProductosEnTabla(); // <-- Recarga la tabla
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoId == null)
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
                return;
            }

            var servicio = new ProductoService();
            string resultado = servicio.Eliminar(productoId.Value);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            CargarProductosEnTabla(); // <-- Recarga la tabla
        }

        private void LimpiarCampos()
        {
            productoId = null;
            txtNombre.Clear();
            txtprecio.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtcantidad.Clear();
        }

        private void CargarProductosEnTabla()
        {
            var servicio = new ProductoService();
            var productos = servicio.ObtenerTodos(tienda.Id);
            dataGridProductos.DataSource = productos;
        }
    }
}
