using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Courseprogram.Data;
using Courseprogram.Models;

namespace Courseprogram.Pages.lecture
{
    public class DeleteModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public DeleteModel(Courseprogram.Data.CourseprogramContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lecture Lecture { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lecture = await _context.Lecture.FirstOrDefaultAsync(m => m.Id == id);

            if (lecture == null)
            {
                return NotFound();
            }
            else
            {
                Lecture = lecture;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lecture = await _context.Lecture.FindAsync(id);
            if (lecture != null)
            {
                Lecture = lecture;
                _context.Lecture.Remove(Lecture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
