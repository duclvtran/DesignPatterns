using AutoMapper;
using RepositoryUnitOfWork.Dtos;
using RepositoryUnitOfWork.Entities;

namespace RepositoryUnitOfWork.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Initialize()
        {
            //var configuration = new MapperConfiguration(cfg =>
            //{
            //    //cfg.AddProfile<AutoMapperProfile>();
            //    cfg.CreateMap<Order, OrderDto>();
            //    cfg.CreateMap<OrderDetail, OrderDetailDto>();
            //});
            //var mapper = configuration.CreateMapper();// or var mapper = new Mapper(configuration);

            //OrderDto dto = mapper.Map<OrderDto>(order);

            //var dtoUser2 = mapper.Map<Order>(OrderDto);
            //Model to Entity
            //CreateMap<Order, OrderDto>();
            //CreateMap<OrderDetail, OrderDetailDto>();

            ////Entity to Model
            //CreateMap<OrderDto, Order>();
            //CreateMap<OrderDetailDto, OrderDetail>();

            //    cfg.CreateMap<Order, OrderDto>();
            //    cfg.CreateMap<OrderDetail, OrderDetailDto>();
            //});
            // only during development, validate your mappings; remove it before release
            //configuration.AssertConfigurationIsValid();
            //// use DI (http://docs.automapper.org/en/latest/Dependency-injection.html) or create the mapper yourself
            //var mapper = configuration.CreateMapper();

            ////Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
            ////Mapper.Initialize(x => x.AddProfile<AutoMapperProfile>());
        }
    }
}