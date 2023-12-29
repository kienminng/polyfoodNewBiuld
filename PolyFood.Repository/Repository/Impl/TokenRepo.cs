using PolyFood.Entity.Entity;
using PolyFood.Repository.Context;
using PolyFood.Repository.Repository.IRepo;

namespace PolyFood.Repository.Repository.Impl;

public class TokenRepo : ITokenRepo
{
    private readonly AppDbContext _context;

    public TokenRepo(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Token entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Token entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Token> GetAll()
    {
        throw new NotImplementedException();
    }

    public Token? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Token entity)
    {
        throw new NotImplementedException();
    }
}