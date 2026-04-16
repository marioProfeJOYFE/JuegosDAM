using JuegosDAM.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDAM.MVVM.ViewModel
{

    //Todos los ViewModel Nuestros heredaram de esta clase
    public abstract class ViewModelBase
    {

        protected INavigationService NavigationService { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        //Metodo que avisa a la interfaz del cambio de valor de una variable
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        protected ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        

    }
}
