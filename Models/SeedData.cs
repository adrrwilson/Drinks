using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Drinks.Data;
using System;
using System.Linq;

namespace Drinks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DrinksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DrinksContext>>()))
            {
                // Look for any movies.
                if (context.Cocktail.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cocktail.AddRange(
                    new Cocktail
                    {
                        Name = "Whiskey",
                        Category = "After Dinner Drink",
                        Ingredients = "Whiskey",
                        Garnish = "None",
                        Preparation = "Pour, sip and enjoy"
                    },
                      new Cocktail
                    {
                        Name = "Tequila Shot",
                        Category = "Party Drink",
                        Ingredients = "Tequila",
                        Garnish = "Salt and Lime",
                        Preparation = "Lick salt, drink shot then bite lime."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}