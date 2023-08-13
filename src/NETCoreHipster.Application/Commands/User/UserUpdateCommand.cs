using NETCoreHipster.Domain.Entities;
using MediatR;
using NETCoreHipster.Dto;

namespace NETCoreHipster.Application.Commands;

public class UserUpdateCommand : IRequest<User>
{
    public UserDto UserDto { get; set; }
}
