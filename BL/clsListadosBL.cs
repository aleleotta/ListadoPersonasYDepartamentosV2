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

        public static List<clsDepartamento> getListadoDepartamentos()
        {
            return clsListadosDAL.listadoCompletoDepartamentos();
        }
    }
}
