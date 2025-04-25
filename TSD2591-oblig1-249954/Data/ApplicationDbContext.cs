using Microsoft.EntityFrameworkCore;
using TSD2591_oblig1_249954.Models;

namespace TSD2591_oblig1_249954.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bruker> Brukere { get; set; }
    }
}

