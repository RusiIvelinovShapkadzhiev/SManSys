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
    public class OwnGradesList
    {
        public class Query : IRequest<List<Grade>>
        {
            public string TeacherId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Grade>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Grade>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await (from g in _context.Grades
                join tg in _context.TeacherGrades on g.Id equals tg.GradeId
                join t in  _context.Teachers on tg.TeacherId equals t.TeacherId
                where t.TeacherId == request.TeacherId && tg.IsTeaching
                select g
                ).ToListAsync(cancellationToken);
            }
        }
    }
}