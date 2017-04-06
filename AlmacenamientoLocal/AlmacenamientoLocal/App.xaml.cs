using AlmacenamientoLocal.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AlmacenamientoLocal
{
    public partial class App : Application
    {
        public ContextoDatos Contexto { get; set; }

        public App()
        {
            Contexto = new ContextoDatos();

            InitializeComponent();

            MainPage = new AlmacenamientoLocal.MainPage(Contexto);
        }

        protected override void OnStart()
        {
            Contexto.Configurar<Cliente>();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
