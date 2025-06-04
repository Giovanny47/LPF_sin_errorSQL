using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace GUI
{
    public partial class visualizar_productos : Form
    {
        private int tiendaId;

        public visualizar_productos(int tiendaId)
        {
            InitializeComponent();
            this.tiendaId = tiendaId;
        }

        private void visualizar_productos_Load(object sender, EventArgs e)
        {
            ProductoService servicioProducto = new ProductoService();
            var productos = servicioProducto.ObtenerTodos(tiendaId);
            DataProductos.DataSource = productos;
        }
    }
}
