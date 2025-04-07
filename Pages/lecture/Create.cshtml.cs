using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Courseprogram.Data;
using Courseprogram.Models;

namespace Courseprogram.Pages.lecture
{
    public class CreateModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public CreateModel(Courseprogram.Data.CourseprogramContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Lecture Lecture { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lecture.Add(Lecture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
