using Domain.Enum;
using System.Collections.Generic;

namespace Domain.Entity.Registrations
{
    public class Address : EntityBaseTenant
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public TypeOfAddress TypeOfAddress { get; set; }

        public virtual Establishment Establishment { get;set;}
        public ICollection<User> Users { get; set; }
        public ICollection<Client> Customers { get; set; }
    }
}
