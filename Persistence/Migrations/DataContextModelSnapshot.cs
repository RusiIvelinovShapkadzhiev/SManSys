﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Grade", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Domain.MeetingRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MeetingRequests");
                });

            modelBuilder.Entity("Domain.Parent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("Domain.ParentChildren", b =>
                {
                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("ParentId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("ParentChildrens");
                });

            modelBuilder.Entity("Domain.ParentMeetingsRequests", b =>
                {
                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MeetingRequestId")
                        .HasColumnType("TEXT");

                    b.HasKey("ParentId", "MeetingRequestId");

                    b.HasIndex("MeetingRequestId");

                    b.ToTable("ParentMeetingRequests");
                });

            modelBuilder.Entity("Domain.Salutation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("Salutaions");
                });

            modelBuilder.Entity("Domain.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("GradeId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Domain.TeacherMeetingsRequests", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<string>("MeetingRequestId")
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId", "MeetingRequestId");

                    b.HasIndex("MeetingRequestId");

                    b.ToTable("TeacherMeetingsRequests");
                });

            modelBuilder.Entity("Domain.TeachersGrades", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GradeId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTeaching")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "GradeId");

                    b.HasIndex("GradeId");

                    b.ToTable("TeacherGrades");
                });

            modelBuilder.Entity("Domain.ParentChildren", b =>
                {
                    b.HasOne("Domain.Parent", "Parent")
                        .WithMany("ParentChildren")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Student", "Student")
                        .WithMany("ParentChildren")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.ParentMeetingsRequests", b =>
                {
                    b.HasOne("Domain.MeetingRequest", "MeetingRequest")
                        .WithMany("ParentMeetingsRequests")
                        .HasForeignKey("MeetingRequestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Parent", "Parent")
                        .WithMany("ParentMeetingsRequests")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MeetingRequest");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Domain.Salutation", b =>
                {
                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithOne("Salutation")
                        .HasForeignKey("Domain.Salutation", "TeacherId");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.Student", b =>
                {
                    b.HasOne("Domain.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId");

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("Domain.TeacherMeetingsRequests", b =>
                {
                    b.HasOne("Domain.MeetingRequest", "MeetingRequest")
                        .WithMany("TeacherMeetingsRequests")
                        .HasForeignKey("MeetingRequestId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithMany("TeacherMeetingsRequests")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MeetingRequest");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.TeachersGrades", b =>
                {
                    b.HasOne("Domain.Grade", "Grade")
                        .WithMany("TeachersGrades")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithMany("TeacherGrades")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Grade");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.Grade", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("TeachersGrades");
                });

            modelBuilder.Entity("Domain.MeetingRequest", b =>
                {
                    b.Navigation("ParentMeetingsRequests");

                    b.Navigation("TeacherMeetingsRequests");
                });

            modelBuilder.Entity("Domain.Parent", b =>
                {
                    b.Navigation("ParentChildren");

                    b.Navigation("ParentMeetingsRequests");
                });

            modelBuilder.Entity("Domain.Student", b =>
                {
                    b.Navigation("ParentChildren");
                });

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.Navigation("Salutation");

                    b.Navigation("TeacherGrades");

                    b.Navigation("TeacherMeetingsRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
