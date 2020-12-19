using System;
using System.Collections.Generic;

namespace Domain
{
    public class MeetingRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<TeacherMeetingsRequests> TeacherMeetingsRequests { get; set; }
        public ICollection<ParentMeetingsRequests> ParentMeetingsRequests { get; set; }
    }
}