using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {

            DAL_POSTGRES.BaseDatos bd = new DAL_POSTGRES.BaseDatos();
            Console.WriteLine(bd.AbrirConexion());
            Console.ReadKey();

            /*
             
             client_id SERIAL PRIMARY KEY,
	        first_name VARCHAR(20) NOT NULL,
	        last_name VARCHAR(20) NOT NULL,
	        email VARCHAR(40) UNIQUE NOT NULL,
	        telephone VARCHAR(12) NOT NULL,
	        client_password VARCHAR(15) NOT NULL, 
             
           
             */

            //DAL_POSTGRES.ClienteRepository repo = new DAL_POSTGRES.ClienteRepository();

            //Cliente cliente = new Cliente(4,"Sara","Martinez","SaraMartinez@gmail.com","65665","uwu");

            //Console.WriteLine(cliente.ToString());

            //Console.WriteLine(repo.Guardar(cliente));
            //Console.ReadKey();


        }
    }
}
