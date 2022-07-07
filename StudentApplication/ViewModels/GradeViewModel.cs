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
  
    public class GradeViewModel : ObserveableObject
    {
        private int currentStudentId = 1;
        private List<GradeTestsCourses> _currentGrades;
        
        public GradeViewModel()
        {
            _currentGrades = LoadGradesTestsCourses(currentStudentId);
        }

        public List<GradeTestsCourses> CurrentGrades
        {
            get { return _currentGrades; }
            set { _currentGrades = value; onPropertyChanged(); }
        }

        public List<GradeTestsCourses> LoadGradesTestsCourses(int idStudent)
        {

            IDataService<GradeTestsCourses> gradesservice = new GenericDataService<GradeTestsCourses>(new SMDbContextFactory());
            return gradesservice.GetGradesTestsCourses(currentStudentId); 
                     

        }


    }
}
