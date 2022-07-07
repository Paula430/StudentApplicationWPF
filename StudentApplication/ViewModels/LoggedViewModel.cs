using StudentApplication.Domain.Model;
using StudentApplication.Domain.Services;
using StudentApplication.EF;
using StudentApplication.EF.Services;
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
        private string _currentStudentName;
        private string _currentStudentLastName;
        private int _currentStudentAlbum;
        private string _currentStudentEmail;

        public object CurrentView
        {
            get { return _currentView; }    
            set { _currentView = value; onPropertyChanged(); }
        }

        public string CurrentStudentName
        {
            get { return _currentStudentName; }
            set { _currentStudentName = value; onPropertyChanged(); }
        }

        public string CurrentStudentLastName
        {
            get { return _currentStudentLastName; }
            set { _currentStudentLastName = value; onPropertyChanged(); }
        }

        public int CurrentStudentAlbum
        {
            get { return _currentStudentAlbum; }
            set { _currentStudentAlbum = value; onPropertyChanged(); }
        }


        public string CurrentStudentEmail
        {
            get { return _currentStudentEmail; }
            set { _currentStudentEmail = value; onPropertyChanged(); }
        }



        public LoggedViewModel()
        {
            GradeVM=new GradeViewModel();
            TestVM = new TestViewModel();
            CourseVM = new CourseViewModel();

            CurrentStudentName = GetNameStudents();
            CurrentStudentLastName = GetLastNameStudents();
            CurrentStudentAlbum = GetAlbumStudent();
            CurrentStudentEmail = GetEmailStudent();
            

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

        public static string GetNameStudents()
        {

            using (SMDbContext context = new SMDbContext())
            {
                return context.Students.Where(s => s.Id == Authentication.currentStudentId).FirstOrDefault().FirstName;
            }
            
        }
        public static string GetLastNameStudents()
        {

            using (SMDbContext context = new SMDbContext())
            {
                return context.Students.Where(s => s.Id == Authentication.currentStudentId).FirstOrDefault().LastName;
            }
                       
        }
        public static int GetAlbumStudent()
        {

            using (SMDbContext context = new SMDbContext())
            {
                return context.Students.Where(s => s.Id == Authentication.currentStudentId).FirstOrDefault().Id;
            }
            
        }
        public static string GetEmailStudent()
        {
            using (SMDbContext context = new SMDbContext())
            {
                return context.Students.Where(s => s.Id == Authentication.currentStudentId).FirstOrDefault().Email;
            }
          
        }



    }
}
