using Application.Features.Commands.UserCommands.CreateUserAsync;
using Application.Features.Queries.UserQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediatR;

        public UserController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            var newUser = await _mediatR.Send(command);
            return Ok(newUser);
        }

        [HttpGet("GetUserById")]
        public async Task<IActionResult> GetUserById(GetUserByIdQuery command)
        {
            var user = await _mediatR.Send(command);
            return Ok(user);
        }
    }
}