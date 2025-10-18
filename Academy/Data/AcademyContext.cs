using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy.Models;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext (DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy.Models.Discipline> Disciplines { get; set; } = default!;
        public DbSet<Academy.Models.Students> Students { get; set; } = default!;
        public DbSet<Academy.Models.Groups> Groups { get; set; } = default!;
        public DbSet<Academy.Models.Directions> Directions { get; set; } = default!;
        public DbSet<Academy.Models.Teachers> Teachers { get; set; } = default!;
    }
}
