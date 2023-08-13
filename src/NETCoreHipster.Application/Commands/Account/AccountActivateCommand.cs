using NETCoreHipster.Domain.Entities;
using MediatR;

namespace NETCoreHipster.Application.Commands;

public class AccountActivateCommand : IRequest<User>
{
    public string Key { get; set; }
}
