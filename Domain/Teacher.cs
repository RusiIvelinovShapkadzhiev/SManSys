using System;
using System.Collections.Generic;

namespace Domain
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual Salutation Salutation { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TeacherClasses> TeacherClasses { get; set; }
    }
}