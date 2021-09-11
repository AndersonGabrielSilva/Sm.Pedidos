using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            DateRegistration = DateTime.UtcNow;
            DateLastUpdate = DateTime.UtcNow;
        }

        [Key]
        public long Id { get; set; }

        public DateTime DateRegistration { get; set; }
        public DateTime DateLastUpdate { get; set; }

        public long? UserChangeId { get; set; }

        public bool Inactivated { get; set; }

        public void RegisterChange(long? userId)
        {
            UserChangeId = userId;
            DateLastUpdate = DateTime.UtcNow;
        }
    }
}
