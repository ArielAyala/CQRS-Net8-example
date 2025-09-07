using CQRS.Example.Infraestructure;
using CQRS.Example.Infraestructure.Commands;
using MediatR;

namespace CQRS.Example.Application.Handlers
{
    public class DeleteTaskHandler: IRequestHandler<DeleteTaskCommand, bool>
    {
        private readonly ApplicationDbContext _dbContext;
        public DeleteTaskHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var taskItem = await _dbContext.TaskItem.FindAsync(
                [request.Id], cancellationToken);
            if (taskItem == null) return false;

            _dbContext.TaskItem.Remove(taskItem);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
