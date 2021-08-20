using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ExamenIIIParcial.Model;
using System.Collections.ObjectModel;
using ExamenIIIParcial.Servicio;
using Xamarin.Forms;

namespace ExamenIIIParcial.ViewModel
{
    public class PagoViewModel : PagoModel
    {
        public ObservableCollection<PagoModel> Pagos { get; set; }
        PagoServicio servicio = new PagoServicio();
        PagoModel modelo;

        public PagoViewModel()
        {
            Pagos = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () => !Isbusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }

        public Command GuardarCommand { get; set; }

        public Command ModificarCommand { get; set; }

        public Command EliminarCommand { get; set; }

        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {
            Isbusy = true;
            Guid IdPago = Guid.NewGuid();
            modelo = new PagoModel()
            {
                Descripcion = Descripcion,
                Monto = Monto,
                Fecha = Fecha,
                Id = IdPago.ToString()
            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Modificar()
        {
            Isbusy = true;

            modelo = new PagoModel()
            {
                Descripcion = Descripcion,
                Monto = Monto,
                Fecha = Fecha,
                Id = Id
            };
            servicio.Modificar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Eliminar()
        {
            Isbusy = true;
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private void Limpiar()
        {
            Descripcion = "";
            Monto = 0;
            Fecha = "";
            Id = "";

        }
    }
}
