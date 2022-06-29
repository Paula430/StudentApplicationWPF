using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Schools : DomainObject
    {


        public string NameSchool { get; set; }
        public virtual ICollection<Students> Students { get; set; }

        public Schools()
        {
            Students = new HashSet<Students>();
        }
    }
}
