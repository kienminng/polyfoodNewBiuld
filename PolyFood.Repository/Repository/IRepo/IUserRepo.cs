using PolyFood.Entity.Entity;

namespace PolyFood.Repository.Repository.IRepo;

public interface IUserRepo : IRepository<User,int>
{
    User? FindByEmail(string email);
}