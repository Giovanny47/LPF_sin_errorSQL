using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class TiendaRepository : BaseDatos
    {

        DAL_POSTGRES.BarrioRepository repoBarrio = new BarrioRepository();
        DAL_POSTGRES.ProductoRepository repoProducto = new ProductoRepository();

        public List<Tienda> BuscarTiendasPorBarrio(int Barrio_id)
        {

            string sentencia = "SELECT shop_id, shop_name, adress, nb_id FROM shop WHERE nb_id = @Barrio_id";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);
            cmd.Parameters.AddWithValue("@Barrio_id", Barrio_id);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Tienda> lista = new List<Tienda>();


            while (reader.Read())
            {
                lista.Add(Mappear(reader));
            }

            CerrarConexion();
            return lista;
        }


        public List<Tienda> Consultar()
        {

            string sentencia = "SELECT shop_id, shop_name, adress, nb_id FROM shop";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Tienda> lista = new List<Tienda>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }





        private Tienda Mappear(NpgsqlDataReader reader)
        {

            Tienda tienda = new Tienda();

            tienda.Id = (int)reader[0];
            tienda.Nombre = (string)reader[1];
            tienda.Direccion = (string)reader[3];
            
            int Barrio_id = (int)reader[4];

            tienda.barrio = repoBarrio.BuscarPorId(Barrio_id);
            tienda.ListaProductos = repoProducto.Consultar(tienda.Id);
            
            return tienda;
        }



        public string Eliminar(int id)
        {

            if (id <= 0)
            {
                return "ID inválida";
            }

            string sentencia = "DELETE FROM [dbo].[shop] WHERE shop_id = @Id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Id", id);

                try
                {

                    AbrirConexion();
                    int i = cmd.ExecuteNonQuery();
                    return i > 0 ? "Registro eliminado correctamente" : "No se encontró el registro. ";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }


        public string Guardar(Tienda entity)
        {

            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "INSERT INTO shop(shop_name, adress, nb_id) VALUES (@Nombre, @Direccion, @Barrio_id) RETURNING shop_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                /* 		shop_id SERIAL PRIMARY KEY,
	                    shop_name VARCHAR(20),
	                    adress VARCHAR(15),
	                    nb_id REFERENCES neighborhood, */

                // @Nombre, @Telefono, @Direccion, @Barrio_id

                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                cmd.Parameters.AddWithValue("@Barrio", entity.barrio.Id);


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


        public string Modificar(Tienda entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "UPDATE shop SET " +
                                "shop_name = @Nombre, " +
                                "adress = @Direccion, " +
                                "nb_id = @Barrio_id " +
                                "WHERE shop_id = @Tienda_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                /* 		shop_id SERIAL PRIMARY KEY,
	                    shop_name VARCHAR(20),
	                    shop_telephone VARCHAR(12),
	                    adress VARCHAR(15),
	                    nb_id REFERENCES neighborhood, */

                // @Nombre, @Telefono, @Direccion, @Barrio_id

                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                cmd.Parameters.AddWithValue("@Barrio_id", entity.barrio.Id);
                cmd.Parameters.AddWithValue("@Tienda_id", entity.Id);


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


        public Tienda BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault<Tienda>(x => x.Id == id);
        }


    }
}
