using MediatR;
using NETCoreHipster.Dto;

namespace NETCoreHipster.Application.Commands;

public class AccountGetQuery : IRequest<UserDto>
{
}
