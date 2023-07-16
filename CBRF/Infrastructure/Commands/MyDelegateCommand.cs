using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CBRF.Infrastructure.Commands
{
    /// <summary>
    /// Команда с передаваемым параметром, используется в табличном режиме для команды сохранить
    /// </summary>
    sealed public class MyDelegateCommand : ICommand
    {
        #region Внутренние поля и переменные
        private Action<object> execute;
        private Func<object, bool> canExecute;
        private Action performCreateUser;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion

        #region Конструктор
        public MyDelegateCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public MyDelegateCommand(Action performCreateUser)
        {
            this.performCreateUser = performCreateUser;
        }
        #endregion

        #region Методы
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (execute != null)
                this.execute(parameter);
            if (performCreateUser != null)
                this.performCreateUser();
        }
        #endregion
    }
}
