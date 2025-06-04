using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class ClienteRepository : BaseDatos
    {

        public Cliente BuscarCliente(string Email)
        {

            string sentencia = "SELECT client_id, first_name, last_name, email, telephone, client_password, adress, nb_id FROM client  WHERE email = '@Email'";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            Cliente cliente = new Cliente();


            cliente = Mappear(reader);

            CerrarConexion();

            if (cliente == null)
            {
                return null;
            }
            return cliente;
        }

        private Cliente Mappear(NpgsqlDataReader reader)
        {

            //  return $"{Id};{Nombre};{Apellido};{Username};{Email};{Telefono};{Password}";

            Cliente cliente = new Cliente();

            cliente.Id = (int)reader[0];
            cliente.Nombre = (string)reader[1];
            cliente.Apellido = (string)reader[2];
            cliente.Email = (string)reader[3];
            cliente.Telefono = (string)reader[4];
            cliente.Password = (string)reader[5];

            return cliente;

        }


        public string Eliminar(int id)
        {

            if (id <= 0)
            {
                return "ID inválida";
            }

            string sentencia = "DELETE FROM [dbo].[client] WHERE client_id = @Id";

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


        public string Guardar(Cliente entity)
        {

            if (entity == null /*|| string.IsNullOrWhiteSpace(entity.Nombre)*/)
            {
                return "Datos inválidos. ";
            }


            string sentencia = "INSERT INTO client(first_name, last_name, email, telephone, client_password) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Password) RETURNING client_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
     
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

        public string Modificar(Cliente entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "UPDATE client SET " +
                "first_name = @Nombre, " +
                "last_name = @Apellido, " +
                "email = @Email, " +
                "telephone = @Telefono, " +
                "client_password = @Password" +
                "WHERE client_id = @Id";
                

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                /*	client_id SERIAL PRIMARY KEY,
	            first_name VARCHAR(20) NOT NULL,
	            last_name VARCHAR(20) NOT NULL,
	            email VARCHAR(40) UNIQUE NOT NULL,
	            telephone VARCHAR(12) NOT NULL,
	            client_password VARCHAR(15) NOT NULL, 
	            adress VARCHAR(15),
	            nb_id REFERENCES neighborhoodL */


                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
                cmd.Parameters.AddWithValue("@Id", entity.Id);


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

    }
}
