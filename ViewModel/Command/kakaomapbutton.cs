using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 에누링.View;

namespace 에누링.ViewModel.Command
{
    class kakaomapbutton : ICommand
    {
        Action<object> _executeMethod;

        public kakaomapbutton()
        {

        }

        public kakaomapbutton(Action<object> executeMethod)
        {
            this._executeMethod = executeMethod;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            kakaomap km = new kakaomap();
            km.Show();
        }
    }
}
