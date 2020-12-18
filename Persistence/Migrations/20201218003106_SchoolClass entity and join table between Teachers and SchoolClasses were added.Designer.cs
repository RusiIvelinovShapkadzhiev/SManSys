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
    [Migration("20201218003106_SchoolClass entity and join table between Teachers and SchoolClasses were added")]
    partial class SchoolClassentityandjointablebetweenTeachersandSchoolClasseswereadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Salutation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("Salutaions");
                });

            modelBuilder.Entity("Domain.SchoolClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SchoolClasses");
                });

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Domain.TeacherClasses", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SchoolClassId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTeaching")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeacherId", "SchoolClassId");

                    b.HasIndex("SchoolClassId");

                    b.ToTable("TeacherClasses");
                });

            modelBuilder.Entity("Domain.Salutation", b =>
                {
                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithOne("Salutation")
                        .HasForeignKey("Domain.Salutation", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.TeacherClasses", b =>
                {
                    b.HasOne("Domain.SchoolClass", "SchoolClass")
                        .WithMany("TeacherClasses")
                        .HasForeignKey("SchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Teacher", "Teacher")
                        .WithMany("TeacherClasses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolClass");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.SchoolClass", b =>
                {
                    b.Navigation("TeacherClasses");
                });

            modelBuilder.Entity("Domain.Teacher", b =>
                {
                    b.Navigation("Salutation");

                    b.Navigation("TeacherClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
