using System;

namespace Domain
{
    public class TeacherClasses
    {
        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }
        public bool IsTeaching { get; set; }
    }
}