using NETCoreHipster.Domain.Entities;
using MediatR;
using NETCoreHipster.Dto;

namespace NETCoreHipster.Application.Commands;

public class AccountCreateCommand : IRequest<User>
{
    public ManagedUserDto ManagedUserDto { get; set; }
}
