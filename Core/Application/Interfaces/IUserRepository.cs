using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserById(Guid id);
        Task<User> CreateUserAsync(User user);
        Task<Guid> DeleteUserByIdAsync(User user);
        Task<List<User>> GetAllUser();
    }
}