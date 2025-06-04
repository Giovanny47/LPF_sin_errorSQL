using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class TiendaService
    {

        DAL_POSTGRES.TiendaRepository repoTienda = new DAL_POSTGRES.TiendaRepository();
        DAL_POSTGRES.ProductoRepository repoProducto = new DAL_POSTGRES.ProductoRepository();

        public TiendaService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public List<Tienda> Consultar()
        {
            return repoTienda.Consultar();
        }

        public string Guardar(Tienda entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. La tienda no puede ser nula. ");
                }

                return repoTienda.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar tienda: {ex.Message}";
            }
        }

        public string Modificar(Tienda entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. La tienda no puede ser nulo. ");
                }

                return repoTienda.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar Tienda: {ex.Message}";
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

                return repoTienda.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar tienda: {ex.Message}";
            }
        }

        public Tienda BuscarId(int id)
        {
            return Consultar().FirstOrDefault<Tienda>(x => x.Id == id);
        }

        public List<Producto> Consultar_productos(int Id)
        {
            return repoProducto.Consultar(Id);
        }

    }
}
