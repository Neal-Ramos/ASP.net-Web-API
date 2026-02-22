using Application.DTOs.User;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
        {
            _context = context;
        }

    public async Task<User> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    public async Task<User?> GetUserById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    public async Task<Guid> DeleteUserByIdAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    public async Task<List<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }
}
}