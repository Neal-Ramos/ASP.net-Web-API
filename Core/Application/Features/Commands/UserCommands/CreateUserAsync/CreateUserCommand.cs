using Application.DTOs.User;
using MediatR;


namespace Application.Features.Commands.UserCommands.CreateUserAsync
{
    public record CreateUserCommand(string Name): IRequest<UserDto>;
}