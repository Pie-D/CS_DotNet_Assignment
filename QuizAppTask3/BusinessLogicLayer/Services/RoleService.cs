using System.Linq.Expressions;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services;

public class RoleService : IBaseService<Role>
{
    private IBaseService<Role> _baseServiceImplementation;
    public Task<int> AddAsync(Role entity)
    {
        return _baseServiceImplementation.AddAsync(entity);
    }

    public Task<bool> UpdateAsync(Role entity)
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

    public Task<bool> DeleteAsync(Role entity)
    {
        return _baseServiceImplementation.DeleteAsync(entity);
    }

    public Task<Role?> GetByIdAsync(Guid id)
    {
        return _baseServiceImplementation.GetByIdAsync(id);
    }

    public Task<IEnumerable<Role>> GetAllAsync()
    {
        return _baseServiceImplementation.GetAllAsync();
    }

    public Task<PaginatedResult<Role>> GetAsync(Expression<Func<Role, bool>>? filter = null, Func<IQueryable<Role>, IOrderedQueryable<Role>>? orderBy = null, string includeProperties = "", int pageIndex = 1,
        int pageSize = 10)
    {
        return _baseServiceImplementation.GetAsync(filter, orderBy, includeProperties, pageIndex, pageSize);
    }
}