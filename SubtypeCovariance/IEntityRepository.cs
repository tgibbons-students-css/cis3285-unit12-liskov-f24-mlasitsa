using System;

namespace SubtypeCovariance
{
    public interface IEntityRepository<out TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
}
