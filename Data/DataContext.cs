using Microsoft.EntityFrameworkCore;
using ParonAPI.Models;
using System.Reflection.Metadata;

namespace ParonAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<FeedPost> FeedPosts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //set primary key(s) for tables:
            modelBuilder.Entity<User>()
                .HasKey(usr => new { usr.Username });
            modelBuilder.Entity<Semester>()
                .HasKey(sem => new { sem.Id });
            modelBuilder.Entity<Lesson>()
                .HasKey(lsn => new { lsn.Id });
            modelBuilder.Entity<Group>()
                .HasKey(grp => new { grp.Id });
            modelBuilder.Entity<Student>()
                .HasKey(stnt => new { stnt.Id });
            modelBuilder.Entity<Period>()
                .HasKey(per => new { per.Id });
            modelBuilder.Entity<School>()
                .HasKey(sch => new { sch.Id });
            modelBuilder.Entity<Day>()
                .HasKey(day => new { day.Id });
            modelBuilder.Entity<Date>()
                .HasKey(dte => new { dte.Id });
            modelBuilder.Entity<FeedPost>()
            .HasKey(pst => new { pst.Username, pst.DateTimePosted });
            modelBuilder.Entity<Attendance>()
                .HasKey(atn => new { atn.DateId, atn.PeriodId, atn.StudentId});
            modelBuilder.Entity<ScheduleItem>()
                .HasKey(scd => new { scd.PeriodId, scd.LessonId, scd.TeacherUsername, scd.DayId });

            //set relationships between tables:
            modelBuilder.Entity<Day>()
                .HasMany(d => d.Dates)
                .WithOne(d => d.Day)
                .HasForeignKey(d => d.DayId);

            modelBuilder.Entity<Semester>()
                .HasMany(s => s.Dates)
                .WithOne(s => s.Semester)
                .HasForeignKey(s => s.SemesterId);

            modelBuilder.Entity<User>()
                .HasMany(f => f.FeedPosts)
                .WithOne(f => f.User)
                .HasForeignKey(f => f.Username);

            modelBuilder.Entity<Period>()
                .HasMany(p => p.ScheduleItems)
                .WithOne(p => p.Period)
                .HasForeignKey(p => p.PeriodId);

            modelBuilder.Entity<Lesson>()
                .HasOne(p => p.ScheduleItem)
                .WithOne(p => p.Lesson)
                .HasForeignKey<ScheduleItem>(p => p.LessonId);

            modelBuilder.Entity<Group>()
                .HasMany(p => p.ScheduleItems)
                .WithOne(p => p.Group)
                .HasForeignKey(p => p.GroupId);

            modelBuilder.Entity<Day>()
                .HasOne(p => p.ScheduleItem)
                .WithOne(p => p.Day)
                .HasForeignKey<ScheduleItem>(p => p.DayId);

            modelBuilder.Entity<User>()
                .HasMany(p => p.ScheduleItems)
                .WithOne(p => p.Teacher)
                .HasForeignKey(p => p.TeacherUsername);

            modelBuilder.Entity<School>()
                .HasMany(s => s.Groups)
                .WithOne(s => s.School)
                .HasForeignKey(s => s.SchoolId);

            modelBuilder.Entity<School>()
                .HasMany(s => s.Staff)
                .WithOne(s => s.School)
                .HasForeignKey(s => s.SchoolId);

            modelBuilder.Entity<Date>()
                .HasMany(s => s.Attendances)
                .WithOne(s => s.Date)
                .HasForeignKey(s => s.DateId);

            modelBuilder.Entity<Period>()
                .HasMany(s => s.Attendances)
                .WithOne(s => s.Period)
                .HasForeignKey(s => s.PeriodId);

            modelBuilder.Entity<Group>()
                .HasMany(s => s.Attendances)
                .WithOne(s => s.Group)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Attendances)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Group>()
               .HasMany(s => s.Students)
               .WithOne(s => s.Group)
               .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<User>()
               .HasOne(s => s.Group)
               .WithOne(s => s.TeacherRep)
               .HasForeignKey<Group>(s => s.TeacherRepUsername);
        }
    }
}
