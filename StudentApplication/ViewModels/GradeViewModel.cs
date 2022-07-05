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
        private List<Grades> _currentGrades;  
    

        public GradeViewModel()
        {
            _currentGrades = LoadGrades();
            
        }

        public List<Grades> CurrentGrades
        {
            get { return _currentGrades; }
            set { _currentGrades = value; onPropertyChanged(); }
        }

        public List<Grades> LoadGrades()
        {

            IDataService<Grades> gradesservice = new GenericDataService<Grades>(new SMDbContextFactory());
            return gradesservice.GetGrades(1);

        }

  

    }
}
