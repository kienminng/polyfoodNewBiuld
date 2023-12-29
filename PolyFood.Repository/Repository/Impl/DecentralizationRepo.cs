using PolyFood.Entity.Entity;
using PolyFood.Repository.Context;
using PolyFood.Repository.Repository.IRepo;

namespace PolyFood.Repository.Repository.Impl;

public class DecentralizationRepo : IDecentralizationRepo
{
    private readonly AppDbContext _context;

    public DecentralizationRepo(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public void Add(Decentralization entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Decentralization entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Decentralization> GetAll()
    {
        throw new NotImplementedException();
    }

    public Decentralization? GetById(int id)
    {
        //       var result = _context.Decentralizations.Find(id);
        //      return result;

        return null;
    }

    public void Update(Decentralization entity)
    {
        throw new NotImplementedException();
    }

    public Decentralization? FindByName(string name)
    {
        //  var result = _context.Decentralizations.FirstOrDefault(x => x.Authority_name == name);
        // return result;
        return null;
    }
}