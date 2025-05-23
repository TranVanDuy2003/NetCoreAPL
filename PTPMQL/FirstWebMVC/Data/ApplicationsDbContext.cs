using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;

namespace FirstWebMVC.Data
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext (DbContextOptions<ApplicationsDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<FirstWebMVC.Models.DaiLy> DaiLy { get; set; } = default!;
    }
}
