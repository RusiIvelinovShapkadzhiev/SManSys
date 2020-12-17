using System;

namespace Domain
{
    public class Salutation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}