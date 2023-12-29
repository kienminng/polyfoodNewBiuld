using PolyFood.Entity.Entity;

namespace PolyFood.Repository.Repository.IRepo;

public interface IAccountRepo : IRepository<Account,int>
{
    Account? FindByUsernamePassword(string usernameOrEmail, string password);
    Account? FindByUsername(string username);
}