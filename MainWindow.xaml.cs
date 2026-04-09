using System;
using System.Windows;
using System.Windows.Input;

namespace JuegosDAM 
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Permite mover la ventana al hacer clic sostenido en el fondo.
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Solo arrastra si se está haciendo clic con el botón izquierdo
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        // Acción para el botón ROJO (Cerrar)
        private void BtnClose_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Acción para el botón AMARILLO (Minimizar)
        private void BtnMinimize_Click(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Acción para el botón VERDE (Maximizar / Restaurar)
        private void BtnMaximize_Click(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
    }
}
