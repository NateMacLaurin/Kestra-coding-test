using Microsoft.EntityFrameworkCore;

namespace Kestra_coding_test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base(options)
        {

        }

        public DbSet<Kestra_coding_test.Models.FormData> FormData { get; set; }
        public DbSet<Kestra_coding_test.Models.FormDropdownOptions> FormDropdownOptions { get; set; }
    }
}
