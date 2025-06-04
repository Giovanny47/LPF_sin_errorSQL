using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class BaseDatos
    {

        protected string cadenaConexion = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=db_localproductfinder";


        public NpgsqlConnection conexion;

        public BaseDatos()
        {
            conexion = new NpgsqlConnection(cadenaConexion);
        }


        public ConnectionState AbrirConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();

            }
            conexion.Open();
            return conexion.State;
        }


        public void CerrarConexion()
        {
            conexion.Close();
        }

    }
}
