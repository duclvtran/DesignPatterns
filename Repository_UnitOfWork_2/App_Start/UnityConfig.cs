using DataAccess.Repository;
using DataAccess.UnitOfWork;
using Models;
using Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Repository_UnitOfWork.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ICourseService, CourseService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IRepository<Course>, Repository<Course>>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}