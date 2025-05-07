using IS_lab8.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace IS_lab8.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IS_lab8.Model;
using IS_lab8.Services;

[Route("api/[controller]")]
[ApiController]

public class UsersController : ControllerBase
{
    private IUserService userService;

    public UsersController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpPost("authenticate")]
    public IActionResult
        Authenticate(AuthenticationRequest request)
    {
        var response = userService.Authenticate(request);
        if (response == null)
            return BadRequest(new { message = "Username or password is incorrect" });
        return Ok(response);
    }

    [Authorize(Roles = "admin", AuthenticationSchemes =
        JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet("getallusers")]
    public IActionResult Get()
    {
        return Ok(userService.GetUsers());
    }

    [Authorize(Roles = "user", AuthenticationSchemes =
        JwtBearerDefaults.AuthenticationScheme)]
    [HttpGet("getregisteredusers")]
    public IActionResult GetRegisteredUsers()
    {
        return Ok(userService.GetUsers());
    }

}