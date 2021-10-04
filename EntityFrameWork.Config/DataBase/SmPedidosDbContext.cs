using Domain.Entity.Registrations;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Config.DataBase
{
    public class SmPedidosDbContext : DbContext
    {
        public SmPedidosDbContext(DbContextOptions<SmPedidosDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Permissions> Permissions { get; set; }

    }
}
