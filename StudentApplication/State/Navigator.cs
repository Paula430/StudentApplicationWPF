using StudentApplication.Models;
using StudentApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentApplication.State
{
    public class Navigator : ObserveableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                onPropertyChanged(nameof(CurrentViewModel));
            }

        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModel(this);


    }
}
