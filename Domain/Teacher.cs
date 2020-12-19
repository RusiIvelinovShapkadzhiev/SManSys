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
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<TeachersGrades> TeacherGrades { get; set; }
        public ICollection<TeacherMeetingsRequests> TeacherMeetingsRequests { get; set; }
        public ICollection<TeachersConversations> TeachersConversations { get; set; }
    }
}