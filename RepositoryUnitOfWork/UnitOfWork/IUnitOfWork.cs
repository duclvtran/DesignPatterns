using RepositoryUnitOfWork.Entities;
using RepositoryUnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryUnitOfWork.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<OrderDetail> OrderDetailsRepository { get; }

        Task SaveAsync();
    }
}