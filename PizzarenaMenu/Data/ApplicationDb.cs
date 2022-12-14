using Microsoft.EntityFrameworkCore;
using PizzarenaMenu.Models;

namespace PizzarenaMenu.Data
{
    public class ApplicationDb: DbContext 
    {
        public DbSet<PizzaOrder> orders { get; set; }

        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {

        }
    }
}
