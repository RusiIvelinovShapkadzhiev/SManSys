using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Teachers;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TeachersController : BaseController
    {
        [HttpGet("/gradeList")]
        public async Task<ActionResult<List<Grade>>> GetAllGrades()
        {
            return await Mediator.Send(new OwnGradesList.Query{TeacherId = "a"});
        }

        [HttpGet("/studentList")]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return await Mediator.Send(new OwnStudentsList.Query{Id = "a"});
        }

        [HttpGet("/requestsList")]
        public async Task<ActionResult<List<MeetingRequest>>> GetAllRequest()
        {
            return await Mediator.Send(new OwnRequestsList.Query{TeacherId = "b"});
        }

        [HttpGet("/teacherList")]
        public async Task<ActionResult<List<Teacher>>> GetAllTeachers()
        {
            return await Mediator.Send(new ListOfTeachers.Query());
        }

        [HttpGet("/gradeStudents/{id}")]
        public async Task<ActionResult<List<Student>>> GetGradeStudents(string gradeId)
        {
            return await Mediator.Send(new GradeStudents.Query{GradeId = gradeId});
        }

        [HttpGet("/gradeParents/{id}")]
        public async Task<ActionResult<List<Parent>>> GetGradeParents(string gradeId)
        {
            return await Mediator.Send(new GradeParents.Query{GradeId = gradeId});
        }

    }
}