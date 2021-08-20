using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIIIParcial.Model;
using ExamenIIIParcial.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenIIIParcial.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagoPage : ContentPage
    {
        PagoViewModel contexto = new PagoViewModel();
        public PagoPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvPagos.ItemSelected += LvPagos_ItemSelected;
        }

        private void LvPagos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                PagoModel modelo = (PagoModel)e.SelectedItem;
                Navigation.PushAsync(new DetallePage(modelo));
                contexto.Descripcion = modelo.Descripcion;
                contexto.Monto = modelo.Monto;
                contexto.Fecha = modelo.Fecha;
                contexto.Id = modelo.Id;

            }
        }

        
    }
}