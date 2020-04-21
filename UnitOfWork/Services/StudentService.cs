using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkPattern.Entitys;
using UnitOfWorkPattern.Repositories;
using UnitOfWorkPattern.UnitOfWorks;

namespace UnitOfWorkPattern.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IUnitOfWork uow, IRepository<Student> studentRepository)
        {
            _uow = uow;
            _studentRepository = studentRepository;
        }

        public IQueryable<Student> GetAll()
        {
            var list1 = _studentRepository.GetAll().ToList();
            var list2 = _uow.GetRepository<Student>().GetAll().ToList();
            var list3 = list1.Concat(list2);
            //return _studentRepository.GetAll();
            return list3.AsQueryable();
        }

        public void Add(Student student)
        {
            _studentRepository.Add(student);
        }

        public void Delete(Student student)
        {
            _studentRepository.Delete(student);
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }
    }
}