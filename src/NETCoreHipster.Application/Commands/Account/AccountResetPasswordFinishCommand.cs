using NETCoreHipster.Domain.Entities;
using MediatR;
using NETCoreHipster.Dto.Authentication;

namespace NETCoreHipster.Application.Commands;

public class AccountResetPasswordFinishCommand : IRequest<User>
{
    public KeyAndPasswordDto KeyAndPasswordDto { get; set; }
}
