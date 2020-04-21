using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Entitys;

namespace UnitOfWorkPattern.Services
{
    public interface IStudentService
    {
        IQueryable<Student> GetAll();

        void Add(Student student);

        void Delete(Student student);

        void Update(Student student);
    }
}