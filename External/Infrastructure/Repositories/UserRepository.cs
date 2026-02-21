using Application.DTOs.User;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<UserDto> CreateUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return new UserDto{
            Id = user.Id,
            Name = user.Name
        };
    }
    public async Task<UserDto> GetUserById(Guid id)
    {
        var result = await _context.Users.FindAsync(id);
        return new UserDto
        {
            Id = result.Id,
            Name = result.Name
        }; 
    }
}
}