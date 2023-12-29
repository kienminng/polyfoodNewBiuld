using PolyFood.Entity.Entity;

namespace PolyFood.Repository.Repository.IRepo;

public interface IDecentralizationRepo : IRepository<Decentralization,int>
{
    Decentralization? FindByName(string name);
}