using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda : BaseEntity
    {

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public Barrio barrio { get; set; }

        public List<Producto> ListaProductos { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Direccion};{barrio.Id}";
        }



    }
}
