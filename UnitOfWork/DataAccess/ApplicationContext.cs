using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Entitys;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Student> Students { get; set; }
    }
}