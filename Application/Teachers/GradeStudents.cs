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
    public class GradeStudents
    {
        public class Query : IRequest<List<Student>>
        {
            public string GradeId { get; set; }
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
                return await (from s in _context.Students
                where s.GradeId == request.GradeId select s
                ).ToListAsync(cancellationToken);
            }
        }
    }
}