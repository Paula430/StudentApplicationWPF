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
    public class CourseViewModel:ObserveableObject
    {
        private int currentStudentId = Authentication.currentStudentId;
        private ICollection<Courses> _currentCourses;
        public CourseViewModel()
        {
            _currentCourses = LoadCourses();
        }

        public ICollection<Courses> CurrentCourses
        {
            get { return _currentCourses; }
            set { _currentCourses = value; onPropertyChanged(); }
        }

        public ICollection<Courses> LoadCourses()
        {
            IDataService<Courses> gradesservice = new GenericDataService<Courses>(new SMDbContextFactory());
            return gradesservice.GetCourses(currentStudentId);
        }

      
    }
}
