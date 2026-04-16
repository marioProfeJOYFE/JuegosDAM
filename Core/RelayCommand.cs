using System;
using System.Windows.Input;

namespace JuegosDAM.Core 
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        // Constructor
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        // Evento que notifica a la vista cuando la condición de CanExecute cambia.
        // CommandManager.RequerySuggested hace que WPF reevalúe los comandos automáticamente.
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Determina si el comando puede ejecutarse
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        // Ejecuta la lógica del comando
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}