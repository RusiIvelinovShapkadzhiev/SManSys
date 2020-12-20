using System;
using System.Collections.Generic;

namespace Domain
{
    public class Grade
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<TeacherGrades> TeacherGrades { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}