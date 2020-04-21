using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        void Commit();
    }

    public interface IUnitOfWork2<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}