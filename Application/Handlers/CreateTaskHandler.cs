using CQRS.Example.Application.DTOs;
using CQRS.Example.Domain;
using CQRS.Example.Infraestructure;
using CQRS.Example.Infraestructure.Commands;
using MediatR;

namespace CQRS.Example.Application.Handlers
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;
        public CreateTaskHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = new TaskItem
            {
                Title = request.Title,
                Description = request.Description,
            };
            _dbContext.TaskItem.Add(taskItem);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return new TaskItemDto
            {
                Id = taskItem.Id,
                Title = taskItem.Title,
                Description = taskItem.Description,
                IsCompleted = taskItem.IsCompleted,
            };
        }
    }
}
