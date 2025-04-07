using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Courseprogram.Data;
using Courseprogram.Models;

namespace Courseprogram.Pages.signup
{
    public class DeleteModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public DeleteModel(Courseprogram.Data.CourseprogramContext context)
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

            var signup = await _context.Signup.FirstOrDefaultAsync(m => m.Id == id);

            if (signup == null)
            {
                return NotFound();
            }
            else
            {
                Signup = signup;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signup = await _context.Signup.FindAsync(id);
            if (signup != null)
            {
                Signup = signup;
                _context.Signup.Remove(Signup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
