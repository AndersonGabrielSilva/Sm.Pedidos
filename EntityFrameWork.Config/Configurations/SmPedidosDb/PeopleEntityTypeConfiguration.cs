using Domain.Entity.Registrations;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Config.Configurations.SmPedidosDb
{
    public class PeopleEntityTypeConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.Property(e => e.Document)
                   .HasConversion(
                       v => v.ToString(),
                       v => new Document(v));
        }
    }
}
