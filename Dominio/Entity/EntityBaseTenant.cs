using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    [Index(nameof(TenentId))]
    public abstract class  EntityBaseTenant : EntityBase
    {        
        [Required]
        public long TenentId { get; set; }
    }
}
