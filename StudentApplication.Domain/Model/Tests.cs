using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Tests : DomainObject
    {

        public int CourseId { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }

        public Tests()
        {
            Grades = new HashSet<Grades>();

        }

    }
}
