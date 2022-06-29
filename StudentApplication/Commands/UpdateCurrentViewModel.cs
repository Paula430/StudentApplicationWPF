using StudentApplication.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentApplication.Commands
{
    public class UpdateCurrentViewModel : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly INavigator _navigator;

        public UpdateCurrentViewModel(INavigator navigator)
        {

            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Grades:
                        _navigator.CurrentViewModel = new GradeViewModel();
                        break;
                    case ViewType.Tests:
                        _navigator.CurrentViewModel = new TestsViewModel();
                        break;
                    case ViewType.Courses:
                        _navigator.CurrentViewModel = new CoursesViewModel();
                        break;

                }
            }
        }
    }
}
