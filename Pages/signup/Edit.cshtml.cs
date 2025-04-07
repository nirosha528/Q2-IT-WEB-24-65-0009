using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Courseprogram.Data;
using Courseprogram.Models;

namespace Courseprogram.Pages.signup
{
    public class EditModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public EditModel(Courseprogram.Data.CourseprogramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Signup Signup { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signup =  await _context.Signup.FirstOrDefaultAsync(m => m.Id == id);
            if (signup == null)
            {
                return NotFound();
            }
            Signup = signup;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Signup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SignupExists(Signup.Id))
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

        private bool SignupExists(int id)
        {
            return _context.Signup.Any(e => e.Id == id);
        }
    }
}
