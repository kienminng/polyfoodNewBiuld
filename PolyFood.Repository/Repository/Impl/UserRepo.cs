using PolyFood.Entity.Entity;
using PolyFood.Repository.Context;
using PolyFood.Repository.Repository.IRepo;

namespace PolyFood.Repository.Repository.Impl;

public class UserRepo : IUserRepo
{
    private readonly AppDbContext _context;

    public UserRepo(AppDbContext context)
    {
        _context = context;
    }

    public User? GetById(int id)
    {
        var result = _context.Users.Find(id);
        return result;
    }

    public IEnumerable<User> GetAll()
    {
        var result = _context.Users.AsEnumerable();
        return result;
    }

    public void Add(User entity)
    {
        _context.Users.Add(entity);
        _context.SaveChanges();
    }

    public void Update(User entity)
    {
        _context.Users.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(User entity)
    {
        _context.Users.Remove(entity);
        _context.SaveChanges();
    }

    public User? FindByEmail(string email) { 
        var result = _context.Users.FirstOrDefault(x=> x.Email == email);
        return result;
    }
}