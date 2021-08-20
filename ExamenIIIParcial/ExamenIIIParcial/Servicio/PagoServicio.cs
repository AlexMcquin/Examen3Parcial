using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ExamenIIIParcial.Model;

namespace ExamenIIIParcial.Servicio
{
    public class PagoServicio
    {
        public ObservableCollection<PagoModel> pagos { get; set; }

        public PagoServicio()
        {
            if (pagos == null)
            {
                pagos = new ObservableCollection<PagoModel>();
            }
        }


        public ObservableCollection<PagoModel> Consultar()
        {
            return pagos;
        }

        public void Guardar(PagoModel modelo)
        {
            pagos.Add(modelo);
        }

        public void Modificar(PagoModel modelo)
        {
            for (int i = 0; i < pagos.Count; i++)
            {
                if (pagos[i].Id == modelo.Id)
                {
                    pagos[i] = modelo;
                }

            }
        }

        public void Eliminar(String idEmpleado)
        {
            PagoModel modelo = pagos.FirstOrDefault(p => p.Id == idEmpleado);
            pagos.Remove(modelo);
        }
    }
}
