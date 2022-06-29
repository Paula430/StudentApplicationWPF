﻿using StudentApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentApplication.State
{
    public enum ViewType
    {
        Grades,
        Tests,
        Courses

    }
    public interface INavigator
    {

        ViewModelBase CurrentViewModel { get; set; }

        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
