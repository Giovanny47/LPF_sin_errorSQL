using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Usuario
    {

        public Cliente()
        {

        }


        public Cliente(int id, string nombre, string apellido, string email, string telefono, string password)
        {
            this.Id = Id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Password = password;

        }




        public override string ToString()
        {
            return $"{Id};{Nombre};{Apellido};{Email};{Telefono};{Password};";
        }


    }
}
