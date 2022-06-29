﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication.Domain.Model
{
    public class Courses : DomainObject
    {

        public string CourseName { get; set; }
        public string BeginTime { get; set; }
        public string DayName { get; set; }
        public virtual ICollection<Tests> Tests { get; set; }


        public Courses()
        {

            Tests = new HashSet<Tests>();


        }
    }
}
