using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Drinks.Data;
using Drinks.Models;

namespace Drinks.Pages.Cocktails
{
    public class IndexModel : PageModel
    {
        private readonly Drinks.Data.DrinksContext _context;

        public IndexModel(Drinks.Data.DrinksContext context)
        {
            _context = context;
        }

        public IList<Cocktail> Cocktail { get;set; }
         [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CocktailCategory { get; set; }

        public async Task OnGetAsync()
        {
             IQueryable<string> genreQuery = from m in _context.Cocktail
                                    orderby m.Category
                                    select m.Category;
            var cocktails = from m in _context.Cocktail
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cocktails = cocktails.Where(s => s.Name.ToUpper().Contains(SearchString.ToUpper()) 
                                    || s.Ingredients.ToUpper().Contains(SearchString.ToUpper())); 
            }
            if (!string.IsNullOrEmpty(CocktailCategory))
            {
                cocktails = cocktails.Where(x => x.Category == CocktailCategory);
            }

            Categories = new SelectList(await genreQuery.Distinct().ToListAsync());
            Cocktail = await cocktails.ToListAsync();
        }
    }
}
