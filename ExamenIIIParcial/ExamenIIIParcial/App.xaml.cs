using ExamenIIIParcial.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenIIIParcial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PagoPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
