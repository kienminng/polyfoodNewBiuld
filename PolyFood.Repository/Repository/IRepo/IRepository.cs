namespace PolyFood.Repository.Repository.IRepo;

public interface IRepository<T,Guid>
{
    T? GetById(Guid id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}