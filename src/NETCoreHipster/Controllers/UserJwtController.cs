using MediatR;
using NETCoreHipster.Dto;
using NETCoreHipster.Security.Jwt;
using NETCoreHipster.Domain.Services.Interfaces;
using NETCoreHipster.Dto.Authentication;
using NETCoreHipster.Web.Extensions;
using NETCoreHipster.Web.Filters;
using NETCoreHipster.Crosscutting.Constants;
using NETCoreHipster.Application.Queries;
using NETCoreHipster.Application.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NETCoreHipster.Controllers;

[Route("api")]
[ApiController]
public class UserJwtController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ITokenProvider _tokenProvider;

    public UserJwtController(IMediator mediator, ITokenProvider tokenProvider)
    {
        _mediator = mediator;
        _tokenProvider = tokenProvider;
    }

    [HttpPost("authenticate")]
    [ValidateModel]
    public async Task<ActionResult<JwtToken>> Authorize([FromBody] LoginDto loginDto)
    {
        var user = await _mediator.Send(new UserJwtAuthorizeCommand { LoginDto = loginDto });
        var rememberMe = loginDto.RememberMe;
        var jwt = _tokenProvider.CreateToken(user, rememberMe);
        var httpHeaders = new HeaderDictionary
        {
            [JwtConstants.AuthorizationHeader] = $"{JwtConstants.BearerPrefix} {jwt}"
        };
        return Ok(new JwtToken(jwt)).WithHeaders(httpHeaders);
    }
}

public class JwtToken
{
    public JwtToken(string idToken)
    {
        IdToken = idToken;
    }

    [JsonProperty("id_token")] private string IdToken { get; }
}
