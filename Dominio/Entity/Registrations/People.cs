
using Domain.ValueObject;
using System.Collections.Generic;

namespace Domain.Entity.Registrations
{
    public class People
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Document Document { get; set; }

        public ICollection<Telephone> Phones { get; set; }
        public ICollection<Address> Addresses { get; set; }

    }
}
