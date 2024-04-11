using Entities;

namespace ListadoPersonasYDepartamentosV2.Models
{
    public class clsPersonaMayorEdad : clsPersona
    {
        private bool mayor;
        private string nombreCompleto;

        public bool Mayor
        {
            get
            {
                return mayor;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return nombreCompleto;
            }
        }

        public clsPersonaMayorEdad(clsPersona persona) : base(persona)
        {
            nombreCompleto = Nombre + " " + Apellidos;
            int edad = DateTime.Now.Year - FechaNac.Year;
            if (edad >= 18)
            {
                mayor = true;
            }
            else
            {
                mayor = false;
            }
        }
    }
}
