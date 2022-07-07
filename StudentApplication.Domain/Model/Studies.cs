using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Studies : DomainObject
    {
        public string NameStudy { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }

        public Studies()
        {
            Students = new HashSet<Students>();
            Courses = new HashSet<Courses>();

        }



    }
}
