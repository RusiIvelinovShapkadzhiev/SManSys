using System;

namespace Domain
{
    public class TeachersGrades
    {
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public string GradeId { get; set; }
        public Grade Grade { get; set; }
        public bool IsTeaching { get; set; }
    }
}