

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        // ,UserManager<AppUser> userManager)
        {
            if(!context.Teachers.Any())
            {
                var teachers = new List<Teacher>
                {
                    new Teacher
                    {
                        TeacherId = "a",
                        Name = "Ivan Petrov",
                        IsActive = true
                    },

                    new Teacher
                    {
                        TeacherId = "b",
                        Name = "Victoria Ivanova",
                        IsActive = true
                    },

                    new Teacher
                    {
                        TeacherId = "c",
                        Name = "Stoyan Simov",
                        IsActive = true
                    },
                };

                await context.Teachers.AddRangeAsync(teachers);
                await context.SaveChangesAsync();
            }

            if(!context.Grades.Any())
            {
                var grades = new List<Grade>
                {
                    new Grade 
                    {
                        Id = "a",
                        Name = "1st A",
                        StartDate = new DateTime(2020,9,15),
                        EndDate = new DateTime(2021,5,24),
                        TeachersGrades = new List<TeachersGrades>
                        {
                            new TeachersGrades
                            {
                                TeacherId = "a",
                                IsTeaching = true
                                
                            },

                            new TeachersGrades
                            {
                                TeacherId = "b",
                                IsTeaching = true
                                
                            },

                            new TeachersGrades
                            {
                                TeacherId = "c",
                                IsTeaching = true
                                
                            }
                        }
                    },
                    new Grade 
                    {
                        Id = "b",
                        Name = "1st B",
                        StartDate = new DateTime(2020,9,15),
                        EndDate = new DateTime(2021,5,24),
                        TeachersGrades = new List<TeachersGrades>
                        {
                            new TeachersGrades
                            {
                                TeacherId = "a",
                                IsTeaching = true
                                
                            },

                            new TeachersGrades
                            {
                                TeacherId = "b",
                                IsTeaching = true
                                
                            },

                            new TeachersGrades
                            {
                                TeacherId = "c",
                                IsTeaching = true
                                
                            }
                        }
                    }
                };

                await context.Grades.AddRangeAsync(grades);
                await context.SaveChangesAsync();
            }

            if(!context.Parents.Any())
            {
                var parents = new List<Parent>
                {
                    new Parent 
                    {
                        Id = "a",
                        Name = "Kaloyan Kaloyanov"
                    },
                    new Parent 
                    {
                        Id = "b",
                        Name = "Desislava Ivanova"
                    }
                };

                await context.Parents.AddRangeAsync(parents);
                await context.SaveChangesAsync();
            }
            
            if(!context.Students.Any())
            {
                var students = new List<Student>
                {
                    new Student 
                    {
                        Id = "a",
                        Name = "Ivan Dimitrov",
                        GradeId = "a",
                        IsActive = true,
                        ParentChildren = new List<ParentChildren>
                        {
                            new ParentChildren
                            {
                                ParentId = "a",
                                StudentId = "a"
                            },
                            new ParentChildren
                            {
                                ParentId = "b",
                                StudentId = "a"
                            }

                        }
                    },
                    new Student 
                    {
                        Id = "b",
                        Name = "Mihail Stoyanov",
                        GradeId = "b",
                        IsActive = true
                    },
                    new Student 
                    {
                        Id = "c",
                        Name = "Dimitur Petrov",
                        GradeId = "a",
                        IsActive = true
                    },
                };

                await context.Students.AddRangeAsync(students);
                await context.SaveChangesAsync();
            }
            
        }
        
    }
}