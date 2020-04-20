using Repository_UnitOfWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Repository_UnitOfWork.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IUnitOfWork _uow;

        public Repository(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return _uow.Context.Set<T>().AsEnumerable();
        }

        public void Add(T entity)
        {
            _uow.Context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            T existing = _uow.Context.Set<T>().Find(entity);
            if (existing != null) _uow.Context.Set<T>().Remove(existing);
        }

        public void Update(T entity)
        {
            _uow.Context.Entry(entity).State = EntityState.Modified;
            _uow.Context.Set<T>().Attach(entity);
        }
    }
}