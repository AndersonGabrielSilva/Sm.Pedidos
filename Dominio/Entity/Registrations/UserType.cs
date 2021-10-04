using System.Collections.Generic;

namespace Domain.Entity.Registrations
{
    public class UserType : EntityBaseTenant
    {
        public string Description { get; set; }

        public ICollection<Permissions> Permissions { get; set; }
    }
}
