using RepositoryUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.DataContext
{
    public class ApplicationContext : DbContext

    {
        public ApplicationContext() : base("name=ConnectionString")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}