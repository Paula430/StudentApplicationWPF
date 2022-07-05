using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApplication.ViewModels
{
    public class LoggedViewModel : ObserveableObject
    {

        public RelayCommand GradeViewCommand { get; set; }
        public RelayCommand CourseViewCommand { get; set; }
        public RelayCommand TestViewCommand { get; set; }


        public GradeViewModel GradeVM { get; set; }
        public CourseViewModel CourseVM { get; set; }
        public TestViewModel TestVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }    
            set { _currentView = value; onPropertyChanged(); }
        }

       public LoggedViewModel()
        {
            GradeVM=new GradeViewModel();
            TestVM = new TestViewModel();
            CourseVM = new CourseViewModel();

            CurrentView = GradeVM;

            CourseViewCommand = new RelayCommand(o =>
             {
                 CurrentView = CourseVM;
             });

            TestViewCommand = new RelayCommand(o =>
            {
                CurrentView = TestVM;
            });

            GradeViewCommand = new RelayCommand(o =>
            {
                CurrentView = GradeVM;
            });

        }

    }
}
