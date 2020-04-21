using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitOfWorkPattern.Entitys;
using UnitOfWorkPattern.Services;

namespace UnitOfWorkPattern.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public Object GetAll()
        {
            var list = _studentService.GetAll();
            return list;
        }

        [HttpPost]
        public Object Add(StudentInput input)
        {
            var param = new Student { Id = input.Id, Name = input.Name };
            _studentService.Add(param);
            return param;
        }
    }
}