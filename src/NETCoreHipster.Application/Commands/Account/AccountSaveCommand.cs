using MediatR;
using NETCoreHipster.Dto;
using System.Security.Claims;

namespace NETCoreHipster.Application.Commands;

public class AccountSaveCommand : IRequest<Unit>
{
    public ClaimsPrincipal User { get; set; }
    public UserDto UserDto { get; set; }
}
