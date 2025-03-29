using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using Core.Entity;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

