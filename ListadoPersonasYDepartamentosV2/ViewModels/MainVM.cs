using BL;
using Entities;
using ListadoPersonasYDepartamentosV2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListadoPersonasYDepartamentosV2.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsPersonaMayorEdad> listadoPersonas;
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private clsPersonaMayorEdad personaSeleccionada;
        private clsDepartamento departamentoSeleccionado;
        private int countPersonas;
        #endregion

        #region Properties
        public ObservableCollection<clsPersonaMayorEdad> ListadoPersonas
        {
            get
            {
                return listadoPersonas;
            }
        }

        public ObservableCollection<clsDepartamento> ListadoDepartamentos
        {
            get
            {
                return listadoDepartamentos;
            }
        }

        public clsPersonaMayorEdad PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                personaSeleccionada = value;
                OnPropertyChanged("PersonaSeleccionada");
            }
        }

        public clsDepartamento DepartamentoSeleccionado
        {
            get
            {
                return departamentoSeleccionado;
            }
            set
            {
                departamentoSeleccionado = value;
                List<clsPersona> listadoPersonasParcial = new List<clsPersona>(clsListadosBL.getListadoPersonasPorId(departamentoSeleccionado.Id));
                listadoPersonas = new ObservableCollection<clsPersonaMayorEdad>();
                foreach (clsPersona persona in listadoPersonasParcial)
                {
                    clsPersonaMayorEdad persona1 = new clsPersonaMayorEdad(persona);
                    listadoPersonas.Add(persona1);
                }
                OnPropertyChanged("ListadoPersonas");
            }
        }

        public int CountPersonas
        {
            get
            {
                return countPersonas;
            }
        }
        #endregion

        #region Constructors
        public MainVM()
        {
            listadoDepartamentos = new ObservableCollection<clsDepartamento>(clsListadosBL.getListadoDepartamentos());
        }
        #endregion

        #region Methods
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
