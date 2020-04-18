using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<OrderDetailDto> OrderDetailDtos { get; set; }
    }
}