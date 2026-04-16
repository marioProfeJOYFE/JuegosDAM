using JuegosDAM.Core;
using JuegosDAM.MVVM.Model;
using JuegosDAM.MVVM.View;
using JuegosDAM.MVVM.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NavigationService = JuegosDAM.Core.NavigationService;

namespace JuegosDAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml Cambios
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            INavigationService navigationService = new NavigationService(MainFrame);

            DataContext = new MainWindowViewModel(navigationService);

            MainFrame.Navigate(new BibliotecaPage(new BibliotecaViewModel(navigationService)));
        }
    }
}
