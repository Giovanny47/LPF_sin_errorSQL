using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_POSTGRES
{
    public class ProductoRepository : BaseDatos
    {

        DAL_POSTGRES.TiendaRepository repoTienda = new DAL_POSTGRES.TiendaRepository();
        DAL_POSTGRES.CategoriaRepository repoCategoria = new DAL_POSTGRES.CategoriaRepository();

        public List<Producto> Consultar(int Tienda_Id)
        {

            string sentencia = "SELECT product_id, category_id, product_name, price, stock FROM product WHERE shop_id = @Tienda_Id";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Producto> lista = new List<Producto>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }



        private Producto Mappear(NpgsqlDataReader reader)
        {

            Producto producto = new Producto();

            producto.Id = (int)reader[0];

            int Tienda_id = (int)reader[1];
            producto.tienda = repoTienda.BuscarPorId(Tienda_id);

            int Categoria_id = (int)reader[2];
            producto.categoria = repoCategoria.BuscarPorId(Categoria_id);

            producto.Nombre = (string)reader[3];
            producto.Precio = (double)reader[4];
            producto.Stock = (int)reader[5];

            return producto;
        }


        public string Eliminar(int id)
        {

            if (id <= 0)
            {
                return "ID inválida";
            }

            string sentencia = "DELETE FROM [dbo].[product] WHERE product_id = @Id";

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



        public string Guardar(Producto entity)
        {

            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "INSERT INTO product(shop_id, category_id, product_name, price, stock) VALUES (@Tienda_id, @Categoria_id, @Nombre, @Precio, @Stock) RETURNING product_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Tienda_id", entity.tienda.Id);
                cmd.Parameters.AddWithValue("@Categoria_id", entity.categoria.Id);
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                cmd.Parameters.AddWithValue("@Stock", entity.Stock);

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


        public string Modificar(Producto entity)
        {
            if (entity == null || string.IsNullOrWhiteSpace(entity.Nombre))
            {
                return "Datos inválidos. ";
            }


            string sentencia = "UPDATE product" +
                "SET category_id = @Categoria_id, " +
                "product_name = @Nombre " +
                "price = @Precio" +
                "Stock = @Stock" +
                "WHERE product_id = @Id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion))
            {

                cmd.Parameters.AddWithValue("@Categoria_id", entity.categoria.Id);
                cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                cmd.Parameters.AddWithValue("@Stock", entity.Stock);

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


        public Producto BuscarPorId(int Tienda_id, int Producto_id)
        {
            return Consultar(Tienda_id).FirstOrDefault<Producto>(x => x.Id == Producto_id);
        }



        public List<Producto> BuscarProductoPorBarrio(string Nombre, string Barrio)
        {

            string sentencia = "SELECT product_id, category_id, product_name, price, stock FROM product WHERE shop_id = @Tienda_Id";

            NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);

            AbrirConexion();

            NpgsqlDataReader reader = cmd.ExecuteReader();

            List<Producto> lista = new List<Producto>();


            while (reader.Read())
            {

                lista.Add(Mappear(reader));

            }

            CerrarConexion();
            return lista;
        }


    }

    
}
