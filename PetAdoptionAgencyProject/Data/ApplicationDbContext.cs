using Microsoft.EntityFrameworkCore;
using PetAdoptionAgencyProject.Models.Entities;

namespace PetAdoptionAgencyProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Credential> Credentials { get; set; }
    }
}
