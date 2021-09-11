using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Registrations
{
    public class Customers : EntityBase
    {
        [Key]
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string Email { get; set; }

        public long? TenentId { get; set; }

        [Required]
        public Guid IdentityUserId { get; set; }

        public ICollection<Address> Adresses { get; set; }
    }
}
