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
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Course> _courseRepository;

        public CourseService(IUnitOfWork uow, IRepository<Course> courseRepository)
        {
            _uow = uow;
            _courseRepository = courseRepository;
        }

        public void Add(Course entity)
        {
            _courseRepository.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseRepository.Delete(entity);
        }

        public IEnumerable<Course> Get()
        {
            return _courseRepository.Get();
        }

        public IEnumerable<Course> Get(Expression<Func<Course, bool>> predicate)
        {
            return _courseRepository.Get(predicate);
        }

        public void Update(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }
}