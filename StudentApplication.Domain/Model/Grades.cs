using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Grades : DomainObject
    {

        public int StudentId { get; set; }
        public int TestId { get; set; }
        public int GradeValue { get; set; }


    }
}
