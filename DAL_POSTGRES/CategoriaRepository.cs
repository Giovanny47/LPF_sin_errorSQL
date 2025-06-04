using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL_POSTGRES
{
    public class CategoriaRepository : BaseDatos
    {

        public List<Categoria> Consultar()
        {

            string sentencia = "SELECT category_id, category_name FROM category";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Categoria> lista = new List<Categoria>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }



        private Categoria Mappear(NpgsqlDataReader reader)
        {

            Categoria categoria = new Categoria();

            categoria.Id = (int)reader[0];
            categoria.Nombre = (string)reader[1];

            return categoria;
        }




        public Categoria BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Categoria>(x => x.Id == id);
        }


    }
}
