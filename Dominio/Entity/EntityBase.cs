using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class EntityBase
    {
        [Key]
        public long Id { get; set; }

        public DateTime DateRegistration { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public Guid UserId { get; set; }
    }
}
