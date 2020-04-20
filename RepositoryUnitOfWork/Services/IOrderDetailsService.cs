using RepositoryUnitOfWork.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryUnitOfWork.Services
{
    public interface IOrderDetailsService
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailDto> orderDetails);
    }
}