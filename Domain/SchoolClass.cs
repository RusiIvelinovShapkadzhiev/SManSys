using System;
using System.Collections.Generic;

namespace Domain
{
    public class SchoolClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<TeacherClasses> TeacherClasses { get; set; }
    }
}