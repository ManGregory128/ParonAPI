﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParonAPI.Data;

#nullable disable

namespace ParonAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParonAPI.Models.Attendance", b =>
                {
                    b.Property<DateTime>("DateId")
                        .HasColumnType("datetime2");

                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.HasKey("DateId", "PeriodId", "StudentId");

                    b.HasIndex("GroupId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("ParonAPI.Models.Date", b =>
                {
                    b.Property<DateTime>("Id")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("HolidayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHoliday")
                        .HasColumnType("bit");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("SemesterId");

                    b.ToTable("Dates");
                });

            modelBuilder.Entity("ParonAPI.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsWorkDay")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("ParonAPI.Models.FeedPost", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTimePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username", "DateTimePosted");

                    b.ToTable("FeedPosts");
                });

            modelBuilder.Entity("ParonAPI.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherRepUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("TeacherRepUsername")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ParonAPI.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ParonAPI.Models.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanBeDouble")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("ParonAPI.Models.ScheduleItem", b =>
                {
                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("PeriodId", "LessonId", "TeacherUsername", "DayId");

                    b.HasIndex("DayId")
                        .IsUnique();

                    b.HasIndex("GroupId");

                    b.HasIndex("LessonId")
                        .IsUnique();

                    b.HasIndex("TeacherUsername");

                    b.ToTable("ScheduleItems");
                });

            modelBuilder.Entity("ParonAPI.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("ParonAPI.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("ParonAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherPhone")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherPhone")
                        .HasColumnType("int");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("ThirdName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ThirdPhone")
                        .HasColumnType("int");

                    b.Property<string>("ThirdRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ParonAPI.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Username");

                    b.HasIndex("SchoolId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ParonAPI.Models.Attendance", b =>
                {
                    b.HasOne("ParonAPI.Models.Date", "Date")
                        .WithMany("Attendances")
                        .HasForeignKey("DateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Group", "Group")
                        .WithMany("Attendances")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Period", "Period")
                        .WithMany("Attendances")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Date");

                    b.Navigation("Group");

                    b.Navigation("Period");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ParonAPI.Models.Date", b =>
                {
                    b.HasOne("ParonAPI.Models.Day", "Day")
                        .WithMany("Dates")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Semester", "Semester")
                        .WithMany("Dates")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("ParonAPI.Models.FeedPost", b =>
                {
                    b.HasOne("ParonAPI.Models.User", "User")
                        .WithMany("FeedPosts")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ParonAPI.Models.Group", b =>
                {
                    b.HasOne("ParonAPI.Models.School", "School")
                        .WithMany("Groups")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.User", "TeacherRep")
                        .WithOne("Group")
                        .HasForeignKey("ParonAPI.Models.Group", "TeacherRepUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("TeacherRep");
                });

            modelBuilder.Entity("ParonAPI.Models.ScheduleItem", b =>
                {
                    b.HasOne("ParonAPI.Models.Day", "Day")
                        .WithOne("ScheduleItem")
                        .HasForeignKey("ParonAPI.Models.ScheduleItem", "DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Group", "Group")
                        .WithMany("ScheduleItems")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Lesson", "Lesson")
                        .WithOne("ScheduleItem")
                        .HasForeignKey("ParonAPI.Models.ScheduleItem", "LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.Period", "Period")
                        .WithMany("ScheduleItems")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.User", "Teacher")
                        .WithMany("ScheduleItems")
                        .HasForeignKey("TeacherUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Group");

                    b.Navigation("Lesson");

                    b.Navigation("Period");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ParonAPI.Models.Student", b =>
                {
                    b.HasOne("ParonAPI.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParonAPI.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("School");
                });

            modelBuilder.Entity("ParonAPI.Models.User", b =>
                {
                    b.HasOne("ParonAPI.Models.School", "School")
                        .WithMany("Staff")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("ParonAPI.Models.Date", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("ParonAPI.Models.Day", b =>
                {
                    b.Navigation("Dates");

                    b.Navigation("ScheduleItem")
                        .IsRequired();
                });

            modelBuilder.Entity("ParonAPI.Models.Group", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("ScheduleItems");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ParonAPI.Models.Lesson", b =>
                {
                    b.Navigation("ScheduleItem")
                        .IsRequired();
                });

            modelBuilder.Entity("ParonAPI.Models.Period", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("ScheduleItems");
                });

            modelBuilder.Entity("ParonAPI.Models.School", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ParonAPI.Models.Semester", b =>
                {
                    b.Navigation("Dates");
                });

            modelBuilder.Entity("ParonAPI.Models.Student", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("ParonAPI.Models.User", b =>
                {
                    b.Navigation("FeedPosts");

                    b.Navigation("Group");

                    b.Navigation("ScheduleItems");
                });
#pragma warning restore 612, 618
        }
    }
}
