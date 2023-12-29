using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PolyFood.Business.Service.IService;
using PolyFood.Common.Common;
using PolyFood.DTOs.Request;
using PolyFood.DTOs.Request.Authen;

namespace PolyFood.Controllers;

[Route(Constant.LinkRouter)]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AuthenticationController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult Login([FromForm] AuthenticationRequest request)
    {
        var result = _accountService.Login(request);
        return Ok(result);
    }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult Register(RegisterRequest request)
    {
        var result = _accountService.Register(request,Constant.Role.User);
        return Ok();
    }

    [HttpPut]
    [Authorize]
    public IActionResult ChangeStatus()
    {
        var username = HttpContext.User.FindFirst(Constant.ClaimType.Name).Value;
        var result = _accountService.ChangeStatus(username);
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateAdmin(RegisterRequest request)
    {
        var result = _accountService.Register(request, Constant.Role.Admin);
        return Ok();
    }
}