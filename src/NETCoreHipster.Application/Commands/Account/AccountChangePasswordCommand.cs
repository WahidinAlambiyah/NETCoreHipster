using MediatR;
using NETCoreHipster.Dto.Authentication;

namespace NETCoreHipster.Application.Commands;

public class AccountChangePasswordCommand : IRequest<Unit>
{
    public PasswordChangeDto PasswordChangeDto { get; set; }
}
