using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkPattern.Repositories;

namespace UnitOfWorkPattern.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;
        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        // Default constructor that news the context and the dictionary containing all the repositories
        public UnitOfWork()
        {
            _context = new ApplicationContext();
            _repositories = new Dictionary<Type, object>();
            _disposed = false;
        }

        // Retrieves the repository for some Model class T
        // If it doesn't exist, we create an instance of it
        public IRepository<T> GetRepository<T>() where T : class
        {
            if (_repositories.Keys.Contains(typeof(T)))
            {
                // Return the repository for that Model class
                return _repositories[(typeof(T))] as IRepository<T>;
            }

            // If the repository for that Model class doesn't exist, then create it
            var repository = new Repository<T>(_context);

            // Add it to the dictionary
            _repositories.Add(typeof(T), repository);

            return repository;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        // Disposes the context
        public void Dispose()
        {
            if (!this._disposed)
            {
                if (_disposed)
                    _context.Dispose();
                GC.SuppressFinalize(this);
                _disposed = true;
            }
        }
    }
}