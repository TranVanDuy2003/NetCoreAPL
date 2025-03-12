using Microsoft.EntityFrameworkCore;
using MvcMovie.Models; // Thêm using directive này

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } // Sửa tên DbSet thành Persons
    }
}