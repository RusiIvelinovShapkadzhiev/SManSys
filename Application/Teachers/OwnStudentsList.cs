using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Teachers
{
    public class OwnStudentsList
    {
        public class Query : IRequest<List<Student>>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Student>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Student>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                var students = await (from t in _context.Teachers
                join tg in _context.TeacherGrades on t.TeacherId equals tg.TeacherId
                join g in  _context.Grades on tg.GradeId equals g.Id
                join s in _context.Students on g.Id equals s.GradeId
                where t.TeacherId == request.Id && tg.IsTeaching
                select s
                ).ToListAsync(cancellationToken);

                return students;
            }
        }
    }
}