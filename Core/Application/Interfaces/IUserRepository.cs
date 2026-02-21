using Application.DTOs.User;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> GetUserById(Guid id);
        Task<UserDto> CreateUserAsync(User user);
    }
}