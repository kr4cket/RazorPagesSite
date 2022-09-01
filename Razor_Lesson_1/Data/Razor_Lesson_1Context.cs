using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_Lesson_1.Models;

namespace Razor_Lesson_1.Data
{
    public class Razor_Lesson_1Context : DbContext
    {
        public Razor_Lesson_1Context (DbContextOptions<Razor_Lesson_1Context> options)
            : base(options)
        {
        }

        public DbSet<Razor_Lesson_1.Models.Movie> Movie { get; set; } = default!;
    }
}
