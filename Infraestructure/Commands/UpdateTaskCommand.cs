using CQRS.Example.Application.DTOs;
using MediatR;

namespace CQRS.Example.Infraestructure.Commands
{
    public record UpdateTaskCommand(int Id, string Title, string Description, bool IsCompleted)
    : IRequest<TaskItemDto>;
}
