using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoService
    {

        DAL_POSTGRES.ProductoRepository repoProducto = new DAL_POSTGRES.ProductoRepository();
       

        public ProductoService()
        {
            
        }

        public List<Producto> Consultar(int Tienda_id)
        {
            return repoProducto.Consultar(Tienda_id);
        }

        public string Guardar(Producto entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El producto no puede ser nulo. ");
                }

                return repoProducto.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar Producto: {ex.Message}";
            }
        }

        public string Modificar(Producto entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El Producto no puede ser nulo. ");
                }

                return repoProducto.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar Producto: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... el id debe ser mayor a cero");
                }

                return repoProducto.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar Producto: {ex.Message}";
            }
        }



    }

}
