using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class TenderoRepository : BaseDatos, IRepository<Tendero>
    {

        TiendaRepository RepoTienda = new TiendaRepository();

        public List<Tendero> Consultar()
        {

            string sentencia = "SELECT so_id, first_name, last_name, email, telephone, so_password, shop_id FROM shop_owner";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Tendero> lista = new List<Tendero>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }



        private Tendero Mappear(NpgsqlDataReader reader)
        {

            Tendero tendero = new Tendero();

            tendero.Id = (int)reader[0];
            tendero.Nombre = (string)reader[1];
            tendero.Apellido = (string)reader[2];
            tendero.Email = (string)reader[3];
            tendero.Telefono = (string)reader[4];
            tendero.Password = (string)reader[5];

            int tienda_id = (int)reader[6];
            
            tendero.Tienda = RepoTienda.BuscarPorId(tienda_id);

            return tendero;
        }



        public string Eliminar(int id)
        {

            if (id <= 0)
            {
                return "ID inválida";
            }

            string sentencia = "DELETE FROM [dbo].[shop_owner] WHERE so_id = @Id";

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


        public string Guardar(Tendero entity)
        {

            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "INSERT INTO shop_owner(first_name, last_name, email, telephone, so_password, shop_id) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Password, @Shop_id,) RETURNING so_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                /* so_id SERIAL PRIMARY KEY,
	                first_name VARCHAR(20) NOT NULL,
	                last_name VARCHAR(20) NOT NULL,
	                email VARCHAR(40) NOT NULL,
	                telephone VARCHAR(12) NOT NULL,
	                so_password VARCHAR(15) NOT NULL,
	                shop_id INT REFERENCES shop */

                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
                cmd.Parameters.AddWithValue("@Shop_id", entity.Tienda.Id);

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


        public string Modificar(Tendero entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "UPDATE shop_owner " +
                                "SET shop_id = @Tienda_id, " +
                                "first_name = @Nombre, " +
                                "last_name = @Apellido, " +
                                "email = @Email, " +
                                "telephone = @Telefono, " +
                                "so_password = @Password " +
                                "WHERE so_id = @Tendero_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Tienda_id", entity.Tienda.Id);
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
                cmd.Parameters.AddWithValue("@Tendero_id", entity.Id);


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

        public Tendero BuscarTendero(string Email)
        {

            string sentencia = "SELECT so_id, first_name, last_name, email, telephone, so_password, shop_id FROM shop_owner WHERE email = '@Email'";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            Tendero tendero = new Tendero();


            tendero = Mappear(reader);

            CerrarConexion();

            if (tendero == null)
            {
                return null;
            }
            return tendero;
        }


    }
}
