using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Registrations
{
    public class Order : EntityBaseTenant
    {
        public Order()
        {
            DateOrder = DateTime.UtcNow;
        }

        public long? EstablishmentId { get; set; }
        public Establishment Establishment { get; set; }

        public long? CustomersId { get; set; }
        public Customers Customers { get; set; }

        public long? EmployeeId { get; set; }

        [Required]
        public DateTime DateOrder { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public OrderStatus Status {get;set;}

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
