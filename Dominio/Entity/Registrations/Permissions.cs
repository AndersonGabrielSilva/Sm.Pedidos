using System.Collections.Generic;

namespace Domain.Entity.Registrations
{
    public class Permissions : EntityBaseTenant
    {        
        public ICollection<UserType> UserTypes { get; set; }
    }
}
