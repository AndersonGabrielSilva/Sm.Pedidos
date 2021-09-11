using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Config.DataBase
{
    public class SmPedidosDbContext : DbContext
    {
        public SmPedidosDbContext(DbContextOptions<SmPedidosDbContext> options) : base(options)
        {

        }

    }
}
