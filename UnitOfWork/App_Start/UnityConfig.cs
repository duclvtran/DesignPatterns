using System.Web.Http;
using UnitOfWorkPattern.Entitys;
using UnitOfWorkPattern.Repositories;

//using UnitOfWorkPattern.Repository;
using UnitOfWorkPattern.Services;
using UnitOfWorkPattern.UnitOfWorks;

//using UnitOfWorkPattern.UnitOfWork;
using Unity;
using Unity.WebApi;

namespace UnitOfWorkPattern
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IRepository<Student>, Repository<Student>>();
            container.RegisterType<IStudentService, StudentService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}