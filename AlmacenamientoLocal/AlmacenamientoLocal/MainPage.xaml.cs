using AlmacenamientoLocal.Modelos;
using Xamarin.Forms;

namespace AlmacenamientoLocal
{
    public partial class MainPage : ContentPage
    {
        public ContextoDatos Contexto { get; set; }

        public MainPage(ContextoDatos contexto)
        {
            Contexto = contexto;

            InitializeComponent();

            botonGuardar.Clicked += (sender, args) => {
                Contexto.Guardar(new[] {
                    new Cliente() { Nombre = "Esteban", Direccion = "Cartago" }
                });
            };

            botonCargar.Clicked += (sender, args) =>
			{
				var elementos = Contexto.Cargar<Cliente>();
			};
        }
    }
}
