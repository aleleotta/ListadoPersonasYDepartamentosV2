using Entities;
using DAL;

namespace BL
{
    public class clsListadosBL
    {
        public static List<clsPersona> getListadoPersonas()
        {
            return clsListadosDAL.listadoCompletoPersonas();
        }

        public static List<clsPersona> getListadoPersonasPorId(int idPersona)
        {
            List<clsPersona> listadoFiltrado = new List<clsPersona>();
            foreach (clsPersona persona in clsListadosDAL.listadoCompletoPersonas())
            {
                if (persona.IdDept == idPersona)
                {
                    listadoFiltrado.Add(persona);
                }
            }
            return listadoFiltrado;
        }

        public static List<clsDepartamento> getListadoDepartamentos()
        {
            return clsListadosDAL.listadoCompletoDepartamentos();
        }
    }
}