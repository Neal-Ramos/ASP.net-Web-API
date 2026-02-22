using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries.GetAllUserQueries
{
    public class GetAllUserCommandHandler: IRequestHandler<GetAllUserCommand, List<User>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> Handle(
            GetAllUserCommand req,
            CancellationToken cancellationToken
        )
        {
            return await _userRepository.GetAllUser();
        }
    }
}