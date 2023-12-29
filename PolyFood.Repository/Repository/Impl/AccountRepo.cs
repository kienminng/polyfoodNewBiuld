using Microsoft.EntityFrameworkCore;
using PolyFood.Entity.Entity;
using PolyFood.Repository.Context;
using PolyFood.Repository.Repository.IRepo;

namespace PolyFood.Repository.Repository.Impl;

public class AccountRepo : IAccountRepo
{
    private readonly AppDbContext _context;

    public AccountRepo(AppDbContext context)
    {
        _context = context;
    }

    public Account? FindByUsernamePassword(string usernameOrEmail, string password)
    {
        var result = _context.Accounts
            .Include(x => x.Users)
           // .Include(x=> x.Token)
            .FirstOrDefault(x =>
                (x.Username == usernameOrEmail || x.Users.Email == usernameOrEmail) && x.Password == password && x.Status == 1);
        return result;
    }

    public Account? FindByUsername(string username)
    {
        var result = _context.Accounts.FirstOrDefault(x => x.Username == username);
        return result;
    }

    public Account? GetById(int id)
    {
        var result = _context.Accounts.FirstOrDefault(x => x.AccountId == id);
        return result;
    }

    public IEnumerable<Account> GetAll()
    {
        var result = _context.Accounts.AsEnumerable();
        return result;
    }

    public void Add(Account entity)
    {
        _context.Accounts.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Account entity)
    {
        _context.Accounts.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(Account entity)
    {
        _context.Accounts.Remove(entity);
        _context.SaveChanges();
    }
}