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
    public class ListOfTeachers
    {
        public class Query : IRequest<List<Teacher>>
        {}

        public class Handler : IRequestHandler<Query, List<Teacher>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Teacher>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await (from t in _context.Teachers
                where t.IsActive select t).ToListAsync(cancellationToken);
            }
        }
    }
}