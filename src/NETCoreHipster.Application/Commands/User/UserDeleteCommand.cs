using NETCoreHipster.Domain.Entities;
using MediatR;

namespace NETCoreHipster.Application.Commands;

public class UserDeleteCommand : IRequest<Unit>
{
    public string Login { get; set; }
}
