using InventoryManegmentSystem3.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManegmentSystem3.Data
{
  
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base(options)
        {

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }


        public DbSet<User> users { get; set; }
        public DbSet<Item> items { get; set; }
    }
}
