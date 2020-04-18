using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryUnitOfWork.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}