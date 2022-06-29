using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Students : DomainObject
    {

        public int SchoolId { get; set; }
        public int StudyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Grades> Grades { get; set; }

        public Students()
        {

            Grades = new HashSet<Grades>();

        }


    }
}
