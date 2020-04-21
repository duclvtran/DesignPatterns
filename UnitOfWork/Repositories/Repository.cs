using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWorkPattern.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;

        public Repository(ApplicationContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            var entry = _context.Set<T>().Where(x => x == entity);
            _context.Set<T>().Attach(entity);
        }
    }
}