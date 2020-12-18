using System;

namespace Domain
{
    public class TeacherMeetingsRequests
    {
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public string MeetingRequestId { get; set; }
        public MeetingRequest MeetingRequest { get; set; }
    }
}