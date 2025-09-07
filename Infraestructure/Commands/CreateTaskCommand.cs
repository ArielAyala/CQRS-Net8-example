using CQRS.Example.Application.DTOs;
using MediatR;

namespace CQRS.Example.Infraestructure.Commands
{
    public record CreateTaskCommand(string Title, string Description)
        : IRequest<TaskItemDto>;
}
