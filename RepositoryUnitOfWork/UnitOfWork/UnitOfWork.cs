using RepositoryUnitOfWork.DataContext;
using RepositoryUnitOfWork.Entities;
using RepositoryUnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryUnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;
        public IGenericRepository<Order> OrderRepository { get; private set; }
        public IGenericRepository<OrderDetail> OrderDetailsRepository { get; private set; }
        private bool _disposed = false;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            OrderRepository = new GenericRepository<Order>(_context);
            OrderDetailsRepository = new GenericRepository<OrderDetail>(_context);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}