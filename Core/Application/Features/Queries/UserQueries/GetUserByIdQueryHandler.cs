using Application.DTOs.User;
using Application.Interfaces;
using MediatR;

namespace Application.Features.Queries.UserQueries
{
    public class GetUserByIdQueryHandler: IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUserRepository _repository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<UserDto> Handle(
            GetUserByIdQuery req,
            CancellationToken cancellationToken
        )
        {
            var result = await _repository.GetUserById(req.Id);
            return result;
        }
    }
}