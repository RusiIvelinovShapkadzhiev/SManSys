using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Salutation> Salutaions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<TeacherGrades> TeacherGrades { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<MeetingRequest> MeetingRequests { get; set; }
        public DbSet<ParentMeetingsRequests> ParentMeetingRequests { get; set; }
        public DbSet<ParentChildren> ParentChildrens { get; set; }
        public DbSet<TeacherMeetingsRequests> TeacherMeetingsRequests { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Absense> Absences { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Comment> Commnets { get; set; }
        public DbSet<ParentConversations> ParentConversations { get; set; }
        public DbSet<TeachersConversations> TeachersConversations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TeacherGrades>(x => x.HasKey(tc =>
               new {tc.TeacherId, tc.GradeId}));
            builder.Entity<TeacherGrades>()
                .HasOne(t => t.Teacher)
                .WithMany(c => c.TeacherGrades)
                .HasForeignKey(t => t.TeacherId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<TeacherGrades>()
                .HasOne(c => c.Grade)
                .WithMany(t => t.TeacherGrades)
                .HasForeignKey(c => c.GradeId);
                // .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ParentMeetingsRequests>(x => x.HasKey(pmr =>
               new {pmr.ParentId, pmr.MeetingRequestId}));
            builder.Entity<ParentMeetingsRequests>()
                .HasOne(p => p.Parent)
                .WithMany(pmr => pmr.ParentMeetingsRequests)
                .HasForeignKey(p => p.ParentId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ParentMeetingsRequests>()
                .HasOne(mr => mr.MeetingRequest)
                .WithMany(pmr => pmr.ParentMeetingsRequests)
                .HasForeignKey(mr => mr.MeetingRequestId);
                // .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<TeacherMeetingsRequests>(x => x.HasKey(tmr => 
                new {tmr.TeacherId, tmr.MeetingRequestId}));
            builder.Entity<TeacherMeetingsRequests>()
                .HasOne(t => t.Teacher)
                .WithMany(tmr => tmr.TeacherMeetingsRequests)
                .HasForeignKey(t => t.TeacherId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<TeacherMeetingsRequests>()
                .HasOne(mr => mr.MeetingRequest)
                .WithMany(tmr => tmr.TeacherMeetingsRequests)
                .HasForeignKey(mr => mr.MeetingRequestId);
                // .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<ParentChildren>(x => x.HasKey(pc =>
                new {pc.ParentId, pc.StudentId}));
            builder.Entity<ParentChildren>()
                .HasOne(p => p.Parent)
                .WithMany(pc => pc.ParentChildren)
                .HasForeignKey(p => p.ParentId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ParentChildren>()
                .HasOne(s => s.Student)
                .WithMany(pc => pc.ParentChildren)
                .HasForeignKey(s => s.StudentId);
                // .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<ParentConversations>(x => x.HasKey(pc =>
                new {pc.ParentId, pc.ConversationId}));
            builder.Entity<ParentConversations>()
                .HasOne(p => p.Parent)
                .WithMany(pc => pc.ParentConversations)
                .HasForeignKey(p => p.ParentId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ParentConversations>()
                .HasOne(c => c.Conversation)
                .WithMany(pc => pc.ParentConversations)
                .HasForeignKey(c => c.ConversationId);
                // .OnDelete(DeleteBehavior.NoAction);
            
            builder.Entity<TeachersConversations>(x => x.HasKey(pc =>
                new {pc.TeacherId, pc.ConversationId}));
            builder.Entity<TeachersConversations>()
                .HasOne(p => p.Teacher)
                .WithMany(tc => tc.TeachersConversations)
                .HasForeignKey(t => t.TeacherId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<TeachersConversations>()
                .HasOne(c => c.Conversation)
                .WithMany(tc => tc.TeachersConversations)
                .HasForeignKey(c => c.ConversationId);
                // .OnDelete(DeleteBehavior.NoAction);
        }
    }
}