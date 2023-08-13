using NETCoreHipster.Domain.Entities;
using MediatR;
using NETCoreHipster.Dto;
using System.Security.Claims;

namespace NETCoreHipster.Application.Commands;

public class AccountGetAuthenticatedQuery : IRequest<string>
{
    public ClaimsPrincipal User { get; set; }
}
