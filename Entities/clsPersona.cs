namespace Entities
{
    public class clsPersona
    {
        #region Attributes
        private int id = 0;
        private string nombre = "";
        private string apellidos = "";
        private DateTime fechaNac;
        private int idDept = 0;
        #endregion

        #region Properties
        public int Id {
            get
            {
                return id;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != null)
                {
                    nombre = value;
                }
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                if (value != null)
                {
                    apellidos = value;
                }
            }
        }
        public DateTime FechaNac
        {
            get
            {
                return fechaNac;
            }
            set
            {
                fechaNac = value;
            }
        }
        public int IdDept
        {
            get
            {
                return idDept;
            }
            set
            {
                idDept = value;
            }
        }
        #endregion

        #region Constructors
        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos, DateTime fechaNac, int idDept)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.idDept = idDept;
        }

        public clsPersona(clsPersona persona)
        {
            this.id = persona.id;
            this.nombre = persona.nombre;
            this.apellidos = persona.apellidos;
            this.fechaNac = persona.fechaNac;
            this.idDept = persona.idDept;
        }
        #endregion
    }
}
