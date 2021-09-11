using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Registrations
{
    public class Product : EntityBaseTenant
    {
        [StringLength(100)]
        public string Description { get; set; }

        public string Un { get; set; }

        public decimal Price { get; set; }

        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
