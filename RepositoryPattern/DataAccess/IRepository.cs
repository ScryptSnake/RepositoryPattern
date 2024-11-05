namespace RepositoryPattern.DataAccess;
/// <summary>
/// A contract for how a data repository should behave. 
/// </summary>
public interface IRepository<TEntity> where TEntity : class
{
    Task GetAsync(TEntity entity);

    Task AddAsync(TEntity entity);

    Task DropAsync(TEntity entity);
}







