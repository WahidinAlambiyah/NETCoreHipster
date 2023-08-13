using MediatR;
using NETCoreHipster.Dto.Authentication;
using System.Security.Principal;

namespace NETCoreHipster.Application.Commands;

public class UserJwtAuthorizeCommand : IRequest<IPrincipal>
{
    public LoginDto LoginDto { get; set; }
}
