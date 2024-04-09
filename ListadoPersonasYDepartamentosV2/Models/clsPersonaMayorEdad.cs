using Entities;

namespace ListadoPersonasYDepartamentosV2.Models
{
    public class clsPersonaMayorEdad : clsPersona
    {
        private bool mayor;

        public bool Mayor
        {
            get
            {
                return mayor;
            }
        }

        public clsPersonaMayorEdad(clsPersona persona) : base(persona)
        {
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
