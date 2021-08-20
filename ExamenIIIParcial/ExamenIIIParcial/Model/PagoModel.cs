using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExamenIIIParcial.Model
{
    public class PagoModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String descripcion = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(descripcion));
        }

        private bool isBusy = false;

        public bool Isbusy
        {
            get { return isBusy = false; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
                OnPropertyChanged();
            }
        }

        private double monto;

        public double Monto
        {
            get { return monto; }
            set
            {
                monto = value;

                OnPropertyChanged();
            }
        }

        private string fecha;

        public String Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
                OnPropertyChanged();
            }
        }
        
        

    }
}
