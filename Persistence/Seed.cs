

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
            if(!context.MeetingRequests.Any())
            {
                var requests = new List<MeetingRequest>
                {
                    new MeetingRequest
                    {
                        Id = "a",
                        Title = "Discipline",
                        StartDate = DateTime.Now.AddDays(5),
                        EndDate = DateTime.Now.AddDays(5).AddHours(1)
                    },
                    new MeetingRequest
                    {
                        Id = "d",
                        Title = "Sport",
                        StartDate = DateTime.Now.AddDays(5),
                        EndDate = DateTime.Now.AddDays(5).AddHours(1)
                    },
                    new MeetingRequest
                    {
                        Id = "b",
                        Title = "English",
                        StartDate = DateTime.Now.AddDays(5),
                        EndDate = DateTime.Now.AddDays(5).AddHours(1)
                    },
                    new MeetingRequest
                    {
                        Id = "c",
                        Title = "Absence",
                        StartDate = DateTime.Now.AddDays(5),
                        EndDate = DateTime.Now.AddDays(5).AddHours(1)
                    }
                };

                await context.MeetingRequests.AddRangeAsync(requests);
                await context.SaveChangesAsync();
            }

            // if(!context.Conversations.Any())
            // {
            //     var conversations = new List<Conversation>
            //     {
            //         new Conversation
            //         {
            //             Id = "a",
            //             Title = "Ivan Discipline",
            //             MeetingRequestId = "a",
            //             Teachers = new List<Teacher>
            //             {

            //             },
            //             ParentId = "a"
            //         },
            //          new Absense
            //         {
            //             Id = "b",
            //             Reason = "Leave abroad",
            //             StartDate = DateTime.Now.AddDays(2),
            //             EndDate = DateTime.Now.AddDays(7),
            //             Notes = "Going to France",
            //             StudentId = "a",
            //             ParentId = "b"
            //         }
            //     };

            //     await context.Absences.AddRangeAsync(absences);
            //     await context.SaveChangesAsync();
            // }
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
                        IsActive = true,
                        TeacherMeetingsRequests = new List<TeacherMeetingsRequests>
                        {
                            new TeacherMeetingsRequests
                            {
                                MeetingRequestId = "d"
                            },
                            new TeacherMeetingsRequests
                            {
                                MeetingRequestId = "c"
                            }
                        }
                    },

                    new Teacher
                    {
                        TeacherId = "c",
                        Name = "Stoyan Simov",
                        IsActive = true,
                        TeacherMeetingsRequests = new List<TeacherMeetingsRequests>
                        {
                            new TeacherMeetingsRequests
                            {
                                MeetingRequestId = "a"
                            },
                            new TeacherMeetingsRequests
                            {
                                MeetingRequestId = "b"
                            }
                        }
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
                        TeacherGrades = new List<TeacherGrades>
                        {
                            new TeacherGrades
                            {
                                TeacherId = "a",
                                IsTeaching = true
                                
                            },

                            new TeacherGrades
                            {
                                TeacherId = "b",
                                IsTeaching = true
                                
                            },

                            new TeacherGrades
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
                        TeacherGrades = new List<TeacherGrades>
                        {
                            new TeacherGrades
                            {
                                TeacherId = "a",
                                IsTeaching = true
                                
                            },

                            new TeacherGrades
                            {
                                TeacherId = "b",
                                IsTeaching = true
                                
                            },

                            new TeacherGrades
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
                        Name = "Kaloyan Kaloyanov",
                        ParentMeetingsRequests = new List<ParentMeetingsRequests>
                        {
                            new ParentMeetingsRequests
                            {
                                MeetingRequestId = "a"
                            },
                            new ParentMeetingsRequests
                            {
                                MeetingRequestId = "b"
                            },
                        }
                    },
                    new Parent 
                    {
                        Id = "b",
                        Name = "Desislava Ivanova",
                        ParentMeetingsRequests = new List<ParentMeetingsRequests>
                        {
                            new ParentMeetingsRequests
                            {
                                MeetingRequestId = "d"
                            },
                            new ParentMeetingsRequests
                            {
                                MeetingRequestId = "c"
                            },
                        }
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
             if(!context.Absences.Any())
            {
                var absences = new List<Absense>
                {
                    new Absense
                    {
                        Id = "a",
                        Reason = "Sick leave",
                        StartDate = DateTime.Now.AddDays(2),
                        EndDate = DateTime.Now.AddDays(7),
                        Notes = "It is normal fly",
                        StudentId = "a",
                        ParentId = "a"
                    },
                     new Absense
                    {
                        Id = "b",
                        Reason = "Leave abroad",
                        StartDate = DateTime.Now.AddDays(2),
                        EndDate = DateTime.Now.AddDays(7),
                        Notes = "Going to France",
                        StudentId = "a",
                        ParentId = "b"
                    }
                };

                await context.Absences.AddRangeAsync(absences);
                await context.SaveChangesAsync();
            } 
        }
        
    }
}