using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class BarrioRepository : BaseDatos
    {

        public List<Barrio> Consultar()
        {

            string sentencia = "SELECT nb_id, nb_name FROM neighborhood";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Barrio> lista = new List<Barrio>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }



        private Barrio Mappear(NpgsqlDataReader reader)
        {

            Barrio barrio = new Barrio();

            barrio.Id = (int)reader[0];
            barrio.Nombre = (string)reader[1];

            return barrio;
        }


        public string Guardar(Barrio entity)
        {

            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "INSERT INTO neighborhood(nb_name) VALUES (@Nombre) RETURNING nb_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);


                try
                {
                    AbrirConexion();
                    object result = cmd.ExecuteScalar();
                    return result != null ? $"Registro insertado correctamente con ID: {result}" : "No se ha insertado. ";
                }
                catch (PostgresException ex)
                {
                    return $"Error de PostgreSQL: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Error general: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }


        public Barrio BuscarPorNombre(string nombre)
        {

            string sentencia = "SELECT FROM neighborhood (nb_id, nb_name) WHERE nb_name = @Name";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Name", nombre);

                AbrirConexion();

                NpgsqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    return Mappear(reader);
                }
                else
                {
                    return null; // No se encontró el barrio
                }

            }
           
        }


        public Barrio BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Barrio>(x => x.Id == id);
        }


    }
}
