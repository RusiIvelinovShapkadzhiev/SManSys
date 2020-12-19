using System;
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
    public class OwnRequestsList
    {
        public class Query : IRequest<List<MeetingRequest>>
        {
            public string TeacherId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<MeetingRequest>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<MeetingRequest>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await (from m in _context.MeetingRequests
                join tmr in _context.TeacherMeetingsRequests on m.Id equals tmr.MeetingRequestId
                where tmr.TeacherId == request.TeacherId && m.StartDate > DateTime.Now
                select m
                ).ToListAsync(cancellationToken);
            }
        }
    }
}