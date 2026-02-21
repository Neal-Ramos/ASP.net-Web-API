using Application.DTOs.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Commands.UserCommands.CreateUserAsync
{
    public class CreateUserCommandHandler: IRequestHandler<CreateUserCommand, UserDto>
    {
        private IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(
            CreateUserCommand req,
            CancellationToken cancellationToken
        )
        {
            var newUser = new User(name: req.Name);

            await _userRepository.CreateUserAsync(newUser);

            return new UserDto
            {
                Id = newUser.Id,
                Name = newUser.Name
            };
        }
    }
}