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
    public class TestViewModel: ObserveableObject
    {
        private int currentStudentId = 1;

        private List<TestsCourses> _currentTests;
        

        public TestViewModel()
        {
            _currentTests = LoadTestsCourses();
           
        }

        public List<TestsCourses> CurrentTests
        {
            get { return _currentTests; }
            set { _currentTests = value; onPropertyChanged(); }
        }

        

        public List<TestsCourses> LoadTestsCourses()
        {
            IDataService<Tests> testsservice = new GenericDataService<Tests>(new SMDbContextFactory());
            return testsservice.GetTestsCourses(currentStudentId);
        }

     


    }
}


