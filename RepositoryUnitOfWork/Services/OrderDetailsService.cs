using AutoMapper;
using RepositoryUnitOfWork.Dtos;
using RepositoryUnitOfWork.Entities;
using RepositoryUnitOfWork.Repositories;
using RepositoryUnitOfWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryUnitOfWork.Services
{
    public class OrderDetailsService : BaseService<OrderDetail, OrderDetailDto>, IOrderDetailsService
    {
        public OrderDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<OrderDetail> _reponsitory => _unitOfWork.OrderDetailsRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreateDate = DateTime.Now,
                CreateBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = Mapper.Map<Order>(orderDto);

            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach (var details in orderDetails)
            {
                details.OrderDto = orderEntity;
                _unitOfWork.OrderDetailsRepository.Add(DtoToEntity(details));
            }

            await _unitOfWork.SaveAsync();
        }
    }
}