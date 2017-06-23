using Prueba.DAO.Repositorios;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Service
{
    public class ClaseService
    {
        ClaseRepository repository = new ClaseRepository();

        public ClaseService()
        {

        }

        public List<Clase> ListarClases()
        {
            List<Clase> lista = repository.ListarClase();

            return lista;
        }
    }
}
