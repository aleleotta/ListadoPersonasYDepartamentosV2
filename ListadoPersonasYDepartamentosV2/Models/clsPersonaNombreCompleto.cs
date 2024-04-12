using Entities;

namespace ListadoPersonasYDepartamentosV2.Models
{
    public class clsPersonaNombreCompleto : clsPersona
    {
        private string nombreCompleto;

        public string NombreCompleto
        {
            get
            {
                return nombreCompleto;
            }
        }

        public clsPersonaNombreCompleto(clsPersona persona) : base(persona)
        {
            nombreCompleto = Nombre + " " + Apellidos;
        }
    }
}
