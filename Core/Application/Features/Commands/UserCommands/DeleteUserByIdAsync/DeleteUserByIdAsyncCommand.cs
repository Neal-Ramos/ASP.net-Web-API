using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Commands.UserCommands.DeleteUserByIdAsync
{
    public record DeleteUserByIdAsyncCommand(Guid Id): IRequest<Guid>;
}