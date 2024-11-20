using agence_de_voyage.Models;
using Microsoft.EntityFrameworkCore;

namespace agence_de_voyage.services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions  options) : base( options) {
        
        }
        public DbSet<voyage> voyages { get; set; }
        public DbSet<client> client { get; set; }
    }
}
