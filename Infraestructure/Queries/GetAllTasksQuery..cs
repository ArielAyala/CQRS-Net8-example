using CQRS.Example.Application.DTOs;
using MediatR;

namespace CQRS.Example.Infraestructure.Queries
{
    public record GetAllTasksQuery(): IRequest<IEnumerable<TaskItemDto>>;
}
