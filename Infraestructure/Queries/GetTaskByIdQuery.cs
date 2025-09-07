using CQRS.Example.Application.DTOs;
using MediatR;

namespace CQRS.Example.Infraestructure.Queries
{
    public record GetTaskByIdQuery(int Id): IRequest<TaskItemDto>;
}
