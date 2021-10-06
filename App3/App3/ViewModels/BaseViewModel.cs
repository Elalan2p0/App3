using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App3.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string nombrepropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrepropiedad));
        }
    }
}
