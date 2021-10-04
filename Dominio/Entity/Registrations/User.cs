using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Registrations
{
    public class User : EntityBaseTenant
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Required]
        public Guid IdentityUserId { get; set; }

        public long UserTypeId { get; set; }
        public UserType UserType { get; set; }

        public ICollection<Address> Adresses { get; set; }
        public ICollection<Establishment> Establishments { get; set; }
    }
}
