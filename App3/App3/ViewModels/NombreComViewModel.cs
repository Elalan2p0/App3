using System;
using System.Collections.Generic;
using System.Text;

namespace App3.ViewModels
{
    public class NombreComViewModel : BaseViewModel
    {
        string nombre;
        string ap1;
        string ap2;

        public string Nombre 
        {
            get => nombre;
            set 
            {
                if (string.Equals(nombre, value)) return;
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(NombreCom));
            }
        }

        public string Ap1
        {
            get => nombre;
            set
            {
                if (string.Equals(ap1, value)) return;
                ap1 = value;
                OnPropertyChanged(nameof(Ap1));
                OnPropertyChanged(nameof(NombreCom));
            }
        }

        public string Ap2
        {
            get => nombre;
            set
            {
                if (string.Equals(ap2, value)) return;
                ap1 = value;
                OnPropertyChanged(nameof(Ap2));
                OnPropertyChanged(nameof(NombreCom));
            }
        }

        public string NombreCom
        {
            get => string.Format("Tu nombre completo es {0} {1} {2}", nombre, ap1, ap2);
        }
    }
}
