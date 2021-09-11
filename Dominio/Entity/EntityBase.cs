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

        public long? UserId { get; set; }

        public void RegisterChange(long? userId)
        {
            UserId = userId;
            DateLastUpdate = DateTime.UtcNow;
        }
    }
}
