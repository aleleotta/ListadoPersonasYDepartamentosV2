using Entities;

namespace ListadoPersonasYDepartamentosV2.Models
{
    public class clsPersonaNombreCompleto : clsPersona
    {
        private string nombreCompleto;
        private int edad;

        public string NombreCompleto
        {
            get
            {
                return nombreCompleto;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public clsPersonaNombreCompleto(clsPersona persona) : base(persona)
        {
            nombreCompleto = Nombre + " " + Apellidos;
            edad = DateTime.Now.Year - FechaNac.Year;
        }
    }
}
