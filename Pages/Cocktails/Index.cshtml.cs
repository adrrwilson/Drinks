using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Cocktail = await _context.Cocktail.ToListAsync();
        }
    }
}
