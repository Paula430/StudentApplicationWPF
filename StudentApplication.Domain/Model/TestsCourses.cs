using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class TestsCourses: DomainObject
    {
        public string CourseName { get; set; }
        public string testNote { get; set; }
        public string TestDate { get; set; }
        public int StudyId { get; set; }

    }
}
