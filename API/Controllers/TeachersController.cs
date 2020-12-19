using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Teachers;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeachersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("/gradeList")]
        public async Task<ActionResult<List<Grade>>> GetAllGrades()
        {
            return await _mediator.Send(new OwnGradesList.Query{TeacherId = "a"});
        }
       

        [HttpGet]
        [Route("/studentList")]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return await _mediator.Send(new OwnStudentsList.Query{Id = "a"});
        }

        [HttpGet]
        [Route("/teacherList")]
        public async Task<ActionResult<List<Teacher>>> GetAllTeachers()
        {
            return await _mediator.Send(new ListOfTeachers.Query());
        }

        [HttpGet("/gradeStudents/{id}")]
        public async Task<ActionResult<List<Student>>> GetGradeStudents(string gradeId)
        {
            return await _mediator.Send(new GradeStudents.Query{GradeId = gradeId});
        }

        [HttpGet("/gradeParents/{id}")]
        public async Task<ActionResult<List<Parent>>> GetGradeParents(string gradeId)
        {
            return await _mediator.Send(new GradeParents.Query{GradeId = gradeId});
        }

    }
}