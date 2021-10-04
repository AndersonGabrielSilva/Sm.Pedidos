using System.Collections.Generic;

namespace Domain.Entity.Registrations
{
    public class Establishment : EntityBaseTenant
    {
        public string Name { get; set; }
        public string About { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
