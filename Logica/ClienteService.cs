using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteService
    {

        DAL_POSTGRES.ClienteRepository repoCliente = new DAL_POSTGRES.ClienteRepository();

        public ClienteService()
        {
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
            //repoEspecie = new EspecieRepository(Archivos.ARC_ESPECIE);
        }


        public string Guardar(Cliente entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El cliente no puede ser nulo. ");
                }

                return repoCliente.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar Cliente: {ex.Message}";
            }
        }

        public string Modificar(Cliente entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error. El cliente no puede ser nulo. ");
                }

                return repoCliente.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar Cliente: {ex.Message}";
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

                return repoCliente.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar Cliente: {ex.Message}";
            }
        }


        public Cliente BuscarCliente(string Email)
        {
            return repoCliente.BuscarCliente(Email);
        }


    }

}

