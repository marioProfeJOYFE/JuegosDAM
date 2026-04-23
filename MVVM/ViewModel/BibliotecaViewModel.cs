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
    public class BibliotecaViewModel : ViewModelBase
    {
        private ObservableCollection<Game> _listaJuegos = [];

        public ICommand VerDetalleCommand { get; }

        public ObservableCollection<Game> ListaJuegos
        {
            get => _listaJuegos;
            set
            {
                _listaJuegos = value;
                OnPropertyChanged();
            }

        }

        public BibliotecaViewModel( INavigationService navigationService) : base(navigationService)
        {

            ListaJuegos = new ObservableCollection<Game>();

            //Enlazar VerDetalleCommand a RelayCommand para ejecutar la accion desde interfaz, y definir que hacer
            VerDetalleCommand = new RelayCommand<Game>(VerDetalle);

            ListaJuegos.Add(
                new Game(
                    0,
                    "Crimson Desert",
                    "Crimson Desert es un videojuego de rol de acción y aventura de 2026 desarrollado y publicado por Pearl Abyss. Originalmente planeado como una precuela de Black Desert Online, el juego evolucionó hasta convertirse en un título independiente durante su desarrollo."
                )
            );
            ListaJuegos.Add(
                new Game(
                    1,
                    "Pokémon Pokopia",
                    "Pokémon Pokopia es un videojuego de simulación de vida desarrollado conjuntamente por Game Freak y Omega Force de Koei Tecmo y publicado por Nintendo y The Pokémon Company para la Nintendo Switch 2.​ Es un spin-off de la serie principal de Pokémon.​ Pokopia recibió críticas muy positivas de los críticos",
                    ["Simulación de Vida"]
                )
            );
        }


        public void VerDetalle(Game juegoSeleccionado)
        {
            DetalleJuegoViewModel vm = new DetalleJuegoViewModel(juegoSeleccionado, NavigationService);
            NavigationService.NavigateTo(new DetalleJuegoPage(vm));
        }


    }
}
