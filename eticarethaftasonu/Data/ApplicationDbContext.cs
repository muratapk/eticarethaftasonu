using eticarethaftasonu.Models;
using Microsoft.EntityFrameworkCore;

namespace eticarethaftasonu.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<eticarethaftasonu.Models.Products>? Products { get; set; }
    }
}
