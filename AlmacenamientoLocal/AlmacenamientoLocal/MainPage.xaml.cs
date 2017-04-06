using AlmacenamientoLocal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
