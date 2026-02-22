using Domain.Entities;
using MediatR;

namespace Application.Features.Queries.UserQueries
{
    public record GetUserByIdQuery(Guid Id): IRequest<User>;
}