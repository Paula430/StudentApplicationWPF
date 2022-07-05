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
        private List<Tests> _currentTests;

        public TestViewModel()
        {
            _currentTests = LoadTests();
        }


        public List<Tests> CurrentTests
        {
            get { return _currentTests; }
            set { _currentTests = value; onPropertyChanged(); }
        }

        public List<Tests> LoadTests()
        {

            IDataService<Tests> testsservice = new GenericDataService<Tests>(new SMDbContextFactory());
            return testsservice.GetTests();

        }

    }
}
