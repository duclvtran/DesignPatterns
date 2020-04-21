using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Repository_UnitOfWork.Controllers
{
    public class CourseController : ApiController
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public Object Get()
        {
            var list = _courseService.Get().Select(x => new { x.Id, x.Name, x.Credit, x.Description });
            return list;
        }

        [HttpPost]
        public Object GetExpression()
        {
            var list = _courseService.Get(x => x.Credit >= 4);
            return list;
        }
    }
}