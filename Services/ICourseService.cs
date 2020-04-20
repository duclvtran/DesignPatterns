using DataAccess.Repository;
using DataAccess.UnitOfWork;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICourseService
    {
        IEnumerable<Course> Get();

        IEnumerable<Course> Get(Expression<Func<Course, bool>> predicate);

        void Add(Course entity);

        void Delete(Course entity);

        void Update(Course entity);
    }
}