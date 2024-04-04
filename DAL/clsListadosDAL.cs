using Entities;

namespace DAL
{
    public class clsListadosDAL
    {
        /// <summary>
        /// Devuelve un listado completo de personas.
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static List<clsPersona> listadoCompletoPersonas()
        {
            List<clsPersona> listadoPersonas = new List<clsPersona>
            {
                new clsPersona(1, "Fernando", "Galiana", new DateTime(1980, 05, 05), 1),
                new clsPersona(2, "user2", "undefined2", new DateTime(1995, 02, 10), 2),
                new clsPersona(3, "user3", "undefined3", new DateTime(2000, 01, 11), 3),
                new clsPersona(4, "user4", "undefined4", new DateTime(1998, 10, 05), 4),
                new clsPersona(5, "user5", "undefined5", new DateTime(2003, 07, 10), 5),
                new clsPersona(6, "user6", "undefined6", new DateTime(2004, 06, 12), 6)
            };
            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve un listado completo de departamentos.
        /// </summary>
        /// <returns>Listado de departamentos</returns>
        public static List<clsDepartamento> listadoCompletoDepartamentos()
        {
            List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>
            {
                new clsDepartamento(1, "Marketing"),
                new clsDepartamento(2, "Contabilidad"),
                new clsDepartamento(3, "Produccion"),
                new clsDepartamento(4, "Recursos Humanos"),
                new clsDepartamento(5, "Suporte"),
                new clsDepartamento(6, "Informatica")
            };
            return listadoDepartamentos;
        }

        /// <summary>
        /// Devuelve una sola persona usando el id en el parametro para identificarla.
        /// </summary>
        /// <param name="idPersona">El id de la persona a devolver.</param>
        /// <param name="listadoPersonas">El listado completo de personas.</param>
        /// <returns>La persona con el id correspondiente.</returns>
        public static clsPersona devolverPersona(int idPersona)
        {
            List<clsPersona> listadoPersonas = new List<clsPersona>
            {
                new clsPersona(1, "Fernando", "Galiana", new DateTime(1980, 05, 05), 1),
                new clsPersona(2, "user2", "undefined2", new DateTime(1995, 02, 10), 2),
                new clsPersona(3, "user3", "undefined3", new DateTime(2000, 01, 11), 3),
                new clsPersona(4, "user4", "undefined4", new DateTime(1998, 10, 05), 4),
                new clsPersona(5, "user5", "undefined5", new DateTime(2003, 07, 10), 5),
                new clsPersona(6, "user6", "undefined6", new DateTime(2004, 06, 12), 6)
            };
            bool encontrado = false;
            int count = 0;
            clsPersona persona;
            while (!encontrado && count < listadoPersonas.Count)
            {
                if (listadoPersonas[count].Id == idPersona)
                {
                    encontrado = true;
                    persona = listadoPersonas[count];
                }
                else
                {
                    count++;
                }
            }
            if (!encontrado)
            {
                persona = new clsPersona();
            }
            return persona;
        }

        /// <summary>
        /// Devuelve un solo departamento usando el id en el parametro para identificarlo.
        /// </summary>
        /// <param name="idDepartamento">El id del departamento a devolver.</param>
        /// <param name="listadoDepartamentos">El listado completo de departamentos</param>
        /// <returns>El departamento con el id correspondiente.</returns>
        public static clsDepartamento devolverDepartamento(List<clsDepartamento> listadoDepartamentos, int idDepartamento)
        {
            bool encontrado = false;
            int count = 0;
            while (!encontrado)
            {
                if (listadoDepartamentos[count].Id == idDepartamento)
                {
                }
                count++;
            }
        }
    }
}