using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tendero : Usuario
    {

        public Tienda Tienda { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Apellido};{Email};{Telefono};{Password};{Tienda.Id};";
        }

    }
}
