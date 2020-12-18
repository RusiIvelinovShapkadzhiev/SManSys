using System;

namespace Domain
{
    public class Salutation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}