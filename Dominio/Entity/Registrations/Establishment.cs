namespace Domain.Entity.Registrations
{
    public class Establishment : EntityBaseTenant
    {
        public string Name { get; set; }
        public string About { get; set; }

        public long AddressId { get; set; }
        public Address Address { get; set; }
    }
}
