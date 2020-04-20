using AutoMapper;
using RepositoryUnitOfWork.Dtos;
using RepositoryUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.AutoMapper
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });
            IMapper iMapper = configuration.CreateMapper();
            return iMapper.Map<TSource, TDestination>(source);
        }

        //public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        //{
        //    return Mapper.Map(source, destination);
        //}

        //Model to Entity
        public static OrderDto ToModel(this Order entity)
        {
            return entity.MapTo<Order, OrderDto>();
        }

        //Entity to Model
        public static OrderDetail ToEntity(this OrderDetailDto model)
        {
            return model.MapTo<OrderDetailDto, OrderDetail>();
        }
    }
}