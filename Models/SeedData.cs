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
                        Name = "Vesper",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "6 cl Gin, 1.5 cl Vodka, 0.75 cl Lillet Blonde.",
                        Garnish = "Lemon twist",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Bacardi",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "4.5 cl White rum, 2 cl Lime juice, 1 cl Syrup.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Negroni",
                        Glass = "old-fashioned",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "3 cl Gin, 3 cl Campari, 3 cl Vermouth.",
                        Garnish = "Half an orange slice",
                        Preparation = "Build into old-fashioned glass filled with ice. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Rose",
                        Glass = "martini",
                        Category = "None",
                        Ingredients = "2 cl Kirsch, 4 cl Vermouth, 3 dashes Strawberry syrup.",
                        Garnish = "None",
                        Preparation = "Stir all ingredients with ice and strain into a cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Old Fashioned",
                        Glass = "old-fashioned",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "4.5 cl Whiskey, 2 dashes Angostura Bitters, 1 sugar cube, Few dashes plain water.",
                        Garnish = "Orange slice and cherry",
                        Preparation = "Place sugar cube in old-fashioned glass and saturate with bitters, add a dash of plain water. Muddle until dissolve. Fill the glass with ice cubes and add whisky."
                },
                new Cocktail
                        { 
                        Name = "Tuxedo",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3 cl Gin, 3 cl Vermouth, 1/2 bar spoon Maraschino, 1/4 bar spoon Absinthe, 3 dashes Orange Bitters.",
                        Garnish = "Cherry and lemon twist",
                        Preparation = "Stir all ingredients with ice and strain into cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Mojito",
                        Glass = "collins",
                        Category = "Longdrink",
                        Ingredients = "4 cl White rum, 3 cl Lime juice, 6 Mint sprigs, 2 teaspoons white sugar, Soda water.",
                        Garnish = "Mint leaves and lemon slice",
                        Preparation = "Muddle mint sprigs with sugar and lime juice. Add splash of soda water and fill glass with cracked ice. Pour rum and top with soda water. Serve with straw."
                },
                new Cocktail
                        { 
                        Name = "Horse's Neck",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4 cl Cognac, 12 cl Ginger Ale, Dash of Angostura bitters (optional).",
                        Garnish = "Lemon twist",
                        Preparation = "Build into highball glass with ice cubes. Stir gently. If required, add dashes of Angostura bitters."
                },
                new Cocktail
                        { 
                        Name = "Planter's Punch",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Dark rum, 3.5 cl Orange juice, 3.5 cl Pineapple juice, 2 cl Lemon juice, 1 cl Syrup, 1 cl Syrup, 3 to 4 dashes Angostura bitters.",
                        Garnish = "Pineapple slice and a cherry",
                        Preparation = "Pour all ingredients, except the bitters, into shaker filled with ice. Shake. Pour into large glass, filled with ice. Add Angostura bitters, “on top”."
                },
                new Cocktail
                        { 
                        Name = "Sea Breeze",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4 cl Vodka, 12 cl Cranberry juice, 3 cl Grapefruit juice.",
                        Garnish = "Lime wedge",
                        Preparation = "Build all ingredients in a rock glass filled with ice."
                },
                new Cocktail
                        { 
                        Name = "Pisco Sour",
                        Glass = "old-fashioned",
                        Category = "All Day Cocktail",
                        Ingredients = "4.5 cl Pisco, 3 cl Lemon juice, 2 cl Syrup, 1 raw egg white (small egg).",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled champagne flute. Dash some Angostura bitters on top."
                },
                new Cocktail
                        { 
                        Name = "Long Island Iced Tea",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "1.5 cl Tequila, 1.5 cl Vodka, 1.5 cl White rum, 1.5 cl Triple Sec, 1.5 cl Gin, 2.5 cl Lemon juice, 3.0 cl Syrup, 1 dash of Cola.",
                        Garnish = "Lemon twist",
                        Preparation = "Add all ingredients into highball glass filled with ice. Stir gently. Serve with straw."
                },
                new Cocktail
                        { 
                        Name = "Clover Club",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4.5 cl Gin, 1.5 cl Syrup, 1.5 cl Lemon juice, Few drops of Egg White.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Angel Face",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3 cl Gin, 3 cl Apricot brandy, 3 cl Calvados.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into a cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Mimosa",
                        Glass = "champagne-flute",
                        Category = "Sparkling Cocktail",
                        Ingredients = "7.5 cl Champagne, 7.5 cl Orange juice.",
                        Garnish = "Optional orange twist",
                        Preparation = "Pour orange juice into flute and gently pour Champagne. Stir gently. Note: Buck's Fizz is a very similar cocktail but made of two parts champagne to one part orange juice."
                },
                new Cocktail
                        { 
                        Name = "Whiskey Sour",
                        Glass = "old-fashioned",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "4.5 cl Whiskey, 3.0 cl Lemon juice, 1.5 cl Syrup.",
                        Garnish = "Half an orange slice and cherry",
                        Preparation = "Dash egg white (Optional: if used shake little harder to foam up the egg white). Pour all ingredients into cocktail shaker filled with ice. Shake. Strain into cocktail glass. If served ‘On the rocks’, strain ingredients into old-fashioned glass filled with ice."
                },
                new Cocktail
                        { 
                        Name = "Screwdriver",
                        Glass = "highball",
                        Category = "All Day Cocktail",
                        Ingredients = "5 cl Vodka, 10 cl Orange juice.",
                        Garnish = "Orange slice",
                        Preparation = "Build into a highball glass filled with ice. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Cuba Libre",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "5 cl White rum, 12 cl Cola, 1 cl Lime juice.",
                        Garnish = "Lime wedge",
                        Preparation = "Build all ingredients in a highball glass filled with ice."
                },
                new Cocktail
                        { 
                        Name = "Manhattan",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "5 cl Whiskey, 2 cl Vermouth, 1 dash Angostura Bitters.",
                        Garnish = "Cherry",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Porto Flip",
                        Glass = "martini",
                        Category = "After Dinner Cocktail",
                        Ingredients = "1.5 cl Cognac, 4.5 cl Red Port, 1 cl Egg yolk.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into cocktail glass. Sprinkle with fresh ground nutmeg."
                },
                new Cocktail
                        { 
                        Name = "Gin Fizz",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Gin, 3 cl Lemon juice, 1 cl Syrup, 8 cl Soda water.",
                        Garnish = "Lemon slice",
                        Preparation = "Shake all ingredients with ice cubes, except soda water. Pour into tumbler. Top with soda water."
                },
                new Cocktail
                        { 
                        Name = "Espresso Martini",
                        Glass = "martini",
                        Category = "After Dinner Cocktail",
                        Ingredients = "5 cl Vodka, 1 cl Coffee liqueur, Sugar syrup (according to individual preference of sweetness), 1 short strong Espresso.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Margarita",
                        Glass = "margarita",
                        Category = "All Day Cocktail",
                        Ingredients = "3.5 cl Tequila, 2 cl Triple Sec, 1.5 cl Lime juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into cocktail glass rimmed with salt (note:Fruit Margarita - blend selected fruit with the above recipe)."
                },
                new Cocktail
                        { 
                        Name = "French 75",
                        Glass = "champagne-tulip",
                        Category = "Sparkling Cocktail",
                        Ingredients = "3 cl Gin, 1.5 cl Lemon juice, 2 dashes Sugar syrup, 6 cl Champagne.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes, except for champagne. Strain into a champagne flute. Top up with champagne. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Yellow Bird",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3 cl White rum, 1.5 cl Galliano, 1.5 cl Triple Sec, 1.5 cl Lime juice.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Pina Colada",
                        Glass = "hurricane",
                        Category = "Longdrink",
                        Ingredients = "3 cl White rum, 9 cl Pineapple juice, 3 cl Coconut milk.",
                        Garnish = "Pineapple slice and a cherry",
                        Preparation = "Blend all the ingredients with ice in a electric blender, pour into a large goblet or Hurricane glass and serve with straws."
                },
                new Cocktail
                        { 
                        Name = "Aviation",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4.5 cl Gin, 1.5 cl Cherry liqueur, 1.5 cl Lemon juice.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Bellini",
                        Glass = "champagne-flute",
                        Category = "Sparkling Cocktail",
                        Ingredients = "10 cl Prosecco, 5 cl Peach puree.",
                        Garnish = "None",
                        Preparation = "Pour peach puree into chilled glass and add sparkling wine. Stir gently. Variations: Puccini (fresh mandarin juice), Rossini (fresh strawberry puree), Tintoretto (fresh pomegranate juice)"
                },
                new Cocktail
                        { 
                        Name = "Grasshopper",
                        Glass = "martini",
                        Category = "After Dinner Cocktail",
                        Ingredients = "3 cl Créme liqueur, 3 cl Créme liqueur, 3 cl Cream.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Tequila Sunrise",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Tequila, 9 cl Orange juice, 1.5 cl Syrup.",
                        Garnish = "Orange slice and a cherry",
                        Preparation = "Build tequila and orange juice into highball with ice cubes. Add a splash of grenadine to create sunrise effect. Do not stir."
                },
                new Cocktail
                        { 
                        Name = "Daiquiri",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "4.5 cl White rum, 2.5 cl Lime juice, 1.5 cl Syrup.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Rusty Nail",
                        Glass = "old-fashioned",
                        Category = "After Dinner Cocktail",
                        Ingredients = "4.5 cl Whiskey, 2.5 cl Drambuie.",
                        Garnish = "Lemon twist",
                        Preparation = "Build into old-fashioned glass filled with ice. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "B52",
                        Glass = "shot",
                        Category = "After Dinner Cocktail",
                        Ingredients = "2 cl Coffee liqueur, 2 cl Cream liqueur, 2 cl Triple Sec.",
                        Garnish = "None",
                        Preparation = "Layer ingredients one at a time starting with Kahlúa, followed by Baileys Irish Cream and top with Grand Marnier. Flame the Grand Marnier, serve while the flame is still on, accompanied with a straw on side plate."
                },
                new Cocktail
                        { 
                        Name = "Stinger",
                        Glass = "martini",
                        Category = "After Dinner Cocktail",
                        Ingredients = "5 cl Cognac, 2 cl Créme liqueur.",
                        Garnish = "None",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into a cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Golden Dream",
                        Glass = "martini",
                        Category = "After Dinner Cocktail",
                        Ingredients = "2 cl Galliano, 2 cl Triple Sec, 2 cl Orange juice, 1 cl Cream.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "God Mother",
                        Glass = "old-fashioned",
                        Category = "None",
                        Ingredients = "3.5 cl Vodka, 3.5 cl DiSaronno.",
                        Garnish = "None",
                        Preparation = "Build into old fashioned glass filled with ice cubes. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Spritz Veneziano",
                        Glass = "old-fashioned",
                        Category = "Sparkling Cocktail",
                        Ingredients = "6 cl Prosecco, 4 cl Aperol, Splash of Soda water.",
                        Garnish = "Half an orange slice",
                        Preparation = "Build into an old-fashioned glass filled with ice. Top with a splash of soda water."
                },
                new Cocktail
                        { 
                        Name = "Bramble",
                        Glass = "old-fashioned",
                        Category = "All Day Cocktail",
                        Ingredients = "4 cl Gin, 1.5 cl Lemon juice, 1 cl Syrup, 1.5 cl Blackberry liqueur.",
                        Garnish = "Lemon slice and two blackberries",
                        Preparation = "Build over crushed ice, in a rock glass. Stir, then pour the blackberry liqueur over the top of the drink in a circular fashion."
                },
                new Cocktail
                        { 
                        Name = "Alexander",
                        Glass = "martini",
                        Category = "None",
                        Ingredients = "3 cl Cognac, 3 cl Créme liqueur, 3 cl Cream.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass. Sprinkle with fresh ground nutmeg."
                },
                new Cocktail
                        { 
                        Name = "Lemon Drop Martini",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "2.5 cl Vodka, 2 cl Triple Sec, 1.5 cl Lemon juice.",
                        Garnish = "Lemon slice",
                        Preparation = "Shake and strain into a chilled cocktail glass rimmed with sugar."
                },
                new Cocktail
                        { 
                        Name = "French Martini",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "4.5 cl Vodka, 1.5 cl Raspberry liqueur, 1.5 cl Pineapple juice.",
                        Garnish = "None",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into chilled cocktail glass. Squeeze oil from lemon peel onto the drink."
                },
                new Cocktail
                        { 
                        Name = "Black Russian",
                        Glass = "old-fashioned",
                        Category = "After Dinner Cocktail",
                        Ingredients = "5 cl Vodka, 2 cl Coffee liqueur.",
                        Garnish = "None",
                        Preparation = "Build into old fashioned glass filled with ice cubes. Stir gently. Note: for White Russian, float fresh cream on the top and stir gently."
                },
                new Cocktail
                        { 
                        Name = "Bloody Mary",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Vodka, 9 cl Tomato juice, 1.5 cl Lemon juice, 2 to 3 dashes of Worcestershire Sauce, Tabasco, Celery salt, Pepper.",
                        Garnish = "Celery and optionally lemon wedge",
                        Preparation = "Stir gently, pour all ingredients into highball glass."
                },
                new Cocktail
                        { 
                        Name = "Mai-tai",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4 cl White rum, 2 cl Dark rum, 1.5 cl Triple Sec, 1.5 cl Syrup, 1 cl Lime juice.",
                        Garnish = "Pineapple spear, mint leaves and lime wedge",
                        Preparation = "Shake and strain into highball glass. Serve with straw."
                },
                new Cocktail
                        { 
                        Name = "Barracuda",
                        Glass = "margarita",
                        Category = "Sparkling Cocktail",
                        Ingredients = "4.5 cl Dark rum, 1.5 cl Galliano, 6 cl Pineapple juice, 1 dash Lime juice, Top with Prosecco.",
                        Garnish = "None",
                        Preparation = "Pour and Serve."
                },
                new Cocktail
                        { 
                        Name = "Sex on the Beach",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4 cl Vodka, 2 cl Peach schnapps, 4 cl Cranberry juice, 4 cl Orange juice.",
                        Garnish = "Orange slice",
                        Preparation = "Build all ingredients in a highball glass filled with ice."
                },
                new Cocktail
                        { 
                        Name = "Monkey Gland",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "5 cl Gin, 3 cl Orange juice, 2 drops Absinthe, 2 drops Grenadine.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Derby",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "6 cl Gin, 2 drops Peach Bitters, 2 Fresh mint leaves.",
                        Garnish = "Mint leaves",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into a cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Sidecar",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "5 cl Cognac, 2 cl Triple Sec, 2 cl Lemon juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Irish Coffee",
                        Glass = "hot-drink",
                        Category = "Hot Drink",
                        Ingredients = "4 cl Whiskey, 9 cl Hot coffee, 3 cl Cream, 1 teaspoon of brown sugar.",
                        Garnish = "None",
                        Preparation = "Warm the Irish whiskey over a burner. Pour into the glass (for hot drink) hot coffee, and add a teaspoon of sugar. Float Cream on top."
                },
                new Cocktail
                        { 
                        Name = "Sazerac",
                        Glass = "old-fashioned",
                        Category = "After Dinner Cocktail",
                        Ingredients = "5 cl Cognac, 1 cl Absinthe, 1 sugar cube, 2 dashes Peychaud’s bitters.",
                        Garnish = "Lemon twist",
                        Preparation = "Rinse a chilled old-fashioned glass with the absinthe, add crushed ice and set it aside. Stir the remaining ingredients over ice and set it aside. Discard the ice and any excess absinthe from the prepared glass, and strain the drink into the glass. Note: The original recipe changed after the American Civil War, rye whiskey substituted cognac as it became hard to obtain."
                },
                new Cocktail
                        { 
                        Name = "Americano",
                        Glass = "old-fashioned",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "3 cl Campari, 3 cl Vermouth, A splash of soda water.",
                        Garnish = "Half an orange slice",
                        Preparation = "Build into old fashioned glass filled with ice cubes. Add a splash of soda water."
                },
                new Cocktail
                        { 
                        Name = "Singapore Sling",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "3 cl Gin, 1.5 cl Cherry liqueur, 0.75 cl Triple Sec, 0.75 cl DOM Bénédictine, 12.0 cl Pineapple juice, 1.5 cl Lime juice, 1 cl Syrup, 1 dash Angostura bitters.",
                        Garnish = "Pineapple slice and a cherry",
                        Preparation = "Shake with ice cubes. Strain into highball glass."
                },
                new Cocktail
                        { 
                        Name = "French Connection",
                        Glass = "old-fashioned",
                        Category = "None",
                        Ingredients = "3.5 cl Cognac, 3.5 cl DiSaronno.",
                        Garnish = "None",
                        Preparation = "Build into old fashioned glass filled with ice cubes. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Moscow Mule",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Vodka, 12 cl Ginger beer, 0.5 cl Lime juice, 1 slice lime in a highball glass.",
                        Garnish = "Lime slice",
                        Preparation = "Combine the vodka and ginger beer. Add lime juice."
                },
                new Cocktail
                        { 
                        Name = "John Collins",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Gin, 3 cl Lemon juice, 1.5 cl Syrup, 6 cl Soda water.",
                        Garnish = "Lemon slice and a cherry",
                        Preparation = "Build into highball glass filled with ice. Stir gently. Add a dash of Angostura bitters. (Note: Use Old Tom Gin for Tom Collins)"
                },
                new Cocktail
                        { 
                        Name = "Kir",
                        Glass = "white-wine",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "9 cl Dry White Wine, 1 cl Créme liqueur.",
                        Garnish = "None",
                        Preparation = "Pour Créme de Cassis into glass, top up with white wine. For Kir Royal: Use champagne instead of white wine."
                },
                new Cocktail
                        { 
                        Name = "Mint Julep",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "6 cl Whiskey, 4 fresh mint sprigs, 1 teaspoon powdered sugar, 2 teaspoons water.",
                        Garnish = "Mint sprig",
                        Preparation = "In a highball glass gently muddle the mint, sugar and water. Fill the glass with cracked ice, add Bourbon and stir well until the glass is frost."
                },
                new Cocktail
                        { 
                        Name = "Tommy's Margarita",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4.5 cl Tequila, 1.5 cl Lime juice, 2 bar spoons of Agave nectar.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Paradise",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3.5 cl Gin, 2 cl Apricot brandy, 1.5 cl Orange juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Dirty Martini",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "6 cl Vodka, 1 cl Vermouth, 1 cl Olive juice.",
                        Garnish = "Green olive",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into chilled martini glass."
                },
                new Cocktail
                        { 
                        Name = "Champagne Cocktail",
                        Glass = "champagne-flute",
                        Category = "Sparkling Cocktail",
                        Ingredients = "9 cl Champagne, 1 cl Cognac, 2 dashes Angostura Bitters, 1 sugar cube.",
                        Garnish = "Orange slice and a cherry",
                        Preparation = "Add dash of Angostura bitter onto sugar cube and drop it into champagne flute. Add cognac followed by pouring gently chilled champagne."
                },
                new Cocktail
                        { 
                        Name = "Mary Pickford",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "6 cl White rum, 1 cl Cherry liqueur, 6 cl Pineapple juice, 1 cl Syrup.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled large cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Hemingway Special",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "6 cl White rum, 4 cl Grapefruit juice, 1.5 cl Cherry liqueur, 1.5 cl Lime juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into a double cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Dark 'n' Stormy",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "6 cl Dark rum, 10 cl Ginger beer.",
                        Garnish = "Lime wedge",
                        Preparation = "Build into highball glass filled with ice. Add rum first and top it with ginger beer."
                },
                new Cocktail
                        { 
                        Name = "Ramos Fizz",
                        Glass = "highball",
                        Category = "Longdrink",
                        Ingredients = "4.5 cl Gin, 1.5 cl Lime juice, 1.5 cl Lemon juice, 3 cl Syrup, 6 cl Cream, 1 Egg white, 3 dashes Orange flower water, 2 drops Vanilla extract, Soda water.",
                        Garnish = "None",
                        Preparation = "Pour all ingredients (except soda) in a mixing glass, dry shake (no ice) for two minutes, add ice and hard shake for another minute. Strain into a highball glass without ice, top with soda."
                },
                new Cocktail
                        { 
                        Name = "Russian Spring Punch",
                        Glass = "highball",
                        Category = "Sparkling Cocktail",
                        Ingredients = "2.5 cl Vodka, 2.5 cl Lemon juice, 1.5 cl Créme liqueur, 1 cl Syrup.",
                        Garnish = "Lemon slice and a blackberry",
                        Preparation = "Shake the ingredients and pour into highball glass. Top with Sparkling wine."
                },
                new Cocktail
                        { 
                        Name = "God Father",
                        Glass = "old-fashioned",
                        Category = "None",
                        Ingredients = "3.5 cl Whiskey, 3.5 cl DiSaronno.",
                        Garnish = "None",
                        Preparation = "Build into old fashioned glass filled with ice cubes. Stir gently."
                },
                new Cocktail
                        { 
                        Name = "Cosmopolitan",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4 cl Vodka, 1.5 cl Triple Sec, 1.5 cl Lime juice, 3 cl Cranberry juice.",
                        Garnish = "Lime slice",
                        Preparation = "Shake with ice cubes. Strain into a large cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Dry Martini",
                        Glass = "martini",
                        Category = "Before Dinner Cocktail",
                        Ingredients = "6 cl Gin, 1 cl Vermouth.",
                        Garnish = "None",
                        Preparation = "Stir in mixing glass with ice cubes. Strain into chilled martini glass. Squeeze oil from lemon peel onto the drink, or garnish with olive."
                },
                new Cocktail
                        { 
                        Name = "Between the Sheets",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3 cl White rum, 3 cl Cognac, 3 cl Triple Sec, 2 cl Lemon juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Casino",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4 cl Gin, 1 cl Cherry liqueur, 1 cl Orange Bitters, 1 cl Lemon juice.",
                        Garnish = "Lemon twist and a cherry",
                        Preparation = "Shake with ice cubes. Strain into chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Caipirinha",
                        Glass = "old-fashioned",
                        Category = "All Day Cocktail",
                        Ingredients = "5 cl Cachaca, half fresh lime cut into 4 wedges, 2 teaspoon sugar.",
                        Garnish = "None",
                        Preparation = "Place lime and sugar in old fashion glass and muddle. Fill glass with ice and Cachaca (note:Caipiroska- use Vodka instead of Cachaca)."
                },
                new Cocktail
                        { 
                        Name = "Vampiro",
                        Glass = "highball",
                        Category = "None",
                        Ingredients = "5 cl Tequila, 7 cl Tomato juice, 3 cl Orange juice, 1 cl Lime juice, 1 teaspoon clear honey, Half slice onion finely chopped, Few slices fresh red hot chili peppers, Few drops Worcestershire sauce, Salt.",
                        Garnish = "Lime wedge and a green or red chili",
                        Preparation = "Shake with ice cubes. Strain into a highball glass, filled with ice."
                },
                new Cocktail
                        { 
                        Name = "Kamikaze",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "3 cl Vodka, 3 cl Triple Sec, 3 cl Lime juice.",
                        Garnish = "None",
                        Preparation = "Shake and strain into a chilled cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "White Lady",
                        Glass = "martini",
                        Category = "All Day Cocktail",
                        Ingredients = "4 cl Gin, 3 cl Triple Sec, 2 cl Lemon juice.",
                        Garnish = "None",
                        Preparation = "Shake with ice cubes. Strain into large cocktail glass."
                },
                new Cocktail
                        { 
                        Name = "Harvey Wallbanger",
                        Glass = "highball",
                        Category = "All Day Cocktail",
                        Ingredients = "4.5 cl Vodka, 1.5 cl Galliano, 9 cl Orange juice.",
                        Garnish = "Orance slice and a cherry",
                        Preparation = "Build vodka and orange juice into a highball glass filled with ice. Stir gently and float Galliano on top."
                }
 
                );
                context.SaveChanges();
            }
        }
    }
}