using System.Data.Entity;

namespace CarInsurance.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
