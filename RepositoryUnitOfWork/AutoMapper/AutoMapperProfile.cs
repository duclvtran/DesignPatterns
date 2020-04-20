using AutoMapper;
using RepositoryUnitOfWork.Dtos;
using RepositoryUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Model to Entity
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDetail, OrderDetailDto>();

            //Entity to Model
            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailDto, OrderDetail>();
        }
    }
}