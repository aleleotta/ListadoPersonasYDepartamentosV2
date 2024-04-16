﻿using Entities;

namespace ListadoPersonasYDepartamentosV2.Models
{
    public class clsPersonaNombreCompleto : clsPersona
    {
        private string nombreCompleto;
        private int edad;
        private bool mayor;

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

        public bool Mayor
        {
            get
            {
                return mayor;
            }
        }

        public clsPersonaNombreCompleto(clsPersona persona) : base(persona)
        {
            nombreCompleto = $"{Nombre} {Apellidos}";
            edad = DateTime.Now.Year - FechaNac.Year;
            if (edad >= 18) mayor = true;
        }
    }
}
