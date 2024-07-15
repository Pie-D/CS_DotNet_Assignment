using System.Linq.Expressions;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services;

public class UserService : IBaseService<User>
{
    private IBaseService<User> _baseServiceImplementation;
    public Task<int> AddAsync(User entity)
    {
        return _baseServiceImplementation.AddAsync(entity);
    }

    public Task<bool> UpdateAsync(User entity)
    {
        return _baseServiceImplementation.UpdateAsync(entity);
    }

    public bool Delete(Guid id)
    {
        return _baseServiceImplementation.Delete(id);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        return _baseServiceImplementation.DeleteAsync(id);
    }

    public Task<bool> DeleteAsync(User entity)
    {
        return _baseServiceImplementation.DeleteAsync(entity);
    }

    public Task<User?> GetByIdAsync(Guid id)
    {
        return _baseServiceImplementation.GetByIdAsync(id);
    }

    public Task<IEnumerable<User>> GetAllAsync()
    {
        return _baseServiceImplementation.GetAllAsync();
    }

    public Task<PaginatedResult<User>> GetAsync(Expression<Func<User, bool>>? filter = null, Func<IQueryable<User>, IOrderedQueryable<User>>? orderBy = null, string includeProperties = "", int pageIndex = 1,
        int pageSize = 10)
    {
        return _baseServiceImplementation.GetAsync(filter, orderBy, includeProperties, pageIndex, pageSize);
    }
}