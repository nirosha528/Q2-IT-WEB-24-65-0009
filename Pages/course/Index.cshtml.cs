using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Courseprogram.Data;
using Courseprogram.Models;

namespace Courseprogram.Pages.course
{
    public class IndexModel : PageModel
    {
        private readonly Courseprogram.Data.CourseprogramContext _context;

        public IndexModel(Courseprogram.Data.CourseprogramContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
