using JuegosDAM.Core;
using JuegosDAM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDAM.MVVM.ViewModel
{
    public class DetalleJuegoViewModel : ViewModelBase
    {
        private Game _juego;
        public Game Juego
        {
            get => _juego;
            set
            {
                _juego = value;
                OnPropertyChanged();
            }
        }


        public DetalleJuegoViewModel(Game juego, INavigationService navigationService): base(navigationService) 
        {
            Juego = juego;
        }
        
    }
}
