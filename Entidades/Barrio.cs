using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barrio : BaseEntity
    {

        public string Nombre { get; set; }


        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }

    }
}
