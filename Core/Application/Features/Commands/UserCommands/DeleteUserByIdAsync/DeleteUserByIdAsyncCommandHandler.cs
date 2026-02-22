using Application.Interfaces;
using MediatR;

namespace Application.Features.Commands.UserCommands.DeleteUserByIdAsync
{
    public class DeleteUserByIdAsyncCommandHandler: IRequestHandler<DeleteUserByIdAsyncCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserByIdAsyncCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(
            DeleteUserByIdAsyncCommand req,
            CancellationToken cancellationToken
        )
        {
            var user = await _userRepository.GetUserById(req.Id);
            if(user == null)throw new KeyNotFoundException($"User Id {req.Id} did not found!");
            await _userRepository.DeleteUserByIdAsync(user);
            
            return req.Id;
        }
    }
}