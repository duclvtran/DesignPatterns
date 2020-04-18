using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.Dtos
{
    public class OrderDetailDto
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public OrderDto OrderDto { get; set; }
    }
}