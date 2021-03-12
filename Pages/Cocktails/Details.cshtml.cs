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
    public class DetailsModel : PageModel
    {
        private readonly Drinks.Data.DrinksContext _context;

        public DetailsModel(Drinks.Data.DrinksContext context)
        {
            _context = context;
        }

        public Cocktail Cocktail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cocktail = await _context.Cocktail.FirstOrDefaultAsync(m => m.ID == id);

            if (Cocktail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
