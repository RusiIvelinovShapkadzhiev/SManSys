using System;
using System.Collections.Generic;

namespace Domain
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GradeId { get; set; }
        public Grade Grade { get; set; }
        public bool IsActive { get; set; }
        public ICollection<ParentChildren> ParentChildren { get; set; }
    }
}