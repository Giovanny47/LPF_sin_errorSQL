using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria : BaseEntity
    {
        public string Nombre { get; set; }


        public Categoria()
        {

        }


        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }


        public override string ToString()
        {
            return $"{Id};{Nombre}";
        }
    }

 }
