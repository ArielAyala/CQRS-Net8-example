using CQRS.Example.Application.DTOs;
using CQRS.Example.Infraestructure;
using CQRS.Example.Infraestructure.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Example.Application.Handlers
{
    public class GetAllTasksHandler : IRequestHandler<GetAllTasksQuery, IEnumerable<TaskItemDto>>
    {
        private readonly ApplicationDbContext _dbContext;
        public GetAllTasksHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TaskItemDto>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.TaskItem
                .Select(task => new TaskItemDto
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    IsCompleted = task.IsCompleted
                })
                .ToListAsync(cancellationToken);
        }
    }
}
