using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JuegosDAM.Core
{
    class NavigationService : INavigationService
    {

        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
        }


        public void NavigateTo<TPage>() where TPage : Page, new()
        {
            _frame.Navigate(new TPage());
        }

        public void NavigateTo(Page page)
        {
            _frame.Navigate(page);
        }

    }
}
