using Application.DTOs.User;
using MediatR;

namespace Application.Features.Queries.UserQueries
{
    public record GetUserByIdQuery(Guid Id): IRequest<UserDto>;
}