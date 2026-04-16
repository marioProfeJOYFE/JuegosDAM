using JuegosDAM.Core;
using JuegosDAM.MVVM.Model;
using JuegosDAM.MVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JuegosDAM.MVVM.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        public ICommand NavBibliotecaCommand { get; }


        public MainWindowViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavBibliotecaCommand = new RelayCommand(
                (_) => navigationService.NavigateTo(new BibliotecaPage(new BibliotecaViewModel(navigationService))) 
            );
        }
        
    }
}
