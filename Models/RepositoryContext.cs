using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Comm.Models
{
    public class RepositoryContext : IdentityDbContext<Users>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
                : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.Entity<CartItem>().HasOne<Cart>(c => c.cart);

            //modelBuilder.Entity<OrderItems>().HasOne<Orders>(opt => opt.OrderNo).WithMany(opt => opt.OrderItems);
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<CartItem> CartItemsTable { get; set; }




    }
}
