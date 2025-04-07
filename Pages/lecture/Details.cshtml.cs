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
    public class DetailsModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public DetailsModel(Courseprogram.Data.CourseprogramContext context)
        {
            _context = context;
        }

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
    }
}
