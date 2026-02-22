using Application.DTOs.User;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.Queries.UserQueries
{
    public class GetUserByIdQueryHandler: IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _repository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<User> Handle(
            GetUserByIdQuery req,
            CancellationToken cancellationToken
        )
        {
            var result = await _repository.GetUserById(req.Id);
            if(result == null) throw new KeyNotFoundException($"User Id {req.Id} did not found!");
            return result;
        }
    }
}