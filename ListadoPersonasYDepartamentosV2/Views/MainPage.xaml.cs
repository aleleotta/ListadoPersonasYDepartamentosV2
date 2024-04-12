using ListadoPersonasYDepartamentosV2.ViewModels;

namespace ListadoPersonasYDepartamentosV2.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainVM();
        }
    }
}