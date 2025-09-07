using MediatR;

namespace CQRS.Example.Infraestructure.Commands
{
    public record DeleteTaskCommand(int Id) : IRequest<bool>;
}
