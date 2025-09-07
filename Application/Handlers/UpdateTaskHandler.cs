using CQRS.Example.Application.DTOs;
using CQRS.Example.Infraestructure;
using CQRS.Example.Infraestructure.Commands;
using MediatR;

namespace CQRS.Example.Application.Handlers
{
    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, TaskItemDto>
    {
        private readonly ApplicationDbContext _dbContext;
        public UpdateTaskHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TaskItemDto> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItem.FindAsync(request.Id);
            if (taskItem == null) return null;

            taskItem.Title = request.Title;
            taskItem.Description = request.Description;
            taskItem.IsCompleted = request.IsCompleted;
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
