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
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<TeacherClasses> TeacherClasses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TeacherClasses>(x => x.HasKey(tc =>
               new {tc.TeacherId, tc.SchoolClassId}));
            
            builder.Entity<TeacherClasses>()
                .HasOne(t => t.Teacher)
                .WithMany(c => c.TeacherClasses)
                .HasForeignKey(t => t.TeacherId);
                // .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<TeacherClasses>()
                .HasOne(c => c.SchoolClass)
                .WithMany(t => t.TeacherClasses)
                .HasForeignKey(c => c.SchoolClassId);
                // .OnDelete(DeleteBehavior.NoAction);
        }
    }
}