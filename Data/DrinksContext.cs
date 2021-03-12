using Microsoft.EntityFrameworkCore;

namespace Drinks.Data
{
    public class DrinksContext : DbContext
    {
        public DrinksContext (
            DbContextOptions<DrinksContext> options)
            : base(options)
        {
        }

        public DbSet<Drinks.Models.Cocktail> Cocktail { get; set; }
    }
}