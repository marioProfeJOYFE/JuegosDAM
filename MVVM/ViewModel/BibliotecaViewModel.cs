using JuegosDAM.Core;
using JuegosDAM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegosDAM.MVVM.ViewModel
{
    public class BibliotecaViewModel : ViewModelBase
    {
        private ObservableCollection<Game> ListaJuegos { get; set; }

        public BibliotecaViewModel( INavigationService navigationService) : base(navigationService)
        {

            ListaJuegos = new ObservableCollection<Game>();

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
    }
}
