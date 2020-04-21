using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_UnitOfWork.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationContext Context { get; }

        void Commit();
    }
}