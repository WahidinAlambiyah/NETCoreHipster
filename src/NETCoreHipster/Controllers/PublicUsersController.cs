using MediatR;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using JHipsterNet.Core.Pagination.Extensions;
using NETCoreHipster.Domain.Entities;
using NETCoreHipster.Security;
using NETCoreHipster.Domain.Services.Interfaces;
using NETCoreHipster.Dto;
using NETCoreHipster.Web.Extensions;
using NETCoreHipster.Web.Filters;
using NETCoreHipster.Web.Rest.Problems;
using NETCoreHipster.Web.Rest.Utilities;
using NETCoreHipster.Crosscutting.Constants;
using NETCoreHipster.Crosscutting.Exceptions;
using NETCoreHipster.Infrastructure.Web.Rest.Utilities;
using NETCoreHipster.Application.Queries;
using NETCoreHipster.Application.Commands;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NETCoreHipster.Controllers;


[Route("api/users")]
[ApiController]
public class PublicUsersController : ControllerBase
{
    private readonly ILogger<UsersController> _log;
    private readonly IMediator _mediator;

    public PublicUsersController(ILogger<UsersController> log, IMediator mediator)
    {
        _log = log;
        _mediator = mediator;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllPublicUsers(IPageable pageable)
    {
        _log.LogDebug("REST request to get a page of Users");
        (var headers, var userDtos) = await _mediator.Send(new UserGetAllPublicUsersQuery { Page = pageable });
        return Ok(userDtos).WithHeaders(headers);
    }

}
