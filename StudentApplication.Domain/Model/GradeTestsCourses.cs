using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class GradeTestsCourses:DomainObject
    {

           public int StudentId { get; set; }
           public  int GradeValue { get; set; }
           public string TestNote { get; set; }
           public string CourseName { get; set; }


    }

}
