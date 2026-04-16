using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JuegosDAM.Core
{
    public interface INavigationService
    {
        /// <summary>
        /// Metodo para Navegar a una Página que no recibe ningun Parámetro de Entrada
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        void NavigateTo<TPage>() where TPage : Page, new();

        /// <summary>
        /// Metodo para Navegar a una Página que SI recibe algun Parámetro de Entrada
        /// </summary>
        /// <param name="page"></param>
        void NavigateTo(Page page);

    }
}
