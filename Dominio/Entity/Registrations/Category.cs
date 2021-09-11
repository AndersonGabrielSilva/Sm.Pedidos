using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity.Registrations
{
    public class Category : EntityBaseTenant
    {
        [StringLength(100)]
        public string Description { get; set; }
        

        public ICollection<Product> Products { get; set; }
    }
}
