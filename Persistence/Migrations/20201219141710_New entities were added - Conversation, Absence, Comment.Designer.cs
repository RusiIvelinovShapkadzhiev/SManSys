﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201219141710_New entities were added - Conversation, Absence, Comment")]
    partial class NewentitieswereaddedConversationAbsenceComment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Absense", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Absense");
                });

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

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("MeetingRequests");
                });

            modelBuilder.Entity("Domain.Parent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

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

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("TeacherId");

                    b.HasIndex("UserId")
                        .IsUnique();

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

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Absense", b =>
                {
                    b.HasOne("Domain.Parent", "Parent")
                        .WithMany("Absence")
                        .HasForeignKey("ParentId");

                    b.HasOne("Domain.Student", "Student")
                        .WithMany("Absence")
                        .HasForeignKey("StudentId");

                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.MeetingRequest", b =>
                {
                    b.HasOne("Domain.Student", "Student")
                        .WithMany("MeetingRequests")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.Parent", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithOne("Parent")
                        .HasForeignKey("Domain.Parent", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.ParentChildren", b =>
                {
                    b.HasOne("Domain.Parent", "Parent")
                        .WithMany("ParentChildren")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Student", "Student")
                        .WithMany("ParentChildren")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Domain.ParentMeetingsRequests", b =>
                {
                    b.HasOne("Domain.MeetingRequest", "MeetingRequest")
                        .WithMany("ParentMeetingsRequests")
                        .HasForeignKey("MeetingRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Parent", "Parent")
                        .WithMany("ParentMeetingsRequests")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
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

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("Domain.Teacher", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.TeacherMeetingsRequests", b =>
                {
                    b.HasOne("Domain.MeetingRequest", "MeetingRequest")
                        .WithMany("TeacherMeetingsRequests")
                        .HasForeignKey("MeetingRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithMany("TeacherMeetingsRequests")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeetingRequest");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.TeachersGrades", b =>
                {
                    b.HasOne("Domain.Grade", "Grade")
                        .WithMany("TeachersGrades")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithMany("TeacherGrades")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
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
                    b.Navigation("Absence");

                    b.Navigation("ParentChildren");

                    b.Navigation("ParentMeetingsRequests");
                });

            modelBuilder.Entity("Domain.Student", b =>
                {
                    b.Navigation("Absence");

                    b.Navigation("MeetingRequests");

                    b.Navigation("ParentChildren");
                });

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.Navigation("Salutation");

                    b.Navigation("TeacherGrades");

                    b.Navigation("TeacherMeetingsRequests");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Navigation("Parent");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
