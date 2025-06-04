using DAL_POSTGRES;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TenderoService
    {

        DAL_POSTGRES.TenderoRepository repoTendero = new DAL_POSTGRES.TenderoRepository();

        public TenderoService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }

        public string Guardar(Tendero entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El propietario no puede ser nulo. ");
                }

                return repoTendero.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar propietario: {ex.Message}";
            }
        }

        public string Modificar(Tendero entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El propietario no puede ser nulo. ");
                }

                return repoTendero.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar Tendero: {ex.Message}";
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

                return repoTendero.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar propietario: {ex.Message}";
            }
        }


        public Tendero BuscarTendero(string Email)
        {
            return repoTendero.BuscarTendero(Email);
        }

    }
}
