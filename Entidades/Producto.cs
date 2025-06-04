using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : BaseEntity
    {

        public Tienda tienda { get; set; }

        public Categoria categoria { get; set; }


        public string Nombre { get; set; }

        public double Precio { get; set; }


        public int Stock { get; set; }
     


        public override string ToString()
        {
            return $"{Id};{tienda.Id};{categoria.Id};{Nombre};{Precio}";
        }

    }

}

