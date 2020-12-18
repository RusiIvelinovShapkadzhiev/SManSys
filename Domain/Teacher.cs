using System;
using System.Collections.Generic;

namespace Domain
{
    public class Teacher
    {
        public string TeacherId { get; set; }
        public string Name { get; set; }
        public Salutation Salutation { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TeachersGrades> TeacherGrades { get; set; }
        public ICollection<TeacherMeetingsRequests> TeacherMeetingsRequests { get; set; }
    }
}