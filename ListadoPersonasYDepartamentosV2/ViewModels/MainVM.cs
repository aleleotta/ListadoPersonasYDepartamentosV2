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
        private ObservableCollection<clsPersonaNombreCompleto> listadoPersonas;
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private clsPersonaNombreCompleto personaSeleccionada;
        private clsDepartamento departamentoSeleccionado;
        #endregion

        #region Properties
        public ObservableCollection<clsPersonaNombreCompleto> ListadoPersonas
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

        public clsPersonaNombreCompleto PersonaSeleccionada
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
                listadoPersonas = new ObservableCollection<clsPersonaNombreCompleto>();
                foreach (clsPersona persona in listadoPersonasParcial)
                {
                    clsPersonaNombreCompleto persona1 = new clsPersonaNombreCompleto(persona);
                    listadoPersonas.Add(persona1);
                }
                OnPropertyChanged("ListadoPersonas");
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
