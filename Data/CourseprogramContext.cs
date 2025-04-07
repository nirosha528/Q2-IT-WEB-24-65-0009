using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courseprogram.Models;

namespace Courseprogram.Data
{
    public class CourseprogramContext : DbContext
    {
        public CourseprogramContext (DbContextOptions<CourseprogramContext> options)
            : base(options)
        {
        }

        public DbSet<Courseprogram.Models.Student> Student { get; set; } = default!;
        public DbSet<Courseprogram.Models.Lecture> Lecture { get; set; } = default!;
        public DbSet<Courseprogram.Models.Course> Course { get; set; } = default!;
        public DbSet<Courseprogram.Models.Signup> Signup { get; set; } = default!;
    }
}
