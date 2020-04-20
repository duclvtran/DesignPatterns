using AutoMapper;
using RepositoryUnitOfWork.Dtos;
using RepositoryUnitOfWork.Entities;
using RepositoryUnitOfWork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RepositoryUnitOfWork.Controllers
{
    public class OrderDetailController : ApiController
    {
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderDetailController(IOrderDetailsService orderDetailsService)
        {
            orderDetailsService = _orderDetailsService;
        }

        [HttpPost]
        public Object Test()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile<AutoMapperProfile>();
                cfg.CreateMap<Order, OrderDto>();
                cfg.CreateMap<OrderDetail, OrderDetailDto>();
            });
            var mapper = configuration.CreateMapper();// or var mapper = new Mapper(configuration);
            var order = new Order { Id = 1, Sku = "SKU", OrderDetail = new List<OrderDetail>(), CreateBy = "Vutdl", CreateDate = DateTime.Now };
            OrderDto dto = mapper.Map<OrderDto>(order);
            return dto;
        }
    }
}