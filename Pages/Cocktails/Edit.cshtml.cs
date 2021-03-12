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
    public class EditModel : PageModel
    {
        private readonly Drinks.Data.DrinksContext _context;

        public EditModel(Drinks.Data.DrinksContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cocktail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CocktailExists(Cocktail.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CocktailExists(int id)
        {
            return _context.Cocktail.Any(e => e.ID == id);
        }
    }
}
