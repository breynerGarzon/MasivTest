namespace Masiv.Data.Interfaces
{
    public interface IRepositoryBase<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        T Find();
    }
}