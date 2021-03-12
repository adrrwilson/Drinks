using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Drinks.Data;
using Drinks.Models;

namespace Drinks.Pages.Cocktails
{
    public class CreateModel : PageModel
    {
        private readonly Drinks.Data.DrinksContext _context;

        public CreateModel(Drinks.Data.DrinksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cocktail Cocktail { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cocktail.Add(Cocktail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
