using CQRS.Example.Application.DTOs;
using CQRS.Example.Infraestructure;
using CQRS.Example.Infraestructure.Queries;
using MediatR;

namespace CQRS.Example.Application.Handlers
{
    public class GetTaskByIdHandler : IRequestHandler<GetTaskByIdQuery, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetTaskByIdHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto?> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItem.FindAsync(
                new object[] { request.Id }, cancellationToken
            );

            if (taskItem == null)
            {
                return null;
            }

            return new TaskItemDto
            {
                Id = taskItem.Id,
                Title = taskItem.Title,
                Description = taskItem.Description,
                IsCompleted = taskItem.IsCompleted
            };
        }
    }
}
