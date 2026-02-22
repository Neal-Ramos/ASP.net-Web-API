using Application.Features.Commands.UserCommands.CreateUserAsync;
using Application.Features.Commands.UserCommands.DeleteUserByIdAsync;
using Application.Features.Queries.GetAllUserQueries;
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

        [HttpDelete("DeleteUserById")]
        public async Task<IActionResult> DeleteUserById(DeleteUserByIdAsyncCommand command)
        {
            var delete = await _mediatR.Send(command);
            return Ok(delete);
        }

        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAllUser(GetAllUserCommand command)
        {
            var userList = await _mediatR.Send(command);
            return Ok(userList);
        }
    }
}