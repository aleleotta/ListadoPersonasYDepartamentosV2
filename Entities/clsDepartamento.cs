namespace Entities
{
    public class clsDepartamento
    {
        #region Attributes
        private int id = 0;
        private string nombreDept = "";
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string NombreDept
        {
            get
            {
                return nombreDept;
            }
            set
            {
                if (value != null)
                {
                    nombreDept = value;
                }
            }
        }
        #endregion

        #region Constructors
        public clsDepartamento() { }

        public clsDepartamento(int id, string nombreDept)
        {
            this.id = id;
            this.nombreDept = nombreDept;
        }
        #endregion
    }
}
