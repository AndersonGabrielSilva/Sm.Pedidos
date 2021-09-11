using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Registrations
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Required]
        public Guid IdentityUserId { get; set; }

        public long TenentId { get; set; }

        public ICollection<Address> Adresses { get; set; }
        public ICollection<Establishment> Establishments { get; set; }
    }
}
