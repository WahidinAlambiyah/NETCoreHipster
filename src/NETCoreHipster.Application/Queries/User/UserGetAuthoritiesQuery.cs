using MediatR;
using System.Collections.Generic;

namespace NETCoreHipster.Application.Queries;

public class UserGetAuthoritiesQuery : IRequest<IEnumerable<string>>
{
}
