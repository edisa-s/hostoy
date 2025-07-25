using System;
using Domain;
using MediatR;
using Persistence;
using Application.Core;
using Application.Activities.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;



namespace Application.Activities.Queries;

public class GetActivityDetails
{
    public class Query : IRequest<Result<ActivityDto>>

    {
        public required string Id { get; set; }
    }

     public class Handler(AppDbContext context, IMapper mapper, IUserAccessor userAccessor) 
        : IRequestHandler<Query, Result<ActivityDto>>
    {
        public async Task<Result<ActivityDto>> Handle(Query request, CancellationToken cancellationToken)
        {
             var activity = await context.Activities
                .ProjectTo<ActivityDto>(mapper.ConfigurationProvider, 
                    new {currentUserId = userAccessor.GetUserId()})
                .FirstOrDefaultAsync(x => request.Id == x.Id, cancellationToken);

              if (activity == null) return Result<ActivityDto>.Failure("Appointment not found", 404);

              return Result<ActivityDto>.Success(activity);
        }
    }
}