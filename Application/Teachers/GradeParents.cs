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
    public class GradeParents
    {
        public class Query : IRequest<List<Parent>>
        {
            public string GradeId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Parent>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Parent>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await (from p in _context.Parents
                join pc in _context.ParentChildrens on p.Id equals pc.ParentId
                join s in _context.Students on pc.StudentId equals s.Id
                where s.GradeId == request.GradeId && s.IsActive
                select p
                ).ToListAsync(cancellationToken);
            }
        }
    }
}