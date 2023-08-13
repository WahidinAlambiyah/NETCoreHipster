using NETCoreHipster.Dto;
using MediatR;

namespace NETCoreHipster.Application.Queries;

public class UserGetQuery : IRequest<UserDto>
{
    public string Login { get; set; }
}
