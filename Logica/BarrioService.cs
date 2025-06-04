using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class BarrioService
    {

        DAL_POSTGRES.BarrioRepository repoBarrio = new DAL_POSTGRES.BarrioRepository();

        public BarrioService()
        {
        }

        public List<Barrio> Consultar()
        {
            return repoBarrio.Consultar();
        }

        public string Guardar(Barrio entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El barrio no puede ser nulo.");
                }
                return repoBarrio.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar Barrio: {ex.Message}";
            }
        }


        public Barrio BuscarPorNombre(string Nombre)
        {
            return repoBarrio.BuscarPorNombre(Nombre);
        }

    }
}
